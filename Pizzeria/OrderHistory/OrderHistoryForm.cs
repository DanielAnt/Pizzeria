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
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            this.orderHistoryTableAdapter.Fill(this.orderHistoryDataSet.OrderHistory);

        }

        
    }
}
