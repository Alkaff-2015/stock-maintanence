using System;
using System.Data;
using System.Data.SqlClient;

namespace RealTechHub
{
    public class DBAccess
    {
        public readonly string connectionString = string.Empty;
        public DBAccess()
        {
            connectionString = cCommonUtils.ConnectionString;
        }

        public DataSet ExecuteSQL(string SQLStatement)
        {
            return ExecuteSQL(SQLStatement, connectionString, CommandType.Text);
        }

        public DataSet ExecuteSQL(string SQLStatement, string ConnectionString)
        {
            return ExecuteSQL(SQLStatement, ConnectionString, CommandType.Text);
        }

        public DataSet ExecuteSQL(string SQLStatement, string ConnectionString, CommandType pCommandType)
        {
            return ExecuteSQL(SQLStatement, ConnectionString, pCommandType, 0);
        }

        public DataSet ExecuteSQL(string SQLStatement, string ConnectionString, CommandType pCommandType, int timeout)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand sqlCommand = new SqlCommand();
            DataSet ds = new DataSet();


            if (sqlCommand.Connection == null)
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                sqlCommand.Connection = connection;
            }

            try
            {
                sqlCommand.CommandType = pCommandType;
                sqlCommand.CommandText = SQLStatement;
                if (timeout > 0)
                    sqlCommand.CommandTimeout = timeout;
                da.SelectCommand = sqlCommand;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlCommand.Connection.Dispose();
                sqlCommand.Dispose();
            }
            return null;
        }
    }
}