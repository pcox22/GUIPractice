using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Note: Lab Instructions requested the submission of both the entire project folder, and four particular files
            // Submitted the entire project folder, as it contains all of the necessary files
            int num1;
            int num2;
            int sum = 0;
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                sum = num1 + num2;
                label1.Text = sum.ToString();
                
            }
            catch (FormatException)
            {

            }
        }
    }
}
