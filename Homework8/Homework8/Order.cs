using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework8
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderClient { get; set; }
        private List<OrderDetails> orderdetails;
        public List<OrderDetails> OrderDetails => orderdetails;
        public Order() { orderdetails = new List<OrderDetails>(); }
        public Order(int ordernumber, string orderclient, List<OrderDetails> orderdetails)
        {
            this.OrderId = ordernumber;
            this.OrderClient = orderclient;
            this.orderdetails = (orderdetails == null) ? new List<OrderDetails>() : orderdetails;
        }


        public int OrderSumPrice { get => orderdetails.Sum(orderdetails => orderdetails.TotalPrice); }

        public OrderDetails GetOrderDetails(int index)
        {
            return OrderDetails.Where(o => o.GoodsId == index).FirstOrDefault();
        }

        public void RemoveOrderDetails(OrderDetails orderdetails)
        {
            OrderDetails.Remove(orderdetails);
        }

        public void AddDetail(OrderDetails orderItem)
        {
            if (orderdetails.Contains(orderItem))
                throw new ApplicationException($"添加错误：订单项{orderItem.GoodsId} 已经存在!");
            orderdetails.Add(orderItem);
        }

        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderDetails orderdetail in OrderDetails)
            {
                details.Append(orderdetail.ToString());
            }
            return $"order number:{OrderId}, order client: {OrderClient}, order details: {details}. ";
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId &&
                   OrderClient == order.OrderClient &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(orderdetails, order.orderdetails) &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(OrderDetails, order.OrderDetails) &&
                   OrderSumPrice == order.OrderSumPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = -1737333573;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderClient);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(orderdetails);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(OrderDetails);
            hashCode = hashCode * -1521134295 + OrderSumPrice.GetHashCode();
            return hashCode;
        }
    }
}
