using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
      public  int sum, a, b, c, d;
 
        public Form2()
        {
            InitializeComponent();

         
          
            
     
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

       
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            d = Convert.ToInt32(textBox4.Text);
            sum = a + b + c + d;
            Form1 kaen = new Form1();
            kaen.label6.Text = Convert.ToString(sum);
            kaen.Show();
            
        }
    }
}
