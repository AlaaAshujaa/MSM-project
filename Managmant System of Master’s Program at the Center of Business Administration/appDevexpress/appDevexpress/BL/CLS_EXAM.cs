using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_EXAM
    {
        public DataTable GET_ALL_Exam()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Exam", null);
            DAL.close();
            return DT;
        }
        public void DELETE_Exam(int Exam_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@Exam_code", SqlDbType.Int);
            param[0].Value = Exam_code;

            DAL.ExectCommand("DELETE_Exam", param);
            DAL.close();

        }

        public void Add_Exam(int course_code, int doctor_code, int Intake_code, string date_Exam, string date_resetExam, string path)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@course_code", SqlDbType.Int);
            param[0].Value = course_code;

            param[1] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[1].Value = doctor_code;

            param[2] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[2].Value = Intake_code;

            param[3] = new SqlParameter("@date_Exam", SqlDbType.Date);
            param[3].Value = date_Exam;

            param[4] = new SqlParameter("@date_resetExam", SqlDbType.Date);
            param[4].Value = date_resetExam;

            param[5] = new SqlParameter("@path", SqlDbType.VarChar);
            param[5].Value = path;



            DAL.ExectCommand("Add_Exam", param);
            DAL.close();




        }
        public void UPDATE_Exam(int course_code, int doctor_code, int Intake_code, string date_Exam, string date_resetExam, string path, int id)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@course_code", SqlDbType.Int);
            param[0].Value = course_code;

            param[1] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[1].Value = doctor_code;

            param[2] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[2].Value = Intake_code;

            param[3] = new SqlParameter("@date_Exam", SqlDbType.Date);
            param[3].Value = date_Exam;

            param[4] = new SqlParameter("@date_resetExam", SqlDbType.Date);
            param[4].Value = date_resetExam;

            param[5] = new SqlParameter("@path", SqlDbType.VarChar);
            param[5].Value = path;



            param[6] = new SqlParameter("@Exam_code", SqlDbType.Int);
            param[6].Value = id;

            DAL.ExectCommand("UPDATE_Exam", param);
            DAL.close();




        }
        public DataTable SEARCH_Exam(string USE)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;
            DT = DAL.SelectData("SEARCH_Exam", param);
            DAL.close();
            return DT;


        }

        internal void Add_Exam(string p1, string p2, string p3, string p4, string p5, string p6)
        {
            throw new NotImplementedException();
        }
    }
}
