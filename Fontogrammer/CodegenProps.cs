using System.Text;

namespace PergleLabs.Fontogrammer
{

    abstract partial class CodeGenerator
    {

        protected void AddProperties(StringBuilder codeText)
        {
            AddProperty(codeText, "Text", _ReferenceFontogram.Text);
            AddProperty(codeText, "TextAttr", _ReferenceFontogram.TextAttr);
            AddProperty(codeText, "TextPosRel", _ReferenceFontogram.TextPosRel);
            AddProperty(codeText, "TextTransform", _ReferenceFontogram.TextTransform);
            AddProperty(codeText, "BackAttr", _ReferenceFontogram.BackAttr);
            AddProperty(codeText, "BackPosRel", _ReferenceFontogram.BackPosRel);
            AddProperty(codeText, "BackBorderNumbersRel", _ReferenceFontogram.BackBorderNumbersRel);
            AddProperty(codeText, "BackTransform", _ReferenceFontogram.BackTransform);
        }

    }

}