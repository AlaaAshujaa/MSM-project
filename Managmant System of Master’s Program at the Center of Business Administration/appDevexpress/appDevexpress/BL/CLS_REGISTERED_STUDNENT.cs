using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace appDevexpress.BL
{
    class CLS_REGISTERED_STUDNENT
    {
        public DataTable GET_ALL_Registered_Student()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Registered_Student", null);
            DAL.close();
            return DT;


        }

        public DataTable check_student_add(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@student_id", SqlDbType.VarChar);
            param[0].Value = id;
            DT = DAL.SelectData("check_student_add", null);
            DAL.close();
            return DT;


        }

        public DataTable GET_ALL_Registered()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Registered", null);
            DAL.close();
            return DT;


        }
      
        public void add_Registered_Student(string Unique_num,string TOEFL, string Specialization, string Worked_Fulltime, string document_path,  string student_id, int Intake_code, string accepted)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[0].Value = Unique_num;


              param[1] = new SqlParameter("@TOEFL", SqlDbType.VarChar);
            param[1].Value = TOEFL;

            param[2] = new SqlParameter("@Specialization", SqlDbType.VarChar);
            param[2].Value = Specialization;

            param[3] = new SqlParameter("@Worked_Fulltime", SqlDbType.VarChar);
            param[3].Value = Worked_Fulltime;

            param[4] = new SqlParameter("@document_path", SqlDbType.VarChar);
            param[4].Value = document_path;

            
            param[5] = new SqlParameter("@student_id", SqlDbType.VarChar);
            param[5].Value = student_id;

            param[6] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[6].Value = Intake_code;

            param[7] = new SqlParameter("@accepted", SqlDbType.VarChar);
            param[7].Value = accepted;









            DAL.ExectCommand("add_Registered_Student", param);
            DAL.close();
        }
        public void UPDATE_Registered_Student(string TOEFL, string Specialization, string Worked_Fulltime, string document_path, int Intake_code, string accepted, string id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@TOEFL", SqlDbType.VarChar);
            param[0].Value = TOEFL;

            param[1] = new SqlParameter("@Specialization", SqlDbType.VarChar);
            param[1].Value = Specialization;

            param[2] = new SqlParameter("@Worked_Fulltime", SqlDbType.VarChar);
            param[2].Value = Worked_Fulltime;

            param[3] = new SqlParameter("@document_path", SqlDbType.VarChar);
            param[3].Value = document_path;

            param[4] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[4].Value = Intake_code;

            param[5] = new SqlParameter("@accepted", SqlDbType.VarChar);
            param[5].Value = accepted;






            param[6] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[6].Value = id;




            DAL.ExectCommand("UPDATE_Registered_Student", param);
            DAL.close();
        }
    }
}
