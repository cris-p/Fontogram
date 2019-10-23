using System.Windows;

namespace PergleLabs.UI
{

    public partial class FontogramBase
        : FontogramProperties
    {

        // Text
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextChanged) );
        private static void OnTextChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.Text_readyMade, e.Property.Name);
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        private string __Text_readyMade;
        private string Text_readyMade
        {
            get { return __Text_readyMade; }
            set { __Text_readyMade = value; SetPropertyValuesInLayers(Text, value, "Text"); }
        }

        // TextAttr
        public static readonly DependencyProperty TextAttrProperty = DependencyProperty.Register(
            "TextAttr", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextAttrChanged) );
        private static void OnTextAttrChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.TextAttr_readyMade, e.Property.Name);
        }
        public string TextAttr
        {
            get { return (string)GetValue(TextAttrProperty); }
            set { SetValue(TextAttrProperty, value); }
        }
        private string __TextAttr_readyMade;
        private string TextAttr_readyMade
        {
            get { return __TextAttr_readyMade; }
            set { __TextAttr_readyMade = value; SetPropertyValuesInLayers(TextAttr, value, "TextAttr"); }
        }

        // TextPosRel
        public static readonly DependencyProperty TextPosRelProperty = DependencyProperty.Register(
            "TextPosRel", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextPosRelChanged) );
        private static void OnTextPosRelChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.TextPosRel_readyMade, e.Property.Name);
        }
        public string TextPosRel
        {
            get { return (string)GetValue(TextPosRelProperty); }
            set { SetValue(TextPosRelProperty, value); }
        }
        private string __TextPosRel_readyMade;
        private string TextPosRel_readyMade
        {
            get { return __TextPosRel_readyMade; }
            set { __TextPosRel_readyMade = value; SetPropertyValuesInLayers(TextPosRel, value, "TextPosRel"); }
        }

        // TextTransform
        public static readonly DependencyProperty TextTransformProperty = DependencyProperty.Register(
            "TextTransform", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextTransformChanged) );
        private static void OnTextTransformChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.TextTransform_readyMade, e.Property.Name);
        }
        public string TextTransform
        {
            get { return (string)GetValue(TextTransformProperty); }
            set { SetValue(TextTransformProperty, value); }
        }
        private string __TextTransform_readyMade;
        private string TextTransform_readyMade
        {
            get { return __TextTransform_readyMade; }
            set { __TextTransform_readyMade = value; SetPropertyValuesInLayers(TextTransform, value, "TextTransform"); }
        }

        // BackAttr
        public static readonly DependencyProperty BackAttrProperty = DependencyProperty.Register(
            "BackAttr", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackAttrChanged) );
        private static void OnBackAttrChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.BackAttr_readyMade, e.Property.Name);
        }
        public string BackAttr
        {
            get { return (string)GetValue(BackAttrProperty); }
            set { SetValue(BackAttrProperty, value); }
        }
        private string __BackAttr_readyMade;
        private string BackAttr_readyMade
        {
            get { return __BackAttr_readyMade; }
            set { __BackAttr_readyMade = value; SetPropertyValuesInLayers(BackAttr, value, "BackAttr"); }
        }

        // BackPosRel
        public static readonly DependencyProperty BackPosRelProperty = DependencyProperty.Register(
            "BackPosRel", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackPosRelChanged) );
        private static void OnBackPosRelChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.BackPosRel_readyMade, e.Property.Name);
        }
        public string BackPosRel
        {
            get { return (string)GetValue(BackPosRelProperty); }
            set { SetValue(BackPosRelProperty, value); }
        }
        private string __BackPosRel_readyMade;
        private string BackPosRel_readyMade
        {
            get { return __BackPosRel_readyMade; }
            set { __BackPosRel_readyMade = value; SetPropertyValuesInLayers(BackPosRel, value, "BackPosRel"); }
        }

        // BackBorderNumbersRel
        public static readonly DependencyProperty BackBorderNumbersRelProperty = DependencyProperty.Register(
            "BackBorderNumbersRel", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackBorderNumbersRelChanged) );
        private static void OnBackBorderNumbersRelChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.BackBorderNumbersRel_readyMade, e.Property.Name);
        }
        public string BackBorderNumbersRel
        {
            get { return (string)GetValue(BackBorderNumbersRelProperty); }
            set { SetValue(BackBorderNumbersRelProperty, value); }
        }
        private string __BackBorderNumbersRel_readyMade;
        private string BackBorderNumbersRel_readyMade
        {
            get { return __BackBorderNumbersRel_readyMade; }
            set { __BackBorderNumbersRel_readyMade = value; SetPropertyValuesInLayers(BackBorderNumbersRel, value, "BackBorderNumbersRel"); }
        }

        // BackTransform
        public static readonly DependencyProperty BackTransformProperty = DependencyProperty.Register(
            "BackTransform", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackTransformChanged) );
        private static void OnBackTransformChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase fgObj = depObj as FontogramBase;
            fgObj.SetPropertyValuesInLayers(e.NewValue as string, fgObj.BackTransform_readyMade, e.Property.Name);
        }
        public string BackTransform
        {
            get { return (string)GetValue(BackTransformProperty); }
            set { SetValue(BackTransformProperty, value); }
        }
        private string __BackTransform_readyMade;
        private string BackTransform_readyMade
        {
            get { return __BackTransform_readyMade; }
            set { __BackTransform_readyMade = value; SetPropertyValuesInLayers(BackTransform, value, "BackTransform"); }
        }


        #region ReadyMade support

        protected void ClearReadyMade()
        {
            ClearLayers();
            Text_readyMade = "";
            TextAttr_readyMade = "";
            TextPosRel_readyMade = "";
            TextTransform_readyMade = "";
            BackAttr_readyMade = "";
            BackPosRel_readyMade = "";
            BackBorderNumbersRel_readyMade = "";
            BackTransform_readyMade = "";
        }

        protected void SetReadyMade(
              string _Text_readyMade
            , string _TextAttr_readyMade
            , string _TextPosRel_readyMade
            , string _TextTransform_readyMade
            , string _BackAttr_readyMade
            , string _BackPosRel_readyMade
            , string _BackBorderNumbersRel_readyMade
            , string _BackTransform_readyMade
        )
        {
            Text_readyMade = _Text_readyMade;
            TextAttr_readyMade = _TextAttr_readyMade;
            TextPosRel_readyMade = _TextPosRel_readyMade;
            TextTransform_readyMade = _TextTransform_readyMade;
            BackAttr_readyMade = _BackAttr_readyMade;
            BackPosRel_readyMade = _BackPosRel_readyMade;
            BackBorderNumbersRel_readyMade = _BackBorderNumbersRel_readyMade;
            BackTransform_readyMade = _BackTransform_readyMade;
        }

        #endregion

    }


    
    // We need to have another class for ready-made support, because there seem to be problems when generic
    // classes contain dependency properties. (At least XAML complains by underlining the properties.)
    public abstract class FontogramBase<_T>
        : FontogramBase
        where _T : struct, System.Enum
    {

        protected static void OnReadyMadeChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            FontogramBase<_T> fgObj = depObj as FontogramBase<_T>;

            fgObj.ClearReadyMade();

            if (e.NewValue == null)
                return;


            _T readyMadeID = (_T)e.NewValue;

            if (!fgObj.GetReadyMadeProperties(readyMadeID
                , out string _Text
                , out string _TextAttr
                , out string _TextPosRel
                , out string _TextTransform
                , out string _BackAttr
                , out string _BackPosRel
                , out string _BackBorderNumbersRel
                , out string _BackTransform
                ))
                return;


            fgObj.SetReadyMade(
                _Text
                , _TextAttr
                , _TextPosRel
                , _TextTransform
                , _BackAttr
                , _BackPosRel
                , _BackBorderNumbersRel
                , _BackTransform
                );
        }


        protected abstract bool GetReadyMadeProperties(_T readyMadeID
            , out string _Text
            , out string _TextAttr
            , out string _TextPosRel
            , out string _TextTransform
            , out string _BackAttr
            , out string _BackPosRel
            , out string _BackBorderNumbersRel
            , out string _BackTransform
            );

    }

}