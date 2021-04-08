using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Goods
    {
        public string GoodsName { get; set; }
        public int GoodsPrice { get; set; }
        public Goods() { }
        public Goods(string goodsname = null, int goodsprice = 0)
        {
            if (goodsprice < 0) throw new Exception("商品价格不能为负数");
            this.GoodsName = goodsname;
            this.GoodsPrice = goodsprice;
        }
        public override string ToString()
        {
            return $"goods name:{GoodsName}, goods price:{GoodsPrice}, ";
        }
    }
}

