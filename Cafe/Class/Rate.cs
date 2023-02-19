using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cafe.Class
{
    internal class Rate: Database
    {


        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "category");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText = "Категория";

        }

        public void DeleteData(int id)
        {
            Execute("Delete from category where idCategory = " + id.ToString() + ";");
        }

        public void InsertData(string category)
        {
                string query = $"Insert into category(category) values('{category}')";
                               //  MessageBox.Show(query);
                Execute(query);
        }

        public void UpdateData(int id, string category)
        {
            try
            {
                string query = $"Update category set category = '{category}' where idCategory = {id};";
              //  MessageBox.Show(query);
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error updateCategory: " + exception.ToString());
            }
            
        }

        /*public void UpdateData(int id, string category, string imagePath , bool status)
        {
            if (System.IO.File.Exists(imagePath))
            {
                string filePath = Function.GenerateFileName();
                System.IO.File.Copy(imagePath, PATH + "/" + filePath);
                string query = "Update category set category = '" + category + "'," +
                 " status = " + Convert.ToInt16(status) + ", image = '" + filePath + "' where idCategory = " + id.ToString() + ";";
                Execute(query);
            }
        }*/

        public List<Item> GetCategory()
        {
            List<Item> list = new List<Item>();
            try
            {
                string query = "Select idCategory, category from category ORDER BY category;";
                MySqlDataReader reader = GetData(query);
                while (reader.Read())
                {
                    list.Add(new Item(reader.GetInt16(0), reader.GetString(1)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception);
            }
            
            return list;
        }
    }
}
