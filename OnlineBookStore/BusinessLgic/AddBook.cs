using OnlineBookStore.DataAccess;
using OnlineBookStore.IBussineLogic;
using OnlineBookStore.IDataAccess;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OnlineBookStore.BusinessLgic
{
    public class AddBook:IAddBook
    {
        /// <summary>
        /// Implement the IAddBook Interface
        /// </summary>
        /// <param name="objBook"></param>
        public void AddBookDetails(BookStock objBook)
        {
            IDataHandler idh = new DataHandler();
             idh.InsertData(objBook);
        }
    }
}