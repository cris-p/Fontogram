using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PergleLabs.UI
{

    public enum ReadyMadeFontogram
    {
        Fontogram_Logo,
        Fontogram_LogoWide,
        Sample_RgbSwirl,
        Test1,
        Test2
    }


    public class Fontogram
        : FontogramBase<ReadyMadeFontogram>
    {

        public static readonly DependencyProperty ReadyMadeProperty =
            DependencyProperty.Register(
                "ReadyMade", typeof(ReadyMadeFontogram?),
                typeof(Fontogram),
                new PropertyMetadata(null, OnReadyMadeChanged));
        public ReadyMadeFontogram? ReadyMade
        {
            get { return (ReadyMadeFontogram?)GetValue(ReadyMadeProperty); }
            set { SetValue(ReadyMadeProperty, value); }
        }

        protected override bool GetReadyMadeProperties(ReadyMadeFontogram readyMadeID
            , out string _Text
            , out string _TextAttr
            , out string _TextPosRel
            , out string _TextTransform
            , out string _BackAttr
            , out string _BackPosRel
            , out string _BackCornerRadiusRel
            , out string _BackTransform
            )
        {
            _Text = "";
            _TextAttr = "";
            _TextPosRel = "";
            _TextTransform = "";
            _BackAttr = "";
            _BackPosRel = "";
            _BackCornerRadiusRel = "";
            _BackTransform = "";

            switch (readyMadeID)
            {
                case ReadyMadeFontogram.Fontogram_Logo:
                    _Text = "🎞|A|A";
                    _TextAttr = ";;#999|Courier New;bold;#304f|Courier New;bold;#f01d";
                    _TextPosRel = "100;26;7|70;-16.4;-0.6|70;-12;1";
                    _TextTransform = "-10;1;0.3;60;-20|-15.8;0.9;1.7;-18,17|-15.8;0.9;1.7;-18,17";
                    _BackAttr = ";#7baa;1,0,0,1.5;#cbaa";
                    _BackPosRel = "105;42;28;10";
                    _BackTransform = "-10;1;0.3;60;-20";
                    break;

                case ReadyMadeFontogram.Fontogram_LogoWide:
                    _Text = "";
                    _TextAttr = "";
                    _TextPosRel = "";
                    _TextTransform = "";
                    _BackAttr = "";
                    _BackPosRel = "";
                    _BackCornerRadiusRel = "";
                    _BackTransform = "";
                    break;

                case ReadyMadeFontogram.Sample_RgbSwirl:
                    _Text = "G|R|B";
                    _TextAttr = ";;green|;;red|;;blue";
                    _TextPosRel = "20|20;-12|20;12";
                    _TextTransform = "";
                    _BackAttr = ";#0f0;0,2,4,6;green|;#8f00;0,2,4,6;red|;#500f;0,2,4,6;blue";
                    _BackPosRel = "60;60|60;60|60;60";
                    _BackCornerRadiusRel = "";
                    _BackTransform = "30|0|60";
                    break;

                case ReadyMadeFontogram.Test1:
                    _Text = "";
                    _TextAttr = "";
                    _TextPosRel = "";
                    _TextTransform = "";
                    _BackAttr = "";
                    _BackPosRel = "";
                    _BackCornerRadiusRel = "";
                    _BackTransform = "";
                    break;

                case ReadyMadeFontogram.Test2:
                    _Text = "";
                    _TextAttr = "";
                    _TextPosRel = "";
                    _TextTransform = "";
                    _BackAttr = "";
                    _BackPosRel = "";
                    _BackCornerRadiusRel = "";
                    _BackTransform = "";
                    break;

                default:
                    return false;
            }

            return true;
        }
    }

}
