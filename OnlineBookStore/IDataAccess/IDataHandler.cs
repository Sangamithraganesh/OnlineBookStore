using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.IDataAccess
{
    interface IDataHandler
    {
        DataTable LoadData(string actiontype, string author, string publisher);
        void InsertData(BookStock objBook);
    }
}
