using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class Product
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public Stopwatch watch = Stopwatch.StartNew();
    }
}
