using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class PizzaForm : Form
    {
        private string pizza_name;
        private string pizza_price;
        public PizzaForm()
        {
            InitializeComponent();
        }

        
        public void SetLabel(string aPizza_name, string aPizza_price)
        {
            pizza_label.Text = aPizza_name + " - " + aPizza_price +"zł";
            pizza_name = aPizza_name;
            pizza_price = aPizza_price;
            refresh_price();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void refresh_price()
        {
            int extras_price = 0;
            if (salami_checkbox.Checked)
            {
                extras_price += 2;
            }
            if (ham_checkbox.Checked)
            {
                extras_price += 2;
            }
            if (mushrooms_checkbox.Checked)
            {
                extras_price += 2;
            }
            if (cheese_checkbox.Checked)
            {
                extras_price += 2;
            }
                        
            pizza_price_label.Text = Convert.ToString(Convert.ToInt32(quantity_textbox.Text) * (Convert.ToInt32(pizza_price) + extras_price)) + "zł";
        }

        private void quantity_textbox_leave(object sender, EventArgs e)
        {
            if(!quantity_textbox.Text.All(char.IsDigit))
            {
                quantity_textbox.Text = "1";
            }

            if(quantity_textbox.Text.Count() < 1)
            {
                quantity_textbox.Text = "1";
            }
            refresh_price();
        }
        private void quantity_textbox_text_changed(object sender, EventArgs e)
        {
            if (quantity_textbox.Text.All(char.IsDigit) && quantity_textbox.Text.Count() > 0)
            {
                refresh_price();
            }
        }

        private void increase_button_Click(object sender, EventArgs e)
        {
            quantity_textbox.Text = Convert.ToString(Convert.ToInt32(quantity_textbox.Text) + 1);
            refresh_price();
        }

        private void decrease_button_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(quantity_textbox.Text) > 1)
            {
                quantity_textbox.Text = Convert.ToString(Convert.ToInt32(quantity_textbox.Text) - 1);
            }
            refresh_price();
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            refresh_price();
        }
    }
}
