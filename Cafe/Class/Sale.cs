using System;
using System.Windows.Forms;

namespace Cafe.Class
{


namespace Cafe.Class
{
    class Sale: Database
    {
        public Sale()
        {

        }

        public void LoadData(DataGridView dg)
        {
            LoadData(dg, "Sale");
            dg.Columns[0].HeaderText = "№";
            dg.Columns[1].HeaderText= "№ продукт";
            dg.Columns[2].HeaderText = "Количество";
            dg.Columns[3].HeaderText = "Валюта в долларах";
            dg.Columns[4].HeaderText = "Валюта в сомони";
            dg.Columns[5].HeaderText = "Дата";
            // dg.Columns[6].HeaderText = "Цена продажи";
            dg.Columns[6].HeaderText = "№ фирмы";
            dg.Columns[7].HeaderText = "№ склада";
            // dg.Columns[9].HeaderText= "Оплачено?";
        }

        public void DeleteData(int id)
        {
            Execute("Delete from invoice where idInvoice = " + id.ToString() + ";");
        }
        public void InsertData(int idProduct, int idStorage,int quantity,decimal usd,decimal tjs,bool isPayed)
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(date);
            string query =
                "Insert into Sale(idProduct, idStorage, quantity, priceusd, pricetjs, date, isPayed)" +
                $" values ({idProduct}, {idStorage},{quantity},{usd},{tjs},'{date}',{(isPayed ? 1 : 0)})";
            Execute(query);
        }

        public void UpdateData(int idSale,int idProduct, int idStorage,int quantity,decimal usd,decimal tjs,bool isPayed)
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            string query =
                $"update Invoice set idProduct={idProduct}, idStorage={idStorage}, quantity={quantity}, priceusd='{usd}', pricetjs='{tjs}', date='{date}', isPayed={(isPayed ? 1 : 0)}) where idInvoice={idSale}";
            Execute(query);
        }
    }
}

}
