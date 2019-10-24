using System.Windows;

namespace PergleLabs.UI
{

    internal partial class FgLayer
        : FontogramProperties   // flowing down from Fontogram
    {

 
        // Text
        public string Text
        {
            get
            {
                return RevealValues( _BindingProps.Text );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.Text
                );
            }
        }

        // TextAttr
        public string TextAttr
        {
            get
            {
                return RevealValues( _BindingProps.TextFont, _BindingProps.TextFontWeight, _BindingProps.TextColor );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.TextFont
                    , _BindingProps.TextFontWeight
                    , _BindingProps.TextColor
                );
            }
        }

        // TextPosRel
        public string TextPosRel
        {
            get
            {
                return RevealValues( _BindingProps.TextFontSize, _BindingProps.TextShiftX, _BindingProps.TextShiftY );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.TextFontSize
                    , _BindingProps.TextShiftX
                    , _BindingProps.TextShiftY
                );
            }
        }

        // TextTransform
        public string TextTransform
        {
            get
            {
                return RevealValues( _BindingProps.TextRotAngle, _BindingProps.TextScaleX, _BindingProps.TextScaleY, _BindingProps.TextSkewX, _BindingProps.TextSkewY );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.TextRotAngle
                    , _BindingProps.TextScaleX
                    , _BindingProps.TextScaleY
                    , _BindingProps.TextSkewX
                    , _BindingProps.TextSkewY
                );
            }
        }

        // BackAttr
        public string BackAttr
        {
            get
            {
                return RevealValues( _BindingProps.BackOpacity, _BindingProps.BackFillColor, _BindingProps.BackStrokeColor );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.BackOpacity
                    , _BindingProps.BackFillColor
                    , _BindingProps.BackStrokeColor
                );
            }
        }

        // BackPosRel
        public string BackPosRel
        {
            get
            {
                return RevealValues( _BindingProps.BackWidth, _BindingProps.BackHeight, _BindingProps.BackShiftX, _BindingProps.BackShiftY );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.BackWidth
                    , _BindingProps.BackHeight
                    , _BindingProps.BackShiftX
                    , _BindingProps.BackShiftY
                );
            }
        }

        // BackBorderNumbersRel
        public string BackBorderNumbersRel
        {
            get
            {
                return RevealValues( _BindingProps.BackStrokeThickness, _BindingProps.BackCornerRadius );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.BackStrokeThickness
                    , _BindingProps.BackCornerRadius
                );
            }
        }

        // BackTransform
        public string BackTransform
        {
            get
            {
                return RevealValues( _BindingProps.BackRotAngle, _BindingProps.BackScaleX, _BindingProps.BackScaleY, _BindingProps.BackSkewX, _BindingProps.BackSkewY );
            }
            set
            {
                DispatchValues(value
                    , _BindingProps.BackRotAngle
                    , _BindingProps.BackScaleX
                    , _BindingProps.BackScaleY
                    , _BindingProps.BackSkewX
                    , _BindingProps.BackSkewY
                );
            }
        }

    }

}