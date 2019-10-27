using System.Linq;


namespace PergleLabs.Fontogrammer
{

    partial class MainWndDataContext
    {


        private void SetPropertyEventHandlers(FgLayerItem layer)
        {
            layer.TextChanged += OnTextChanged;
            layer.TextAttrChanged += OnTextAttrChanged;
            layer.TextPosRelChanged += OnTextPosRelChanged;
            layer.TextTransformChanged += OnTextTransformChanged;
            layer.BackAttrChanged += OnBackAttrChanged;
            layer.BackPosRelChanged += OnBackPosRelChanged;
            layer.BackBorderNumbersRelChanged += OnBackBorderNumbersRelChanged;
            layer.BackTransformChanged += OnBackTransformChanged;
        }


        private void OnTextChanged()
        {
            _FgPreview.Text = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).Text));
            UpdateGeneratedCode();
        }
        private void OnTextAttrChanged()
        {
            _FgPreview.TextAttr = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).TextAttr));
            UpdateGeneratedCode();
        }
        private void OnTextPosRelChanged()
        {
            _FgPreview.TextPosRel = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).TextPosRel));
            UpdateGeneratedCode();
        }
        private void OnTextTransformChanged()
        {
            _FgPreview.TextTransform = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).TextTransform));
            UpdateGeneratedCode();
        }
        private void OnBackAttrChanged()
        {
            _FgPreview.BackAttr = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackAttr));
            UpdateGeneratedCode();
        }
        private void OnBackPosRelChanged()
        {
            _FgPreview.BackPosRel = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackPosRel));
            UpdateGeneratedCode();
        }
        private void OnBackBorderNumbersRelChanged()
        {
            _FgPreview.BackBorderNumbersRel = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackBorderNumbersRel));
            UpdateGeneratedCode();
        }
        private void OnBackTransformChanged()
        {
            _FgPreview.BackTransform = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackTransform));
            UpdateGeneratedCode();
        }


        public void ReapplyProperties()
        {
            _FgPreview.Text = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).Text));
            _FgPreview.TextAttr = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).TextAttr));
            _FgPreview.TextPosRel = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).TextPosRel));
            _FgPreview.TextTransform = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).TextTransform));
            _FgPreview.BackAttr = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackAttr));
            _FgPreview.BackPosRel = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackPosRel));
            _FgPreview.BackBorderNumbersRel = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackBorderNumbersRel));
            _FgPreview.BackTransform = string.Join("|", _BottomToTopLayers.Select(layer => (layer as FgLayerItem).BackTransform));
            UpdateGeneratedCode();
        }
}

}
