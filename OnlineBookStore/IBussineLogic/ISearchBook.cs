using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.IBussineLogic
{
    interface ISearchBook
    {
        List<BookStock> Search(List<BookStock> objBS, string author, string publisher);
    }
}
