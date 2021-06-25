using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business
{
    interface IDatabaseConnection
    {
        void Connect(string url);
        void Disconnect();
    }
}
