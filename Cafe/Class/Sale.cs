using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Class
{
    class Sale: Database
    {

        public Sale()
        {

        }
        public void DeleteData(int id)
        {
            Execute("Delete from sale where idSale = " + id.ToString() + " AND isPayed = 0;");
        }
        public void InsertData(double price, double count, int idProduct, int idUnit, int idUser, int idTable, bool isPayed = false)
        {
            string query = @"INSERT INTO sale (
                              price, `count`, idProduct,
                              idUnit, idUser, insertDate,
                              idTable, isPayed
                            ) 
                            VALUES
                              (
                                {0}, {1}, {2},
                                {3}, {4}, '{5}',
                                {6}, {7}
                              ) ;";
            string queryCommand = string.Format(query, price, count, idProduct, idUnit, idUser, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), idTable, isPayed);
          //  MessageBox.Show(queryCommand);
            Execute(queryCommand);
        }

        public void UpdateData(double price, double count, int idProduct, int idUnit, int idUser, int idTable, bool isPayed, int idSale)
        {
            string query = @"UPDATE 
                              sale 
                            SET
                              price = {0},
                              `count`= {1},
                              idProduct = {2},
                              idUnit = {3},
                              idUser = {4},
                              idTable = {5},
                              isPayed = {6}
                            WHERE idSale = {7};";
            string commandString = string.Format(query, price, count, idProduct, idUnit, idUser, idTable, isPayed, idSale);
            // MessageBox.Show(commandString);
            Execute(commandString);
        }

        public MySqlDataReader GetSaleByTableId(int IdTable)
        {
              string query = @"SELECT 
                              s.idSale,
                              s.idProduct,
                              p.product,
                              s.count,
                              u.unit,
                              s.price,
                              u.idUnit
                            FROM
                              sale s 
                              INNER JOIN product p 
                                ON s.idProduct = p.idProduct 
                              INNER JOIN unit u 
                                ON s.idUnit = u.idUnit 
                            WHERE s.idTable = " + IdTable.ToString() +
                            " /*AND s.isPayed*/ ;";
            MySqlDataReader reader = GetData(query);

            return reader;
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}
