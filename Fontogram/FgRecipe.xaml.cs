using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PergleLabs.UI
{

    internal partial class FgRecipe
        : UserControl
        , FontogramProperties   // flowing down from Fontogram
    {

        public FgRecipe()
        {
            InitializeComponent();

            DataContext = _BindingProps;

            this.SizeChanged += FgControl_SizeChanged;
        }


        private void FgControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            _BindingProps.OnControlSizeChanged(e.NewSize.Width, e.NewSize.Height);
        }


        private static void DispatchValues(string cslVals, params TranslatedProperty[] xProperties)
        {
            string[] partsIn = cslVals.Split(',').Select(part => part.Trim()).ToArray();

            for (int i = 0; i < xProperties.Length; i++)
                xProperties[i].In =
                    partsIn.Length <= i ? null : partsIn[i];            
        }


        #region Fontogram-originated properties
 
        public string Text
        {
            set
            {
                _BindingProps.Text.In = value;
            }
        }

        public string TextAttr
        {
            set
            {
                DispatchValues(value,
                    _BindingProps.TextFont,
                    _BindingProps.TextFontWeight,
                    _BindingProps.TextColor
                    );
            }
        }

        public string TextPosRel
        {
            set
            {
                DispatchValues(value,
                    _BindingProps.TextFontSize,
                    _BindingProps.TextShiftX,
                    _BindingProps.TextShiftY
                    );
            }
        }

        public string TextTransform
        {
            set
            {
                DispatchValues(value,
                    _BindingProps.TextRotAngle,
                    _BindingProps.TextScaleX,
                    _BindingProps.TextScaleY,
                    _BindingProps.TextSkewX,
                    _BindingProps.TextSkewY
                    );
            }
        }


        public string BackAttr
        {
            set
            {
                DispatchValues(value,
                    _BindingProps.BackOpacity,
                    _BindingProps.BackFillColor,
                    _BindingProps.BackStrokeThickness,
                    _BindingProps.BackStrokeColor
                    );
            }
        }

        public string BackPosRel
        {
            set
            {
                DispatchValues(value,
                    _BindingProps.BackWidth,
                    _BindingProps.BackHeight,
                    _BindingProps.BackShiftX,
                    _BindingProps.BackShiftY
                    );
            }
        }

        public string BackCornerRadiusRel
        {
            set
            {
                _BindingProps.BackCornerRadius.In = value;
            }
        }

        public string BackTransform
        {
            set
            {
                DispatchValues(value,
                    _BindingProps.BackRotAngle,
                    _BindingProps.BackScaleX,
                    _BindingProps.BackScaleY,
                    _BindingProps.BackSkewX,
                    _BindingProps.BackSkewY
                    );
            }
        }

        #endregion


        private readonly RecipeBindingProps _BindingProps = new RecipeBindingProps();

    }

}
