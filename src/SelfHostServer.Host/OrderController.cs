using System.Collections.Generic;
using System.Web.Http;
using static SelfHostServer.Host.ProductController;

namespace SelfHostServer.Host
{
    public class OrderController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order{Id=1,Name="Tomato",Category="Grocery",Price=1},
            new Order{Id=2,Name="YoYo",Category="Tosy",Price=3.75M},
            new Order{Id=3,Name="Hammer",Category="Hardware",Price=16.99M}
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
            new Product{Id=1,Name="Pro1"},
            new Product{Id=2,Name="Pro2"},
            new Product{Id=3,Name="Pro3"}
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
