using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllStudents students = new AllStudents();
            //foreach (var s in students)
            //    Console.WriteLine(s.Name);

            AllClients clients = new AllClients();
            //foreach (var c in clients)
            //    Console.WriteLine("Name: "+c.ClientName + ", City: " + c.City + ", Country: " + c.Country);

            AllOrderProducts orderProducts = new AllOrderProducts();
            //foreach (var op in orderProducts)
            //    Console.WriteLine("Product shipping date: "+op.DateOfShipping);

            AllOrders orders = new AllOrders();
            //foreach (var or in orders)
            //    Console.WriteLine("Order Numbers: "+or.OrderNumber);

            AllProducts products = new AllProducts();
            //foreach (var p in products)
            //    Console.WriteLine("Product\'s Name: "+p.ProductName);

            //var clientsIceland = from cli in clients
            //                     where cli.Country == Client.Countries.Iceland 
            //                     orderby cli.City
            //                     select cli;

            //foreach (var c in clientsIceland)
            //    Console.WriteLine("City: "+c.City+", Country: "+ c.Country);

            //var days = new DateTime(2019,4,1);
            //var latestOrder = from cli in clients
            //                  join o in orders on cli.Id equals o.ClientId
            //                  join op in orderProducts on o.Id equals op.OrderId
            //                  join p in products on op.ProductId equals p.Id

            //                  where op.DateOfShipping > days
            //                  orderby op.DateOfShipping
            //                  select new
            //                  {
            //                      op.DateOfShipping,
            //                      p.ProductName,
            //                      cli.ClientName
            //                  };
            //foreach (var n in latestOrder)
            //    Console.WriteLine("Date of shipping: "+ n.DateOfShipping);

            //string specificName = "Mouse";
            //var nameMouse = from cli in clients
            //                where cli.ClientName.Contains(specificName)
            //                orderby cli.City
            //                select cli;
            //foreach (var cc in nameMouse)
            //    Console.WriteLine("Client name: "+cc.ClientName+", client city: "+cc.City);

            //var notShipped = from op in orderProducts
            //                 join o in orders on op.OrderId equals o.Id
            //                 join p in products on op.ProductId equals p.Id
            //                 join cli in clients on o.ClientId equals cli.Id
            //                 where op.Shipped == false
            //                 orderby cli.ClientName

            //                 select new
            //                 {
            //                     cli.ClientName,
            //                     p.ProductName
            //                 };
            //foreach (var nn in notShipped)
            //    Console.WriteLine("Client\'s name: "+nn.ClientName+", product\'s name: "+nn.ProductName);

            var finnish = from cli in clients
                          join o in orders on cli.Id equals o.ClientId
                          join op in orderProducts on o.Id equals op.OrderId
                          join p in products on op.ProductId equals p.Id

                          where cli.Country == Client.Countries.Finland
                          orderby cli.ClientName
                          select new
                          {
                              cli.ClientName,
                              cli.City,
                              p.ProductName,
                              p.Price
                          };
            foreach (var f in finnish)
                Console.WriteLine("client\'s name: "+ f.ClientName+", client\'s city: "+f.City+", product\'s name: "+ f.ProductName+", product\'s price: "+f.Price);



        }
    }
}
