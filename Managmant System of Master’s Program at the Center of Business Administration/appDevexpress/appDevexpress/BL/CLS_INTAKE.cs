using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_INTAKE
    {
        public DataTable GET_ALL_intake()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_intake", null);
            DAL.close();
            return DT;


        }

        public DataTable SEARCH_Intake(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;
            DT = DAL.SelectData("SEARCH_Intake", param);
            DAL.close();
            return DT;


        }
        public void ADD_intake(string name, int num, string year)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;

            param[1] = new SqlParameter("@num", SqlDbType.Int);
            param[1].Value = num;

            param[2] = new SqlParameter("@year", SqlDbType.Date);
            param[2].Value = year;



            DAL.ExectCommand("Add_intake", param);
            DAL.close();
        }

        public void UPDATE_intake(string name, int num, string year, int Intake_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;

            param[1] = new SqlParameter("@num", SqlDbType.Int);
            param[1].Value = num;

            param[2] = new SqlParameter("@year", SqlDbType.Date);
            param[2].Value = year;


            param[3] = new SqlParameter("@id", SqlDbType.Int);
            param[3].Value = Intake_code;

            DAL.ExectCommand("UPDATE_intake", param);
            DAL.close();




        }

        public void DELETE_intake(string name, int num, string year, int Intake_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;

            param[1] = new SqlParameter("@num", SqlDbType.Int);
            param[1].Value = num;

            param[2] = new SqlParameter("@year", SqlDbType.Date);
            param[2].Value = year;


            param[3] = new SqlParameter("@id", SqlDbType.Int);
            param[3].Value = Intake_code;


            DAL.ExectCommand("DELETE_intake", param);
            DAL.close();




        }
    }
}
