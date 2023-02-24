using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Class
{
    public class Income:Database
    {
        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "income");
            dg.Columns[0].HeaderText = @"№";
            dg.Columns[1].HeaderText = @"Имя";
        }

        public void DeleteData(int id)
        {
            Execute("Delete from income where idIncome = " + id+ ";");
        }

        public void InsertData(string name)
        {
            var query = $"Insert into income(Name) values('{name}')";
            //  MessageBox.Show(query);
            Execute(query);
        }

        public void UpdateData(int id,string name)
        {
            try
            {
                var query = $"Update income set Name = '{name}' where idIncome = {id};";
                //  MessageBox.Show(query);
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error updateCategory: " + exception);
            }
        }
        public List<Item> GetIncome()
        {
            var list = new List<Item>();
            try
            {
                const string query = "Select idIncome, Name from income;";
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
            return base.GetById(id, "income", "name");
        }
    }
}