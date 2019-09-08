using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace PergleLabs.UI
{

    /// <summary>
    /// just to have them in one place ('internal' is fine)
    /// </summary>
    internal interface FontogramProperties
    {
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



        private FgRecipe GetOrCreateNthRecipe(int n)
        {
            // 'n' can be at most 1 past the end of the current list
            System.Diagnostics.Debug.Assert(n <= _Recipes.Count);

            if (n < _Recipes.Count)
                return _Recipes[n];


            FgRecipe newRecipe = new FgRecipe();

            _ParentGrid.Children.Add(newRecipe);
            _Recipes.Add(newRecipe);

            return newRecipe;
        }


        // kept it in sync with the control Grid's 'Children' collection
        private readonly List<FgRecipe> _Recipes = new List<FgRecipe>();

    }

}
