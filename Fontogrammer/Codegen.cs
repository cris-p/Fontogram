using PergleLabs.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PergleLabs.Fontogrammer
{

    abstract partial class CodeGenerator
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

        protected abstract void AddProperty(StringBuilder codeText, string propertyName, string propertyValue);

        protected abstract void AddEnding(StringBuilder codeText);


        protected int _currentIndent = 0;

        protected readonly Fontogram _ReferenceFontogram;

    }


    class CodegenXaml
        : CodeGenerator
    {

        public CodegenXaml(Fontogram fg)
            : base(fg)
        { }

        protected override void AddBeginning(StringBuilder codeText)
        {
            /*
                                    <fg:Fontogram
                                        Width="192" Height="128"
                                        
                                        Text="{Binding PreviewFontogram.Text}"
                                        TextAttr="{Binding PreviewFontogram.TextAttr}"
                                        TextPosRel="{Binding PreviewFontogram.TextPosRel}"
                                        TextTransform="{Binding PreviewFontogram.TextTransform}"
                                        BackAttr="{Binding PreviewFontogram.BackAttr}"
                                        BackPosRel="{Binding PreviewFontogram.BackPosRel}"
                                        BackBorderNumbersRel="{Binding PreviewFontogram.BackBorderNumbersRel}"
                                        BackTransform="{Binding PreviewFontogram.BackTransform}"
                                        
                                        ReadyMade="{Binding PreviewFontogram.ReadyMade}"
                                            
                                        SelectiveLayerEnable="{Binding PositionInFontogram}"
                                        />
             */
            codeText.AppendLine("< ...");
            codeText.AppendLine("    xmlns:fg=\"clr -namespace:PergleLabs.UI;assembly=PergleLabs.Fontogram\"");
            codeText.AppendLine("    >");
            codeText.AppendLine("    ...");

            _currentIndent = 4;
            string pad = string.Empty.PadLeft(_currentIndent, ' ');

            codeText.AppendLine($"{pad}<fg:Fontogram");

            _currentIndent += 4;

        }

        protected override void AddEnding(StringBuilder codeText)
        {
            string pad = string.Empty.PadLeft(_currentIndent, ' ');

            codeText.AppendLine($"{string.Empty.PadLeft(_currentIndent, ' ')}ReadyMade = \"{_ReferenceFontogram.ReadyMade}\";");

            codeText.AppendLine($"{pad}/>");
        }

        protected override void AddProperty(StringBuilder codeText, string propertyName, string propertyValue)
        {
            codeText.AppendLine($"{string.Empty.PadLeft(_currentIndent, ' ')}{propertyName} = \"{propertyValue}\";");
        }
    }

    class CodegenCsharp
        : CodeGenerator
    {

        public CodegenCsharp(Fontogram fg)
            : base(fg)
        { }

        protected override void AddBeginning(StringBuilder codeText)
        {
            codeText.AppendLine("void Create__<custom READYMADE_NAMES enum entry>(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)");
            codeText.AppendLine("{");

            _currentIndent = 4;
        }

        protected override void AddEnding(StringBuilder codeText)
        {
            codeText.AppendLine("}");
        }

        protected override void AddProperty(StringBuilder codeText, string propertyName, string propertyValue)
        {
            codeText.AppendLine($"{string.Empty.PadLeft(_currentIndent, ' ')}_{propertyName} = \"{propertyValue}\";");
        }
    }

}
