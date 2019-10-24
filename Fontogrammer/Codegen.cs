using PergleLabs.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PergleLabs.Fontogrammer
{

    abstract class CodeGenerator
    {

        public CodeGenerator(Fontogram fg)
        {
            _ReferenceFontogram = fg;
        }

        public string GetCode()
        {
            StringBuilder codeText = new StringBuilder();

            AddBeginning(codeText);

            AddProperties(codeText);

            AddEnding(codeText);

            return codeText.ToString();
        }

        protected abstract void AddBeginning(StringBuilder codeText);

        protected void AddProperties(StringBuilder codeText)
        {
            AddProperty(codeText, "Text", _ReferenceFontogram.Text);
            AddProperty(codeText, "TextAttr", _ReferenceFontogram.TextAttr);
        }
        protected abstract void AddProperty(StringBuilder codeText, string propertyName, string propertyValue);

        protected abstract void AddEnding(StringBuilder codeText);


        protected int _currentIndent = 0;


        private readonly Fontogram _ReferenceFontogram;

    }


    class CodegenCsharp
        : CodeGenerator
    {

        public CodegenCsharp(Fontogram fg)
            : base(fg)
        { }

        protected override void AddBeginning(StringBuilder codeText)
        {
            codeText.AppendLine("[C# beginning]");
            _currentIndent = 4;
        }

        protected override void AddEnding(StringBuilder codeText)
        {
            codeText.AppendLine("[C# ending]");
        }

        protected override void AddProperty(StringBuilder codeText, string propertyName, string propertyValue)
        {
            codeText.AppendLine($"{string.Empty.PadLeft(_currentIndent, ' ')}_{propertyName} = \"{propertyValue}\";");
        }
    }

}
