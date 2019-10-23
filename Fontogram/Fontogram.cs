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
            , out string _BackBorderNumbersRel
            , out string _BackTransform
            )
        {
            _Text = "";
            _TextAttr = "";
            _TextPosRel = "";
            _TextTransform = "";
            _BackAttr = "";
            _BackPosRel = "";
            _BackBorderNumbersRel = "";
            _BackTransform = "";

            switch (readyMadeID)
            {
                case ReadyMadeFontogram.Fontogram_Logo:
                    _Text = "🎞|A|A";
                    _TextAttr = ";;#999|Courier New;bold;#304f|Courier New;bold;#f01d";
                    _TextPosRel = "100;26;7|70;-16.4;-0.6|70;-12;1";
                    _TextTransform = "-10;1;0.3;60;-20|-15.8;0.9;1.7;-18,17|-15.8;0.9;1.7;-18,17";
                    _BackAttr = ";#7baa;#cbaa";
                    _BackPosRel = "105;42;28;10";
                    _BackBorderNumbersRel = "1,0,0,1.5";
                    _BackTransform = "-10;1;0.3;60;-20";
                    break;

                case ReadyMadeFontogram.Fontogram_LogoWide:
                    _Text = "🎞|Abc|Abc";
                    _TextAttr = ";;#d999|Courier New;bold;#304f|Courier New;bold;#e04f";
                    _TextPosRel = "100;58;-15|70;-16;-5|70;-13;-4";
                    _TextTransform = "-10;2;0.5;60;-20|-13.1;0.8;1.62;-8|-13.1;0.8;1.62;-8";
                    _BackAttr = ";#6baa;#cbaa";
                    _BackPosRel = "90;42;47;2";
                    _BackBorderNumbersRel = "0.5,0,0,0.7;8";
                    _BackTransform = "-10;2;0.5;60;-20";
                    break;

                case ReadyMadeFontogram.Sample_RgbSwirl:
                    _Text = "G|R|B";
                    _TextAttr = "arial;bold;green|arial;bold;red|arial;bold;blue";
                    _TextPosRel = "16;1;43|16;23;36.5|16;-20;38.5";
                    _TextTransform = "30|0|60";
                    _BackAttr = ";#0f0;green|;#8f00;red|;#500f;blue";
                    _BackPosRel = "60;60|60;60|60;60";
                    _BackBorderNumbersRel = "0.3,1.7,3.2,5;6|0.3,1.7,3.2,5;6|0.3,1.7,3.2,5;6";
                    _BackTransform = "30|0|60";
                    break;

                case ReadyMadeFontogram.Test1:
                    _Text = "";
                    _TextAttr = "";
                    _TextPosRel = "";
                    _TextTransform = "";
                    _BackAttr = "";
                    _BackPosRel = "";
                    _BackBorderNumbersRel = "";
                    _BackTransform = "";
                    break;

                case ReadyMadeFontogram.Test2:
                    _Text = "";
                    _TextAttr = "";
                    _TextPosRel = "";
                    _TextTransform = "";
                    _BackAttr = "";
                    _BackPosRel = "";
                    _BackBorderNumbersRel = "";
                    _BackTransform = "";
                    break;

                default:
                    return false;
            }

            return true;
        }
    }

}
