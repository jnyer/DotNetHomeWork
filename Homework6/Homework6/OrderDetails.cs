using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class OrderDetails
    {
        public Goods Goods { get; set; }
        public int GoodsNumber { get; set; }
        public OrderDetails() { }
        public OrderDetails(Goods goods, int goodsNumber)
        {
            if (goodsNumber <= 0) throw new Exception("商品数量不能为负数");
            this.Goods = goods;
            this.GoodsNumber = goodsNumber;
        }
        public override string ToString()
        {
            return $"{Goods} ";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Goods>.Default.Equals(Goods, details.Goods) &&
                   GoodsNumber == details.GoodsNumber;
        }

        public override int GetHashCode()
        {
            var hashCode = -945225835;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
            hashCode = hashCode * -1521134295 + GoodsNumber.GetHashCode();
            return hashCode;
        }
    }
}
