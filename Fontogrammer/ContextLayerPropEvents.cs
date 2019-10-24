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
            layer.BackBorderNumbersRelChanged += OnBackBorderNumbersRelChanged;
            layer.BackTransformChanged += OnBackTransformChanged;
        }


        private void OnTextChanged()
        {
            _FgPreview.Text = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.Text));
            UpdateGeneratedCode();
        }
        private void OnTextAttrChanged()
        {
            _FgPreview.TextAttr = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.TextAttr));
            UpdateGeneratedCode();
        }
        private void OnTextPosRelChanged()
        {
            _FgPreview.TextPosRel = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.TextPosRel));
            UpdateGeneratedCode();
        }
        private void OnTextTransformChanged()
        {
            _FgPreview.TextTransform = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.TextTransform));
            UpdateGeneratedCode();
        }
        private void OnBackAttrChanged()
        {
            _FgPreview.BackAttr = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.BackAttr));
            UpdateGeneratedCode();
        }
        private void OnBackPosRelChanged()
        {
            _FgPreview.BackPosRel = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.BackPosRel));
            UpdateGeneratedCode();
        }
        private void OnBackBorderNumbersRelChanged()
        {
            _FgPreview.BackBorderNumbersRel = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.BackBorderNumbersRel));
            UpdateGeneratedCode();
        }
        private void OnBackTransformChanged()
        {
            _FgPreview.BackTransform = string.Join("|", XamlReversedLayers.Reverse().Select(layer => layer.BackTransform));
            UpdateGeneratedCode();
        }

    }

}
