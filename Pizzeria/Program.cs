using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public class Dish : IEquatable<Dish>
    {
        public string name { get; set; }

        public string extras { get; set; }

        public int quantity { get; set; }

        public string type { get; set; }

        public string price { get; set; }

        public string total_price { get; set; }


        public override string ToString()
        {
            return name + extras +" " + quantity +  "szt " + total_price + "zł";
        }

        public bool Equals(Dish other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
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
