using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.IBussineLogic
{
    interface IBook:IAddBook,ISearchBook
    {
        List<BookStock> GetAllBookDetails(string actiontype, string author, string publisher);
    }
}
