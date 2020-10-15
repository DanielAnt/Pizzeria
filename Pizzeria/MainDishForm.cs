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
        private string _dishName;
        private string _dishPrice;
        private Form1 _mainForm;

        public string PriceLabel
        {
            get
            {
                return Regex.Match(dishPriceLabel.Text, @"\d+").Value;
            }
            set
            {
                dishPriceLabel.Text = Convert.ToString(value) + "zł";

            }

        }

        public void SetLabel(Form1 aForm, string aDish_name, string aDish_price)
        {
            dishNameLabel.Text = aDish_name + " - " + aDish_price + "zł";
            _dishName = aDish_name;
            _dishPrice = aDish_price;
            _mainForm = aForm;
            RefreshPrice();
        }


        private void RefreshPrice()
        {
            int extrasPrice = 0;
            if (saucesCheckbox.Checked)
            {
                extrasPrice += 6;
            }
            if (saladCheckbox.Checked)
            {
                extrasPrice += 5;
            }
           
            PriceLabel = Convert.ToString(Convert.ToInt32(quantityTextbox.Text) * (Convert.ToInt32(_dishPrice) + extrasPrice));
        }

        private void quantityTextbox_Leave(object sender, EventArgs e)
        {
            if (!quantityTextbox.Text.All(char.IsDigit) || quantityTextbox.Text.Count() < 1 || Convert.ToInt32(quantityTextbox.Text) < 1)
            {
                quantityTextbox.Text = "1";
            }
            RefreshPrice();
        }
        private void quantityTextbox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextbox.Text.All(char.IsDigit) && quantityTextbox.Text.Count() > 0)
            {
                RefreshPrice();
            }
        }

        private void increaseQuantityButton_Click(object sender, EventArgs e)
        {
            quantityTextbox.Text = Convert.ToString(Convert.ToInt32(quantityTextbox.Text) + 1);
            RefreshPrice();
        }

        private void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(quantityTextbox.Text) > 1)
            {
                quantityTextbox.Text = Convert.ToString(Convert.ToInt32(quantityTextbox.Text) - 1);
            }
            RefreshPrice();
        }

        private void checkboxCheckedChanged(object sender, EventArgs e)
        {
            RefreshPrice();
        }

        private void addDishButton_Click(object sender, EventArgs e)
        {
            Dish newDish = new Dish();
            newDish.Name = _dishName;
            newDish.Quantity = Convert.ToInt32(quantityTextbox.Text);
            newDish.Price = Convert.ToString(Convert.ToInt32(PriceLabel) / Convert.ToInt32(quantityTextbox.Text));
            
            if (saucesCheckbox.Checked)
            {
                newDish.Extras += " +zestaw sosów";
            }
            if (saladCheckbox.Checked)
            {
                newDish.Extras += " +bar sałatkowy";
            }

            _mainForm.AddToListbox(newDish);

            this.Close();
        }
    }
}
