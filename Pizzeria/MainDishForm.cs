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

        public MainDishForm(Form1 aForm, string aDish_name, string aDish_price)
        {
            InitializeComponent();
            dishNameLabel.Text = aDish_name + " - " + aDish_price + "zł";
            _dishName = aDish_name;
            _dishPrice = aDish_price;
            _mainForm = aForm;
            LoadExtrasCheckBox();
            RefreshPrice();
        }


        private void LoadExtrasCheckBox()
        {
            SetCheckbox(firstMainDishExtrasCheckbox);
            SetCheckbox(secondMainDishExtrasCheckbox);
        }

        private void SetCheckbox(CheckBox checkbox)
        {
            string checkboxName = checkbox.Name.ToString();
            checkbox.Text = _mainForm.menuDictionary[checkboxName + "Name"] + " - " + _mainForm.menuDictionary[checkboxName + "Price"] + "zł";
        }
                             

        private void RefreshPrice()
        {
            int extrasPrice = 0;
            if (firstMainDishExtrasCheckbox.Checked)
            {
                extrasPrice += Convert.ToInt32(_mainForm.menuDictionary[firstMainDishExtrasCheckbox.Name + "Price"]);
            }
            if (secondMainDishExtrasCheckbox.Checked)
            {
                extrasPrice += Convert.ToInt32(_mainForm.menuDictionary[secondMainDishExtrasCheckbox.Name + "Price"]);
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
            
            if (secondMainDishExtrasCheckbox.Checked)
            {
                newDish.Extras += String.Format(" +{0} ", _mainForm.menuDictionary[firstMainDishExtrasCheckbox.Name + "Name"]);
            }
            if (firstMainDishExtrasCheckbox.Checked)
            {
                newDish.Extras += String.Format(" +{0} ", _mainForm.menuDictionary[secondMainDishExtrasCheckbox.Name + "Name"]); ;
            }

            _mainForm.AddToListbox(newDish);

            this.Close();
        }

        
    }
}
