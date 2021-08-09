using System;
using System.Linq;
using LTCSDL_IT81_EF.Models;

namespace LTCSDL_IT81_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- LTCSDL- EF --------");
            NorthwindContext context = new NorthwindContext();

            //var cus = from c in context.Customers
            //          where c.Country == "UK"
            //          select c;

            //var cus1 = context.Customers
            //    .Where(x => x.Country == "UK");

            //foreach(var c in cus1)
            //{
            //    Console.WriteLine("------Start-----");
            //    Console.WriteLine("Ma KH: {0}", c.CustomerId.ToString());
            //    Console.WriteLine("Ten Cty: {0}", c.CompanyName);
            //    Console.WriteLine("Ten Nguoi dai dien: {0}", c.ContactName);
            //    Console.WriteLine("Quoc gia: {0}", c.Country);
            //    Console.WriteLine("------End-----");
            //}

            var lsPro = context.Products
                    .Where(x => x.UnitPrice < 15 && x.UnitsInStock > 50)
                    .ToList();
            var lst = lsPro
                .Join(context.Categories, a => a.CategoryId, b => b.CategoryId, (a, b) => new
                {
                    a.ProductId,
                    a.ProductName,
                    a.UnitPrice,
                    a.UnitsInStock,
                    a.CategoryId,
                    a.SupplierId,
                    b.CategoryName
                })
                .Join(context.Suppliers, a => a.SupplierId, b => b.SupplierId, (a, b) => new
                {
                    a.ProductId,
                    a.ProductName,
                    a.UnitPrice,
                    a.UnitsInStock,
                    a.CategoryId,
                    a.SupplierId,
                    a.CategoryName,
                    SupplierName = b.CompanyName,
                    SupplierCountry = b.Country
                });
            foreach (var p in lst)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",p.ProductId,p.ProductName, p.UnitPrice, p.UnitsInStock);
                Console.WriteLine("\tNhom nganh hang: {0}", p.CategoryName);
                Console.WriteLine("\tNCC: {0} - {1}", p.SupplierName, p.SupplierCountry);
                Console.WriteLine();
            }
        }
    }
}
