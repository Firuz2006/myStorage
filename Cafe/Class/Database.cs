using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cafe.Class
{
    public abstract class Database
    {
        public MySqlConnection connection;
        public MySqlTransaction transaction;

        public Database()
        {
            string user = "root";
            string project = "mystorage";
            string password = "";
            string connectionString;
            string server = "localhost";
            connectionString = "SERVER=" + server + "; UID =" + user + ";  DATABASE = " + project + "; PASSWORD = " + password + "; CHARSET = utf8;";
            connection = new MySqlConnection(connectionString);

        }

        private void openConnection()
        { 
             if(connection.State == ConnectionState.Closed)   connection.Open();
            //  transaction = connection.BeginTransaction();
        }

        protected void closeConnection()
        {
            connection.Close();
        }

        protected void LoadData(DataGridView dg, string table, string query = "")
        {
            string queryString = "SELECT * FROM " + table + ";";
            if (!string.IsNullOrEmpty(query))
            {
                queryString = query;
            }
            openConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            connection.Close();
            da.Dispose();
            dt.Dispose();
        }

        public void Execute(string sql)
        {
            try
            {
                closeConnection();
                openConnection();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
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
                closeConnection();
            }
        }

        protected MySqlDataReader GetData(string query)
        {
            MySqlDataReader reader = null;
            try
            {
                openConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Error: " + exception);
            }
            return reader;
        }
    }
}