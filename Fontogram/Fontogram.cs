using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PergleLabs.UI
{

    public enum BuiltinFontogram
    {
        Test1,
        Test2,
        Logo
    }



    public class Fontogram
        : FontogramBase<BuiltinFontogram>
    {

        protected override void CreateBuiltin(BuiltinFontogram value)
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
