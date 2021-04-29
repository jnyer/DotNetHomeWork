using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class OrderDetails
    {
        public int GoodsId { get; set; }
        public string GoodsName { get ; set; }
        public int GoodsNumber { get; set; }
        public int GoodsPrice { get; set; }
        public OrderDetails() { }
        public OrderDetails(string goodsName, int goodsNumber,int goodsprice,int goodsid)
        {
            GoodsName = goodsName;
            GoodsNumber = goodsNumber;
            GoodsPrice = goodsprice;
            GoodsId = goodsid;
        }
        public int TotalPrice { get => GoodsNumber * GoodsPrice; }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   GoodsName == details.GoodsName &&
                   GoodsNumber == details.GoodsNumber &&
                   GoodsPrice == details.GoodsPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = 234505180;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + GoodsNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + GoodsPrice.GetHashCode();
            return hashCode;
        }
    }
}
