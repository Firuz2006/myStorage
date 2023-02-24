using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Class
{
    public class CashInBox:Database
    {
        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "cashInBox",@"select c.idCashBox,c.date,c.priceusd,c.pricetjs, ic.name,s.storage
            from cashinbox as c,income as ic,storage as s
            where ic.idIncome=c.idIncome AND s.idStorage=c.idStorage;");
            dg.Columns[0].HeaderText = @"№";
            dg.Columns[1].HeaderText = @"Дата";
            dg.Columns[2].HeaderText = @"USD";
            dg.Columns[3].HeaderText = @"TJS";
            dg.Columns[4].HeaderText = @"Доход";
            dg.Columns[5].HeaderText = @"Склад";
        }

        public void DeleteData(int id)
        {
            Execute($"Delete from cashInBox where idCashBox = {id};");
        }
        public void InsertData(int idStorage,string priceUsd,string priceTjs, int idIncome)
        {
            var query =
                $"Insert into cashInBox(idStorage,priceUSD,priceTJS,idIncome,date) values('{idStorage}', '{priceUsd}', '{priceTjs}', '{idIncome}','{DateTime.Now:yyyy-MM-dd}')";
            // MessageBox.Show(queryCommand);
            Execute(query);
        }
        public void UpdateData(int idCashInBox,int idStorage,string priceUsd,string priceTjs, int idIncome)
        {
            var query =
                $"update cashInBox set idStorage='{idStorage}', priceUSD='{priceUsd}', priceTJS='{priceTjs}', idIncome='{idIncome}', date='{DateTime.Now:yyyy-MM-dd}' where idCashBox={idCashInBox}";
            // MessageBox.Show(queryCommand);
            Execute(query);
        }

        public Dictionary<string, int> GetById(int id)
        {
            var res = new Dictionary<string, int>();
            var query = $"select c.idIncome, c.idStorage from cashInbox as c where c.idCashBox={id}";
            var data = GetData(query);
            data.Read();
            res.Add("idStorage",data.GetInt16(1));
            res.Add("idIncome",data.GetInt16(0));
            return res;
        }
    }
}