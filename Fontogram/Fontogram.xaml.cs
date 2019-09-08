using System;
using System.Collections.Generic;
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
    /// just to have them in one place ('internal' is fine)
    /// </summary>
    internal interface FontogramProperties
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value>default: 100</value>
        string FontSizeRel { set; }
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

            Builtin = BuiltinFontogram.Logo;
        }


        public BuiltinFontogram Builtin
        {
            set
            {
                CreateBuiltin(value);
            }
        }


        public string FontSizeRel
        {
            set
            {
                string[] fontSizes = value.Split(';');

                for (int n=0; n<fontSizes.Length; n++)
                {
                    string fontSizeRel = fontSizes[n];
                    FgRecipe recipe = GetOrCreateNthRecipe(n);

                    recipe.FontSizeRel = fontSizeRel;
                }
            }
        }



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

        private void AddInternalRecipe(string fontSizeRel)
        {
            FgRecipe newRecipe = new FgRecipe();

            newRecipe.FontSizeRel = fontSizeRel;

            _ParentGrid.Children.Add(newRecipe);
            // no need to deal with this._Recipes
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
