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
    public partial class Form1 : Form
    {

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
                int sum_price = 0;
                foreach (Dish a in order_listbox.Items)
                {
                    sum_price += Convert.ToInt32(a.total_price);
                }
                sum_price_label.Text = Convert.ToString(sum_price) + "zł";
            };
            timer.Start();
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
            DialogResult dialog_result = MessageBox.Show("Czy chcesz potwierdzić zamówienie?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if(dialog_result == DialogResult.Yes)
            {
                EmailHandler.send_message(this);
            }
            
        }

       
        public void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Error \n" + e.Error.Message);
                Console.WriteLine(e.Error);
                return;
            }
            MessageBox.Show("Message has been sent to: " + Properties.Settings.Default.EmailTo);
            order_listbox.Items.Clear();
            comments_textbox.Text = "";
        }

        private void config_button_Click(object sender, EventArgs e)
        {
            SettingsForm settings_form = new SettingsForm();
            settings_form.ShowDialog();
        }
    }
}
