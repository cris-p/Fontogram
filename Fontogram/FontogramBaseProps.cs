using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace PergleLabs.UI
{

    public partial class FontogramBase
        : FontogramProperties
    {

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextChanged) );
        private static void OnTextChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextAttrProperty = DependencyProperty.Register(
            "TextAttr", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextAttrChanged) );
        private static void OnTextAttrChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string TextAttr
        {
            get { return (string)GetValue(TextAttrProperty); }
            set { SetValue(TextAttrProperty, value); }
        }

        public static readonly DependencyProperty TextPosRelProperty = DependencyProperty.Register(
            "TextPosRel", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextPosRelChanged) );
        private static void OnTextPosRelChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string TextPosRel
        {
            get { return (string)GetValue(TextPosRelProperty); }
            set { SetValue(TextPosRelProperty, value); }
        }

        public static readonly DependencyProperty TextTransformProperty = DependencyProperty.Register(
            "TextTransform", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnTextTransformChanged) );
        private static void OnTextTransformChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string TextTransform
        {
            get { return (string)GetValue(TextTransformProperty); }
            set { SetValue(TextTransformProperty, value); }
        }

        public static readonly DependencyProperty BackAttrProperty = DependencyProperty.Register(
            "BackAttr", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackAttrChanged) );
        private static void OnBackAttrChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string BackAttr
        {
            get { return (string)GetValue(BackAttrProperty); }
            set { SetValue(BackAttrProperty, value); }
        }

        public static readonly DependencyProperty BackPosRelProperty = DependencyProperty.Register(
            "BackPosRel", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackPosRelChanged) );
        private static void OnBackPosRelChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string BackPosRel
        {
            get { return (string)GetValue(BackPosRelProperty); }
            set { SetValue(BackPosRelProperty, value); }
        }

        public static readonly DependencyProperty BackCornerRadiusRelProperty = DependencyProperty.Register(
            "BackCornerRadiusRel", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackCornerRadiusRelChanged) );
        private static void OnBackCornerRadiusRelChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string BackCornerRadiusRel
        {
            get { return (string)GetValue(BackCornerRadiusRelProperty); }
            set { SetValue(BackCornerRadiusRelProperty, value); }
        }

        public static readonly DependencyProperty BackTransformProperty = DependencyProperty.Register(
            "BackTransform", typeof(string), typeof(FontogramBase), new PropertyMetadata(null, OnBackTransformChanged) );
        private static void OnBackTransformChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).SetPropertyValuesInLayers(e.NewValue as string, e.Property.Name);
        }
        public string BackTransform
        {
            get { return (string)GetValue(BackTransformProperty); }
            set { SetValue(BackTransformProperty, value); }
        }

    }

}