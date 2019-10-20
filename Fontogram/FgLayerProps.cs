using System.Windows;

namespace PergleLabs.UI
{

    internal partial class FgLayer
        : FontogramProperties   // flowing down from Fontogram
    {

 
        // Text
        public string Text
        {
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
            set
            {
                DispatchValues(value
                    , _BindingProps.BackOpacity
                    , _BindingProps.BackFillColor
                    , _BindingProps.BackStrokeThickness
                    , _BindingProps.BackStrokeColor
                );
            }
        }

        // BackPosRel
        public string BackPosRel
        {
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

        // BackCornerRadiusRel
        public string BackCornerRadiusRel
        {
            set
            {
                DispatchValues(value
                    , _BindingProps.BackCornerRadius
                );
            }
        }

        // BackTransform
        public string BackTransform
        {
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