using OnlineBookStore.IDataAccess;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Configuration;

namespace OnlineBookStore.DataAccess
{
    public class DataHandler : IDataHandler
    {

        /// <summary>
        /// Load All Available books details if isAvtive=1
        /// </summary>
        /// <param name="actiontype"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <returns></returns>
        public DataTable LoadData(string actiontype, string author, string publisher)
        {
            string qry = "SELECT * FROM tblBooks where IsActie=1";
            if (actiontype.ToLower() != "all")
            {
                if (author != null && author.Length > 0)
                {
                    qry += " and AuthorName like '%" + author + "%'";
                }
                if (publisher != null && publisher.Length > 0)
                {
                    qry += " and BookName like '%" + publisher + "%'";
                }
            }

            string connectionString = ConfigurationManager.ConnectionStrings["BookStallDBContext"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter sqlDA = new SqlDataAdapter(qry, con))
                {
                   
                    sqlDA.Fill(dt);
                }
            }

            return dt;
        }
        /// <summary>
        /// Insert the New Book Details
        /// </summary>
        /// <param name="objBook"></param>
        public void InsertData(BookStock objBook)
        {
            string qry = "Insert into tblBooks(BookName,AuthorName,BookCategory,Edition,Price,IsActie,CreUserId,CreateDate) values('"+ objBook.BookName+"','"+ objBook.AuthorName+"','"+ objBook.BookCategory+"','"
                + objBook.Edition+"',"+ objBook.Price+","+"1,"+"'Ganesh',"+DateTime.Now.ToString("dd/MM/yyyy") + ")";
            string connectionString = ConfigurationManager.ConnectionStrings["BookStallDBContext"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter sqlDA = new SqlDataAdapter(qry, con))
                {
                    sqlDA.InsertCommand = new SqlCommand(qry, con);
                    sqlDA.InsertCommand.ExecuteNonQuery();
                }
            }
           

        }
    }
}