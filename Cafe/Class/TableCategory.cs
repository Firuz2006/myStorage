using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cafe.Class
{
    class TableCategory: Database
    {
        public TableCategory()
        {
        }
        public List<Item> GetCategory()
        {
            List<Item> list = new List<Item>();
            try
            {
                string query = "SELECT idTableCategory, category FROM TableCategory WHERE status = 1 ORDER BY category;";
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

            return list;
        }
    }
     
}
