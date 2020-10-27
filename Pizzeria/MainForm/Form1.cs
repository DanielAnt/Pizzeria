using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Pizzeria
{
    public partial class Form1 : Form
    {

        public Dictionary<string, string> menuDictionary;

        public string TotalPrice
        {
            get 
            { 
                return Regex.Match(TotalPriceLabel.Text, @"\d+").Value;
            }
            set
            {
                TotalPriceLabel.Text = Convert.ToString(value) + "zł";
            }
        }        

        public Form1()
        {
            InitializeComponent();
            try
            {
                menuDictionary = Constants.LoadMenuJson();
                LoadLableNames();
                UpdateSumPrice();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Nie można wczytać nazw produktów");
                System.Environment.Exit(1);
                
            }
            
            
        }

        private void LoadLableNames()
        {
            SetLableName(firstPizzaLabel);
            SetLableName(secondPizzaLabel);
            SetLableName(thirdPizzaLabel);
            SetLableName(fourthPizzaLabel);
            SetLableName(firstMainDishLabel);
            SetLableName(secondMainDishLabel);
            SetLableName(thirdMainDishLabel);
            SetLableName(firstSoupLabel);
            SetLableName(secondSoupLabel);
            SetLableName(firstDrinkLabel);
            SetLableName(secondDrinkLabel);
            SetLableName(thirdDrinkLabel);
        }

        private void SetLableName(Label label)
        {
            string lableName = label.Text.ToString();
            label.Text = menuDictionary[lableName + "Name"] + " - " + menuDictionary[lableName + "Price"] + "zł";
        }

        private void UpdateSumPrice()
        {
            Timer timer = new Timer() { Interval = 200 };
            timer.Tick += (o, args) =>
            {
                TotalPrice = Convert.ToString(CalculateTotalPrice());
            };
            timer.Start();
        }

        private int CalculateTotalPrice()
        {
            int sumPrice = 0;
            foreach (Dish a in orderListbox.Items)
            {
                sumPrice += Convert.ToInt32(a.TotalPrice);
            }
            return sumPrice;
        }

        private string GetOrderList()
        {
            string[] items = orderListbox.Items
                .OfType<object>()
                .Select(item => item.ToString())
                .ToArray();
            string orderList = String.Join(" -- ", items);
            return orderList;
        }

        private void AddToListbox(string aName, string aPrice)
        {
            Dish newDish = new Dish() {
                Name = aName,
                Quantity = 1,
                Price = aPrice
            };
            if(orderListbox.FindString(newDish.Name) == -1)
            {
                orderListbox.Items.Add(newDish);
            }
            else
            {
                int selectedIndex = orderListbox.FindString(newDish.Name);
                Dish selectedDish = orderListbox.Items[selectedIndex] as Dish;
                selectedDish.Quantity++;
                orderListbox.Items.Remove(selectedDish);
                orderListbox.Items.Insert(selectedIndex, selectedDish);
            }
        }

        public void AddToListbox(Dish aDish)
        {
            if (orderListbox.FindString(aDish.Name + aDish.Extras + " |") == -1)
            {
                orderListbox.Items.Add(aDish);
            }
            else
            {
                int selectedIndex = orderListbox.FindString(aDish.Name + aDish.Extras + " |");
                Dish selectedDish = orderListbox.Items[selectedIndex] as Dish;
                selectedDish.Quantity += aDish.Quantity;
                orderListbox.Items.Remove(selectedDish);
                orderListbox.Items.Insert(selectedIndex, selectedDish);
            }
        }

        private void PizzaButton_Click(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            string tag = pressedButton.Tag.ToString();
            string pizzaName = menuDictionary[tag + "Name"];
            string pizzaPrice = menuDictionary[tag + "Price"];
            PizzaForm f2 = new PizzaForm(this, pizzaName, pizzaPrice);
            f2.ShowDialog();

        }
        
        private void MainDishButton_Click(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            string tag = pressedButton.Tag.ToString();
            string mainDishName = menuDictionary[tag + "Name"];
            string mainDishPrice = menuDictionary[tag + "Price"];
            MainDishForm f2 = new MainDishForm(this, mainDishName, mainDishPrice);
            f2.ShowDialog();
        }

        private void SideProductButton_Click(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            string tag = pressedButton.Tag.ToString();
            string sideProductName = menuDictionary[tag + "Name"];
            string sideProductPrice = menuDictionary[tag + "Price"];
            AddToListbox(sideProductName, sideProductPrice);

        }

        private void DeleteDishButton_Click(object sender, EventArgs e)
        {
            if(orderListbox.SelectedIndex != -1)
            {
                orderListbox.Items.Remove(orderListbox.SelectedItem);
            }
           
        }

        private void IncreaseDishQuantityButton_Click(object sender, EventArgs e)
        {
            if (orderListbox.SelectedIndex != -1)
            {
                Dish selectedDish = orderListbox.SelectedItem as Dish;
                selectedDish.Quantity++;
                int selectedIndex = orderListbox.SelectedIndex;
                orderListbox.Items.Remove(orderListbox.SelectedItem);
                orderListbox.Items.Insert(selectedIndex, selectedDish);
                orderListbox.SelectedIndex = selectedIndex;
            }
        
        }

        private void DecreaseDishQuantityButton_Click(object sender, EventArgs e)
        {
            if (orderListbox.SelectedIndex != -1)
            {
                Dish selectedDish = orderListbox.SelectedItem as Dish;
                if(selectedDish.Quantity > 1)
                {
                    selectedDish.Quantity--;
                    int selectedIndex = orderListbox.SelectedIndex;
                    orderListbox.Items.Remove(orderListbox.SelectedItem);
                    orderListbox.Items.Insert(selectedIndex, selectedDish);
                    orderListbox.SelectedIndex = selectedIndex;
                }
                else
                {
                    orderListbox.Items.Remove(orderListbox.SelectedItem);
                }
            }

        }
      
        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            if (orderListbox.Items.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz potwierdzić zamówienie?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EmailHandler.SendMessage(this, orderListbox.Items, commentsTextbox.Text);
                }
            }
            else
            {
                MessageBox.Show("Zamówienie jest puste");
            }
            
        }
     
        public void EmailHandlerSendMessage_Completed(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Nie udało się wysłać maila.\n" + e.Error.Message);
                DialogResult dialog_result = MessageBox.Show("Czy dodać zamówienie do bazy danych?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialog_result == DialogResult.Yes)
                {
                    HandleDatabase.SendToDatabase(GetOrderList(), commentsTextbox.Text, CalculateTotalPrice());
                }
                return;
            }
            MessageBox.Show("Wiadomość została wysłana do: " + Properties.Settings.Default.EmailTo);

            if(HandleDatabase.SendToDatabase(GetOrderList(), commentsTextbox.Text, CalculateTotalPrice()))
            {
                orderListbox.Items.Clear();
                commentsTextbox.Text = "";
                MessageBox.Show("Dodano zamówienie do bazy danych");
            }
            else
            {
                MessageBox.Show("Nie udało się dodać zamówienia do bazy danych");
            }
            
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings_form = new SettingsForm();
            settings_form.ShowDialog();
        }

        private void OrderHistoryButton_Click(object sender, EventArgs e)
        {
            OrderHistoryForm order_history_form = new OrderHistoryForm();
            order_history_form.Show();
        }
    }
}
