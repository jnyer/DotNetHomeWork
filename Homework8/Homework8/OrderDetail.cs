using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class OrderDetail
    {

        public uint OrderID { get; set; } //序号

        public Goods GoodsItem { get; set; }

        public String GoodsName { get => GoodsItem != null ? this.GoodsItem.Name : ""; }

        public double UnitPrice { get => GoodsItem != null ? this.GoodsItem.Price : 0.0; }


        public uint Quantity { get; set; }

        public OrderDetail() { }

        public OrderDetail(uint index, Goods goods, uint quantity)
        {
            this.OrderID = index;
            this.GoodsItem = goods;
            this.Quantity = quantity;
        }

        public double TotalPrice
        {
            get => GoodsItem == null ? 0.0 : GoodsItem.Price * Quantity;
        }

        public override string ToString()
        {
            return $"[No.:{OrderID},goods:{GoodsName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   OrderID == detail.OrderID &&
                   EqualityComparer<Goods>.Default.Equals(GoodsItem, detail.GoodsItem) &&
                   GoodsName == detail.GoodsName &&
                   UnitPrice == detail.UnitPrice &&
                   Quantity == detail.Quantity &&
                   TotalPrice == detail.TotalPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = -1589312376;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(GoodsItem);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + UnitPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            return hashCode;
        }
    }
}
