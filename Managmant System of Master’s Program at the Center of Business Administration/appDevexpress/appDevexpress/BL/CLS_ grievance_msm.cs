using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appDevexpress.BL
{
    class CLS__grievance_msm
    {
        public DataTable GET_intake_student(int Intake_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@intake_code", SqlDbType.Int);
            param[0].Value = Intake_code;



            DT = DAL.SelectData("GET_intake_student", param);
            DAL.close();
            return DT;

        }
        public DataTable GET_All_grievance_msm(int Intake_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@intake_code", SqlDbType.Int);
            param[0].Value = Intake_code;



            DT = DAL.SelectData("GET_All_grievance_msm", param);
            DAL.close();
            return DT;

        }
        public void UPDATE_grievance_msm(string accepted, int id)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@accepted", SqlDbType.VarChar);
            param[0].Value = accepted;


            param[1] = new SqlParameter("@code", SqlDbType.Int);
            param[1].Value = id;

            DAL.ExectCommand("UPDATE_grievance_msm", param);
            DAL.close();




        }
    }
}
