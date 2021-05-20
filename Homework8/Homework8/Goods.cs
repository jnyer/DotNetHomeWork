using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Goods
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods()
        {
        }

        public Goods(string iD, string name, double price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   ID == goods.ID &&
                   Name == goods.Name &&
                   Price == goods.Price;
        }

        public override int GetHashCode()
        {
            var hashCode = 560300832;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
