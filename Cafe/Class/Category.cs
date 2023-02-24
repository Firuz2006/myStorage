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
    class Category: Database
    {
        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "category");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText = "Категория";

        }

        public void DeleteData(int id)
        {
            Execute($"Delete from category where idCategory = {id};");
        }

        public void InsertData(string category)
        {
                var query = $"Insert into category(category) values('{category}')";
                               //  MessageBox.Show(query);
                Execute(query);
        }

        public void UpdateData(int id, string category)
        {
            try
            {
                var query = $"Update category set category = '{category}' where idCategory = {id};";
              //  MessageBox.Show(query);
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error updateCategory: " + exception.ToString());
            }
            
        }

        public List<Item> GetCategory()
        {
            var list = new List<Item>();
            try
            {
                const string query = "Select idCategory, category from category ORDER BY category;";
                var reader = GetData(query);
                while (reader.Read())
                {
                    list.Add(new Item(reader.GetInt16(0), reader.GetString(1)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error: " + exception);
            }
            
            return list;
        }

        public Item GetById(int id)
        {
            return base.GetById(id, "category", "category");
        }
    }
}
