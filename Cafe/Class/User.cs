using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cafe.Class
{
    class User:Database
    {
        public int idUser { get; set; }
        public string fio { get; set; }
        public string login { get; set; }
        public string password{ get; set; }
        public string image { get; set; }
        public string privilege { get; set; }
        public bool status { get; set; }
       
        public bool validationLogin(string login,  string password, bool checkPassword = true)
        {

            try
            {
                Connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка подключения к БД: " + ex.ToString());
            }

            string cmdText = "Select * from User where login = '" + login
                              + "' and status = 1";

            if (checkPassword)
            {
                cmdText += " and password = md5('" + password + "');";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, Connection);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    this.idUser = reader.GetInt16(0);
                    this.login = reader.GetString(1);
                    this.fio = reader.GetString(3);
                    this.image = reader.GetString(4);
                    this.privilege = reader.GetString(5);
                    Connection.Close();
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения данных:" + ex.ToString());
            }

            Connection.Close();
            return false;
        }

        public void LoadData(DataGridView dg)
        {

            LoadData(dg, "user");
        }

        public void DeleteData(int id)
        {
            Execute("Delete from user where idUser = " + id.ToString() 
                + " and privilege = 'Администратор';");
        }

        public void InsertData(string login, string password, string fio, string image, string privilege, bool status)
        {

            if (!this.validationLogin(login, password, false))
            {
                string query = @"INSERT INTO `user` (
                                  login, `password`, fio,
                                  image, privilege, `status`
                                ) 
                                VALUES
                                  (
                                    '{0}', md5('{1}'), '{2}',
                                    '{3}', '{4}', {5}
                                  ) ;";
                string queryCommand = string.Format(query, login, password, fio, image, privilege, status);
                MessageBox.Show(queryCommand);
                Execute(queryCommand);
            }
            else
            {
                MessageBox.Show(@"Пользователь с таким логином уже существует :(");
            }
        }

        public void UpdateData(int idUser, string login, string password, string fio, string image, string privilege, bool status)
        {
            string query = "UPDATE user set login  = '{0}', password = '{1}'," + 
                            " fio = '{2}', image = {3}," +
                            " privilege = '{4}', status = {5}" +
                            " Where idUser = {6}" +
                            " and privilege = 'Администратор';";
            string commandString = string.Format(query, login, password, fio, image, privilege, status, idUser);
            MessageBox.Show(commandString);
            Execute(commandString);
        }

    }
}
