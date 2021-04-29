using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class OrderService
    {
        public List<Order> Order = new List<Order>();
        public List<Order> MyOrder => Order;

        public OrderService() { }
        public OrderService(List<Order> order)
        {
            this.Order = order;
        }
        public void add(Order ord)                                      //增加订单
        {
            Order.Add(ord);
        }
        public void delete(int ordernumber)                              //删除某个订单
        {
            bool found = false;
            try
            {
                for (int i = 0; i < Order.Count; i++)
                {
                    if (Order[i].OrderId == ordernumber)
                    {
                        Order.RemoveAt(i);
                        found = true;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (found == false) throw new Exception("未找到订单");
        }
        public void sort()                                                //排序
        {
            Order.Sort((p1, p2) => p1.OrderId - p2.OrderId);
        }
        public Order getByNumber(int number)                              //按照订单编号查询
        {
            var query = from o in Order
                        where o.OrderId == number
                        select o;
            if (query == null) throw new Exception("未找到订单");
            List<Order> list = query.ToList();
            Order ord = (Order)list[0];
            return ord;
        }
        public Order getByGoodsName(string name)                          //按照商品名称查询
        {
            Order destiorder = null;
            foreach (Order ord in Order)
            {
                IEnumerable<OrderDetails> query = null;
                query = from o in ord.OrderDetails
                        where o.GoodsName == name
                        select o;
                if (query != null) destiorder = ord;
            }
            Order order = (Order)destiorder;
            return order;
        }
        public Order getByClient(string name)                              //按照客户名查询
        {
            var query = from o in Order
                        where o.OrderClient == name
                        select o;
            if (query == null) throw new Exception("未找到订单");
            Order order = (Order)query;
            return order;
        }
        public Order getByOrderPrice(int price)                           //按照订单价格查询
        {
            var query = from o in Order
                        where o.OrderSumPrice == price
                        select o;
            if (query == null) throw new Exception("未找到订单");
            Order order = (Order)query;
            return order;
        }
        public override string ToString()
        {
            string orderid = null;
            for(int i = 0; i < Order.Count; i++)
            {
                orderid += Order[i].OrderId;
            }
            return orderid;
        }
        
    }
}
