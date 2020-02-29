using OnlineBookStore.IBussineLogic;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookStore.BusinessLgic
{
    /// <summary>
    /// Search the Book with related atributes like author and publisher
    /// </summary>
    public class SearchBooks:ISearchBook
    {
        public List<BookStock> Search(List<BookStock> objBS,string author, string publisher)
        {
            var query = objBS;
            if (!String.IsNullOrEmpty(author))
            {
                query = query.Where(s => s.AuthorName.Contains(author)).ToList();
            }

            if (!String.IsNullOrEmpty(publisher))
            {
                query = query.Where(s => s.BookName.Contains(publisher)).ToList();
            }

            return query.ToList();
        }
    }
}