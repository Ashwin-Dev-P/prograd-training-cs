using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook.Tests
{
    [TestClass()]
    public class PhotoBookTests
    {
        [TestMethod()]
        public void PhotoBookTest()
        {

            PhotoBook photobook = new PhotoBook();
            Console.WriteLine($"The number of pages is: {photobook.GetNumberPages()}");

            Assert.AreEqual(photobook.GetNumberPages(), 16);
            return;
            
        }

        [TestMethod()]
        public void PhotoBookTest2()
        {


            PhotoBook photobook2 = new PhotoBook(32);
            Console.WriteLine($"The number of pages is: {photobook2.GetNumberPages()}");

            
            Assert.AreEqual(photobook2.GetNumberPages(), 32);
            return;
            
        }

        [TestMethod()]
        public void PhotoBookTest3()
        {

           

            PhotoBook largePhotobook = new PhotoBook(2000);
            Console.WriteLine($"The number of pages is: {largePhotobook.GetNumberPages()}");

            
            Assert.AreEqual(largePhotobook.GetNumberPages(), 2000);
            return;
           
        }
    }
}