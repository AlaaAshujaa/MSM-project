using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_ADD_COURSE
    {
        public DataTable GET_ALL_Add_course()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Add_course", null);
            DAL.close();
            return DT;


        }
        public DataTable SEARCH_Courses(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;
            DT = DAL.SelectData("SEARCH_Courses", param);
            DAL.close();
            return DT;


        }
        public void ADD_Courses(string name, string type, int houres, string ECTS)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;

            param[1] = new SqlParameter("@type", SqlDbType.VarChar);
            param[1].Value = type;

            param[2] = new SqlParameter("@houres", SqlDbType.Int);
            param[2].Value = houres;

            param[3] = new SqlParameter("@ECTS", SqlDbType.Int);
            param[3].Value = ECTS;

            DAL.ExectCommand("Add_Course", param);
            DAL.close();
        }
        public void UPDATE_Courses(string name, string type, int houres, string ECTS, int course_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[1].Value = type;

            param[2] = new SqlParameter("@houres", SqlDbType.Int);
            param[2].Value = houres;

            param[3] = new SqlParameter("@ECTS", SqlDbType.VarChar);
            param[3].Value = ECTS;

            param[4] = new SqlParameter("@course_code", SqlDbType.Int);
            param[4].Value = course_code;

            DAL.ExectCommand("UPDATE_Courses", param);
            DAL.close();




        }
        public void DELETE_Courses(string name, string type, int houres,string ECTS, int course_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[1].Value = type;

            param[2] = new SqlParameter("@houres", SqlDbType.Int);
            param[2].Value = houres;

            param[3] = new SqlParameter("@ECTS", SqlDbType.VarChar);
            param[3].Value = houres;

            param[4] = new SqlParameter("@course_code", SqlDbType.Int);
            param[4].Value = course_code;


            DAL.ExectCommand("DELETE_Course", param);
            DAL.close();




        }
    }
}
