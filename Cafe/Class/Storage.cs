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
    internal class Storage: Database
    {


        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "storage");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText = "Категория";
            dg.Columns[2].HeaderText = "Адрес";

        }

        public void DeleteData(int id)
        {
            Execute("Delete from storage where idStorage = " + id+ ";");
        }

        public void InsertData(string storage,string address)
        {
                var query = $"Insert into storage(storage, address) values('{storage}','{address}')";
                               //  MessageBox.Show(query);
                Execute(query);
        }

        public void UpdateData(int id, string storage,string address)
        {
            try
            {
                var query = $"Update storage set storage = '{storage}',address='{address}' where idstorage = {id};";
              //  MessageBox.Show(query);
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error updateCategory: " + exception.ToString());
            }
            
        }


        public List<Item> GetStorage()
        {
            var list = new List<Item>();
            try
            {
                const string query = "Select idStorage, storage from storage;";
                var reader = GetData(query);
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
