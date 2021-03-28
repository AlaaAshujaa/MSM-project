using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_LOGIN
    {
        
              DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

        public DataTable LOGIN(string name, string pass)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            param[1].Value = pass;

            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("check_login", param);
            return DT;

        }


        public string get_priv(string name, string pass)
        {
         
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            para[0].Value = name;

            para[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            para[1].Value = pass;

            DAL.open();
            string re = DAL.SelectData_value("get_priv_login", para);
            
           
           
            return re;

            DataTable DT = new DataTable();

        }


        public DataTable GET_priv_login(string name, string pass)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            param[1].Value = pass;

            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("get_priv_login", param);
            return DT;

        }
    }
}
