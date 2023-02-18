using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rollaDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Random randomMain = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            this.label1.Text = roll.ToString();
        }
       

        public void roll2dices()
        {
            Random random1 = new Random();
            int roll1 = random1.Next(1, 7);
            
            Random random2 = new Random();
            int roll2 = random2.Next(8, 14);


            this.label2.Text = roll1.ToString() + " : " + (roll2-6).ToString();
        }

        public void roll6dices()
        {
            this.label3.Text = "";

            Random random1 = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            Random random4 = new Random();
            Random random5 = new Random();
            Random random6 = new Random();

           
               
                int roll1 = random1.Next(1, 49);
                int roll2 = random1.Next(1, 49);
                int roll3 = random1.Next(1, 49);
                int roll4 = random1.Next(1, 49);
                int roll5 = random1.Next(1, 49);
                int roll6 = random1.Next(1, 49);

            this.label3.Text += roll1.ToString() + " : ";
            this.label3.Text += roll2.ToString() + " : ";
            this.label3.Text += roll3.ToString() + " : ";
            this.label3.Text += roll4.ToString() + " : ";
            this.label3.Text += roll5.ToString() + " : ";
            this.label3.Text += roll6.ToString() + " : ";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            roll2dices();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            roll6dices();
        }



        public int rndDieces()
        {
            
            int roll = randomMain.Next(1, 49);
            return roll;
        }

        //you can modified and check in a list if values are unique or not
        public void runNTimes(int n, ref Label l)
        {
            l.Text = " ";
            for (int i = 0; i < n; i++)
            {
                l.Text += i.ToString() + " : ";
                l.Text += rndDieces().ToString();
                l.Text += " \r\t ";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            runNTimes(49,  ref this.label4);
        }
    }
}
