using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public Client OrderClient { get; set; }
        public OrderDetails[] OrderDetails { get; set; }
        public int OrderSumPrice { get; set; }
        public Order() { }
        public Order(int ordernumber = 0, Client orderclient = null, OrderDetails[] orderdetails = null)
        {
            this.OrderNumber = ordernumber;
            this.OrderClient = orderclient;
            this.OrderDetails = orderdetails;
        }
        public void Calculate()
        {
            foreach (OrderDetails orderdetail in OrderDetails)
            {
                OrderSumPrice += (orderdetail.Goods.GoodsPrice) * (orderdetail.GoodsNumber);
            }
        }
        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderDetails orderdetail in OrderDetails)
            {
                details.Append(orderdetail.ToString());
            }
            return $"order number:{OrderNumber}, order client: {OrderClient}, order details: {details}. ";
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderNumber == order.OrderNumber &&
                   EqualityComparer<Client>.Default.Equals(OrderClient, order.OrderClient) &&
                   EqualityComparer<OrderDetails[]>.Default.Equals(OrderDetails, order.OrderDetails) &&
                   OrderSumPrice == order.OrderSumPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = 2045822872;
            hashCode = hashCode * -1521134295 + OrderNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(OrderClient);
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderDetails[]>.Default.GetHashCode(OrderDetails);
            hashCode = hashCode * -1521134295 + OrderSumPrice.GetHashCode();
            return hashCode;
        }
    }
}
