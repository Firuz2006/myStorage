using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Class
{
    internal class Product:Database
    {
        public string PATH = "images/product";
        public Product()
        {

        }

        public void LoadData(DataGridView dg)
        {
            string query = @"SELECT 
                              p.`idProduct`,
                              p.`product`,
                              cat.`category`,
                              u.`unit`,
                            FROM
                              product AS p
                              INNER JOIN category AS cat
                              ON p.`idCategory` = cat.`idCategory`
                              INNER JOIN unit AS u
                              ON p.`idUnit`  = u.`idUnit`";
            LoadData(dg, "product");
        }

        public void DeleteData(int id)
        {
            Execute("Delete from product where idProduct = " + id.ToString() + ";");
        }
        public void InsertData(string product, int  idCategory, int idUnit)
        {
            string query = "Insert into product(product, idCategory, idUnit) values" +
                           $"('{product}', '{idCategory}','{idUnit}')";
                MessageBox.Show(query);
                Execute(query);
            }
        public void UpdateData(int idProduct, string product, int idCategory, int idUnit)  
        {
            string query="";
            try
            {
                query = $"Update product set product  = '{product}' , idCategory = {idCategory}, idUnit = {idUnit} where idProduct={idProduct}";
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.ToString());
            }

        }

        public List<Item> GetProduct(int idCategory = 0)
        {
            List<Item> list = new List<Item>();
            try
            {
                string query = "Select idProduct, product from product";
                if (idCategory > 0)
                {
                    query += " and idCategory = " + idCategory;
                }
                query += " ORDER BY product";

                MySqlDataReader reader = GetData(query);
                while (reader.Read())
                {
                    list.Add(new Item(reader.GetInt16(0), reader.GetString(1)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.ToString());
            }

            // finally
            // {
                closeConnection();
            // }

            return list;
        }

        public IDictionary<string, string> GetProductById(int IdProduct)
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>();

            string query = @"SELECT 
                              p.idProduct,
                              p.product,
                              u.unit,
                              p.price,
                              u.idUnit
                            FROM
                              product p 
                              INNER JOIN unit u 
                                ON p.idUnit = u.idUnit 
                              /*INNER JOIN invoice_item ii 
                                ON p.idProduct = ii.idProduct 
                                AND (ii.count > 0 OR ii.count = -10)
                              */
                            AND p.status = 1
                            AND p.idProduct = " + IdProduct.ToString() +
                            " LIMIT 1;";
            MySqlDataReader reader = GetData(query);
            while (reader.Read())
            {
                dictionary.Add("productId", reader.GetInt16(0).ToString());
                dictionary.Add("productName", reader.GetString(1));
                dictionary.Add("productUnit", reader.GetString(2));
                dictionary.Add("productPrice", reader.GetDecimal(3).ToString());
                dictionary.Add("idUnit", reader.GetInt32(4).ToString());

            }
            closeConnection();
            return dictionary;
        }
    }
}
