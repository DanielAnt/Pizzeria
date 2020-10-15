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
    public partial class PizzaForm : Form
    {
        private string _pizzaName;
        private string _pizzaPrice;
        private Form1 _mainForm;
       

        public string PriceLabel
        {
            get
            {
                return Regex.Match(pizzaPriceLabel.Text, @"\d+").Value;
            }
            set
            {
                pizzaPriceLabel.Text = Convert.ToString(value) + "zł";

            }

        }

        public PizzaForm(Form1 aForm, string aPizza_name, string aPizza_price)
        {
            InitializeComponent();
            pizzaNameLabel.Text = aPizza_name + " - " + aPizza_price + "zł";
            _pizzaName = aPizza_name;
            _pizzaPrice = aPizza_price;
            _mainForm = aForm;
            LoadToppingCheckBox();
            RefreshPrice();
        }
        

        private void LoadToppingCheckBox()
        {
            SetCheckbox(firstPizzaToppingCheckbox);
            SetCheckbox(secondPizzaToppingCheckbox);
            SetCheckbox(thirdPizzaToppingCheckbox);
            SetCheckbox(fourthPizzaToppingCheckbox);
        }

        private void SetCheckbox(CheckBox checkbox)
        {
            string checkboxName = checkbox.Name.ToString();
            checkbox.Text = _mainForm.menuDictionary[checkboxName + "Name"] + " - " + _mainForm.menuDictionary[checkboxName + "Price"] + "zł";
        }

        private void addPizzaButton_Click(object sender, EventArgs e)
        {
            Dish newDish = new Dish();
            newDish.Name = _pizzaName;
            newDish.Price = Convert.ToString(Convert.ToInt32(PriceLabel) / Convert.ToInt32(quantityTextbox.Text));
            newDish.Quantity = Convert.ToInt32(quantityTextbox.Text);
            if (firstPizzaToppingCheckbox.Checked)
            {
                newDish.Extras += String.Format(" +{0} ", _mainForm.menuDictionary[firstPizzaToppingCheckbox.Name + "Name"]);
            }
            if (secondPizzaToppingCheckbox.Checked)
            {
                newDish.Extras += String.Format(" +{0} ",_mainForm.menuDictionary[secondPizzaToppingCheckbox.Name+"Name"]);
            }
            if (thirdPizzaToppingCheckbox.Checked)
            {
                newDish.Extras += String.Format(" +{0} ", _mainForm.menuDictionary[thirdPizzaToppingCheckbox.Name + "Name"]);
            }
            if (fourthPizzaToppingCheckbox.Checked)
            {
                newDish.Extras += String.Format(" +{0} ", _mainForm.menuDictionary[fourthPizzaToppingCheckbox.Name + "Name"]);
            }
            


            _mainForm.AddToListbox(newDish);
            
            this.Close();
        }

        private void RefreshPrice()
        {
            int extrasPrice = 0;
            if (firstPizzaToppingCheckbox.Checked)
            {
                extrasPrice += Convert.ToInt32(_mainForm.menuDictionary[firstPizzaToppingCheckbox.Name + "Price"]);
            }
            if (secondPizzaToppingCheckbox.Checked)
            {
                extrasPrice += Convert.ToInt32(_mainForm.menuDictionary[secondPizzaToppingCheckbox.Name + "Price"]);
            }
            if (thirdPizzaToppingCheckbox.Checked)
            {
                extrasPrice += Convert.ToInt32(_mainForm.menuDictionary[thirdPizzaToppingCheckbox.Name + "Price"]);
            }
            if (fourthPizzaToppingCheckbox.Checked)
            {
                extrasPrice += Convert.ToInt32(_mainForm.menuDictionary[fourthPizzaToppingCheckbox.Name + "Price"]);
            }
            
                        
            PriceLabel = Convert.ToString(Convert.ToInt32(quantityTextbox.Text) * (Convert.ToInt32(_pizzaPrice) + extrasPrice));
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
            if(Convert.ToInt32(quantityTextbox.Text) > 1)
            {
                quantityTextbox.Text = Convert.ToString(Convert.ToInt32(quantityTextbox.Text) - 1);
            }
            RefreshPrice();
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPrice();
        }
    }
}
