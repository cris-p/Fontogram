using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PergleLabs.UI
{

    public partial class Fontogram
    {

        const string DEF_SymbolFont = "Segoe MDL2 Assets";
        const string DEF_SymbolFontWeight = "Normal";
        const string DEF_SymbolColor = "Black";
        const string DEF_SymbolMarginRel = "0,0,0,0";
        const string DEF_SymbolText = "";   // no text
        const string DEF_BackOpacity = "1";
        const string DEF_BackFillColor = "Transparent"; // no backdrop
        const string DEF_BackStrokeThicknessRel = "0";  // no border
        const string DEF_BackStrokeColor = "Black";
        const string DEF_BackMarginRel = "0,0,0,0";
        const string DEF_BackCornerRadiusRel = "10,10,10,10";   // slightly rounded corners




        void AddRecipes_Logo()
        {
            AddInternalRecipe(
                    "80"
                    );
        }

        void AddRecipes_Default()
        {

            AddInternalRecipe(
                    "50"
                    );

        }

        void AddRecipes_Test1()
        {

            AddInternalRecipe(
                    "20"
                    );

            AddInternalRecipe(
                    "40"
                    );

            AddInternalRecipe(
                    "60"
                    );

            AddInternalRecipe(
                    "80"
                    );
        }

        void AddRecipes_Test2()
        {

            AddInternalRecipe(
                    "100"
                    );

            AddInternalRecipe(
                    "95"
                    );

            AddInternalRecipe(
                    "90"
                    );

            AddInternalRecipe(
                    "85"
                    );
        }

    }

}
