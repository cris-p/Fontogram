using System;
using System.Collections.Generic;
using System.Windows;

namespace PergleLabs.UI
{

    public partial class Fontogram
    {

        // For each type of ready-made Fontogram, must set each property as a '|'-separated list of layers,
        // each layer being a list of ';'-separated values of the component attributes.
        // Some attributes' values can be lists of ','-separated values.


        void Create__Fontogram_Logo(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "🎞|A|A";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = ";;#999|Courier New;bold;#304f|Courier New;bold;#f01d";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = "100;26;7|70;-16.4;-0.6|70;-12;1";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = "-10;1;0.3;60;-20|-15.8;0.9;1.7;-18,17|-15.8;0.9;1.7;-18,17";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = ";#7baa;#cbaa";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = "105;42;28;10";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = "1,0,0,1.5";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = "-10;1;0.3;60;-20";

        }

        void Create__Fontogram_LogoWide(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "🎞|Abc|Abc";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = ";;#d999|Courier New;bold;#304f|Courier New;bold;#e04f";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = "100;58;-15|70;-16;-5|70;-13;-4";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = "-10;2;0.5;60;-20|-13.1;0.8;1.62;-8|-13.1;0.8;1.62;-8";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = ";#6baa;#cbaa";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = "90;42;47;2";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = "0.5,0,0,0.7;8";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = "-10;2;0.5;60;-20";

        }

        void Create__Fontogrammer_Logo(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "🎞|F";
            _TextAttr = ";;#555|Impact;;red";
            _TextPosRel = "134;8.5;49|;-1";
            _TextTransform = "90;;1.4";
        }

        void Create__DocState_OK(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "📄|✔";
            _TextAttr = ";;#a6a|;;#0b0";
            _TextPosRel = "89;-6;-5.5|60;18;16";
            _TextTransform = "|";
            _BackAttr = ";white;|";
            _BackPosRel = "76;92;-6;1|";
            _BackBorderNumbersRel = ";0,15,0,0|";
            _BackTransform = "|";
        }

        void Create__DocState_Missing(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "📄|❌";
            _TextAttr = ";;#bbb|;;#d33";
            _TextPosRel = "89;-6;-5.5|60;23;16";
            _TextTransform = "|";
            _BackAttr = ";white;|";
            _BackPosRel = "76;92;-6;1|";
            _BackBorderNumbersRel = ";0,15,0,0|";
            _BackTransform = "|";
        }

        void Create__DocState_Unknown(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "📄|❓";
            _TextAttr = ";;#bbb|;;#f60";
            _TextPosRel = "89;-6;-5.5|72;24;5";
            _TextTransform = "|";
            _BackAttr = ";white;|";
            _BackPosRel = "76;92;-6;1|";
            _BackBorderNumbersRel = ";0,15,0,0|";
            _BackTransform = "|";
        }

        void Create__DocState_Waiting(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "📄|⏳";
            _TextAttr = ";;#c9c|;;#05a";
            _TextPosRel = "89;-6;-5.5|66;24;3";
            _TextTransform = "|";
            _BackAttr = ";white;|";
            _BackPosRel = "76;92;-6;1|";
            _BackBorderNumbersRel = ";0,15,0,0|";
            _BackTransform = "|";
        }

        void Create__DocState_NoAccess(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "📄|🚫";
            _TextAttr = ";;#555|;bold;red";
            _TextPosRel = "89;-6;-5.5|60;19;10";
            _TextTransform = "|";
            _BackAttr = ";white;|";
            _BackPosRel = "76;92;-6;1|";
            _BackBorderNumbersRel = ";0,15,0,0|";
            _BackTransform = "|";
        }

        void Create__DocState_FolderNotFound(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "📁|🔍";
            _TextAttr = ";;red|;bold;";
            _TextPosRel = "89;;-10|60;14;12";
            _TextTransform = "|";
            _BackAttr = ";white;|";
            _BackPosRel = "81;54.4;-2;1|";
            _BackBorderNumbersRel = ";0,0,30,0|";
            _BackTransform = "|";
        }

        void Create__Sample_RgbSwirl(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {

            // " Text_L0 | ...(Layer1) | ...(Layer2) | ... "
            _Text = "G|R|B";

            // " TextFont_L0;TextFontWeight_L0;TextColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextAttr = "arial;bold;green|arial;bold;red|arial;bold;blue";

            // " TextFontSize_L0;TextShiftX_L0;TextShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextPosRel = "16;1;43|16;23;36.5|16;-20;38.5";

            // " TextRotAngle_L0;TextScaleX_L0;TextScaleY_L0;TextSkewX_L0;TextSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _TextTransform = "30|0|60";

            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = ";#0f0;green|;#8f00;red|;#500f;blue";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = "60;60|60;60|60;60";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = "0.3,1.7,3.2,5;6|0.3,1.7,3.2,5;6|0.3,1.7,3.2,5;6";

            // " BackRotAngle_L0;BackScaleX_L0;BackScaleY_L0;BackSkewX_L0;BackSkewY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackTransform = "30|0|60";

        }

        void Create__Sample_TopHatSmiley(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "😉||☝||🎩";
            _TextAttr = ";;#c00||;;#aaa";
            _TextPosRel = "55;17;15||47;-32;18||40;8;-30";
            _TextTransform = "-15||||;1.6";
            _BackAttr = ";#fd0|;white|;white|;#444|;black|;darkorange";
            _BackPosRel = "56;56;18;18|26;33;-32;29|8;30;-22;10|12;41;-3;-28|48;7.5;7;-16.3|54.5;9;8;-20";
            _BackBorderNumbersRel = ";30|;9,0,0,17||;0|;0|;0";
            _BackTransform = "";
        }

        void Create__Sample_TallHatSmiley(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "😉|||☝||🎩";
            _TextAttr = ";;#800|||;;#aaa";
            _TextPosRel = "40;10;21|||34;-22;22||42;4;-23.5";
            _TextTransform = "-15|||||0;1;1.1";
            _BackAttr = ";#fa0|;transparent;#fa0|;white|;white|;#444|;#06f";
            _BackPosRel = "41;41;11;23.5|45.5;45.5;10.5;23.3|21;27;-22;30|6;20;-15;15|8;48;-3.5;-21|30;7.5;4;-8";
            _BackBorderNumbersRel = ";30|4;23|;10,0,0,16||;0|;0";
            _BackTransform = "";
        }

        void Create__Sample_GoogleChromeLogo(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _BackAttr = ";#14a361|;#de4e41|;#ffcf42|;#14a361|;#4b8cf5;white|;;white";
            _BackPosRel = "|80;80;5.8;-24|50;74;25;14|20;47;1.5;24.5|45.7;45.7|150;150";
            _BackBorderNumbersRel = "|;0,0,22,0|;0|;0|4.6;25|25;100";
            _BackTransform = "|60||27";
        }

        void Create__Sample_ABClogo(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _BackAttr = ";black;|;;white|;white;|;;white|;white;|;;white|;black;";
            _BackPosRel = "|31.5;31.5;-33;|8;15.75;-21.25;7.875|31.5;31.5;;|8;26;-11.75;-13|31.5;31.5;33;|10;7;44;";
            _BackBorderNumbersRel = ";50|8;16|;0|8;16|;0|8;16|;0";
        }

        void Create__Sample_BBClogo(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "B|B|C";
            _TextAttr = "gill sans mt;;white|gill sans mt;;white|gill sans mt;;white";
            _TextPosRel = "32;-35.5;|32;-0.5;|32;34;";
            _BackAttr = ";black;|;black;|;black;";
            _BackPosRel = "30;30;-35;|30;30;;|30;30;35;";
            _BackBorderNumbersRel = ";0|;0|;0";
        }

        void Create__Sample_CBClogo(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            // " BackOpacity_L0;BackFillColor_L0;BackStrokeColor_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackAttr = " 1;white | 1;#e60505 | 1;#e60505 | 1;#e60505 | 1;#e60505 | 1;#e60505 | 1;white | 1;white | 1;#e60505 | 1;#e60505 | 1;#e60505 | 1;#e60505 | 1;white | 1;#e60505";

            // " BackWidth_L0;BackHeight_L0;BackShiftX_L0;BackShiftY_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackPosRel = " | 36;36;-31 | 36;36;;-31 | 36;36;31 | 36;36;;31 | 75;75 | 82;41 | 41;82 | 36;36;-21 | 36;36;;-21 | 36;36;21 | 36;36;;21 | 41;41 | 36;36";

            // " BackStrokeThickness_L0;BackCornerRadius_L0 | ...(Layer1) | ...(Layer2) | ... "
            _BackBorderNumbersRel = " ;0 | ;18 | ;18 | ;18 | ;18 | ;17 | ;0 | ;0 | ;18 | ;18 | ;18 | ;18 | ;0 | ;18";
        }

        void Create__Sample_VideoFaceSearch(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text =                 "🎞" +     "|😐" +    "|." +      "|🔍";
            _TextAttr =             ";;#888     |;bold;black|;;#4fff    |;bold;#800";
            _TextPosRel =           "130;4;-1   |32;-6;26   |245;16;-118|62;14;-17";
            _TextTransform =        "90;1;0.76  |           |0;;;-10    |";
            _BackAttr =             ";orange    |;;white    |;#b5ae    |;#fad";
            _BackPosRel =           "32;32;-6;28|120;128;-4 |40;40;3;-25|15;30;28;2";
            _BackBorderNumbersRel = ";20        |14;0       |;30        |;0";
            _BackTransform =        "           |           |           |-45";
        }

        void Create__Sample_HoodedSmiley(ref string _Text, ref string _TextAttr, ref string _TextPosRel, ref string _TextTransform, ref string _BackAttr, ref string _BackPosRel, ref string _BackBorderNumbersRel, ref string _BackTransform)
        {
            _Text = "|🙂";
            _TextAttr = "|;;silver";
            _TextPosRel = "|42;-6.3;-12";
            _TextTransform = "|;0.66;;;10";
            _BackAttr = ";whitesmoke;gainsboro|;whitesmoke;gainsboro";
            _BackPosRel = "80;40;;25|50;50;3;-10";
            _BackBorderNumbersRel = "2.5,2.5,2.5,0;22,22,0,0|2.5,2.5,20,0;20,29,27,25";
        }

    }
}
