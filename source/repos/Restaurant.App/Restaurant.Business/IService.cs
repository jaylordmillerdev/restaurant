using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business
{
    interface IService<T>
    {
        RequestResult Save(T data);
        RequestResult Update(T data);
        RequestResult Delete(int id);
    }
}
