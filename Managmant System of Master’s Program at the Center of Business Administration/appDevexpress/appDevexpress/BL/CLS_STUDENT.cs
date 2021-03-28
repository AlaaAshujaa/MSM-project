using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appDevexpress.BL
{
    class CLS_STUDENT
    {
        public DataTable Get_All_student()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_All_student", null);
            DAL.close();
            return DT;
        }
        public DataTable SEARCH_student(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;
            DT = DAL.SelectData("SEARCH_student", param);
            DAL.close();
            return DT;


        }
    }
}
