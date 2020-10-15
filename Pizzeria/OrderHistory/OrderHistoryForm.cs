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

        private void orderHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orderHistoryDataSet);

        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderHistoryDataSet.OrderHistory' table. You can move, or remove it, as needed.
            this.orderHistoryTableAdapter.Fill(this.orderHistoryDataSet.OrderHistory);

        }

        
    }
}
