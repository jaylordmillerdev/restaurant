using System.Drawing;

namespace Restaurant.App
{
    public sealed class CONFIG
    {
        private CONFIG() { }
        private static CONFIG instance = null;

        public static CONFIG Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CONFIG();
                }
                return instance;
            }
        }

        public string APP_DESCRIPTION = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam rhoncus ac quam ac suscipit.";

        public Color MAIN_COLOR = ColorTranslator.FromHtml("#294c7d");

        public Color MAIN_COLOR_DARK = ColorTranslator.FromHtml("#213d63");
    }
}
