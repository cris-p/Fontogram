using Microsoft.Win32;
using PergleLabs.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace PergleLabs.Fontogrammer
{

    interface BitmapFileParams
    {
        string ExportWidth { get; }
        string ExportHeight { get; }
        string ExportResolution { get; }
    }


    class ExportBitmapCommand
        : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object fgPreview)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.DefaultExt = "png";
            saveDlg.Filter = "PNG format - extension added automatically|*.png";
            saveDlg.Title = "Export Fontogram to PNG file";

            if (saveDlg.ShowDialog() == false)
                return;


            int w;
            if (!int.TryParse(_BitmapFileParams.ExportWidth, out w))
                w = 256;
            int h;
            if (!int.TryParse(_BitmapFileParams.ExportHeight, out h))
                h = 256;
            double res;
            if (!double.TryParse(_BitmapFileParams.ExportResolution, out res))
                res = 256;

            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(w, h, res, res, PixelFormats.Pbgra32);

            var drawingVisual = new DrawingVisual();
            using (var drawingContext = drawingVisual.RenderOpen())
            {
                var visualBrush = new VisualBrush((Visual)fgPreview);
                drawingContext.DrawRectangle(visualBrush, null, new Rect(new Size(w, h)));
            }

            renderTargetBitmap.Render(drawingVisual);

            var encoder = new PngBitmapEncoder();

            encoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

            using (System.IO.Stream stream = System.IO.File.Create(saveDlg.FileName))
                encoder.Save(stream);
        }

        public ExportBitmapCommand(BitmapFileParams bitmapFileParams)
        {
            _BitmapFileParams = bitmapFileParams;
        }


        private readonly BitmapFileParams _BitmapFileParams;

    }


    interface PreviewResizeClient
    {
        void OnPreviewResize(int w, int h);
    }


    partial class MainWndDataContext
        : INotifyPropertyChanged
        , LayerObjectCreator
        , BitmapFileParams
        , PreviewResizeClient
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public ICommand _ExportBitmapCommand { get; }


        private readonly Fontogram _FgPreview;


        public MainWndDataContext(Fontogram fgPreview, LayerEditor layerEditor)
        {
            _FgPreview = fgPreview;

            _LayerEditor = layerEditor;
            _LayerEditor.SetLayerCreator(this);
            _LayerEditor.LayersChanged += _LayerEditor_LayersChanged;


            _ExportBitmapCommand = new ExportBitmapCommand(this);


            _CodegenXaml = new CodegenXaml(fgPreview);

            _CodegenCsharp = new CodegenCsharp(fgPreview);


            foreach (var readyMadeID in (ReadyMadeFontogram[])Enum.GetValues(typeof(ReadyMadeFontogram)))
            {
                ReadyMadeFontogramChoices.Add(readyMadeID);
            }

            this.ReadyMadeFontogramSelection = 0;   // default is "none" - an item separate from ReadyMadeFontogramChoices
        }

        private void _LayerEditor_LayersChanged()
        {
            ReapplyProperties();
        }

        public List<ReadyMadeFontogram> ReadyMadeFontogramChoices { get; private set; } = new List<ReadyMadeFontogram>();


        private ReadyMadeFontogram? _readyMadeSelectedValue = null;
        public ReadyMadeFontogram? ReadyMadeSelectedValue
        {
            get { return _readyMadeSelectedValue; }
            private set
            {
                _readyMadeSelectedValue = value;

                NotifyPropertyChanged();
            }
        }


        int _readyMadeFontogramSelection = 0;
        public int ReadyMadeFontogramSelection
        {
            get { return _readyMadeFontogramSelection; }
            set
            {
                if (value > 0)
                    ReadyMadeSelectedValue = ReadyMadeFontogramChoices[value-1];
                else
                    ReadyMadeSelectedValue = null;

                UpdateGeneratedCode();

                _readyMadeFontogramSelection = value;
            }
        }


        private string _codeTextXaml = null;
        public string CodeTextXaml
        {
            get { return _codeTextXaml; }
            private set
            {
                _codeTextXaml = value;

                NotifyPropertyChanged();
            }
        }

        private string _codeTextCsharp = null;
        public string CodeTextCsharp
        {
            get { return _codeTextCsharp; }
            private set
            {
                _codeTextCsharp = value;

                NotifyPropertyChanged();
            }
        }


        private readonly LayerEditor _LayerEditor;

        private ObservableCollection<LayerBoxItem> _LiveTopToBottomLayers
        {
            get { return _LayerEditor.LiveTopToBottomLayers; }
        }

        private IEnumerable<LayerBoxItem> _BottomToTopLayers
        {
            get { return _LiveTopToBottomLayers.Reverse(); }
        }


        private FgLayerItem _currentXamlLayer;
        public FgLayerItem CurrentXamlLayer {
            get { return _currentXamlLayer; }
            set
            {
                _currentXamlLayer = value;
                NotifyPropertyChanged();
            }
        }


        public string ExportWidth { get; set; } = "256";

        public string ExportHeight { get; set; } = "256";

        public string ExportResolution { get; set; } = "96";

        
        public void OnPreviewResize(int w, int h)
        {
            ExportWidth = $"{w}";
            NotifyPropertyChanged("ExportWidth");

            ExportHeight = $"{h}";
            NotifyPropertyChanged("ExportHeight");
        }


        private readonly CodegenXaml _CodegenXaml;

        private readonly CodegenCsharp _CodegenCsharp;

        private void UpdateGeneratedCode()
        {

            this.CodeTextCsharp = _CodegenCsharp.GetCode();

            this.CodeTextXaml = _CodegenXaml.GetCode();

        }

        public LayerBoxItem CreateLayer(int position)
        {
            var newLayerItem = new FgLayerItem(_FgPreview, position);    // in case we just add new
            SetPropertyEventHandlers(newLayerItem);

            return newLayerItem;
        }
    }

}
