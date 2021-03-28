using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appDevexpress.BL
{
    class CLS_Grade
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
        public DataTable GET_ALL_grade(int Intake_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@intake_code", SqlDbType.Int);
            param[0].Value = Intake_code;



            DT = DAL.SelectData("GET_ALL_grade", param);
            DAL.close();
            return DT;

        }





        public void Add_Grade(int course_code, int Intake_code, string Unique_num, decimal Assignment, decimal final_Exam, decimal Total_grade, string year)
        {
             


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];


            param[0] = new SqlParameter("@course_code", SqlDbType.Int);
            param[0].Value = course_code;

            param[1] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[1].Value = Intake_code;

            param[2] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[2].Value = Unique_num;


            param[3] = new SqlParameter("@Assignment", SqlDbType.Decimal);
            param[3].Value = Assignment;


            param[4] = new SqlParameter("@final_Exam", SqlDbType.Decimal);
            param[4].Value = final_Exam;

            param[5] = new SqlParameter("@Total_grade", SqlDbType.Decimal);
            param[5].Value = Total_grade;

            param[6] = new SqlParameter("@year", SqlDbType.Date);
            param[6].Value = year;



            DAL.ExectCommand("Add_Grade", param);
            DAL.close();
        }
        public void UPDATE_Garde(int course_code, int Intake_code, string Unique_num, decimal Assignment, decimal final_Exam, decimal Total_grade, string year,int id)
        {



            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@course_code", SqlDbType.Int);
            param[0].Value = course_code;

            param[1] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[1].Value = Intake_code;

            param[2] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[2].Value = Unique_num;



            param[3] = new SqlParameter("@Assignment", SqlDbType.Decimal);
            param[3].Value = Assignment;


            param[4] = new SqlParameter("@final_Exam", SqlDbType.Decimal);
            param[4].Value = final_Exam;

            param[5] = new SqlParameter("@Total_grade_Resit", SqlDbType.Decimal);
            param[5].Value = Total_grade;

            param[6] = new SqlParameter("@year", SqlDbType.Date);
            param[6].Value = year;

            param[7] = new SqlParameter("@grade_code", SqlDbType.Int);
            param[7].Value = id;


            DAL.ExectCommand("UPDATE_Garde", param);
            DAL.close();




        }
        public void DELETE_Grade(int code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@grade_code", SqlDbType.Int);
            param[0].Value = code;

            DAL.ExectCommand("DELETE_Grade", param);
            DAL.close();


        }
    }
}
