using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_ACADIMIC
    {
  
        public DataTable GET_ALL_Acadimic_Staff()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_Acadimic_Staff", null);
            DAL.close();
            return DT;


        }

        public void DELETE_Acadimic_Staff(string first_name, string middle_name, string last_name, int cell_phone, int office_phone, int fax, string sex, string major, string scientific_degree, string qualifies, string organization, string nationality, string cv, string address, string date,int doctor_code)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@middle_name", SqlDbType.VarChar);
            param[1].Value = middle_name;

            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar);
            param[2].Value = last_name;

            param[3] = new SqlParameter("@cell_phone", SqlDbType.Int);
            param[3].Value = cell_phone;

            param[4] = new SqlParameter("@office_phone", SqlDbType.Int);
            param[4].Value = office_phone;

            param[5] = new SqlParameter("@fax", SqlDbType.Int);
            param[5].Value = fax;

            param[6] = new SqlParameter("@sex", SqlDbType.VarChar);
            param[6].Value = sex;

            param[7] = new SqlParameter("@major", SqlDbType.VarChar);
            param[7].Value = major;

            param[8] = new SqlParameter("@scientific_degree", SqlDbType.VarChar);
            param[8].Value = scientific_degree;

            param[9] = new SqlParameter("@qualifies", SqlDbType.VarChar);
            param[9].Value = qualifies;

            param[10] = new SqlParameter("@organization", SqlDbType.VarChar);
            param[10].Value = organization;

            param[11] = new SqlParameter("@nationality", SqlDbType.VarChar);
            param[11].Value = nationality;

            param[12] = new SqlParameter("@cv", SqlDbType.VarChar);
            param[12].Value = cv;

            param[13] = new SqlParameter("@address", SqlDbType.VarChar);
            param[13].Value = address;

            param[14] = new SqlParameter("@date", SqlDbType.Date);
            param[14].Value = date;

            param[15] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[15].Value = doctor_code;

            DAL.ExectCommand("DELETE_Acadimic_Staff", param);
            DAL.close();




        }


        public void ADD_Acadimic_Staff( string first_name ,string middle_name,string last_name  ,int cell_phone  ,int office_phone,int fax ,string sex ,string major ,string scientific_degree ,string qualifies ,string organization ,string nationality,string cv,string address,string date)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[15];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@middle_name", SqlDbType.VarChar);
            param[1].Value = middle_name;

            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar);
            param[2].Value = last_name;

            param[3] = new SqlParameter("@cell_phone", SqlDbType.Int);
            param[3].Value = cell_phone;

            param[4] = new SqlParameter("@office_phone", SqlDbType.Int);
            param[4].Value = office_phone;

            param[5] = new SqlParameter("@fax", SqlDbType.Int);
            param[5].Value = fax;

            param[6] = new SqlParameter("@sex", SqlDbType.VarChar);
            param[6].Value = sex;

            param[7] = new SqlParameter("@major", SqlDbType.VarChar);
            param[7].Value = major;

            param[8] = new SqlParameter("@scientific_degree", SqlDbType.VarChar);
            param[8].Value = scientific_degree;

            param[9] = new SqlParameter("@qualifies", SqlDbType.VarChar);
            param[9].Value = qualifies;

            param[10] = new SqlParameter("@organization", SqlDbType.VarChar);
            param[10].Value = organization;

            param[11] = new SqlParameter("@nationality", SqlDbType.VarChar);
            param[11].Value = nationality;

            param[12] = new SqlParameter("@cv", SqlDbType.VarChar);
            param[12].Value = cv;

            param[13] = new SqlParameter("@address", SqlDbType.VarChar);
            param[13].Value = address;

            param[14] = new SqlParameter("@date", SqlDbType.Date);
            param[14].Value = date;

           
            DAL.ExectCommand("ADD_Acadimic_Staff", param);
            DAL.close();
        }


        public DataTable SEARCH_Acadimic_Staff(string USE )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;
           
            DT = DAL.SelectData("SEARCH_Acadimic_Staff", param);
            DAL.close();
            return DT;


        }


        public void UPDATE_Acadimic_Staff(string first_name, string middle_name, string last_name, int cell_phone, int office_phone, int fax, string sex, string major, string scientific_degree, string qualifies, string organization, string nationality, string cv, string address, string date, int doctor_code)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@middle_name", SqlDbType.VarChar);
            param[1].Value = middle_name;

            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar);
            param[2].Value = last_name;

            param[3] = new SqlParameter("@cell_phone", SqlDbType.Int);
            param[3].Value = cell_phone;

            param[4] = new SqlParameter("@office_phone", SqlDbType.Int);
            param[4].Value = office_phone;

            param[5] = new SqlParameter("@fax", SqlDbType.Int);
            param[5].Value = fax;

            param[6] = new SqlParameter("@sex", SqlDbType.VarChar);
            param[6].Value = sex;

            param[7] = new SqlParameter("@major", SqlDbType.VarChar);
            param[7].Value = major;

            param[8] = new SqlParameter("@scientific_degree", SqlDbType.VarChar);
            param[8].Value = scientific_degree;

            param[9] = new SqlParameter("@qualifies", SqlDbType.VarChar);
            param[9].Value = qualifies;

            param[10] = new SqlParameter("@organization", SqlDbType.VarChar);
            param[10].Value = organization;

            param[11] = new SqlParameter("@nationality", SqlDbType.VarChar);
            param[11].Value = nationality;

            param[12] = new SqlParameter("@cv", SqlDbType.VarChar);
            param[12].Value = cv;

            param[13] = new SqlParameter("@address", SqlDbType.VarChar);
            param[13].Value = address;

            param[14] = new SqlParameter("@date", SqlDbType.Date);
            param[14].Value = date;

            param[15] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[15].Value = doctor_code;


            DAL.ExectCommand("UPDATE_Acadimic_Staff", param);
            DAL.close();
        }



    }
}
