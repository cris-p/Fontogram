using System.Collections.Generic;
using System.Windows;

namespace FgSample
{

    public partial class CustomFgPack
    {

        // For each type of ready-made Fontogram, must set each property as a '|'-separated list of layers,
        // each layer being a list of ';'-separated values of the component attributes.
        // Some attributes' values can be lists of ','-separated values.
        // Leave empty those slots that don't need to be set. (sensible defaults will be used)


        void Create__Custom1(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "1|1";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " |;bold";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = "120;-20|80;20";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " |180";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = "2;#ffd;red| ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = "2;20| ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }

        void Create__Custom2(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            _Text = "2|2";
            _TextAttr = ";bold;gray|;bold;#d080";
            _TextPosRel = ";13;15.5|;-16;-9";
            _TextTransform = ";;0.4;-60;|;;;;";
        }

        void Create__Custom3(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "|3";
            _TextAttr = "|Courier New;bold;blue";
            _TextPosRel = "|120;;6";
            _BackAttr = ";silver;gainsboro|;silver;gainsboro";
            _BackPosRel = "80;60;-2;19|70;60;-0.5;-19";
            _BackBorderNumbersRel = "4,0,4,4;60,30,30,32|2,4,2,0;35,29,29,60";
        }
    }
}