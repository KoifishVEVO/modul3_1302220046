using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302220046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


   
        int angka1;

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
   

            label1.Text = label1.Text + "0";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
  

            label1.Text = label1.Text + "3";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {


            label1.Text = label1.Text + "2";
           
        }

        private void button6_Click(object sender, EventArgs e)
        {


            label1.Text = label1.Text + "1";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            
            angka1 = angka1 + Int32.Parse(label1.Text);
            label1.Text = angka1.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            
                angka1 = Int32.Parse(label1.Text);
                label1.Text = null;
            
     
        }

        private void button9_Click(object sender, EventArgs e)
        {


            label1.Text = label1.Text + "4";
  
        }

        private void button8_Click(object sender, EventArgs e)
        {


            label1.Text = label1.Text + "5";
     
        }

        private void button7_Click(object sender, EventArgs e)
        {
 

            label1.Text = label1.Text + "6";
        
        }

        private void button12_Click(object sender, EventArgs e)
        {
 

            label1.Text = label1.Text + "7";
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
   

            label1.Text = label1.Text + "8";
          
        }

        private void button10_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "9";
         
        }




    }
}
