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
    public partial class MainDishForm : Form
    {
        public MainDishForm()
        {
            InitializeComponent();
        }
        private string dish_name;
        private string dish_price;
       
        public void SetLabel(string aDish_name, string aDish_price)
        {
            dish_label.Text = aDish_name + " - " + aDish_price + "zł";
            dish_name = aDish_name;
            dish_price = aDish_price;
            refresh_price();
        }

        

        private void refresh_price()
        {
            int extras_price = 0;
            if (sauces_checkbox.Checked)
            {
                extras_price += 6;
            }
            if (salads_checkbox.Checked)
            {
                extras_price += 5;
            }
           

            dish_price_label.Text = Convert.ToString(Convert.ToInt32(quantity_textbox.Text) * (Convert.ToInt32(dish_price) + extras_price)) + "zł";
        }

        private void quantity_textbox_leave(object sender, EventArgs e)
        {
            if (!quantity_textbox.Text.All(char.IsDigit) || quantity_textbox.Text.Count() < 1 || Convert.ToInt32(quantity_textbox.Text) < 1)
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
            if (Convert.ToInt32(quantity_textbox.Text) > 1)
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
