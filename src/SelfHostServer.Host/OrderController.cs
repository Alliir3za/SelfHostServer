using System.Collections.Generic;
using System.Web.Http;
using static SelfHostServer.Host.ProductController;

namespace SelfHostServer.Host
{
    public class OrderController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order{Id=1,Name="pro1",Category="Grocery",Price=1},
            new Order{Id=2,Name="Pro2",Category="Tosy",Price=3.75M},
            new Order{Id=3,Name="Pro3",Category="Hardware",Price=16.99M}
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }

    }


    //http://localhost:2727/api/Product
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1,Name="Tomato"},
            new Product{Id=2,Name="YoYo"},
            new Product{Id=3,Name="Hammer"}
        };

        [HttpGet]
        public IEnumerable<Product> All()
        {
            return products;
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
