using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class Course_B_D
    {
        public DataTable GET_ALL_book()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_book", null);
            DAL.close();
            return DT;


        }
        public DataTable GET_ALL_Course_B_D()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Course_B_D", null);
            DAL.close();
            return DT;


        }
        public void DELETE_Course_B_D(int code)
        {



            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@code", SqlDbType.Int);
            param[0].Value = code;





            DAL.ExectCommand("DELETE_Course_B_D", param);
            DAL.close();




        }
        public void ADD_Course_B_D(int id_course, int id_doctor, int id_intake, string id_book, int id_program, string from_date, string to_date, string plan)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@course_code", SqlDbType.Int);
            param[0].Value = id_course;

            param[1] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[1].Value = id_doctor;

            param[2] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[2].Value = id_intake;

            param[3] = new SqlParameter("@ISPN", SqlDbType.VarChar);
            param[3].Value = id_book;

            param[4] = new SqlParameter("@program_code", SqlDbType.Int);
            param[4].Value = id_program;

            param[5] = new SqlParameter("@from_date", SqlDbType.Date);
            param[5].Value = from_date;

            param[6] = new SqlParameter("@to_date", SqlDbType.Date);
            param[6].Value = to_date;

            param[7] = new SqlParameter("@plan", SqlDbType.VarChar);
            param[7].Value = plan;




            DAL.ExectCommand("ADD_Course_B_D", param);
            DAL.close();
        }
        public DataTable SEARCH_Course_B_D(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;

            DT = DAL.SelectData("SEARCH_Course_B_D", param);
            DAL.close();
            return DT;


        }
        public void UPDATE_Course_B_D(int id_course, int id_doctor, int id_intake, string id_book, int id_program, string from_date, string to_date, string plan, int id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@course_code", SqlDbType.Int);
            param[0].Value = id_course;

            param[1] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[1].Value = id_doctor;

            param[2] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[2].Value = id_intake;

            param[3] = new SqlParameter("@ISPN", SqlDbType.VarChar);
            param[3].Value = id_book;

            param[4] = new SqlParameter("@program_code", SqlDbType.Int);
            param[4].Value = id_program;

            param[5] = new SqlParameter("@from_date", SqlDbType.Date);
            param[5].Value = from_date;

            param[6] = new SqlParameter("@to_date", SqlDbType.Date);
            param[6].Value = to_date;

            param[7] = new SqlParameter("@plan", SqlDbType.VarChar);
            param[7].Value = plan;


            param[8] = new SqlParameter("@code", SqlDbType.Int);
            param[8].Value = id;




            DAL.ExectCommand("UPDATE_Course_B_D", param);
            DAL.close();
        }
    }
}
