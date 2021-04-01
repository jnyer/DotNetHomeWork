using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{

    class Goods
    {
        public string GoodsName { get; set; }
        public int GoodsPrice { get; set; }
        public Goods(string goodsname = null, int goodsprice = 0)
        {
            this.GoodsName = goodsname;
            this.GoodsPrice = goodsprice;
        }
        public override string ToString()
        {
            return $"goods name:{GoodsName}, goods price:{GoodsPrice} ";
        }
    }
}

