using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        static Client client1 = new Client("a");
        static Client client2 = new Client("aa");
        static Client client3 = new Client("aaa");

        static Goods goods1 = new Goods("goods1", 1);
        static Goods goods2 = new Goods("goods2", 2);
        static Goods goods3 = new Goods("goods3", 3);

        static OrderDetails orderdetails1 = new OrderDetails(goods1, 1);
        static OrderDetails orderdetails2 = new OrderDetails(goods2, 2);
        static OrderDetails orderdetails3 = new OrderDetails(goods2, 3);

        static OrderDetails[] orderdetailss1 = { orderdetails1, orderdetails2 };
        static OrderDetails[] orderdetailss2 = { orderdetails1, orderdetails3 };
        static OrderDetails[] orderdetailss3 = { orderdetails1, orderdetails2, orderdetails3 };

        static Order order1 = new Order(1, client1, orderdetailss1);
        static Order order2 = new Order(2, client2, orderdetailss2);
        static Order order3 = new Order(3, client3, orderdetailss3);
        [TestMethod()]
        public void OrderServiceTest()
        {
            OrderService a = new OrderService();
            CollectionAssert.Equals(a, null);
        }

        [TestMethod()]
        public void OrderServiceTest2()
        {
            OrderService a = new OrderService(null);
            CollectionAssert.Equals(a, null);
        }

        [TestMethod()]
        public void AddTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order1);
            testorder.Add(order2);
            OrderService testord = new OrderService(testorder);
            testord.Add(order3);
            List<Order> resultorder = new List<Order>();
            resultorder.Add(order1);
            resultorder.Add(order2);
            resultorder.Add(order3);
            OrderService resultord = new OrderService(resultorder);
            CollectionAssert.Equals(testord, resultord);

        }

        [TestMethod()]
        public void DeleteTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order1);
            testorder.Add(order2);
            testorder.Add(order3);
            List<Order> resultorder = new List<Order>();
            resultorder.Add(order1);
            resultorder.Add(order2);
            OrderService testord = new OrderService(testorder);
            testord.Delete(3);
            OrderService resultord = new OrderService(resultorder);
            CollectionAssert.Equals(testord, resultord);
        }

        [TestMethod()]
        public void SortTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order2);
            testorder.Add(order1);
            testorder.Add(order3);
            List<Order> resultorder = new List<Order>();
            resultorder.Add(order1);
            resultorder.Add(order2);
            resultorder.Add(order3);
            OrderService testord = new OrderService(testorder);
            OrderService resultord = new OrderService(resultorder);
            CollectionAssert.Equals(testord, resultord);
        }

        [TestMethod()]
        public void GetByNumberTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order2);
            testorder.Add(order1);
            testorder.Add(order3);
            OrderService testord = new OrderService(testorder);
            Order a = testord.GetByNumber(2);
            CollectionAssert.Equals(a, order2);

        }

        [TestMethod()]
        public void GetByGoodsNameTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order2);
            testorder.Add(order1);
            testorder.Add(order3);
            OrderService testord = new OrderService(testorder);
            Order[] a = testord.GetByGoodsName("goods1");
            Order[] b = { order2, order1, order3 };
            CollectionAssert.Equals(a, b);
        }

        [TestMethod()]
        public void GetByClientTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order2);
            testorder.Add(order1);
            testorder.Add(order3);
            OrderService testord = new OrderService(testorder);
            Order a = testord.GetByClient("a");
            CollectionAssert.Equals(a, order1);
        }

        [TestMethod()]
        public void GetByOrderPriceTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order2);
            testorder.Add(order1);
            testorder.Add(order3);
            OrderService testord = new OrderService(testorder);
            Order[] a = testord.GetByOrderPrice(5);
            Order[] b = { order1 };
            CollectionAssert.Equals(a, b);

        }

        [TestMethod()]
        public void ToStringTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order2);
            testorder.Add(order1);
            testorder.Add(order3);
            OrderService testord = new OrderService(testorder);
            testord.ToString();
        }

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest()
        {
            List<Order> testorder = new List<Order>();
            testorder.Add(order2);
            testorder.Add(order1);
            testorder.Add(order3);
            OrderService testord = new OrderService(testorder);
            testord.Import();
        }

    }
}

namespace Honework6Tests8
{
    class OrderServiceTests
    {
    }
}
