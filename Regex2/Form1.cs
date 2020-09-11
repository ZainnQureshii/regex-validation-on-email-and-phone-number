using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Regex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegularExpression.checkForEmail(textBox1.Text.ToString()))
            {
                label1.ForeColor = System.Drawing.Color.Green;
                label1.Text = "Email is Valid";
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "Email is InValid";
            }


            if (RegularExpression.checkForPhone(textBox2.Text.ToString()))
            {
                label5.ForeColor = System.Drawing.Color.Green;
                label5.Text = "Phone no. is Valid";
            }
            else
            {
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "Phone no. is InValid";
            }
         }    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        }
    
    
    }

