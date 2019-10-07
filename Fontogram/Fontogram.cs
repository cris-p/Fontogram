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
        Logo,
        LogoWide
    }


    public class Fontogram
        : FontogramBase<FontogramReadyMade>
    {

        protected override void CreateBuiltin(FontogramReadyMade value)
        {
            switch (value)
            {
                case FontogramReadyMade.Test1:
                    AddLayers_Test1();
                    break;
                case FontogramReadyMade.Test2:
                    AddLayers_Test2();
                    break;
                case FontogramReadyMade.Logo:
                    AddLayers_Logo();  // 
                    break;
                default:
                    AddLayers_Default();
                    break;
            }
        }



        void AddLayers_Logo()
        {
            AddInternalLayer(
                    "0,0,0,0"
                    );
        }

        void AddLayers_Default()
        {

            AddInternalLayer(
                    "0,0,0,0"
                    );

        }

        void AddLayers_Test1()
        {

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );
        }

        void AddLayers_Test2()
        {

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );

            AddInternalLayer(
                    "0,0,0,0"
                    );
        }

    }

}
