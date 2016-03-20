using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD302_S00144297.DAL
{
    public interface IRepository<T> : IDisposable
    {
        //This is a generic repository that can be used by many classes
        List<T> GetAllItems();
        T GetItemByID(int id);
    }
}