using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class Form1 : Form
    {
        public OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();

            OrderDetails OrderDetails1 = new OrderDetails("milk", 2, 3, 1);
            OrderDetails OrderDetails2 = new OrderDetails("hot dog", 3, 4, 2);
            OrderDetails OrderDetails3 = new OrderDetails("bread", 4, 5, 3);
 

            List<OrderDetails> OrderDetailss1 = new List<OrderDetails>{ OrderDetails1, OrderDetails3 };
            List<OrderDetails> OrderDetailss2 = new List<OrderDetails>{ OrderDetails2, OrderDetails3 };
            List<OrderDetails> OrderDetailss3 = new List<OrderDetails>{ OrderDetails1, OrderDetails2 };
           

            Order order1 = new Order(1, "a", OrderDetailss1);
            Order order2 = new Order(2, "aa", OrderDetailss2);
            Order order3 = new Order(3, "aaa",  OrderDetailss3);
            os.add(order2);
            os.add(order1);
            os.add(order3);
            orderBindingSource.DataSource = os.MyOrder;
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            OrderDetails orderDetails = new OrderDetails();
            Form2 form2 = new Form2(order, orderDetails, true);
            form2.ShowDialog(this);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int orderId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Order order = os.getByNumber(orderId);
            if(order != null)
            {
                os.delete(orderId);
            }
            orderBindingSource.ResetBindings(false);
        }

        private void revise_button_Click(object sender, EventArgs e)
        {

        }
    }
}
