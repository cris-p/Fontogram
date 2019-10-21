using System;

namespace PergleLabs.Fontogrammer
{

    partial class XamlLayerItem
    {


        // Text

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


        // TextAttr

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


        // TextPosRel

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


        // TextTransform

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


        // BackAttr

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


        // BackPosRel

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


        // BackCornerRadiusRel

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


        // BackTransform

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


    }

}