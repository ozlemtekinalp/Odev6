using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductCode = "1234";
            product1.ProductName = "Atkı";

            Product product2 = new Product();
            product2.ProductCode = "1235";
            product2.ProductName = "Bere";

            Product product3 = new Product();
            product3.ProductCode = "1236";
            product3.ProductName = "Kaşkol";

            Product[] Products = new Product[] { product1, product2, product3 };

            //foreach ile product listeleme

            foreach (var product in Products)
            {
                Console.WriteLine(product.ProductCode + "  : " + product.ProductName);
            }

            //for döngüsü ile product listeleme
           
            int i = new int();
            for ( i=0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i].ProductCode + "  : " + Products[i].ProductName);

            }

            //while döngüsü ile product listeleme

            int a= 0;
            while (a < Products.Length)
            {
                Console.WriteLine(Products[a].ProductCode + "  : " + Products[a].ProductName);
                a++; 
            }
        }
        

            class Product
        {
            public string ProductName { get; set; }
            public string ProductCode { get; set; }
        }
        }
    }

