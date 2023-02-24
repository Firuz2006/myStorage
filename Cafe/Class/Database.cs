using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cafe.Class
{
    public abstract class Database
    {
        protected readonly MySqlConnection Connection;

        protected Database()
        {
            const string user = "root";
            const string project = "myStorage";
            const string password = "";
            const string server = "localhost";
            const string connectionString = "SERVER=" + server + "; UID =" + user + ";  DATABASE = " + project + "; PASSWORD = " + password + "; CHARSET = utf8;";
            Connection = new MySqlConnection(connectionString);

        }

        private void OpenConnection()
        { 
             if(Connection.State == ConnectionState.Closed)   Connection.Open();
            //  transaction = connection.BeginTransaction();
        }

        protected void CloseConnection()
        {
            Connection.Close();
        }

        protected void LoadData(DataGridView dg, string table, string query = "")
        {
            CloseConnection();
            var queryString = "SELECT * FROM " + table + ";";
            if (!string.IsNullOrEmpty(query))
            {
                queryString = query;
            }
            OpenConnection();
            var da = new MySqlDataAdapter(queryString, Connection);
            var dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            Connection.Close();
            da.Dispose();
            dt.Dispose();
        }

        protected void Execute(string sql)
        {
            try
            {
                CloseConnection();
                OpenConnection();

                var cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            finally
            {
                CloseConnection();
            }
        }

        protected MySqlDataReader GetData(string query)
        {
            CloseConnection();
            MySqlDataReader reader = null;
            try
            {
                OpenConnection();
                var cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(@"Error: " + exception);
            }
            return reader;
        }

        protected Item GetById(int id,string table,string colName)
        {
            CloseConnection();
            var query = $"SELECT {colName} FROM {table} where id{table}={id};";
            OpenConnection();
            var data = GetData(query);
            data.Read();
            return new Item(id, data.GetString(0));
        }
    }
}