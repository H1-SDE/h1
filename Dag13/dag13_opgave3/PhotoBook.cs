using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dag13_opgave4
{
    internal class PhotoBook
    {
        public int numPages { get; set; }

        public int GetNumberPages()
        {
            return numPages;
        }

        public PhotoBook() 
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
    }
}
