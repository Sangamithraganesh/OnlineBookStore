using OnlineBookStore.BusinessLgic;
using OnlineBookStore.IBussineLogic;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineBookStore.Controllers
{
    public class BookDetailsController : ApiController
    {
        /// <summary>
        /// Load All Available books details
        /// </summary>
        /// <param name="actiontype">Search type</param>
        /// <param name="author">Author name for Search</param>
        /// <param name="publisher">publisher Name for Search</param>
        /// <returns></returns>
        // GET api/BookDetails
        [HttpGet]
        public IEnumerable<BookStock> GetBookDetails([FromUri] string actiontype, [FromUri]string author, [FromUri]string publisher)
        {
            IBook objBook = new LoadBookDetails();
            return objBook.GetAllBookDetails(actiontype, author, publisher);
        }
       /// <summary>
       /// Add New Book into the DataBase
       /// </summary>
       /// <param name="objNewBook"></param>
       /// <returns></returns>
        [HttpPost]
        public IEnumerable<BookStock> AddNewBook([FromBody]BookStock objNewBook)
        {

            IBook objBook = new LoadBookDetails();
            objBook.AddBookDetails(objNewBook);
            return objBook.GetAllBookDetails("All", "", "");
        }
        /// <summary>
        /// User Login validation 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        [HttpPost]
        public string CheckUser([FromBody]UserDetails objUser)
        {
            if (objUser.UserId.ToLower() == "admin" && objUser.Password.ToLower() == "admin")
                return "admin";
            else
                return "user";
        }

    }
}