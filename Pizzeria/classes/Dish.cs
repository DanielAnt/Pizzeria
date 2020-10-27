using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Dish : IEquatable<Dish>
    {
        public string Name { get; set; }

        public string Extras { get; set; }

        private int _quantity;

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                TotalPrice = Convert.ToString(Convert.ToInt32(_price) * _quantity);
            }
        }

        private string _price;
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                TotalPrice = Convert.ToString(Convert.ToInt32(_price) * _quantity);
            }
        }

        public string TotalPrice;


        public override string ToString()
        {
            return Name + Extras + " | " + _quantity + "szt | " + TotalPrice + "zł";
        }

        public bool Equals(Dish other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
}
