using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appDevexpress.BL
{
    class CLS_STATE
    {
        public DataTable GET_ALL_states()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_states", null);
            DAL.close();
            return DT;


        }
        public void ADD_states(string name)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;

            DAL.ExectCommand("Add_states", param);
            DAL.close();
        }
        public void UPDATE_states(string name, int state_id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;


            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = state_id;

            DAL.ExectCommand("UPDATE_states", param);
            DAL.close();




        }
        public void DELETE_states(string name, int state_id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = name;


            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = state_id;


            DAL.ExectCommand("DELETE_states", param);
            DAL.close();




        }
        public DataTable SEARCH_states(string USE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USE", SqlDbType.VarChar, 50);
            param[0].Value = USE;
            DT = DAL.SelectData("SEARCH_states", param);
            DAL.close();
            return DT;


        }
    }
}
