using System.Linq;


namespace PergleLabs.Fontogrammer
{

    partial class MainWndDataContext
    {


        private void SetPropertyEventHandlers(XamlLayerItem layer)
        {
            layer.TextChanged += OnTextChanged;
            layer.TextChanged += OnTextChanged;
            layer.TextAttrChanged += OnTextAttrChanged;
            layer.TextPosRelChanged += OnTextPosRelChanged;
            layer.TextTransformChanged += OnTextTransformChanged;
            layer.BackAttrChanged += OnBackAttrChanged;
            layer.BackPosRelChanged += OnBackPosRelChanged;
            layer.BackCornerRadiusRelChanged += OnBackCornerRadiusRelChanged;
            layer.BackTransformChanged += OnBackTransformChanged;
        }


        private void OnTextChanged()
        {
            _FgPreview.Text = string.Join("|", XamlLayers.Select(layer => layer.Text));
        }
        private void OnTextAttrChanged()
        {
            _FgPreview.TextAttr = string.Join("|", XamlLayers.Select(layer => layer.TextAttr));
        }
        private void OnTextPosRelChanged()
        {
            _FgPreview.TextPosRel = string.Join("|", XamlLayers.Select(layer => layer.TextPosRel));
        }
        private void OnTextTransformChanged()
        {
            _FgPreview.TextTransform = string.Join("|", XamlLayers.Select(layer => layer.TextTransform));
        }
        private void OnBackAttrChanged()
        {
            _FgPreview.BackAttr = string.Join("|", XamlLayers.Select(layer => layer.BackAttr));
        }
        private void OnBackPosRelChanged()
        {
            _FgPreview.BackPosRel = string.Join("|", XamlLayers.Select(layer => layer.BackPosRel));
        }
        private void OnBackCornerRadiusRelChanged()
        {
            _FgPreview.BackCornerRadiusRel = string.Join("|", XamlLayers.Select(layer => layer.BackCornerRadiusRel));
        }
        private void OnBackTransformChanged()
        {
            _FgPreview.BackTransform = string.Join("|", XamlLayers.Select(layer => layer.BackTransform));
        }

    }

}
