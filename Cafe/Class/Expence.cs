using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Class
{
    public class Expense:Database
    {
        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "expense");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText = "Имя";

        }

        public void DeleteData(int id)
        {
            Execute("Delete from expense where idExpense = " + id+ ";");
        }

        public void InsertData(string Name)
        {
            string query = $"Insert into expense(Name) values('{Name}')";
            //  MessageBox.Show(query);
            Execute(query);
        }

        public void UpdateData(int id,string Name)
        {
            try
            {
                string query = $"Update expense set Name = '{Name}' where idExpense = {id};";
                //  MessageBox.Show(query);
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error updateCategory: " + exception);
            }
            
        }

        public List<Item> GetExpense()
        {
            var list = new List<Item>();
            try
            {
                const string query = "Select idExpense, name from expense;";
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
    }
}