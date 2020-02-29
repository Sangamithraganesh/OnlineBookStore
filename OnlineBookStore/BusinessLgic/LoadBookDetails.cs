using OnlineBookStore.Common;
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
    public class LoadBookDetails: IBook
    {
        /// <summary>
        /// Loaded the data and send back to client
        /// </summary>
        /// <param name="actiontype"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <returns></returns>
        public List<BookStock> GetAllBookDetails(string actiontype,string author,string publisher)
        {
            DataTable dtBooks = LoadData( actiontype,  author,  publisher);
            List<BookStock> lstBS = new List<BookStock>();
            lstBS = DataFilling(dtBooks);
            return lstBS;
        }
        
       /// <summary>
       /// Collect the data's from DB based on type of search
       /// </summary>
       /// <param name="actiontype"></param>
       /// <param name="author"></param>
       /// <param name="publisher"></param>
       /// <returns></returns>
        private DataTable LoadData(string actiontype, string author, string publisher)
        {
            IDataHandler idh = new DataHandler();
            return idh.LoadData(actiontype, author, publisher);
        }
        /// <summary>
        /// Insert New book details into the DB
        /// </summary>
        /// <param name="objBook"></param>
        public void  AddBookDetails(BookStock objBook)
        {
            IAddBook iAB = new AddBook();
            iAB.AddBookDetails(objBook);
        }
        /// <summary>
        /// it's used for Search the book using some related attributes
        /// </summary>
        /// <param name="objBS"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <returns></returns>
        public List<BookStock> Search(List<BookStock> objBS, string author, string publisher)
        {          
            ISearchBook iSB = new SearchBooks();
            return iSB.Search( objBS,  author,  publisher);
        }
        /// <summary>
        /// Convert the Datas from Datatable to List of BookStock
        /// </summary>
        /// <param name="dtBooks"></param>
        /// <returns></returns>
        private static List<BookStock> DataFilling(DataTable dtBooks)
        {
            List<BookStock> lstBS = new List<BookStock>();
            lstBS = (from DataRow dr in dtBooks.Rows
                     select new BookStock()
                     {
                         BookId = TypeConvertion.ToInt(dr["BookId"].ToString()),
                         BookName = TypeConvertion.ToString(dr["BookName"].ToString()),
                         AuthorName = TypeConvertion.ToString(dr["AuthorName"].ToString()),
                         BookCategory = TypeConvertion.ToString(dr["BookCategory"].ToString()),
                         Edition = TypeConvertion.ToString(dr["Edition"].ToString()),
                         Price = TypeConvertion.ToDouble(dr["Price"].ToString(), 2)
                     }).ToList();
            return lstBS;
        }

    }
}