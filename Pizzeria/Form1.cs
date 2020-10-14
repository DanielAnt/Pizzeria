using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Pizzeria
{
    public partial class Form1 : Form
    {

        public string Total_Price
        {
            get 
            { 
                return Regex.Match(sum_price_label.Text, @"\d+").Value;
            }
            set
            {
                sum_price_label.Text = Convert.ToString(value) + "zł";
            }
        }
        

        public Form1()
        {
            InitializeComponent();
            update_sum_price_label();
        }

        private void update_sum_price_label()
        {
            Timer timer = new Timer() { Interval = 200 };
            timer.Tick += (o, args) =>
            {
                Total_Price = Convert.ToString(calculate_total_price());
            };
            timer.Start();
        }

        private int calculate_total_price()
        {
            int sum_price = 0;
            foreach (Dish a in order_listbox.Items)
            {
                sum_price += Convert.ToInt32(a.total_price);
            }
            return sum_price;
        }

        private string get_order_list()
        {
            string[] items = order_listbox.Items
                .OfType<object>()
                .Select(item => item.ToString())
                .ToArray();
            string order_list = String.Join(" - ", items);
            return order_list;
        }

        private void add_to_listbox(string aName, int aQuantity, string aPrice)
        {
            Dish new_dish = new Dish();
            new_dish.name = aName;
            new_dish.Quantity = aQuantity;
            new_dish.Price = aPrice;
            if(order_listbox.FindString(new_dish.name) == -1)
            {
                order_listbox.Items.Add(new_dish);
            }
            else
            {
                order_listbox.SetSelected(order_listbox.FindString(new_dish.name), true);
                Dish selected_dish = order_listbox.SelectedItem as Dish;
                selected_dish.Quantity++;
                int sel_index = order_listbox.SelectedIndex;
                order_listbox.Items.Remove(order_listbox.SelectedItem);
                order_listbox.Items.Insert(sel_index, selected_dish);
            }
        }
          

        private void margarita_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel(this, "Margarita", "20");
            f2.ShowDialog();

        }

        private void vegetariana_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel(this, "Vegetariana", "22");
            f2.ShowDialog();

        }

        private void tosca_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel(this, "Tosca", "25");
            f2.ShowDialog();

        }

        private void venecia_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel(this, "Venecia", "25");
            f2.ShowDialog();
        }

        private void schnitzel_button_Click(object sender, EventArgs e)
        {
            MainDishForm f2 = new MainDishForm();
            f2.SetLabel(this, "Schabowy z frytkami / ryżem / ziemniakami", "30");
            f2.ShowDialog();
        }

        private void fish_button_Click(object sender, EventArgs e)
        {
            MainDishForm f2 = new MainDishForm();
            f2.SetLabel(this, "Ryba z frytkami", "28");
            f2.ShowDialog();
        }

        private void fritter_button_Click(object sender, EventArgs e)
        {
            MainDishForm f2 = new MainDishForm();
            f2.SetLabel(this, "Placek po węgiersku", "27");
            f2.ShowDialog();
        }

        private void tomateo_soup_button_Click(object sender, EventArgs e)
        {
            add_to_listbox("Zupa pomidorowa", 1, "12");

        }

        private void broth_button_Click(object sender, EventArgs e)
        {
            add_to_listbox("Rosół", 1, "10");
        }

        private void coffe_button_Click(object sender, EventArgs e)
        {
            add_to_listbox("Kawa", 1, "5");
        }

        private void tea_button_Click(object sender, EventArgs e)
        {
            add_to_listbox("Herbata", 1, "5");
        }

        private void cola_button_Click(object sender, EventArgs e)
        {
            add_to_listbox("Cola", 1, "5");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if(order_listbox.SelectedIndex != -1)
            {
                order_listbox.Items.Remove(order_listbox.SelectedItem);
            }
           
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (order_listbox.SelectedIndex != -1)
            {
                Dish selected_dish = order_listbox.SelectedItem as Dish;
                selected_dish.Quantity++;
                int sel_index = order_listbox.SelectedIndex;
                order_listbox.Items.Remove(order_listbox.SelectedItem);
                order_listbox.Items.Insert(sel_index, selected_dish);
                order_listbox.SelectedIndex = sel_index;
            }
        
        }

        private void subtract_button_Click(object sender, EventArgs e)
        {
            if (order_listbox.SelectedIndex != -1)
            {
                Dish selected_dish = order_listbox.SelectedItem as Dish;
                if(selected_dish.Quantity > 1)
                {
                    selected_dish.Quantity--;
                    int selected_index = order_listbox.SelectedIndex;
                    order_listbox.Items.Remove(order_listbox.SelectedItem);
                    order_listbox.Items.Insert(selected_index, selected_dish);
                    order_listbox.SelectedIndex = selected_index;
                }
                else
                {
                    order_listbox.Items.Remove(order_listbox.SelectedItem);
                }
            }

        }
      
        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (order_listbox.Items.Count > 0)
            {
                DialogResult dialog_result = MessageBox.Show("Czy chcesz potwierdzić zamówienie?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialog_result == DialogResult.Yes)
                {
                    EmailHandler.send_message(this, order_listbox.Items, comments_textbox.Text);
                }
            }
            else
            {
                MessageBox.Show("Zamówienie jest puste");
            }
            
        }

       
        public void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Nie udało się wysłać maila.\n" + e.Error.Message);
                DialogResult dialog_result = MessageBox.Show("Czy dodać zamówienie do bazy danych?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialog_result == DialogResult.Yes)
                {
                    HandleDatabase.send_to_database(get_order_list(), comments_textbox.Text, calculate_total_price());
                }
                return;
            }
            MessageBox.Show("Wiadomość została wysłana do: " + Properties.Settings.Default.EmailTo);

            if(HandleDatabase.send_to_database(get_order_list(), comments_textbox.Text, calculate_total_price()))
            {
                order_listbox.Items.Clear();
                comments_textbox.Text = "";
                MessageBox.Show("Dodano zamówienie do bazy danych");
            }
            else
            {
                MessageBox.Show("Nie udało się dodać zamówienia do bazy danych");
            }
            
        }


        private void config_button_Click(object sender, EventArgs e)
        {
            SettingsForm settings_form = new SettingsForm();
            settings_form.ShowDialog();
        }

        private void order_history_button_Click(object sender, EventArgs e)
        {
            OrderHistoryForm order_history_form = new OrderHistoryForm();
            order_history_form.Show();
        }
    }
}
