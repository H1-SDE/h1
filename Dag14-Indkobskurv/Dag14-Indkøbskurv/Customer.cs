using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }





        public List<Product> Cart { get; set; }

        public void AddToCart(int id, Product product)
        {
            string data2;
            Data data1 = new Data();

            string filepath = "data/customers.json";

            Cart.Add(product);

            using (var sr = new StreamReader(filepath))
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

            File.WriteAllText("../../" + filepath, data2);
            File.WriteAllText(filepath, data2);

            if (product.Type == "ticket")
            {
                Console.WriteLine();
            }
        }
    }
}
