using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Class
{
    class InvoiceItem: Database
    {

        public void LoadData(DataGridView dg, int idInvoice)
        {
            LoadData(dg, "Invoice_item", @"SELECT 
                                          it.idInvoiceItem,
                                          it.idInvoice,
                                          p.product,
                                          it.price,
                                          it.count,
                                          u.unit,
                                          it.price*it.count as sum
                                        FROM
                                          invoice_item it 
                                          INNER JOIN invoice i 
                                            ON it.idInvoice = i.idInvoice 
                                          INNER JOIN product p 
                                            ON it.idProduct = p.idProduct 
                                          INNER JOIN unit u 
                                            ON it.idUnit = u.idUnit 
                                        WHERE i.idInvoice = " + idInvoice.ToString()+";");
        }

        public void LoadAllData(DataGridView dg)
        {
            LoadData(dg, "Invoice_item", @"SELECT 
                                          it.idInvoiceItem,
                                          it.idInvoice,
                                          p.product,
                                          it.price,
                                          it.count,
                                          u.unit
                                        FROM
                                          invoice_item it 
                                          INNER JOIN invoice i 
                                            ON it.idInvoice = i.idInvoice 
                                          INNER JOIN product p 
                                            ON it.idProduct = p.idProduct 
                                          INNER JOIN unit u 
                                            ON it.idUnit = u.idUnit
                                          ORDER BY it.idInvoice;");
        }

        public void DeleteData(int id)
        {
            Execute("Delete from Invoice_item where idInvoiceItem = " + id.ToString() + ";");
        }

        public void InsertData(int idInvoice, int idProduct, decimal price, int count, int idUnit)
        {
            string query = "Insert into Invoice_item(idInvoice, idProduct, price, `count`, idUnit)" +
                           " values ({0}, {1}, {2}, {3}, {4});";
            string queryCommand = string.Format(query, idInvoice, idProduct, 
                                  price.ToString().Replace(",", "."), count, idUnit);
            MessageBox.Show(queryCommand);
            Execute(queryCommand);
        }

        public void UpdateData(int idInvoiceItem, int idInvoice, int idProduct, decimal price, int count, int idUnit)
        {
            string query = "Update Invoice set idInvoice = {0} , idProduct = {1}, price = {2} " +
                            "`count` = {3}, idUnit = {4} Where idInvoiceItem = {5};";
            string commandString = string.Format(query, idInvoice, idProduct,
                                  price.ToString().Replace(",", "."), count, idUnit, idInvoiceItem);
            MessageBox.Show(commandString);
            Execute(commandString);
        }
    }
}
