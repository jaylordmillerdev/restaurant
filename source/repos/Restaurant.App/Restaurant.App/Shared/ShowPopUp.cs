using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant.App.Shared
{
    public class ShowPopUp
    {
        string _Message = string.Empty;
        public ShowPopUp(string title, Dictionary<string, string> messageData)
        {
            foreach (KeyValuePair<string, string> entry in messageData)
            {
                _Message += $"{entry.Key}: {entry.Value} \n";
            }
            MessageBox.Show(_Message, title);
        }
    }
}
