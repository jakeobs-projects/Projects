using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rngtest
{
    public partial class Form1 : Form
    {
        Random rng1 = new Random();
        int count = 0;
        int show_hide = 0;
        int show_hide_1 = 0;
        int restart_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            restart_count++;
            label3.Text = "Restart Count: " + restart_count.ToString();
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            if (comboBox1.Text == "2")
            {
                count = rng1.Next(1, 3);
                label2.Text = "Chance: 50%";
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
            else if(comboBox1.Text == "3")
            {
                count = rng1.Next(1, 4);
                label2.Text = "Chance: 33.3%";
                button5.Visible = false;
                button6.Visible = false;
            }
            else if (comboBox1.Text == "4")
            {
                count = rng1.Next(1, 5);
                label2.Text = "Chance: 25%";
                button6.Visible = false;
            }
            else if (comboBox1.Text == "5")
            {
                count = rng1.Next(1, 6);
                label2.Text = "Chance: 20%";
            }
            
            label1.Text = "Correct: "+count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(count == 1)
            {
                this.BackColor = Color.Lime;
            }
           else
            {
                this.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count == 2)
            {
                this.BackColor = Color.Lime;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                this.BackColor = Color.Lime;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count == 4)
            {
                this.BackColor = Color.Lime;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                this.BackColor = Color.Lime;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Correct: " + count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(show_hide == 0)
            {
                show_hide = 1;
                label1.Visible = true;
                button7.Text = "Hide";
            }
            else
            {
                show_hide = 0;
                label1.Visible = false;
                button7.Text = "Show";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (show_hide_1 == 0)
            {
                show_hide_1 = 1;
                label2.Visible = true;
                button8.Text = "Hide";
            }
            else
            {
                show_hide_1 = 0;
                label2.Visible = false;
                button8.Text = "Show";
            }
        }
    }
}
