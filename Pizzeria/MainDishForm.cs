using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        private Form1 main_form;

        public string Price_Label
        {
            get
            {
                return Regex.Match(dish_price_label.Text, @"\d+").Value;
            }
            set
            {
                dish_price_label.Text = Convert.ToString(value) + "zł";

            }

        }

        public void SetLabel(Form1 aForm, string aDish_name, string aDish_price)
        {
            dish_label.Text = aDish_name + " - " + aDish_price + "zł";
            dish_name = aDish_name;
            dish_price = aDish_price;
            main_form = aForm;
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
           
            Price_Label = Convert.ToString(Convert.ToInt32(quantity_textbox.Text) * (Convert.ToInt32(dish_price) + extras_price));
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

        private void add_button_Click(object sender, EventArgs e)
        {
            Dish new_dish = new Dish();
            new_dish.name = dish_name;
            new_dish.Quantity = Convert.ToInt32(quantity_textbox.Text);
            new_dish.Price = Convert.ToString(Convert.ToInt32(Price_Label) / Convert.ToInt32(quantity_textbox.Text));
            
            if (sauces_checkbox.Checked)
            {
                new_dish.extras += " +zestaw sosów";
            }
            if (salads_checkbox.Checked)
            {
                new_dish.extras += " +bar sałatkowy";
            }

            if (main_form.order_listbox.FindString(new_dish.name + new_dish.extras + " |") == -1)
            {
                main_form.order_listbox.Items.Add(new_dish);
            }
            else
            {
                main_form.order_listbox.SetSelected(main_form.order_listbox.FindString(new_dish.name + new_dish.extras + " |"), true);
                Dish selected_dish = main_form.order_listbox.SelectedItem as Dish;
                selected_dish.Quantity += new_dish.Quantity;
                int sel_index = main_form.order_listbox.SelectedIndex;
                main_form.order_listbox.Items.Remove(main_form.order_listbox.SelectedItem);
                main_form.order_listbox.Items.Insert(sel_index, selected_dish);
            }

            this.Close();
        }
    }
}
