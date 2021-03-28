using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace appDevexpress.BL
{
    class CLS_book
    {
        public DataTable GET_ALL_book()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_book", null);
            DAL.close();
            return DT;


        }
        public void Add_book(string ISPN, string name, string publisher, string auther, string text_book)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ISPN", SqlDbType.VarChar);
            param[0].Value = ISPN;

            param[1] = new SqlParameter("@name", SqlDbType.VarChar);
            param[1].Value = name;

            param[2] = new SqlParameter("@publisher", SqlDbType.VarChar);
            param[2].Value = publisher;




            param[3] = new SqlParameter("@auther", SqlDbType.VarChar);
            param[3].Value = auther;

            param[4] = new SqlParameter("@text_book", SqlDbType.VarChar);
            param[4].Value = text_book;

            DAL.ExectCommand("Add_book", param);
            DAL.close();
        }

        public DataTable SEARCH_book(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;

            DT = DAL.SelectData("SEARCH_book", param);
            DAL.close();
            return DT;


        }

        public void DELETE_Book(string id)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];



            param[0] = new SqlParameter("@ISPN", SqlDbType.VarChar);
            param[0].Value = id;
            

            DAL.ExectCommand("DELETE_Book", param);
            DAL.close();




        }
        public void UPDATE_Book(string name, string publisher, string auther, string text_book, string id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;

            param[1] = new SqlParameter("@publisher", SqlDbType.VarChar);
            param[1].Value = publisher;


            param[2] = new SqlParameter("@auther", SqlDbType.VarChar);
            param[2].Value = auther;

            param[3] = new SqlParameter("@text_book", SqlDbType.VarChar);
            param[3].Value = text_book;

            param[4] = new SqlParameter("@ISPN", SqlDbType.VarChar);
            param[4].Value = id;


            DAL.ExectCommand("UPDATE_Book", param);
            DAL.close();
        }
    }
}
