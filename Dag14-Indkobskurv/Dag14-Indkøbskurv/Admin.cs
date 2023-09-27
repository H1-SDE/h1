using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class Admin
    {
        public List<Product> products { get; set; }
        public List<Customer> customers { get; set; }
        public string filePath = "data/customers.json";

        public void EditProduct(int id, Product product) 
        {
            string data2;
            Data data1 = new Data();

            products.Add(product);

            using (var sr = new StreamReader(filePath))
            {
                string raw_data = sr.ReadToEnd();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var data = JsonSerializer.Deserialize<List<Customer>>(raw_data, options);

                foreach (var i in data1.GetCustomers())
                {
                    if (id == i.Id)
                    {
                        data[id].Cart.Add(product);
                    }
                }

                data2 = JsonSerializer.Serialize(data);

            }

            File.WriteAllText("../../" + filePath, data2);
            File.WriteAllText(filePath, data2);

        }

        public void EditCostumer(int id, Customer customer)
        {
            //string data2;
            Data data1 = new Data();

            //Cart.Add(product);

        }
    }
}
