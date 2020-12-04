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


namespace Assignment8EmployeeFile
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.empno = Convert.ToInt32(textBox1.Text);
            e1.empname = textBox2.Text;
            e1.salary = Convert.ToInt32(textBox3.Text);
            FileStream fs = new FileStream(@"C:\Users\test\Desktop\Emp\EmpDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            
            sw.Write("\n"+e1.empno+ " " +e1.empname+ " "+e1.salary+ "\n");
            sw.Close();
            fs.Close();
            MessageBox.Show("Employee Details Submitted");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\test\Desktop\Emp\EmpDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
   
            richTextBox1.Text = sr.ReadToEnd();

            sr.Close();
            fs.Close();
           
        }
    }
}
