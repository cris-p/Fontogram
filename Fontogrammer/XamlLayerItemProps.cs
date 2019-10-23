using System;

namespace PergleLabs.Fontogrammer
{

    partial class XamlLayerItem
    {


        #region Text

        // Composite property

        private string __Text;
        public string Text
        {
            get { return __Text; }
            set
            {
                __Text = value;
                TextChanged?.Invoke();
            }
        }
        public event Action TextChanged;


        // Components

        // Text
        private string __Text_;
        public string Text_
        {
            get { return __Text_; }
            set
            {
                __Text_ = value;
                UpdateText();
            }
        }


        private void UpdateText()
        {
            Text = $"{Text_}";
        }

        #endregion


        #region TextAttr

        // Composite property

        private string __TextAttr;
        public string TextAttr
        {
            get { return __TextAttr; }
            set
            {
                __TextAttr = value;
                TextAttrChanged?.Invoke();
            }
        }
        public event Action TextAttrChanged;


        // Components

        // TextFont
        private string __TextFont_;
        public string TextFont_
        {
            get { return __TextFont_; }
            set
            {
                __TextFont_ = value;
                UpdateTextAttr();
            }
        }

        // TextFontWeight
        private string __TextFontWeight_;
        public string TextFontWeight_
        {
            get { return __TextFontWeight_; }
            set
            {
                __TextFontWeight_ = value;
                UpdateTextAttr();
            }
        }

        // TextColor
        private string __TextColor_;
        public string TextColor_
        {
            get { return __TextColor_; }
            set
            {
                __TextColor_ = value;
                UpdateTextAttr();
            }
        }


        private void UpdateTextAttr()
        {
            TextAttr = $"{TextFont_};{TextFontWeight_};{TextColor_}";
        }

        #endregion


        #region TextPosRel

        // Composite property

        private string __TextPosRel;
        public string TextPosRel
        {
            get { return __TextPosRel; }
            set
            {
                __TextPosRel = value;
                TextPosRelChanged?.Invoke();
            }
        }
        public event Action TextPosRelChanged;


        // Components

        // TextFontSize
        private string __TextFontSize_;
        public string TextFontSize_
        {
            get { return __TextFontSize_; }
            set
            {
                __TextFontSize_ = value;
                UpdateTextPosRel();
            }
        }

        // TextShiftX
        private string __TextShiftX_;
        public string TextShiftX_
        {
            get { return __TextShiftX_; }
            set
            {
                __TextShiftX_ = value;
                UpdateTextPosRel();
            }
        }

        // TextShiftY
        private string __TextShiftY_;
        public string TextShiftY_
        {
            get { return __TextShiftY_; }
            set
            {
                __TextShiftY_ = value;
                UpdateTextPosRel();
            }
        }


        private void UpdateTextPosRel()
        {
            TextPosRel = $"{TextFontSize_};{TextShiftX_};{TextShiftY_}";
        }

        #endregion


        #region TextTransform

        // Composite property

        private string __TextTransform;
        public string TextTransform
        {
            get { return __TextTransform; }
            set
            {
                __TextTransform = value;
                TextTransformChanged?.Invoke();
            }
        }
        public event Action TextTransformChanged;


        // Components

        // TextRotAngle
        private string __TextRotAngle_;
        public string TextRotAngle_
        {
            get { return __TextRotAngle_; }
            set
            {
                __TextRotAngle_ = value;
                UpdateTextTransform();
            }
        }

        // TextScaleX
        private string __TextScaleX_;
        public string TextScaleX_
        {
            get { return __TextScaleX_; }
            set
            {
                __TextScaleX_ = value;
                UpdateTextTransform();
            }
        }

        // TextScaleY
        private string __TextScaleY_;
        public string TextScaleY_
        {
            get { return __TextScaleY_; }
            set
            {
                __TextScaleY_ = value;
                UpdateTextTransform();
            }
        }

        // TextSkewX
        private string __TextSkewX_;
        public string TextSkewX_
        {
            get { return __TextSkewX_; }
            set
            {
                __TextSkewX_ = value;
                UpdateTextTransform();
            }
        }

        // TextSkewY
        private string __TextSkewY_;
        public string TextSkewY_
        {
            get { return __TextSkewY_; }
            set
            {
                __TextSkewY_ = value;
                UpdateTextTransform();
            }
        }


        private void UpdateTextTransform()
        {
            TextTransform = $"{TextRotAngle_};{TextScaleX_};{TextScaleY_};{TextSkewX_};{TextSkewY_}";
        }

        #endregion


        #region BackAttr

        // Composite property

        private string __BackAttr;
        public string BackAttr
        {
            get { return __BackAttr; }
            set
            {
                __BackAttr = value;
                BackAttrChanged?.Invoke();
            }
        }
        public event Action BackAttrChanged;


        // Components

        // BackOpacity
        private string __BackOpacity_;
        public string BackOpacity_
        {
            get { return __BackOpacity_; }
            set
            {
                __BackOpacity_ = value;
                UpdateBackAttr();
            }
        }

        // BackFillColor
        private string __BackFillColor_;
        public string BackFillColor_
        {
            get { return __BackFillColor_; }
            set
            {
                __BackFillColor_ = value;
                UpdateBackAttr();
            }
        }

        // BackStrokeColor
        private string __BackStrokeColor_;
        public string BackStrokeColor_
        {
            get { return __BackStrokeColor_; }
            set
            {
                __BackStrokeColor_ = value;
                UpdateBackAttr();
            }
        }


        private void UpdateBackAttr()
        {
            BackAttr = $"{BackOpacity_};{BackFillColor_};{BackStrokeColor_}";
        }

        #endregion


        #region BackPosRel

        // Composite property

        private string __BackPosRel;
        public string BackPosRel
        {
            get { return __BackPosRel; }
            set
            {
                __BackPosRel = value;
                BackPosRelChanged?.Invoke();
            }
        }
        public event Action BackPosRelChanged;


        // Components

        // BackWidth
        private string __BackWidth_;
        public string BackWidth_
        {
            get { return __BackWidth_; }
            set
            {
                __BackWidth_ = value;
                UpdateBackPosRel();
            }
        }

        // BackHeight
        private string __BackHeight_;
        public string BackHeight_
        {
            get { return __BackHeight_; }
            set
            {
                __BackHeight_ = value;
                UpdateBackPosRel();
            }
        }

        // BackShiftX
        private string __BackShiftX_;
        public string BackShiftX_
        {
            get { return __BackShiftX_; }
            set
            {
                __BackShiftX_ = value;
                UpdateBackPosRel();
            }
        }

        // BackShiftY
        private string __BackShiftY_;
        public string BackShiftY_
        {
            get { return __BackShiftY_; }
            set
            {
                __BackShiftY_ = value;
                UpdateBackPosRel();
            }
        }


        private void UpdateBackPosRel()
        {
            BackPosRel = $"{BackWidth_};{BackHeight_};{BackShiftX_};{BackShiftY_}";
        }

        #endregion


        #region BackBorderNumbersRel

        // Composite property

        private string __BackBorderNumbersRel;
        public string BackBorderNumbersRel
        {
            get { return __BackBorderNumbersRel; }
            set
            {
                __BackBorderNumbersRel = value;
                BackBorderNumbersRelChanged?.Invoke();
            }
        }
        public event Action BackBorderNumbersRelChanged;


        // Components

        // BackStrokeThickness
        private string __BackStrokeThickness_;
        public string BackStrokeThickness_
        {
            get { return __BackStrokeThickness_; }
            set
            {
                __BackStrokeThickness_ = value;
                UpdateBackBorderNumbersRel();
            }
        }

        // BackCornerRadius
        private string __BackCornerRadius_;
        public string BackCornerRadius_
        {
            get { return __BackCornerRadius_; }
            set
            {
                __BackCornerRadius_ = value;
                UpdateBackBorderNumbersRel();
            }
        }


        private void UpdateBackBorderNumbersRel()
        {
            BackBorderNumbersRel = $"{BackStrokeThickness_};{BackCornerRadius_}";
        }

        #endregion


        #region BackTransform

        // Composite property

        private string __BackTransform;
        public string BackTransform
        {
            get { return __BackTransform; }
            set
            {
                __BackTransform = value;
                BackTransformChanged?.Invoke();
            }
        }
        public event Action BackTransformChanged;


        // Components

        // BackRotAngle
        private string __BackRotAngle_;
        public string BackRotAngle_
        {
            get { return __BackRotAngle_; }
            set
            {
                __BackRotAngle_ = value;
                UpdateBackTransform();
            }
        }

        // BackScaleX
        private string __BackScaleX_;
        public string BackScaleX_
        {
            get { return __BackScaleX_; }
            set
            {
                __BackScaleX_ = value;
                UpdateBackTransform();
            }
        }

        // BackScaleY
        private string __BackScaleY_;
        public string BackScaleY_
        {
            get { return __BackScaleY_; }
            set
            {
                __BackScaleY_ = value;
                UpdateBackTransform();
            }
        }

        // BackSkewX
        private string __BackSkewX_;
        public string BackSkewX_
        {
            get { return __BackSkewX_; }
            set
            {
                __BackSkewX_ = value;
                UpdateBackTransform();
            }
        }

        // BackSkewY
        private string __BackSkewY_;
        public string BackSkewY_
        {
            get { return __BackSkewY_; }
            set
            {
                __BackSkewY_ = value;
                UpdateBackTransform();
            }
        }


        private void UpdateBackTransform()
        {
            BackTransform = $"{BackRotAngle_};{BackScaleX_};{BackScaleY_};{BackSkewX_};{BackSkewY_}";
        }

        #endregion


    }

}