using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cafe.Class
{
    internal class Firm: Database
    {
        public List<Item> GetFirm()
        {
            List<Item> list = new List<Item>();
            try
            {
                string query = "Select idFirm, firm from firm;";
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

            LoadData(dg, "firm","");
        }

        public void DeleteData(int id)
        {
            Execute("Delete from firm where idFirm = " + id.ToString() + ";");
        }
        public void InsertData(string firm,string phone,string address, string info)
        {
            string query =
                $"Insert into firm(firm, phone, address, info) values('{firm}', '{phone}', '{address}', '{info}')";
                           // MessageBox.Show(queryCommand);
            Execute(query);
        }
        public void UpdateData(int idFirm,string firm,string phone,string address, string info)
        {
            string query =
                $"update firm set firm='{firm}', phone='{phone}', address='{address}', info='{info}' where idFirm={idFirm}";
                           // MessageBox.Show(queryCommand);
            Execute(query);
        }
    }
}
