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
    public partial class Form3 : Form
    {
        OrderDetails orderdetails = new OrderDetails();
        List<OrderDetails> orderdetailss = new List<OrderDetails>();
        public Form3(OrderDetails orderdetail,int index,OrderDetails orderdetails)
        {
            InitializeComponent();
            goodsId.Text = index.ToString();
            goodsId.Enabled = false;
            this.orderdetails = orderdetails;
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            orderdetails = new OrderDetails(goodsName.Text, int.Parse(goodsQuantity.Text), 
                int.Parse(goodsPrice.Text), int.Parse(goodsId.Text));
        }
    }
}
