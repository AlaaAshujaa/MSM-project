using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDevexpress.BL
{
    class CLS_StudentFail
    {
        public DataTable Get_all_StudentFail(int course_code, int intake_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@course_code", SqlDbType.Int);
            param[0].Value = course_code;

            param[1] = new SqlParameter("@intake_code", SqlDbType.Int);
            param[1].Value = intake_code;

            DT = DAL.SelectData("Get_all_StudentFail",param);
            DAL.close();
            return DT;


        }
    }
}
