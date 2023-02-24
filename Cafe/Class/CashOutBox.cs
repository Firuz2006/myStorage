using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Class
{
    public class CashOutBox:Database
    {
        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "cashOutBox",$@"select c.idCashBox,c.date,c.priceusd,c.pricetjs, ic.name,s.storage
            from cashOutbox as c,expense as ic,storage as s
            where ic.idExpense=c.idExpense AND s.idStorage=c.idStorage;");
            dg.Columns[0].HeaderText = @"№";
            dg.Columns[1].HeaderText = @"Дата";
            dg.Columns[2].HeaderText = @"USD";
            dg.Columns[3].HeaderText = @"TJS";
            dg.Columns[4].HeaderText = @"Расход";
            dg.Columns[5].HeaderText = @"Склад";
        }

        public void DeleteData(int id)
        {
            Execute($"Delete from cashOutbox where idCashBox = {id};");
        }
        public void InsertData(int idStorage,string priceUsd,string priceTjs, int idExpense)
        {
            var query =
                $"Insert into cashoutbox(idStorage,priceUSD,priceTJS,idExpense,date) values('{idStorage}', '{priceUsd}', '{priceTjs}', '{idExpense}','{DateTime.Now:yyyy-MM-dd}')";
            // MessageBox.Show(queryCommand);
            Execute(query);
        }
        public void UpdateData(int idCashInBox,int idStorage,string priceUsd,string priceTjs, int idExpense)
        {
            var query =
                $"update cashOutBox set idStorage='{idStorage}', priceUSD='{priceUsd}', priceTJS='{priceTjs}', idExpense='{idExpense}', date='{DateTime.Now:yyyy-MM-dd}' where idCashBox={idCashInBox}";
            // MessageBox.Show(queryCommand);
            Execute(query);
        }

        public Dictionary<string, int> GetById(int id)
        {
            var res = new Dictionary<string, int>();
            var query = $"select c.idExpense, c.idStorage from cashOutbox as c where c.idCashBox={id}";
            var data = GetData(query);
            data.Read();
            res.Add("idStorage",data.GetInt32(1));
            res.Add("idExpense",data.GetInt32(0));
            return res;
        }
    }
}