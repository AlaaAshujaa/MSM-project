using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_USERS
    {
        public DataTable GET_ALL_USER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_USER", null);
            DAL.close();
            return DT;


        }
        public DataTable GET_ALL_Priv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Priv", null);
            DAL.close();
            return DT;


        }

       
        public DataTable SEARCH_USER(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.NVarChar, 50);
            param[0].Value = USE;
            DT = DAL.SelectData("SEARCH_USER", param);
            DAL.close();
            return DT;


        }
        public void ADD_USERS(string user_name, string password, int priv_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar);
            param[0].Value = user_name;



            param[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            param[1].Value = password;

            param[2] = new SqlParameter("@priv_code", SqlDbType.NVarChar);
            param[2].Value = priv_code;

            DAL.ExectCommand("Add_USER", param);
            DAL.close();
        }

        public void UPDATE_USERS(string user_name, string password, int priv_code, int id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar);
            param[0].Value = user_name;



            param[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            param[1].Value = password;

            param[2] = new SqlParameter("@priv_code", SqlDbType.Int);
            param[2].Value = priv_code;


            param[3] = new SqlParameter("@user_code", SqlDbType.Int);
            param[3].Value = id;

            DAL.ExectCommand("UPDATE_USERS", param);
            DAL.close();




        }

        public void DELETE_USERS(int id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
        

            param[0] = new SqlParameter("@user_code", SqlDbType.Int);
            param[0].Value = id;


            DAL.ExectCommand("DELETE_USERS", param);
            DAL.close();




        }
       
       
    }
}
