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
            LoadSettingsToTextboxes();
        }

        private void LoadSettingsToTextboxes()
        {
            host_textbox.Text = Properties.Settings.Default.Host;
            port_textbox.Text = Convert.ToString(Properties.Settings.Default.Port);
            emailFrom_textbox.Text = Properties.Settings.Default.EmailFrom;
            password_textbox.Text = Properties.Settings.Default.Password;
            emailTo_textbox.Text = Properties.Settings.Default.EmailTo;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = host_textbox.Text;
            Properties.Settings.Default.Port = Convert.ToInt32(port_textbox.Text);
            Properties.Settings.Default.EmailFrom = emailFrom_textbox.Text;
            Properties.Settings.Default.Password = password_textbox.Text;
            Properties.Settings.Default.EmailTo = emailTo_textbox.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
      
    }
}
