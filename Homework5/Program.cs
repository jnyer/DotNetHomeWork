using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods goods1 = new Goods("football", 1);                                          //测试数据
            Goods goods2 = new Goods("basketball", 2);
            Goods goods3 = new Goods("volleyball", 3);
            Goods goods4 = new Goods("water", 4);
            Goods goods5 = new Goods("chocolate", 5);

            Client client1 = new Client("a");
            Client client2 = new Client("aa");
            Client client3 = new Client("aaa");

            OrderDetails OrderDetails1 = new OrderDetails(goods1, 1);
            OrderDetails OrderDetails2 = new OrderDetails(goods2, 2);
            OrderDetails OrderDetails3 = new OrderDetails(goods3, 3);
            OrderDetails OrderDetails4 = new OrderDetails(goods4, 4);
            OrderDetails OrderDetails5 = new OrderDetails(goods5, 5);

            OrderDetails[] OrderDetailss1 = { OrderDetails1, OrderDetails5 };
            OrderDetails[] OrderDetailss2 = { OrderDetails2, OrderDetails3 };
            OrderDetails[] OrderDetailss3 = { OrderDetails2, OrderDetails3, OrderDetails4 };

            Order order1 = new Order(1, client1, OrderDetailss1);
            Order order2 = new Order(2, client2, OrderDetailss2);
            Order order3 = new Order(3, client3, OrderDetailss3);
            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);
            Console.WriteLine($"当前保存的订单编号序列: {orderService}");
            Console.WriteLine($"查询订单编号为1的订单并输出订单信息： {orderService.getByNumber(1)}");
            orderService.sort();
            Console.WriteLine($"默认排序后的订单编号序列: {orderService}");
            Console.WriteLine("删除订单编号为3的订单");
            orderService.delete(3);
            Console.WriteLine($"当前保存的订单编号序列: {orderService}");
        }
    }
}

