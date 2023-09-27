using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dag13_opgave4
{
    internal class PhotoBookTest : BigPhotoBook
    {
        public PhotoBookTest() 
        {
            PhotoBook default_photobook = new PhotoBook();
            Console.WriteLine(default_photobook.GetNumberPages());

            PhotoBook photobook_24 = new PhotoBook(24);
            Console.WriteLine(photobook_24.GetNumberPages());

            PhotoBook stor_album = new BigPhotoBook();
            Console.WriteLine(stor_album.GetNumberPages());
        }
    }
}
