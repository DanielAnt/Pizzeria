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
        }



        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            order_listbox.Items.Add("Kawa");
        }

        private void margarita_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel("Margarita", "20");
            f2.ShowDialog();

        }

        private void vegetariana_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel("Vegetariana", "22");
            f2.ShowDialog();

        }

        private void tosca_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel("Tosca", "25");
            f2.ShowDialog();
        }

        private void venecia_button_Click(object sender, EventArgs e)
        {
            PizzaForm f2 = new PizzaForm();
            f2.SetLabel("Venecia", "25");
            f2.ShowDialog();
        }

        private void schnitzel_button_Click(object sender, EventArgs e)
        {
            MainDishForm f2 = new MainDishForm();
            f2.SetLabel("Schabowy z frytkami / ryżem / ziemniakami", "30");
            f2.ShowDialog();
        }

        private void fish_button_Click(object sender, EventArgs e)
        {
            MainDishForm f2 = new MainDishForm();
            f2.SetLabel("Ryba z frytkami", "28");
            f2.ShowDialog();
        }

        private void fritter_button_Click(object sender, EventArgs e)
        {
            MainDishForm f2 = new MainDishForm();
            f2.SetLabel("Placek po węgiersku", "27");
            f2.ShowDialog();
        }

        private void tomateo_soup_button_Click(object sender, EventArgs e)
        {

        }

        private void broth_button_Click(object sender, EventArgs e)
        {

        }

        private void coffe_button_Click(object sender, EventArgs e)
        {

        }

        private void tea_button_Click(object sender, EventArgs e)
        {

        }

        private void cola_button_Click(object sender, EventArgs e)
        {

        }
    }
}
