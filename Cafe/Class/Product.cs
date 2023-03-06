using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Class
{
    internal class Product:Database
    {
        public void LoadDataByCategory(DataGridView dg,int catId)
        {
            var query = @$"select 
                                p.idProduct,
                                p.product,
                                u.unit
                            from
                                category as c,
                                product as p,
                                unit as u
                            where
                                u.idUnit=p.idUnit and p.idCategory={catId}";
            LoadData(dg ,"product",query);
            
        }
        public void LoadData(DataGridView dg)
        {
            const string query = @"SELECT 
                              p.`idProduct`,
                              p.`product`,
                              cat.`category`,
                              u.`unit`
                            FROM
                              product AS p
                              INNER JOIN category AS cat
                              ON p.`idCategory` = cat.`idCategory`
                              INNER JOIN unit AS u
                              ON p.`idUnit`  = u.`idUnit`";
            LoadData(dg, "product",query);
        }

        public void DeleteData(int id)
        {
            Execute($"Delete from product where idProduct = {id};");
        }
        public void InsertData(string product, int  idCategory, int idUnit)
        {
            string query = "Insert into product(product, idCategory, idUnit) values" +
                           $"('{product}', '{idCategory}','{idUnit}')";
                Execute(query);
            }
        public void UpdateData(int idProduct, string product, int idCategory, int idUnit)  
        {
            try
            {
                var query=$"Update product set product  = '{product}' , idCategory = {idCategory}, idUnit = {idUnit} where idProduct={idProduct}";
                Execute(query);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception);
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
                MessageBox.Show("Error: " + exception);
            }

            // finally
            // {
                CloseConnection();
            // }

            return list;
        }

        public IDictionary<string, string> GetProductById(int idProduct)
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>();

            string query = $"select p.idUnit, p.idCategory from product as p where p.idProduct={idProduct}";
                
            var reader = GetData(query);
            while (reader.Read())
            {
                dictionary.Add("idUnit", reader.GetString(0));
                dictionary.Add("idCategory", reader.GetDecimal(1).ToString());

            }
            CloseConnection();
            return dictionary;
        }
    }
}
