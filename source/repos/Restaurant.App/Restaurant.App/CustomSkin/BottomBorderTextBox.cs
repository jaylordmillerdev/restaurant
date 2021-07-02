using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.CustomSkin
{
    public class BottomBorderTextBox : TextBox
    {
        public BottomBorderTextBox()
        {
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            AutoSize = false; //Allows you to change height to have bottom padding
            Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
        }
    }

}
