using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cafe.Class
{
    class Invoice: Database
    {
        public Invoice()
        {

        }

        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "Invoice");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText= "№ продукт";
            dg.Columns[2].HeaderText = "Количество";
            dg.Columns[3].HeaderText = "Валюта в долларах";
            dg.Columns[4].HeaderText = "Валюта в сомони";
            dg.Columns[5].HeaderText = "Дата";
            dg.Columns[6].HeaderText = "Цена продажи";
            dg.Columns[7].HeaderText = "№ фирмы";
            dg.Columns[8].HeaderText = "№ склада";
            dg.Columns[9].HeaderText= "Оплачено?";
        }

        public void DeleteData(int id)
        {
            Execute($"Delete from invoice where idInvoice = {id};");
        }
        public void InsertData(int idFirm,int idProduct, int idStorage,int quantity,decimal usd,decimal tjs,decimal sale,bool isPayed)
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(date);
            string query =
                "Insert into Invoice(idFirm, idProduct, idStorage, quantity, priceusd, pricetjs, date, sellingPrice, isPayed)" +
                $" values ({idFirm}, {idProduct}, {idStorage},{quantity},{usd},{tjs},'{date}',{sale},{(isPayed ? 1 : 0)})";
            Execute(query);
        }

        public void UpdateData(int idInvoice, int idFirm,int idProduct, int idStorage,int quantity,decimal usd,decimal tjs,decimal sale,bool isPayed)
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            string query =
                $"update Invoice set idFirm={idFirm}, idProduct={idProduct}, idStorage={idStorage}, quantity={quantity}, priceusd='{usd}', pricetjs='{tjs}', date='{date}', sellingPrice='{sale}', isPayed={(isPayed ? 1 : 0)} where idInvoice={idInvoice}";
            Execute(query);
        }

        public Dictionary<string, string> GetById(int id)
        {
            var res = new Dictionary<string, string>();
            var query = $@"select idInvoice, quantity, priceusd, pricetjs, sellingPrice, isPayed, idProduct, idStorage from invoice where idInvoice={id}";
            var dataReader = GetData(query);
            
            if (!dataReader.Read()) return res;
            res.Add("id",dataReader.GetInt32(0).ToString());
            res.Add("quantity",dataReader.GetInt32(1).ToString());
            res.Add("usd",dataReader.GetDecimal(2).ToString());
            res.Add("tjs",dataReader.GetDecimal(3).ToString());
            res.Add("sale",dataReader.GetDecimal(4).ToString());
            res.Add("isPayed",dataReader.GetInt32(5).ToString());
            res.Add("product",dataReader.GetDecimal(6).ToString());
            res.Add("storage",dataReader.GetDecimal(7).ToString());

            return res;
        }
    }
}
