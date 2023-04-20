using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           

        }

        

       public static int number_of_players;
       public static int goal;
       public static string player1;
       public static string player2;
       public static string player3;
       public static string player4;
        public static string color1;
        public static string color2;
        public static string color3;
        public static string color4;

        public static int score1;
        public static int bank1;
        public static int score2;
        public static int bank2;
       public static int score3;
        public static int bank3;
        public static int score4;
        public static int bank4;





        private void button1_Click(object sender, EventArgs e)
        {
            number_of_players = Convert.ToInt32(textBox1.Text);
            goal = Convert.ToInt32(textBox2.Text);
            if ((number_of_players < 2) || (number_of_players > 4))
            {
                MessageBox.Show("Please enter players between 2 and 4");
            }
            else if ((goal < 10) || (goal > 1000))
            {

                MessageBox.Show("Please enter goal between 10 and 1000");
            }
            else if (number_of_players == 2)
            {

               
              
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                button2.Enabled = true;

            }

           else if (number_of_players == 3)
            {
               
                
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = false;
                button2.Enabled = true;
            }
            else if (number_of_players == 4)
            {
               
               
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                button2.Enabled = true;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Please enter players and goal");
            }
            else
            {


                color1 = (string)comboBox1.SelectedItem;
                color2 = (string)comboBox2.SelectedItem;
                color3 = (string)comboBox3.SelectedItem;
                color4 = (string)comboBox4.SelectedItem;

                player1 = textBox3.Text;
                player2 = textBox4.Text;
                player3 = textBox5.Text;
                player4 = textBox6.Text;
                number_of_players = Convert.ToInt32(textBox1.Text);
                goal = Convert.ToInt32(textBox2.Text);
                if (number_of_players == 2)
                {


                    People.allpeople.Add(new Person(player1, color1));
                    People.allpeople.Add(new Person(player2, color2));
                    score1 = 0;
                    bank1 = 0;
                    score2 = 0;
                    bank2 = 0;
                }
                else if (number_of_players == 3)
                {
                    People.allpeople.Add(new Person(player1, color1));
                    People.allpeople.Add(new Person(player2, color2));
                    People.allpeople.Add(new Person(player3, color3));
                    score1 = 0;
                    bank1 = 0;
                    score2 = 0;
                    bank2 = 0;
                    score3 = 0;
                    bank3 = 0;
                }
                else if (number_of_players == 4)
                {

                    People.allpeople.Add(new Person(player1, color1));
                    People.allpeople.Add(new Person(player2, color2));
                    People.allpeople.Add(new Person(player3, color3));
                    People.allpeople.Add(new Person(player4, color4));

                    score1 = 0;
                    bank1 = 0;
                    score2 = 0;
                    bank2 = 0;
                    score3 = 0;
                    bank3 = 0;
                    score4 = 0;
                    bank4 = 0;
                }
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Snow;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Snow;
        }

       
    }
}
