using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_Program
    {
     
        public DataTable GET_ALL_Program()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Program", null);
            DAL.close();
            return DT;


        }

        public DataTable SEARCH_Program(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;
            DT = DAL.SelectData("SEARCH_Program", param);
            DAL.close();
            return DT;


        }
        public void ADD_Program(string name, string type)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value =name;

            param[1] = new SqlParameter("@type", SqlDbType.VarChar);
            param[1].Value = type;

            DAL.ExectCommand("Add_Program", param);
            DAL.close();
        }

        public void UPDATE_Program(string name, string type, int program_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[1].Value = type;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = program_code;

            DAL.ExectCommand("UPDATE_Program", param);
            DAL.close();




        }

        public void DELETE_Program( int program_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = program_code;


            DAL.ExectCommand("DELETE_Program", param);
            DAL.close();




        }
    }
}
