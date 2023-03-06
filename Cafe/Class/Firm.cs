using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Class
{
    internal class Firm: Database
    {
        public List<Item> GetFirm()
        {
            List<Item> list = new();
            try
            {
                const string query = $"Select idFirm, firm from firm;";
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
        public void LoadData(DataGridView dg)
        {

            LoadData(dg, "firm");
        }

        public void DeleteData(int id)
        {
            Execute($@"Delete from firm where idFirm = {id};");
        }
        public void InsertData(string firm,string phone,string address, string info)
        {
            var query =
                $"Insert into firm(firm, phone, address, info) values('{firm}', '{phone}', '{address}', '{info}')";
                           // MessageBox.Show(queryCommand);
            Execute(query);
        }
        public void UpdateData(int idFirm,string firm,string phone,string address, string info)
        {
            var query =
                $"update firm set firm='{firm}', phone='{phone}', address='{address}', info='{info}' where idFirm={idFirm}";
                           // MessageBox.Show(queryCommand);
            Execute(query);
        }
    }
}
