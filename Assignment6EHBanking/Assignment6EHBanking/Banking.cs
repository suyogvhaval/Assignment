using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6EHBanking
{
   public class Banking
    {

        public int Netbalance
        {
            get;
            set;
        }
         public void OverBalance(int amount)
        {
            double tax = amount * 0.18;
            MessageBox.Show("Your Tax Amount:" + tax);
        }
        public void UnderBalance(int amount)
        {
            MessageBox.Show("Your balance is Below 5000. Please maintain minimum balance in your account");
        }
    }
}
