using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework8
{
    public partial class Form2 : Form
    {
        Order order = new Order();
        OrderDetails od = new OrderDetails();
        bool isAdd = false;

        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(Order order, OrderDetails od, bool isAdd)
        {
            InitializeComponent();
            this.order = order;
            this.od = od;
            this.isAdd = isAdd;
            orderBindingSource.DataSource = order;

            orderId.Enabled = isAdd;
            if (!isAdd)
            {
                orderClient.Text = order.OrderClient;
            }
        }

        private void addDetail_btn_Click(object sender, EventArgs e)
        {
            int count = orderDetailDataGridView.Rows.Count;
            Form3 form3 = new Form3(new OrderDetails(), count, od);

            if (form3.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(od.GoodsNumber);
                order.AddDetail(od);
                orderBindingSource.ResetBindings(true);
                orderDetailBindingSource.ResetBindings(true);
            }
        }
    }
}
