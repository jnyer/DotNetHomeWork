using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Homework6
{
    public class OrderService
    {
        List<Order> order = new List<Order>();
        public OrderService() { }
        public OrderService(List<Order> order)
        {
            this.order = order;
        }
        public void Add(Order ord)                                      //增加订单
        {
            order.Add(ord);
        }
        public void Delete(int ordernumber)                              //删除某个订单
        {
            bool found = false;
            try
            {
                for (int i = 0; i < order.Count; i++)
                {
                    if (order[i].OrderNumber == ordernumber)
                    {
                        order.RemoveAt(i);
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
        public void Sort()                                                //排序
        {
            order.Sort((p1, p2) => p1.OrderNumber - p2.OrderNumber);
        }
        public Order GetByNumber(int number)                              //按照订单编号查询
        {
            var query = from o in order
                        where o.OrderNumber == number
                        select o;
            if (query == null) throw new Exception("未找到订单");
            List<Order> list = query.ToList();
            Order ord = (Order)list[0];
            return ord;
        }
        public Order[] GetByGoodsName(string name)                          //按照商品名称查询
        {
            Order[] resultOrder = new Order[50];
            int i = 0;
            foreach (Order ord in order)
            {
                IEnumerable<OrderDetails> query = null;
                query = from o in ord.OrderDetails
                        where o.Goods.GoodsName == name
                        select o;
                if (query != null) resultOrder[i] = ord;
                i++;
            }
            return resultOrder;
        }
        public Order GetByClient(string name)                              //按照客户名查询
        {
            var query = from o in order
                        where o.OrderClient.ClientName == name
                        select o;
            if (query == null) throw new Exception("未找到订单");
            List<Order> list = query.ToList();
            Order ord = (Order)list[0];
            return ord;

        }
        public Order[] GetByOrderPrice(int price)                           //按照订单价格查询
        {
            foreach (Order ord in this.order)
            {
                ord.Calculate();
            }
            Order[] resultOrder = new Order[50];
            int i = 0;
            foreach (Order ord in order)
            {
                var query = false;
                query = (ord.OrderSumPrice == price);
                if (query == true) resultOrder[i] = ord;
                i++;
            }
            return resultOrder;
        }
        public override string ToString()
        {
            string orderid = null;
            for (int i = 0; i < order.Count; i++)
            {
                orderid += order[i].OrderNumber;
            }
            return orderid;
        }
        public void Export(string path) //TODO
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Create))
                xmlSerializer.Serialize(fs, order);
            Console.WriteLine("Serialize as XML: ");
            Console.WriteLine(File.ReadAllText("orderlist.xml"));

        }
        public void Import(string path) //TODO
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            try
            {
                using (FileStream fs = new FileStream("orderlist.xml", FileMode.Open))
                {
                    order = (List<Order>)xmlSerializer.Deserialize(fs);
                }
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            Console.WriteLine("Deserialize from XML: ");
            foreach (Order o in order)
            {
                Console.WriteLine(o);
            }
        }

    }
}
