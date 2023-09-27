using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class Data
    {
        internal string filePathProducts = "data/Products.json";
        internal string filePathCustomers = "data/customers.json";

        public List<Product> GetProducts()
        {
            using (var sr = new StreamReader(filePathProducts))
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                string data = sr.ReadToEnd();

                return JsonSerializer.Deserialize<List<Product>>(data, options);
            }
        }

        public List<Customer> GetCustomers()
        {
            using (var sr = new StreamReader(filePathCustomers))
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                string data = sr.ReadToEnd();

                return JsonSerializer.Deserialize<List<Customer>>(data, options);
            }
        }
    }
}
