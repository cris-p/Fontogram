using System.Windows;

namespace FgSample
{

    public enum ReadyMadeCustomFgPack
    {
        Custom1,
        Custom2,
        Custom3,
    }

    public partial class CustomFgPack
        : PergleLabs.UI.FontogramBase< ReadyMadeCustomFgPack >
    {

        public static readonly DependencyProperty ReadyMadeProperty =
            DependencyProperty.Register(
                "ReadyMade", typeof(ReadyMadeCustomFgPack?),
                typeof(CustomFgPack),
                new PropertyMetadata(null, OnReadyMadeChanged));
        public ReadyMadeCustomFgPack? ReadyMade
        {
            get { return (ReadyMadeCustomFgPack?)GetValue(ReadyMadeProperty); }
            set { SetValue(ReadyMadeProperty, value); }
        }

        protected override bool GetReadyMadeProperties(ReadyMadeCustomFgPack readyMadeID
            , out string _Text
            , out string _TextAttr
            , out string _TextPosRel
            , out string _TextTransform
            , out string _BackAttr
            , out string _BackPosRel
            , out string _BackBorderNumbersRel
            , out string _BackTransform
            )
        {
            _Text = "";
            _TextAttr = "";
            _TextPosRel = "";
            _TextTransform = "";
            _BackAttr = "";
            _BackPosRel = "";
            _BackBorderNumbersRel = "";
            _BackTransform = "";

            switch (readyMadeID)
            {
                case ReadyMadeCustomFgPack.Custom1:
                    Create__Custom1(ref _Text, ref _TextAttr, ref _TextPosRel, ref _TextTransform, ref _BackAttr, ref _BackPosRel, ref _BackBorderNumbersRel, ref _BackTransform);
                    break;

                case ReadyMadeCustomFgPack.Custom2:
                    Create__Custom2(ref _Text, ref _TextAttr, ref _TextPosRel, ref _TextTransform, ref _BackAttr, ref _BackPosRel, ref _BackBorderNumbersRel, ref _BackTransform);
                    break;

                case ReadyMadeCustomFgPack.Custom3:
                    Create__Custom3(ref _Text, ref _TextAttr, ref _TextPosRel, ref _TextTransform, ref _BackAttr, ref _BackPosRel, ref _BackBorderNumbersRel, ref _BackTransform);
                    break;


                default:
                    return false;
            }

            return true;
        }

        #region Contents of file CustomFgPack.cs
        /*
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

        void Create__Custom2(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
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
        */
        #endregion
    }

}
