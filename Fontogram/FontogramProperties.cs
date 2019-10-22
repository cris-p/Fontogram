
namespace PergleLabs.UI
{

    public interface FontogramProperties
    {
 
        /// <summary>
        /// Text = " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string Text { set; }

        /// <summary>
        /// TextAttr = " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string TextAttr { set; }

        /// <summary>
        /// TextPosRel = " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string TextPosRel { set; }

        /// <summary>
        /// TextTransform = " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string TextTransform { set; }

        /// <summary>
        /// BackAttr = " BackOpacity_L0;BackFillColor_L0;BackStrokeThickness_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string BackAttr { set; }

        /// <summary>
        /// BackPosRel = " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string BackPosRel { set; }

        /// <summary>
        /// BackCornerRadiusRel = " BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string BackCornerRadiusRel { set; }

        /// <summary>
        /// BackTransform = " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
        /// </summary>
        string BackTransform { set; }

    }

}