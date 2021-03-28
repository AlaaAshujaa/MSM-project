using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_Research
    {
        public DataTable GET_All_Research()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_All_Research", null);
            DAL.close();
            return DT;
        }


        public void UPDATE_Research(string Unique_num, int doctor_code, string title_research, string type, string date, int id)
        {


            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[0].Value = Unique_num;

            param[1] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[1].Value = doctor_code;

            param[2] = new SqlParameter("@title_research", SqlDbType.VarChar);
            param[2].Value = title_research;

            param[3] = new SqlParameter("@type", SqlDbType.VarChar);
            param[3].Value = type;

            param[4] = new SqlParameter("@date", SqlDbType.Date);
            param[4].Value = date;

            param[5] = new SqlParameter("@Research_code", SqlDbType.Int);
            param[5].Value = id;

            DAL.ExectCommand("UPDATE_Research", param);
            DAL.close();




        }
        public void DELETE_Research(int Research_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@Research_code ", SqlDbType.Int);
            param[0].Value = Research_code;

            DAL.ExectCommand("DELETE_Research", param);
            DAL.close();

        }

        public void Add_Research(string Unique_num, int doctor_code, string title_research, string type,string date)
        {
            

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Unique_num", SqlDbType.VarChar);
            param[0].Value = Unique_num;

            param[1] = new SqlParameter("@doctor_code", SqlDbType.Int);
            param[1].Value = doctor_code;

            param[2] = new SqlParameter("@title_research", SqlDbType.VarChar);
            param[2].Value = title_research;

            param[3] = new SqlParameter("@type", SqlDbType.VarChar);
            param[3].Value = type;

            param[4] = new SqlParameter("@date", SqlDbType.Date);
            param[4].Value = date;

            DAL.ExectCommand("Add_Research", param);
            DAL.close();




        }

    }
}
