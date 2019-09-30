using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;


namespace PergleLabs.UI
{

    public enum BuiltinFontogram
    {
        Test1,
        Test2,
        Logo
    }


    /// <summary>
    /// Properties to be used in XAML
    /// </summary>
    /// 
    /// <remarks>
    /// This interface is shared between Fontogram and FgRecipe - important for 'SetForEachRecipe' (the 'string' type also helps).
    /// 
    /// Values are semicolon-separated - one for each recipe.
    /// 
    /// All size-like values are in percentages relative to the *height* of the Fontogram. Left and Right margins
    /// are considered relative to a square whose top and bottom edges coincide with that of the Fontogram, centered
    /// within Fontogram's actual horizontal span.
    /// 
    /// Font size is inferred from TextMarginRel.
    /// 
    /// Most characters of regular (non-icon) fonts don't fill the full text height; in these cases,
    /// the symbol(s) will not extend to the specified top and bottom margins. The remedy is to specify margins
    /// that are outside of the symbol's actual desired margins (values to be determined by experiment).
    /// In addition, the left and right margins will not cause the symbol to be stretched horizontally -
    /// instead, it will just be centered between the specified margins.
    /// 
    /// Transforms apply to each recipe (backdrop + text) as a whole.
    /// </remarks>
    internal interface FontogramProperties
    {
        //// e.g. "Segoe UI Emoji", "Arial", "Monospace", "Wingdings 3"
        //// default "Segoe MDL2 Assets"
        //string TextFont { set; }

        //// e.g. "Bold"
        //// default "Normal"
        //string TextFontWeight { set; }

        //// e.g. "#f00" (red), "#880088FF" (half transparent greenish blue)
        //// default "Black"
        //string TextColor { set; }

        //// e.g. "25,25,25,25" (centered half-size square), "0,-60,-60,0" (left-bottom aligned square; symbol cropped at top, and possibly at right, depending on actual width)
        //// default "0,0,0,0"
        //string TextMarginRel { set; }

        //// e.g. "25" (a quarter of the height from the bottom)
        //// default "0"
        //// It's the font's baseline. Some characters may extend below the baseline -
        //// quite common for emojis. Find the right value by experiment.
        //string TextYRel { set; }

        ////
        ////
        //// This is relative to the left boundary of a square aligned with the top and bottom
        //// of the control, centered horizontally relative to the control. Characters' left side
        //// boundaries are in general not perfectly aligned with this value. So experiment.
        //string TextXRel { set; }


        //// e.g. "50" (half of the control's height)
        //// default "100"
        //// It's the height of the font. Different characters may or may not fill this specified height.
        //string TextHeightRel { set; }


        // e.g. "👍", "Abc", "!"
        // default "" (no text)
        string Text { set; }

        // e.g. "Arial,bold,#f00"; "Segoe UI Emoji,,"
        // FontFamily,FontWeight,Color
        string TextAttr { set; }

        // e.g. "-10,10,60"
        // default "0,0,100"
        // FontSizeRel,xShiftRel,yShiftRel
        string TextPosRel { set; }

        string TextTransform { set; }


        // Transforms are: RotAngle, ScaleX, ScaleY, SkewAngleX, SkewAngleY; ... ; ...
        // relative to center of text or backdrop

        // Opacity,FillColor,StrokeThicknessRel,StrokeColor
        string BackAttr { set; }

        // (wRel, hRel, shiftXRel, shiftYRel)
        string BackPosRel { set; }

        // e.g. "50,50,0,0" (half disk)
        // default "10,10,10,10" (slightly rounded corners)
        string BackCornerRadiusRel { set; }

        string BackTransform { set; }


        //// e.g. "0.5"
        //// default "1"
        //string BackOpacity { set; }

        //// e.g. "#f00" (red), "#880088FF" (half transparent greenish blue)
        //// default "Transparent" (no backdrop)
        //string BackFillColor { set; }

        //// e.g. "10" (10% of Fontogram height)
        //// default "0" (no border)
        //string BackStrokeThicknessRel { set; }

        //// e.g. "#f00" (red), "#880088FF" (half transparent greenish blue)
        //// default "Black"
        //string BackStrokeColor { set; }

        ////// e.g. "25,25,25,25" (centered half-size square), "0,-60,-60,0" (left-bottom aligned square; symbol cropped at top, and possibly at right, depending on actual width)
        ////// default "0,0,0,0"
        ////string BackMarginRel { set; }

        //// (wRel, hRel, shiftXRel, shiftYRel)
        //string BackPosRel { set; }

        //// e.g. "50,50,0,0" (half disk)
        //// default "10,10,10,10" (slightly rounded corners)
        //string BackCornerRadiusRel { set; }



        //string RotAngle { set; }

        //// like https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.skewtransform.anglexproperty
        //// center in the middle of the text
        //string SkewAngleX { set; }

        //// like https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.skewtransform.angleyproperty
        //// center in the middle
        //string SkewAngleY { set; }

    }


    /// <summary>
    /// Interaction logic for Fontogram.xaml
    /// </summary>
    public partial class Fontogram
        : UserControl
        , FontogramProperties
    {

        public Fontogram()
        {
            InitializeComponent();


            //Builtin = BuiltinFontogram.Logo;
        }


        public BuiltinFontogram Builtin
        {
            set
            {
                CreateBuiltin(value);
            }
        }


        private void SetPropertyValuesInRecipes(string valueList, [CallerMemberName] string propertyName = "")
        {
            PropertyInfo propInfo = typeof(FgRecipe).GetProperty(propertyName);

            string[] values = valueList.Split(';');

            for (int n = 0; n < values.Length; n++)
            {
                string fontSizeRel = values[n];

                FgRecipe recipe = GetOrCreateNthRecipe(n);

                propInfo.SetValue(recipe, fontSizeRel);
            }
        }


        #region The Properties

        public string Text { set { SetPropertyValuesInRecipes(value); } }
        public string TextAttr { set { SetPropertyValuesInRecipes(value); } }
        public string TextPosRel { set { SetPropertyValuesInRecipes(value); } }
        public string TextTransform { set { SetPropertyValuesInRecipes(value); } }

        public string BackAttr { set { SetPropertyValuesInRecipes(value); } }
        public string BackPosRel { set { SetPropertyValuesInRecipes(value); } }
        public string BackCornerRadiusRel { set { SetPropertyValuesInRecipes(value); } }
        public string BackTransform { set { SetPropertyValuesInRecipes(value); } }
        //public string TextFont { set { SetPropertyValuesInRecipes(value); } }
        //public string TextFontWeight { set { SetPropertyValuesInRecipes(value); } }
        //public string TextColor { set { SetPropertyValuesInRecipes(value); } }
        //public string TextPosRel { set { SetPropertyValuesInRecipes(value); } }
        //public string Text { set { SetPropertyValuesInRecipes(value); } }
        //public string BackOpacity { set { SetPropertyValuesInRecipes(value); } }
        //public string BackFillColor { set { SetPropertyValuesInRecipes(value); } }
        //public string BackStrokeColor { set { SetPropertyValuesInRecipes(value); } }
        ////public string BackMarginRel { set { SetPropertyValuesInRecipes(value); } }
        //public string BackStrokeThicknessRel { set { SetPropertyValuesInRecipes(value); } }
        //public string BackCornerRadiusRel { set { SetPropertyValuesInRecipes(value); } }
        //public string RotAngle { set { SetPropertyValuesInRecipes(value); } }
        //public string SkewAngleX { set { SetPropertyValuesInRecipes(value); } }
        //public string SkewAngleY { set { SetPropertyValuesInRecipes(value); } }


        #endregion



        //public string FontSizeRel
        //{
        //    set
        //    {
        //        string[] fontSizes = value.Split(';');

        //        for (int n=0; n<fontSizes.Length; n++)
        //        {
        //            string fontSizeRel = fontSizes[n];
        //            FgRecipe recipe = GetOrCreateNthRecipe(n);

        //            recipe.FontSizeRel = fontSizeRel;
        //        }
        //    }
        //}



        private void CreateBuiltin(BuiltinFontogram value)
        {
            if (_isBuiltIn == false)
                StartClean();

            _isBuiltIn = true;


            switch (value)
            {
                case BuiltinFontogram.Test1:
                    AddRecipes_Test1();
                    break;
                case BuiltinFontogram.Test2:
                    AddRecipes_Test2();
                    break;
                case BuiltinFontogram.Logo:
                    AddRecipes_Logo();
                    break;
                default:
                    AddRecipes_Default();
                    break;
            }
        }

        private void AddInternalRecipe(string textMarginRel)
        {
            FgRecipe newRecipe = new FgRecipe();

            //newRecipe.TextMarginRel = textMarginRel;

            _ParentGrid.Children.Add(newRecipe);
            // no need to deal with 'this._Recipes'
        }


        private FgRecipe GetOrCreateNthRecipe(int n)
        {
            if (_isBuiltIn == true)
                StartClean();

            _isBuiltIn = false;


            // 'n' can be at most 1 past the end of the current list
            System.Diagnostics.Debug.Assert(n <= _Recipes.Count);

            if (n < _Recipes.Count)
                return _Recipes[n];


            FgRecipe newRecipe = new FgRecipe();

            _ParentGrid.Children.Add(newRecipe);
            _Recipes.Add(newRecipe);

            return newRecipe;
        }


        private void StartClean()
        {
            _ParentGrid.Children.Clear();
            _Recipes.Clear();
        }


        // for convenience - kept it in sync with the control Grid's 'Children' collection
        private readonly List<FgRecipe> _Recipes = new List<FgRecipe>();


        private bool? _isBuiltIn = null;

    }

}
