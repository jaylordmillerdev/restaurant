using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.App
{
    public interface IService<T>
    {
        T Service { get; }
    }
}
