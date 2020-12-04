using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6EHBanking
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banking b = new Banking();
            b.Netbalance = Convert.ToInt32(textBox1.Text);

            if(b.Netbalance >= 100000)
            {
                b.OverBalance(b.Netbalance);
            }
            else if(b.Netbalance < 5000)
            {
                b.UnderBalance(b.Netbalance);
            }
            else
            {
                MessageBox.Show("Congrasulations you dont have to pay any tax and minimum balance is maintained for your account ");
            }
        }
    }
}
