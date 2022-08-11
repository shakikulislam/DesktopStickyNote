using System.Drawing;

namespace DesktopStickyNote.Theme
{
    public class ThemeColor
    {

        #region Color Variable

        

        // Global Variable
        //======================= Blue ==================================
        private static Color _blue = ColorTranslator.FromHtml("0D6EFD");
        private static Color _blue_100 = ColorTranslator.FromHtml("CFE2FF");
        private static Color _blue_200 = ColorTranslator.FromHtml("9EC5FE");
        private static Color _blue_300 = ColorTranslator.FromHtml("6EA8FE");
        private static Color _blue_400 = ColorTranslator.FromHtml("3D8BFD");
        private static Color _blue_500 = ColorTranslator.FromHtml("0D6EFD");
        private static Color _blue_600 = ColorTranslator.FromHtml("0A58CA");
        private static Color _blue_700 = ColorTranslator.FromHtml("084298");
        private static Color _blue_800 = ColorTranslator.FromHtml("052C65");
        private static Color _blue_900 = ColorTranslator.FromHtml("031633");

        //======================= Purple ==================================
        private static Color _purple = ColorTranslator.FromHtml("6F42C1");
        private static Color _purple_100 = ColorTranslator.FromHtml("E2D9F3");
        private static Color _purple_200 = ColorTranslator.FromHtml("C5B3E6");
        private static Color _purple_300 = ColorTranslator.FromHtml("A98EDA");
        private static Color _purple_400 = ColorTranslator.FromHtml("8C68CD");
        private static Color _purple_500 = ColorTranslator.FromHtml("6F42C1");
        private static Color _purple_600 = ColorTranslator.FromHtml("59359A");
        private static Color _purple_700 = ColorTranslator.FromHtml("432874");
        private static Color _purple_800 = ColorTranslator.FromHtml("2C1A4D");
        private static Color _purple_900 = ColorTranslator.FromHtml("160D27");

        //======================= Pink ==================================
        private static Color _pink = ColorTranslator.FromHtml("D63384");
        private static Color _pink_100 = ColorTranslator.FromHtml("F7D6E6");
        private static Color _pink_200 = ColorTranslator.FromHtml("EFADCE");
        private static Color _pink_300 = ColorTranslator.FromHtml("E685B5");
        private static Color _pink_400 = ColorTranslator.FromHtml("DE5C9D");
        private static Color _pink_500 = ColorTranslator.FromHtml("D63384");
        private static Color _pink_600 = ColorTranslator.FromHtml("AB296A");
        private static Color _pink_700 = ColorTranslator.FromHtml("801F4F");
        private static Color _pink_800 = ColorTranslator.FromHtml("561435");
        private static Color _pink_900 = ColorTranslator.FromHtml("2B0A1A");

        //======================= Red ==================================
        private static Color _red = ColorTranslator.FromHtml("DC3545");
        private static Color _red_100 = ColorTranslator.FromHtml("F8D7DA");
        private static Color _red_200 = ColorTranslator.FromHtml("F1AEB5");
        private static Color _red_300 = ColorTranslator.FromHtml("EA868F");
        private static Color _red_400 = ColorTranslator.FromHtml("E35D6A");
        private static Color _red_500 = ColorTranslator.FromHtml("DC3545");
        private static Color _red_600 = ColorTranslator.FromHtml("B02A37");
        private static Color _red_700 = ColorTranslator.FromHtml("842029");
        private static Color _red_800 = ColorTranslator.FromHtml("58151C");
        private static Color _red_900 = ColorTranslator.FromHtml("2C0B0E");

        //======================= Orange ==================================
        private static Color _orange = ColorTranslator.FromHtml("FD7E14");
        private static Color _orange_100 = ColorTranslator.FromHtml("FFE5D0");
        private static Color _orange_200 = ColorTranslator.FromHtml("FECBA1");
        private static Color _orange_300 = ColorTranslator.FromHtml("FEB272");
        private static Color _orange_400 = ColorTranslator.FromHtml("FD9843");
        private static Color _orange_500 = ColorTranslator.FromHtml("FD7E14");
        private static Color _orange_600 = ColorTranslator.FromHtml("CA6510");
        private static Color _orange_700 = ColorTranslator.FromHtml("984C0C");
        private static Color _orange_800 = ColorTranslator.FromHtml("653208");
        private static Color _orange_900 = ColorTranslator.FromHtml("331904");

        //======================= Yellow ==================================
        private static Color _yellow = ColorTranslator.FromHtml("FFC107");
        private static Color _yellow_100 = ColorTranslator.FromHtml("FFF3CD");
        private static Color _yellow_200 = ColorTranslator.FromHtml("FFE69C");
        private static Color _yellow_300 = ColorTranslator.FromHtml("FFDA6A");
        private static Color _yellow_400 = ColorTranslator.FromHtml("FFCD39");
        private static Color _yellow_500 = ColorTranslator.FromHtml("FFC107");
        private static Color _yellow_600 = ColorTranslator.FromHtml("CC9A06");
        private static Color _yellow_700 = ColorTranslator.FromHtml("997404");
        private static Color _yellow_800 = ColorTranslator.FromHtml("664D03");
        private static Color _yellow_900 = ColorTranslator.FromHtml("332701");

        //======================= Green ==================================
        private static Color _green = ColorTranslator.FromHtml("198754");
        private static Color _green_100 = ColorTranslator.FromHtml("D1E7DD");
        private static Color _green_200 = ColorTranslator.FromHtml("A3CFBB");
        private static Color _green_300 = ColorTranslator.FromHtml("75B798");
        private static Color _green_400 = ColorTranslator.FromHtml("479F76");
        private static Color _green_500 = ColorTranslator.FromHtml("198754");
        private static Color _green_600 = ColorTranslator.FromHtml("146C43");
        private static Color _green_700 = ColorTranslator.FromHtml("0F5132");
        private static Color _green_800 = ColorTranslator.FromHtml("0A3622");
        private static Color _green_900 = ColorTranslator.FromHtml("051B11");

        //======================= Cyan ==================================
        private static Color _cyan = ColorTranslator.FromHtml("0DCAF0");
        private static Color _cyan_100 = ColorTranslator.FromHtml("CFF4FC");
        private static Color _cyan_200 = ColorTranslator.FromHtml("9EEAF9");
        private static Color _cyan_300 = ColorTranslator.FromHtml("6EDFF6");
        private static Color _cyan_400 = ColorTranslator.FromHtml("3DD5F3");
        private static Color _cyan_500 = ColorTranslator.FromHtml("0DCAF0");
        private static Color _cyan_600 = ColorTranslator.FromHtml("0AA2C0");
        private static Color _cyan_700 = ColorTranslator.FromHtml("087990");
        private static Color _cyan_800 = ColorTranslator.FromHtml("055160");
        private static Color _cyan_900 = ColorTranslator.FromHtml("032830");

        //======================= Gray ==================================
        private static Color _gray = ColorTranslator.FromHtml("ADB5BD");
        private static Color _gray_100 = ColorTranslator.FromHtml("F8F9FA");
        private static Color _gray_200 = ColorTranslator.FromHtml("E9ECEF");
        private static Color _gray_300 = ColorTranslator.FromHtml("DEE2E6");
        private static Color _gray_400 = ColorTranslator.FromHtml("CED4DA");
        private static Color _gray_500 = ColorTranslator.FromHtml("ADB5BD");
        private static Color _gray_600 = ColorTranslator.FromHtml("6C757D");
        private static Color _gray_700 = ColorTranslator.FromHtml("495057");
        private static Color _gray_800 = ColorTranslator.FromHtml("343A40");
        private static Color _gray_900 = ColorTranslator.FromHtml("212529");


        ////======================= new ==================================
        //private static Color _new = ColorTranslator.FromHtml("000");
        //private static Color _new_100 = ColorTranslator.FromHtml("000");
        //private static Color _new_200 = ColorTranslator.FromHtml("000");
        //private static Color _new_300 = ColorTranslator.FromHtml("000");
        //private static Color _new_400 = ColorTranslator.FromHtml("000");
        //private static Color _new_500 = ColorTranslator.FromHtml("000");
        //private static Color _new_600 = ColorTranslator.FromHtml("000");
        //private static Color _new_700 = ColorTranslator.FromHtml("000");
        //private static Color _new_800 = ColorTranslator.FromHtml("000");
        //private static Color _new_900 = ColorTranslator.FromHtml("000");


        #endregion

        // Property

        //======================= Blue ==================================
        public static Color Blue { get { return _blue;}}
        public static Color Blue100 { get { return _blue_100; } }
        public static Color Blue200 { get { return _blue_200; } }
        public static Color Blue300 { get { return _blue_300; } }
        public static Color Blue400 { get { return _blue_400; } }
        public static Color Blue500 { get { return _blue_500; } }
        public static Color Blue600 { get { return _blue_600; } }
        public static Color Blue700 { get { return _blue_700; } }
        public static Color Blue800 { get { return _blue_800; } }
        public static Color Blue900 { get { return _blue_900; } }

        //======================= Purple ==================================
        public static Color Purple { get { return _purple;}}
        public static Color Purple100 { get { return _purple_100; } }
        public static Color Purple200 { get { return _purple_200; } }
        public static Color Purple300 { get { return _purple_300; } }
        public static Color Purple400 { get { return _purple_400; } }
        public static Color Purple500 { get { return _purple_500; } }
        public static Color Purple600 { get { return _purple_600; } }
        public static Color Purple700 { get { return _purple_700; } }
        public static Color Purple800 { get { return _purple_800; } }
        public static Color Purple900 { get { return _purple_900; } }

        //======================= Pink ==================================
        public static Color Pink { get { return _pink;}}
        public static Color Pink100 { get { return _pink_100; } }
        public static Color Pink200 { get { return _pink_200; } }
        public static Color Pink300 { get { return _pink_300; } }
        public static Color Pink400 { get { return _pink_400; } }
        public static Color Pink500 { get { return _pink_500; } }
        public static Color Pink600 { get { return _pink_600; } }
        public static Color Pink700 { get { return _pink_700; } }
        public static Color Pink800 { get { return _pink_800; } }
        public static Color Pink900 { get { return _pink_900; } }

        //======================= Red ==================================
        public static Color Red { get { return _red;}}
        public static Color Red100 { get { return _red_100; } }
        public static Color Red200 { get { return _red_200; } }
        public static Color Red300 { get { return _red_300; } }
        public static Color Red400 { get { return _red_400; } }
        public static Color Red500 { get { return _red_500; } }
        public static Color Red600 { get { return _red_600; } }
        public static Color Red700 { get { return _red_700; } }
        public static Color Red800 { get { return _red_800; } }
        public static Color Red900 { get { return _red_900; } }

        //======================= Orange ==================================
        public static Color Orange { get { return _orange;}}
        public static Color Orange100 { get { return _orange_100; } }
        public static Color Orange200 { get { return _orange_200; } }
        public static Color Orange300 { get { return _orange_300; } }
        public static Color Orange400 { get { return _orange_400; } }
        public static Color Orange500 { get { return _orange_500; } }
        public static Color Orange600 { get { return _orange_600; } }
        public static Color Orange700 { get { return _orange_700; } }
        public static Color Orange800 { get { return _orange_800; } }
        public static Color Orange900 { get { return _orange_900; } }

        //======================= Yellow ==================================
        public static Color Yellow { get { return _yellow;}}
        public static Color Yellow100 { get { return _yellow_100; } }
        public static Color Yellow200 { get { return _yellow_200; } }
        public static Color Yellow300 { get { return _yellow_300; } }
        public static Color Yellow400 { get { return _yellow_400; } }
        public static Color Yellow500 { get { return _yellow_500; } }
        public static Color Yellow600 { get { return _yellow_600; } }
        public static Color Yellow700 { get { return _yellow_700; } }
        public static Color Yellow800 { get { return _yellow_800; } }
        public static Color Yellow900 { get { return _yellow_900; } }

        //======================= Green ==================================
        public static Color Green { get { return _green;}}
        public static Color Green100 { get { return _green_100; } }
        public static Color Green200 { get { return _green_200; } }
        public static Color Green300 { get { return _green_300; } }
        public static Color Green400 { get { return _green_400; } }
        public static Color Green500 { get { return _green_500; } }
        public static Color Green600 { get { return _green_600; } }
        public static Color Green700 { get { return _green_700; } }
        public static Color Green800 { get { return _green_800; } }
        public static Color Green900 { get { return _green_900; } }

        //======================= Cyan ==================================
        public static Color Cyan { get { return _cyan;}}
        public static Color Cyan100 { get { return _cyan_100; } }
        public static Color Cyan200 { get { return _cyan_200; } }
        public static Color Cyan300 { get { return _cyan_300; } }
        public static Color Cyan400 { get { return _cyan_400; } }
        public static Color Cyan500 { get { return _cyan_500; } }
        public static Color Cyan600 { get { return _cyan_600; } }
        public static Color Cyan700 { get { return _cyan_700; } }
        public static Color Cyan800 { get { return _cyan_800; } }
        public static Color Cyan900 { get { return _cyan_900; } }

        //======================= Gray ==================================
        public static Color Gray { get { return _gray;}}
        public static Color Gray100 { get { return _gray_100; } }
        public static Color Gray200 { get { return _gray_200; } }
        public static Color Gray300 { get { return _gray_300; } }
        public static Color Gray400 { get { return _gray_400; } }
        public static Color Gray500 { get { return _gray_500; } }
        public static Color Gray600 { get { return _gray_600; } }
        public static Color Gray700 { get { return _gray_700; } }
        public static Color Gray800 { get { return _gray_800; } }
        public static Color Gray900 { get { return _gray_900; } }


    }
}
