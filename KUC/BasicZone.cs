using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUC
{
    internal class BasicZone
    {
        //Border Color #938BB7
        //BackgroundColor #002FA7
        //Exit Color #950009
        //Status Color #ADA9BB
        //Txt Color #FBF8FF
        private static Color background;
        public static Color Background
        {
            get { return background; }
            internal set { background = value; }
        }

        private static Color border;
        public static Color Border
        {
            get { return border; }
            internal set { border = value; }
        }

        private static Color exit;
        public static Color Exit
        {
            get { return exit; }
            internal set { exit = value; }
        }

        private static Color status;
        public static Color Status
        {
            get { return status; }
            internal set { status = value; }
        }

        private static Color txt;
        public static Color Txt
        {
            get { return txt; }
            internal set { txt = value; }
        }

        public static void Palette(Color color, Color color1, Color color2, Color color3, Color color4)
        {
            background = color;
            border = color1;
            exit = color2;
            status = color3;
            txt = color4;
        }

        public static void Palette_KLB()
        {
            background = ColorTranslator.FromHtml("#002FA7"); ;
            border = ColorTranslator.FromHtml("#938BB7");
            exit = ColorTranslator.FromHtml("#950009");
            status = ColorTranslator.FromHtml("#ADA9BB");
            txt = ColorTranslator.FromHtml("#FBF8FF");
        }

    }
}
