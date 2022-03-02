using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product ürün1 = new Product();
            ürün1.ShoeBrand = "Nike";
            ürün1.ShoeSize = "45";

            Product ürün2 = new Product();
            ürün2.TshirtBrand = "POLO";
            ürün2.TshirtBodySize = "XL";

            Console.WriteLine("Brand : " + ürün1.ShoeBrand + ", Size : " + ürün1.ShoeSize);
            Console.WriteLine("Brand : " + ürün2.TshirtBrand + ", Body Size : " + ürün2.TshirtBodySize);

            Console.ReadKey();
        }
    }

    class Product
    {
        public string ShoeSize { get; set; }
        public string ShoeBrand { get; set; }
        public string TshirtBrand { get; set; }
        public string TshirtBodySize { get; set; }
    }

}
