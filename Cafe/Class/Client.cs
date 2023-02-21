using System;
using System.Windows.Forms;

namespace Cafe.Class
{
    public class Client:Database
    {

        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "client");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText = "Категория";

        }

        public void DeleteData(int id)
        {
            Execute("Delete from client where idClient = " + id+ ";");
        }

        public void InsertData(string firstName,string lastName,string phone, string address)
        {
            string query = $"Insert into client(firstName,lastName,phone,address) values('{firstName}','{lastName}','{phone}','{address}')";
            //  MessageBox.Show(query);
            Execute(query);
        }

        public void UpdateData(int id, string firstName,string lastName,string phone, string address)
        {
            try
            {
                string query = $"Update client set firstName = '{firstName}',lastName='{lastName}', phone='{phone}',address='{address}' where idClient = {id};";
                //  MessageBox.Show(query);
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error updateCategory: " + exception.ToString());
            }
            
        }
    }
}