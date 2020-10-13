using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Dish : IEquatable<Dish>
    {
        public string name { get; set; }

        public string extras { get; set; }

        private int quantity { get; set; }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                total_price = Convert.ToString(Convert.ToInt32(price) * quantity);
            }
        }

        public string type { get; set; }

        private string price;
        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                total_price = Convert.ToString(Convert.ToInt32(price) * quantity);
            }
        }

        public string total_price;


        public override string ToString()
        {
            return name + extras + " | " + quantity + "szt | " + total_price + "zł";
        }

        public bool Equals(Dish other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }
    }
}
