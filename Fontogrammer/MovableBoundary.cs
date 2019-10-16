using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace PergleLabs.UI
{
    /// <summary>
    /// Divider in a 3x3 grid.
    /// </summary>
    /// <remarks>
    /// Useful to think of this as a boundary for the middle column&row.
    /// </remarks>
    class MovableBoundary
        : GridSplitter
    {

        private static readonly Brush NormalBrush = new SolidColorBrush(Color.FromArgb(238, 232, 232, 255));
        private static readonly Brush ActiveBrush = new SolidColorBrush(Color.FromArgb(255, 245, 245, 255));


        public int Col { set; private get; } = 1;
        public int Row { set; private get; } = 1;


        public enum Position { Left, Top, Right, Bottom }

        private Position _location;
        public Position Location
        {
            set
            {
                _location = value;

                int gridRowCount = (this.Parent as Grid).RowDefinitions.Count;
                int gridColCount = (this.Parent as Grid).ColumnDefinitions.Count;

                if (gridRowCount < 3 || gridColCount < 3)
                    return;


                switch (_location)
                {
                    case Position.Left:
                        this.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                        break;
                    case Position.Top:
                        this.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                        break;
                    case Position.Right:
                        this.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
                        break;
                    case Position.Bottom:
                        this.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                        break;
                }

                Grid.SetColumn(this, 1);
                Grid.SetRow(this, 1);
                switch (_location)
                {
                    case Position.Left:
                    case Position.Right:
                        Grid.SetRow(this, 0);
                        Grid.SetRowSpan(this, gridRowCount);
                        this.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
                        this.Width = 7;
                        break;

                    case Position.Top:
                    case Position.Bottom:
                        Grid.SetColumn(this, 0);
                        Grid.SetColumnSpan(this, gridColCount);
                        this.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
                        this.Height = 7;
                        break;
                }
            }
        }


        public MovableBoundary()
        {
            this.Margin = new System.Windows.Thickness(-3);
            this.Background = NormalBrush;
            this.ToolTip = "double-click -> square";

            Grid.SetRow(this, this.Row);
            Grid.SetColumn(this, this.Col);

            this.MouseEnter += MovableBoundary_MouseEnter;
            this.MouseLeave += MovableBoundary_MouseLeave;
        }

        private void MovableBoundary_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = NormalBrush;
        }

        private void MovableBoundary_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = ActiveBrush;
        }
    }
}
