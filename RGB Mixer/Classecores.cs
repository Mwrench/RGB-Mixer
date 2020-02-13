namespace RGB_Mixer
{
    public class ARGB
    {
        private double red;
        private double green;
        private double blue;
        //private double cyan;
        //private double magenta;
        //private double yellow;
        private ARGB(double _red, double _green, double _blue)
        {
            Red = _red;
            Green = _green;
            Blue = _blue;
        }

        public static ARGB ColorRGB_RGBModelo(double _red, double _green, double _blue)
        {
            return new ARGB(_red, _green, _blue);
        }

        //public static ARGB ColorRGB_CMYModelo(double _cyan, double _magenta, double _yellow)
        //{
        //    var _red = 1 - _cyan;
        //    var _green = 1 - _magenta;
        //    var _blue = 1 - _yellow;
        //    return new ARGB(_red, _green, _blue);
        //}

        public double Red
        {
            get { return red; }
            private set { red = red < 0 ? 0 : (red > 1 ? 1 : value); }
        }
        public double Green
        {
            get { return green; }
            private set { green = green < 0 ? 0 : (green > 1 ? 1 : value); }
        }
        public double Blue
        {
            get { return blue; }
            private set { blue = blue < 0 ? 0 : (blue > 1 ? 1 : value); }
        }
        //public double Cyan
        //{
        //    get { return cyan; }
        //    private set { cyan = cyan < 0 ? 0 : (cyan > 1 ? 1 : value); }
        //}
        //public double Magenta
        //{
        //    get { return magenta; }
        //    private set { magenta = magenta < 0 ? 0 : (magenta > 1 ? 1 : value); }
        //}
        //public double Yellow
        //{
        //    get { return yellow; }
        //    private set { yellow = yellow < 0 ? 0 : (yellow > 1 ? 1 : value); }
        //} 
    }
}