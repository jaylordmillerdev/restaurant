using System.Drawing;
using System.Drawing.Text;

namespace Restaurant.App
{
    public sealed class CustomFont
    {
        private CustomFont() { }
        private static CustomFont Instance = null;

        public static CustomFont Get
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new CustomFont();
                }
                return Instance;
            }
        }
        PrivateFontCollection RegularFontData;
        PrivateFontCollection BoldFontData;
        PrivateFontCollection LightFontData;
        public Font RegularFontLage(int size)
        {
            string path = "../../Utilities/assets/font/Montserrat-Regular.ttf";
            if (RegularFontData == null)
            {
                RegularFontData = new PrivateFontCollection();
                RegularFontData.AddFontFile(path);
            }
            return new Font(RegularFontData.Families[0], size);
        }
        public Font BoldFont(int size)
        {
            string path = "../../Utilities/assets/font/Montserrat-Bold.ttf";
            if (BoldFontData == null)
            {
                BoldFontData = new PrivateFontCollection();
                BoldFontData.AddFontFile(path);
            }
            return new Font(BoldFontData.Families[0], size);
        }
        public Font LightFont(int size)
        {
            string path = "../../Utilities/assets/font/Montserrat-Light.ttf";
            if (LightFontData == null)
            {
                LightFontData = new PrivateFontCollection();
                LightFontData.AddFontFile(path);
            }
            return new Font(LightFontData.Families[0], size);
        }
    }
}
