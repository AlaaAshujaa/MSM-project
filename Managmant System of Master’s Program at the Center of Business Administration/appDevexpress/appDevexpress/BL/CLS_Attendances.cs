using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_Attendances
    {
        public DataTable GET_intake_student(int Intake_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@intake_code", SqlDbType.Int);
            param[0].Value = Intake_code;

          

            DT = DAL.SelectData("GET_intake_student",param);
            DAL.close();
            return DT;

        }
        public DataTable GET_ALL_Attendances(int Intake_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@intake_code", SqlDbType.Int);
            param[0].Value = Intake_code;



            DT = DAL.SelectData("GET_ALL_Attendances", param);
            DAL.close();
            return DT;

        }

       

       

        public void ADD_Attendances(string Unique_num, int houre_come, int houre_absence, string date, int Intake_code,int course_code)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[0].Value = Unique_num;

          

            param[1] = new SqlParameter("@houre_come", SqlDbType.Int);
            param[1].Value = houre_come;


            param[2] = new SqlParameter("@houre_absence", SqlDbType.Int);
            param[2].Value = houre_absence;

            param[3] = new SqlParameter("@date", SqlDbType.Date);
            param[3].Value = date;

            param[4] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[4].Value = Intake_code;
            param[5] = new SqlParameter("@course_code", SqlDbType.Int);
            param[5].Value = course_code;

            DAL.ExectCommand("ADD_Attendances", param);
            DAL.close();
        }
        public void UPDATE_Attendances(string Unique_num, int houre_come, int houre_absence, string date, int Intake_code, int course_code,int id)
        {

            
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[0].Value = Unique_num;



            param[1] = new SqlParameter("@houre_come", SqlDbType.Int);
            param[1].Value = houre_come;


            param[2] = new SqlParameter("@houre_absence", SqlDbType.Int);
            param[2].Value = houre_absence;

            param[3] = new SqlParameter("@date", SqlDbType.Date);
            param[3].Value = date;

            param[4] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[4].Value = Intake_code;
            param[5] = new SqlParameter("@course_code", SqlDbType.Int);
            param[5].Value = course_code;
            param[6] = new SqlParameter("@code", SqlDbType.Int);
            param[6].Value = id;

            DAL.ExectCommand("UPDATE_Attendances", param);
            DAL.close();




        }
        public void DELETE_Attendances(int code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@code", SqlDbType.Int);
            param[0].Value = code;

            DAL.ExectCommand("DELETE_Attendances", param);
            DAL.close();


        }
    }
}
