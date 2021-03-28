using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appDevexpress.BL
{
    class ADD_Discussant
    {
        public string Get_DOCTOR(string Unique_num)
        {
            DAL.DataAccessLayer DAL = new appDevexpress.DAL.DataAccessLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar, 50);
            para[0].Value = Unique_num;



            DAL.open();
            string re = DAL.SelectData_value("Get_DOCTOR", para);



            return re;



        }
        public string Get_Title_research(string Unique_num)
        {
            DAL.DataAccessLayer DAL = new appDevexpress.DAL.DataAccessLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar, 50);
            para[0].Value = Unique_num;



            DAL.open();
            string re = DAL.SelectData_value("Get_Title_research", para);



            return re;



        }
        public string Get_DOCTOR_last(string Unique_num)
        {
            DAL.DataAccessLayer DAL = new appDevexpress.DAL.DataAccessLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar, 50);
            para[0].Value = Unique_num;



            DAL.open();
            string re = DAL.SelectData_value("Get_DOCTOR_last", para);



            return re;



        }
        public DataTable Get_unique(int Intake_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Intake_code", SqlDbType.Int);
            para[0].Value = Intake_code;
            DT = DAL.SelectData("Get_unique", para);
            DAL.close();
            return DT;


        }
        public DataTable Get_All_Discussant()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_All_Discussant", null);
            DAL.close();
            return DT;


        }




        public void Add_all_Discussant(int ntake_code, string Unique_num, string Internal_Examainer, string External_Examiner)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ntake_code", SqlDbType.Int);
            param[0].Value = ntake_code;

            param[1] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[1].Value = Unique_num;



            param[2] = new SqlParameter("@Internal_Examainer", SqlDbType.VarChar);
            param[2].Value = Internal_Examainer;

            param[3] = new SqlParameter("@External_Examiner", SqlDbType.VarChar);
            param[3].Value = External_Examiner;


            DAL.ExectCommand("Add_all_Discussant", param);
            DAL.close();
        }



        public void UPDATE_Discussant(int ntake_code, string Unique_num, string Internal_Examainer, string External_Examiner, int id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Intake_code", SqlDbType.Int);
            param[0].Value = ntake_code;

            param[1] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[1].Value = Unique_num;



            param[2] = new SqlParameter("@Internal_Examainer", SqlDbType.VarChar);
            param[2].Value = Internal_Examainer;

            param[3] = new SqlParameter("@External_Examiner", SqlDbType.VarChar);
            param[3].Value = External_Examiner;

            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Value = id;

            DAL.ExectCommand("UPDATE_Discussant", param);
            DAL.close();
        }


        public void DELETE_Discussant(int code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@code", SqlDbType.Int);
            param[0].Value = code;

            DAL.ExectCommand("DELETE_Discussant", param);
            DAL.close();


        }
    }
}
