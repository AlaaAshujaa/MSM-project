using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace appDevexpress.DAL
{
    class DataAccessLayer
    {
  
        SqlConnection SqlConnection;

        //inisiat connection
        public DataAccessLayer()
        {
            SqlConnection = new SqlConnection(@"server=.\;Database=MSM; integrated security=true");
            SqlConnection.Open();
        }

        public string SelectData_value(string stord_procedure, SqlParameter[] param)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stord_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);

            }

            SqlDataReader re;

            re = sqlcmd.ExecuteReader();

            re.Read();
            return "" + re.GetValue(0);

        }

        public SqlDataReader SelectData_att(string sql)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = SqlConnection;

            SqlDataReader re;

            re = sqlcmd.ExecuteReader();

            return re;

        }
        //open connecion
        public void open()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }

        //close connection
        public void close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        //select data via stord procedure
        public DataTable SelectData(string stord_procedure, SqlParameter[] param)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stord_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                //for(int i=0; 1<param.Length;i++)
                //{
                //    sqlcmd.Parameters.Add(param[i]);
                //}

                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);

                }

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            if (dt != null) { 
            
            }
            da.Fill(dt);
            return dt;
        }

        public SqlDataReader SelectData_reader(string stord_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stord_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);

            }

            SqlDataReader re;
            re = sqlcmd.ExecuteReader();
            return re;

        }

       
        public SqlDataReader SelectData_reader(string stord_procedure)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stord_procedure;
            sqlcmd.Connection = SqlConnection;

            SqlDataReader re;
            re = sqlcmd.ExecuteReader();
            return re;

        }

        // imsert , updta and delete data from batabase
        public void ExectCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);

            }
            sqlcmd.ExecuteNonQuery();
        }

        public void ExectCommand(string sql)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = SqlConnection;

            sqlcmd.ExecuteNonQuery();
        }


        //select data via 
        public DataTable SelectData(string sql)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = SqlConnection;

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlDataReader SelectData_readerSQl(string sql)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = SqlConnection;

            SqlDataReader re;

            re = sqlcmd.ExecuteReader();

            return re;

        }
    }
}
