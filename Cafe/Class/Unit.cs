using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cafe.Class
{
    internal class Unit: Database
    {
        public List<Item> GetUnit()
        {
            List<Item> list = new List<Item>();
            try
            {
                string query = "Select idUnit, unit from unit;";
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

        public void LoadData(DataGridView dg)
        {

            LoadData(dg, "unit");
        }

        public void DeleteData(int id)
        {
            Execute("Delete from unit where idUnit = " + id.ToString() + ";");
        }
        public void InsertData(string Company)
        {
            string query = "Insert into unit(unit)" +
                           " values ('{0}')";
            string queryCommand = string.Format(query, Company);
            MessageBox.Show(queryCommand);
            Execute(queryCommand);
        }

        public void UpdateData(int idUnit, string Unit)
        {
            string query = "Update unit set unit  = '{0}' Where idUnit = {1};";
            string commandString = string.Format(query, Unit, idUnit);
            MessageBox.Show(commandString);
            Execute(commandString);
        }
    }
}
