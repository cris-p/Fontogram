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

        #endregion


        #region BackCornerRadiusRel

        // Composite property

        private string __BackCornerRadiusRel;
        public string BackCornerRadiusRel
        {
            get { return __BackCornerRadiusRel; }
            set
            {
                __BackCornerRadiusRel = value;
                BackCornerRadiusRelChanged?.Invoke();
            }
        }
        public event Action BackCornerRadiusRelChanged;

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

        #endregion


    }

}