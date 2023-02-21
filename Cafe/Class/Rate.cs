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
            LoadData(dg, "rate");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText = "TJS";
            dg.Columns[2].HeaderText = "USD";
            dg.Columns[3].HeaderText = "Date";
            
        }

        // public void DeleteData(int id)
        // {
            // Execute("Delete from rate where idRate = " + id + ";");
        // }

        public void InsertData(decimal usd,decimal tjs)
        {
                string query = $"Insert into rate(tjs,usd,date) values('{tjs}','{usd}','{DateTime.Now.ToString("yyyy-MM-dd")}')";
                               //  MessageBox.Show(query);
                Execute(query);
        }

        // public void UpdateData(int id, string category)
        // {
        //     try
        //     {
        //         string query = $"Update category set category = '{category}' where idCategory = {id};";
        //       //  MessageBox.Show(query);
        //         Execute(query);
        //     }
        //     catch (Exception exception)
        //     {
        //         MessageBox.Show("Error updateCategory: " + exception.ToString());
        //     }
        //     
        // }

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

        // public List<Item> GetRate()
        // {
        //     List<Item> list = new List<Item>();
        //     try
        //     {
        //         string query = "Select idCategory, category from category ORDER BY category;";
        //         MySqlDataReader reader = GetData(query);
        //         while (reader.Read())
        //         {
        //             list.Add(new Item(reader.GetInt16(0), reader.GetString(1)));
        //         }
        //     }
        //     catch (Exception exception)
        //     {
        //         MessageBox.Show("Error: " + exception);
        //     }
        //     
        //     return list;
        // }
    }
}
