using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_Grade_Discussant
    {
        public DataTable Get_All_Grade_Discussant()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_All_Grade_Discussant", null);
            DAL.close();
            return DT;


        }
       
              public DataTable    Get_Registered_stud()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Registered_stud", null);
            DAL.close();
            return DT;


        }


        public void ADD_Grade_Discussant(string Unique_num, decimal grade_disc_Supervisor, decimal grade_disc_internal, decimal grade_disc_external)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[0].Value = Unique_num;

            param[1] = new SqlParameter("@grade_disc_Supervisor", SqlDbType.Decimal);
            param[1].Value = grade_disc_Supervisor;

            param[2] = new SqlParameter("@grade_disc_internal", SqlDbType.Decimal);
            param[2].Value = grade_disc_internal;


            param[3] = new SqlParameter("@grade_disc_external", SqlDbType.Decimal);
            param[3].Value = grade_disc_external;



            DAL.ExectCommand("ADD_Grade_Discussant", param);
            DAL.close();
        }

        public void UPDATE_Grade_Discussant(string Unique_num, decimal grade_disc_Supervisor, decimal grade_disc_internal, decimal grade_disc_external ,int id)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[0].Value = Unique_num;

            param[1] = new SqlParameter("@grade_disc_Supervisor", SqlDbType.Decimal);
            param[1].Value = grade_disc_Supervisor;

            param[2] = new SqlParameter("@grade_disc_internal", SqlDbType.Decimal);
            param[2].Value = grade_disc_internal;


            param[3] = new SqlParameter("@grade_disc_external", SqlDbType.Decimal);
            param[3].Value = grade_disc_external;

            param[4] = new SqlParameter("@code", SqlDbType.Decimal);
            param[4].Value = id;

            DAL.ExectCommand("UPDATE_Grade_Discussant", param);
            DAL.close();




        }
        public void DELETE_Grade_Discussant(int code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@code", SqlDbType.Int);
            param[0].Value = code;

            DAL.ExectCommand("DELETE_Grade_Discussant", param);
            DAL.close();


        }


    }
}
