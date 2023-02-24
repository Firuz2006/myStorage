using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Class
{
    internal class Rate: Database
    {

        public KeyValuePair<decimal,decimal> GetLastRate()
        {
            string query = "select tjs, usd from rate order by idRate desc limit 1";
            var dataReader = GetData(query);
            KeyValuePair<decimal,decimal> res=new KeyValuePair<decimal, decimal>();
            if (dataReader.Read())
            {
                res = new KeyValuePair<decimal, decimal>(dataReader.GetDecimal(0),dataReader.GetDecimal(1));
            }
            return res;

        }
        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "rate");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText = "TJS";
            dg.Columns[2].HeaderText = "USD";
            dg.Columns[3].HeaderText = "Date";
            
        }

        public void InsertData(decimal usd,decimal tjs)
        {
                string query = $"Insert into rate(tjs,usd,date) values('{tjs}','{usd}','{DateTime.Now.ToString("yyyy-MM-dd")}')";
                               //  MessageBox.Show(query);
                Execute(query);
        }

       
    }
}
