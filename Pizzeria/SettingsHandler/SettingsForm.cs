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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            load_settings_to_textboxes();
        }

        private void load_settings_to_textboxes()
        {
            host_textbox.Text = Properties.Settings.Default.Host;
            port_textbox.Text = Convert.ToString(Properties.Settings.Default.Port);
            email_from_textbox.Text = Properties.Settings.Default.EmailFrom;
            password_textbox.Text = Properties.Settings.Default.Password;
            email_to_textbox.Text = Properties.Settings.Default.EmailTo;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = host_textbox.Text;
            Properties.Settings.Default.Port = Convert.ToInt32(port_textbox.Text);
            Properties.Settings.Default.EmailFrom = email_from_textbox.Text;
            Properties.Settings.Default.Password = password_textbox.Text;
            Properties.Settings.Default.EmailTo = email_to_textbox.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
      
    }
}
