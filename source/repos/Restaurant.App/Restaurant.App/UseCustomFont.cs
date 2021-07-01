using System.Drawing;
using System.Drawing.Text;

namespace Restaurant.App
{
    public class UseCustomFont
    {
        public Font RegularFont(int size)
        {
            string path = "../../assets/font/Montserrat-Regular.ttf";
            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile(path);
            return new Font(modernFont.Families[0], size);
        }
        public Font BoldFont(int size)
        {
            string path = "../../assets/font/Montserrat-Bold.ttf";
            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile(path);
            return new Font(modernFont.Families[0], size);
        }
        public Font LightFont(int size)
        {
            string path = "../../assets/font/Montserrat-Light.ttf";
            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile(path);
            return new Font(modernFont.Families[0], size);
        }
    }
}
