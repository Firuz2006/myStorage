using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cafe.Class
{
    class Table : Database
    {
        public Table()
        {
        }

        public List<Item> GetTable(int idTableCategory)
        {
            List<Item> list = new List<Item>();
            try
            {
                string query = @"SELECT idTable, `table` FROM `Table` 
                               WHERE status = 1 AND idTableCategory = " + idTableCategory + " ORDER BY `table`;";
                MySqlDataReader reader = GetData(query);
                while (reader.Read())
                {
                    list.Add(new Item(reader.GetInt16(0), reader.GetString(1)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.ToString());
            }
            finally
            {
                // closeConnection();
            }

            return list;
        }
    }
}
