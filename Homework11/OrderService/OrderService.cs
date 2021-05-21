using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{

    /**
     * The service class to manage orders
     * */
    public class OrderService
    {

        //the order list
        //private List<Order> orders;

        public OrderService()
        {
            using (var context = new OrderContext())
            {
                if (context.Goods.Count() == 0)
                {
                    context.Goods.Add(new Goods("apple", 100.0));
                    context.Goods.Add(new Goods("egg", 200.0));
                    context.SaveChanges();
                }
                if (context.Customers.Count() == 0)
                {
                    context.Customers.Add(new Customer("li"));
                    context.Customers.Add(new Customer("zhang"));
                    context.SaveChanges();
                }
            }
        }

        public List<Order> Orders
        {
            get
            {
                using (var context = new OrderContext())
                {
                    return context.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer").
                      ToList<Order>();
                }
            }
        }

        public Order GetOrder(string id)
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                  .SingleOrDefault(o => o.OrderId == id);
            }
        }

        public void AddOrder(Order order)
        {
            FixOrder(order);
            using (var context = new OrderContext())
            {
                context.Entry(order).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void RemoveOrder(string orderId)
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.Include("Details").SingleOrDefault(o => o.OrderId == orderId);
                if (order == null) return;
                context.OrderDetails.RemoveRange(order.Details);
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                    .Where(order => order.Details.Any(item => item.GoodsItem.Name == goodsName));
                return query.ToList();
            }
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                  .Where(order => order.Customer.Name == customerName).ToList();
                //.OrderBy(o => o.TotalPrice)
            }
        }

        public void UpdateOrder(Order newOrder)
        {
            RemoveOrder(newOrder.OrderId);
            AddOrder(newOrder);
        }

        //避免级联添加或修改Customer和Goods
        private static void FixOrder(Order newOrder)
        {
            newOrder.CustomerId = newOrder.Customer.Id;
            newOrder.Customer = null;
            newOrder.Details.ForEach(d =>
            {
                d.GoodsId = d.GoodsItem.Id;
                d.GoodsItem = null;
            });
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (var context = new OrderContext())
                {
                    List<Order> temp = (List<Order>)xs.Deserialize(fs);
                    temp.ForEach(order =>
                    {
                        if (context.Orders.SingleOrDefault(o => o.OrderId == order.OrderId) == null)
                        {
                            FixOrder(order);
                            context.Orders.Add(order);
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        public object QueryByTotalAmount(float amout)
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                .Where(order => order.Details.Sum(d => d.Quantity * d.GoodsItem.Price) > amout)
                .ToList();
            }
        }
    }
}
