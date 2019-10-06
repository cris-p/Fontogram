using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PergleLabs.UI
{

    public enum FontogramReadyMade
    {
        Test1,
        Test2,
        Logo
    }


    public class Fontogram
        : FontogramBase<FontogramReadyMade>
    {

        protected override void CreateBuiltin(FontogramReadyMade value)
        {
            switch (value)
            {
                case FontogramReadyMade.Test1:
                    AddRecipes_Test1();
                    break;
                case FontogramReadyMade.Test2:
                    AddRecipes_Test2();
                    break;
                case FontogramReadyMade.Logo:
                    AddRecipes_Logo();  // 
                    break;
                default:
                    AddRecipes_Default();
                    break;
            }
        }



        void AddRecipes_Logo()
        {
            AddInternalRecipe(
                    "0,0,0,0"
                    );
        }

        void AddRecipes_Default()
        {

            AddInternalRecipe(
                    "0,0,0,0"
                    );

        }

        void AddRecipes_Test1()
        {

            AddInternalRecipe(
                    "0,0,0,0"
                    );

            AddInternalRecipe(
                    "0,0,0,0"
                    );

            AddInternalRecipe(
                    "0,0,0,0"
                    );

            AddInternalRecipe(
                    "0,0,0,0"
                    );
        }

        void AddRecipes_Test2()
        {

            AddInternalRecipe(
                    "0,0,0,0"
                    );

            AddInternalRecipe(
                    "0,0,0,0"
                    );

            AddInternalRecipe(
                    "0,0,0,0"
                    );

            AddInternalRecipe(
                    "0,0,0,0"
                    );
        }

    }

}
