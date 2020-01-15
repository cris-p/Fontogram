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

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "B| ";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " | ";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = " | ";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " | ";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " | ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " | ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }

        void Create__Custom3(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = " | ";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = " | ";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = " | ";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = " | ";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " | ";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | ";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " | ";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = " | ";

        }
    }
}