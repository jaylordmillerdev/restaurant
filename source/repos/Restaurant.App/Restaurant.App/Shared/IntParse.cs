using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.App.Shared
{
    public static class IntParse
    {
        public static int Parse(string item, int defaultValue)
        {
            int output = 0;
            return Int32.TryParse(item, out output) ? output:defaultValue;
        }
    }
}
