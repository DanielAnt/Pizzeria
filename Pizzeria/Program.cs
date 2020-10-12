using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public class Dish : IEquatable<Dish>
    {
        public string dish_name { get; set; }

        public string dish_extras { get; set; }

        public int dish_quantity { get; set; }

        public string dish_type { get; set; }

        public string dish_price { get; set; }


        public override string ToString()
        {
            return "";
        }

        public bool Equals(Dish other)
        {
            if (other == null) return false;
            return (this.dish_name.Equals(other.dish_name));
        }

    }

    public class Order
    {
        public int price { get; set; }

        public Order()
        {
            price = 0;
        }

        public void calculate_price()
        {
            price = 0;
        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
