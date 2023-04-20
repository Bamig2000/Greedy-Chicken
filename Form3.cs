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
    public partial class Form3 : Form
    {
        List<Panel> panellist = new List<Panel>();
        List<Label> labellist = new List<Label>();

        public Form3()
        {
            InitializeComponent();

        }
        int Goal = Form2.goal;
        int Number_of_Players = Form2.number_of_players;
        int Score1 = Form2.score1;
        int bank1 = Form2.bank2;
        int score2 = Form2.score2;
        int bank2 = Form2.bank2;
        int score3 = Form2.score3;
        int bank3 = Form2.bank3;
        int score4 = Form2.score4;
        int bank4 = Form2.bank4;
        public void updatelabeltwo()
        {
            label8.Text = Score1.ToString();
            label10.Text = bank1.ToString();
            label14.Text = score2.ToString();
            label15.Text = bank2.ToString();
            if ((Score1 == Goal))
            {
                MessageBox.Show($"{People.allpeople[0].playername} won the game!!");
            }
            else if (score2>=Goal)
            {
                MessageBox.Show($"{People.allpeople[1].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }


        }
        public void updatelabelthree()
        {
            label8.Text = Score1.ToString();
            label10.Text = bank1.ToString();
            label14.Text = score2.ToString();
            label15.Text = bank2.ToString();
            label12.Text = score3.ToString();
            label13.Text = bank3.ToString();
            if ((Score1 == Goal))
            {
                MessageBox.Show($"{People.allpeople[0].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else if (score2 >= Goal)
            {
                MessageBox.Show($"{People.allpeople[1].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else if (score3 >=Goal)
            {
                MessageBox.Show($"{People.allpeople[2].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }


        }
        public void updatelabelfour()
        {
            label8.Text = Score1.ToString();
            label10.Text = bank1.ToString();
            label14.Text = score2.ToString();
            label15.Text = bank2.ToString();
            label12.Text = score3.ToString();
            label13.Text = bank3.ToString();
            label18.Text = score4.ToString();
            label19.Text = bank4.ToString();

            if ((Score1 >= Goal))
            {
                MessageBox.Show($"{People.allpeople[0].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else if (score2 >= Goal)
            {
                MessageBox.Show($"{People.allpeople[1].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else if (score3 >= Goal)
            {
                MessageBox.Show($"{People.allpeople[2].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else if (score4 >=Goal)
            {
                MessageBox.Show($"{People.allpeople[3].playername} won the game!!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int diceval;
            diceval = rnd.Next(1, 6);
            if (diceval == 1)
            {
                pictureBox1.Image = Properties.Resources.dice1;
                if ((Number_of_Players == 2))
                {
                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 = 0;
                        updatelabeltwo();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[1].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[1].color);
                        button2.BackColor = Color.FromName(People.allpeople[1].color);

                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 = 0;
                        updatelabeltwo();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[0].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[0].color);
                        button2.BackColor = Color.FromName(People.allpeople[0].color);

                    }
                }
                else if (Number_of_Players == 3)
                {
                    if (button1.BackColor == (Color.FromName(People.allpeople[0].color)))
                    {
                        bank1 = 0;
                        updatelabelthree();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[1].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[1].color);
                        button2.BackColor = Color.FromName(People.allpeople[1].color);
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 = 0;
                        updatelabelthree();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[2].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[2].color);
                        button2.BackColor = Color.FromName(People.allpeople[2].color);

                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 = 0;
                        updatelabelthree();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[0].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[0].color);
                        button2.BackColor = Color.FromName(People.allpeople[0].color);
                    }

                }
                else if (Number_of_Players == 4)
                {

                    if (button1.BackColor == (Color.FromName(People.allpeople[0].color)))
                    {
                        bank1 = 0;
                        updatelabelfour();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[1].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[1].color);
                        button2.BackColor = Color.FromName(People.allpeople[1].color);
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 = 0;
                        updatelabelfour();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[2].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[2].color);
                        button2.BackColor = Color.FromName(People.allpeople[2].color);

                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 = 0;
                        updatelabelfour();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[3].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[3].color);
                        button2.BackColor = Color.FromName(People.allpeople[3].color);
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[3].color))))
                    {
                        bank4 = 0;
                        updatelabelfour();
                        label23.Visible = true;
                        label23.Text = "You Rolled one!!";
                        label22.Text = $"It's {People.allpeople[0].playername}'s turn";
                        label22.Visible = true;
                        button1.BackColor = Color.FromName(People.allpeople[0].color);
                        button2.BackColor = Color.FromName(People.allpeople[0].color);
                    }
                }
            }


            else if (diceval == 2)
            {
                pictureBox1.Image = Properties.Resources.dice2;
                if (Number_of_Players == 2)
                {
                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 2;
                        updatelabeltwo();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 2;
                        updatelabeltwo();
                        label23.Visible = false;
                    }

                }
                else if (Number_of_Players == 3)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 2;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 2;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 2;
                        updatelabelthree();
                        label23.Visible = false;
                    }


                }
                else if (Number_of_Players == 4)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 2;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 2;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 2;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[3].color))))
                    {
                        bank4 += 2;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                }

            }
            else if (diceval == 3)
            {
                pictureBox1.Image = Properties.Resources.dice3;
                if (Number_of_Players == 2)
                {
                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 3;
                        updatelabeltwo();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 3;
                        updatelabeltwo();
                        label23.Visible = false;
                    }

                }
                else if (Number_of_Players == 3)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 3;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 3;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 3;
                        updatelabelthree();
                        label23.Visible = false;
                    }


                }
                else if (Number_of_Players == 4)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 3;
                        updatelabelfour();
                            label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 3;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 3;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[3].color))))
                    {
                        bank4 += 3;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                }
            }
            else if (diceval == 4)
            {
                pictureBox1.Image = Properties.Resources.dice4;
                if (Number_of_Players == 2)
                {
                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 4;
                        updatelabeltwo();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 4;
                        updatelabeltwo();
                        label23.Visible = false;
                    }

                }
                else if (Number_of_Players == 3)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 4;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 4;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 4;
                        updatelabelthree();
                        label23.Visible = false;
                    }


                }
                else if (Number_of_Players == 4)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 4;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 4;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 4;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[3].color))))
                    {
                        bank4 += 4;
                        updatelabelfour();
                        label23.Visible = false;
                    }

                }
            }
            else if (diceval == 5)
            {
                pictureBox1.Image = Properties.Resources.dice5;
                if (Number_of_Players == 2)
                {
                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 5;
                        updatelabeltwo();
                        label23.Visible = false;

                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 5;
                        updatelabeltwo();
                        label23.Visible = false;
                    }

                }
                else if (Number_of_Players == 3)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 5;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 5;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 5;
                        updatelabelthree();
                        label23.Visible = false;
                    }


                }
                else if (Number_of_Players == 4)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 5;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 5;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 5;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[3].color))))
                    {
                        bank4 += 5;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                }
            }
            else if (diceval == 6)
            {
                pictureBox1.Image = Properties.Resources.dice6;
                if (Number_of_Players == 2)
                {
                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 6;
                        updatelabeltwo();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 6;
                        updatelabeltwo();
                        label23.Visible = false;
                    }

                }
                else if (Number_of_Players == 3)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 6;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 6;
                        updatelabelthree();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 6;
                        updatelabelthree();
                        label23.Visible = false;
                    }


                }
                else if (Number_of_Players == 4)
                {

                    if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                    {
                        bank1 += 6;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                    {
                        bank2 += 6;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                    {
                        bank3 += 6;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                    else if ((button1.BackColor == (Color.FromName(People.allpeople[3].color))))
                    {
                        bank4 += 6;
                        updatelabelfour();
                        label23.Visible = false;
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panellist.Add(panel1);
            panellist.Add(panel2);
            panellist.Add(panel3);
            panellist.Add(panel4);

            labellist.Add(label1);
            labellist.Add(label2);
            labellist.Add(label3);
            labellist.Add(label4);
            label7.Text =$"Goal \n{Goal}";



            showtherightdata();
            button1.BackColor = Color.FromName(People.allpeople[0].color);
            button2.BackColor = Color.FromName(People.allpeople[0].color);
            bank1 = 0;
            bank2 = 0;
            bank3 = 0;
            bank4 = 0;
            Score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
            updatelabelfour();


        }

        private void showtherightdata()
        {
            for (int i = 0; i < People.allpeople.Count; i++)
            {
                panellist[i].Visible = true;
                panellist[i].BackColor = Color.FromName(People.allpeople[i].color);
                labellist[i].Text = (People.allpeople[i].playername);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Number_of_Players == 2))
            {
                if ((button1.BackColor == (Color.FromName(People.allpeople[0].color))))
                {
                    Score1 += bank1;
                    bank1 = 0;
                    updatelabeltwo();
                    label22.Text = $"It's {People.allpeople[1].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[1].color);
                    button2.BackColor = Color.FromName(People.allpeople[1].color);

                }
                else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                {
                    score2 += bank2;
                    bank2 = 0;
                    updatelabeltwo();
                    label22.Text = $"It's {People.allpeople[0].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[0].color);
                    button2.BackColor = Color.FromName(People.allpeople[0].color);

                }
            }
            else if (Number_of_Players == 3)
            {
                if (button1.BackColor == (Color.FromName(People.allpeople[0].color)))
                {
                    Score1 += bank1;
                    bank1 = 0;
                    updatelabelthree();
                    label22.Text = $"It's {People.allpeople[1].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[1].color);
                    button2.BackColor = Color.FromName(People.allpeople[1].color);
                }
                else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                {
                    score2 += bank2;
                    bank2 = 0;
                    updatelabelthree();
                    label22.Text = $"It's {People.allpeople[2].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[2].color);
                    button2.BackColor = Color.FromName(People.allpeople[2].color);

                }
                else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                {
                    score3 += bank3;
                    bank3 = 0;
                    updatelabelthree();
                    label22.Text = $"It's {People.allpeople[0].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[0].color);
                    button2.BackColor = Color.FromName(People.allpeople[0].color);
                }

            }
            else if (Number_of_Players == 4)
            {

                if (button1.BackColor == (Color.FromName(People.allpeople[0].color)))
                {
                    Score1 += bank1;
                    bank1 = 0;
                    updatelabelfour();
                    label22.Text = $"It's {People.allpeople[1].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[1].color);
                    button2.BackColor = Color.FromName(People.allpeople[1].color);
                }
                else if ((button1.BackColor == (Color.FromName(People.allpeople[1].color))))
                {
                    score2 += bank2;
                    bank2 = 0;
                    updatelabelfour();
                    label22.Text = $"It's {People.allpeople[2].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[2].color);
                    button2.BackColor = Color.FromName(People.allpeople[2].color);

                }
                else if ((button1.BackColor == (Color.FromName(People.allpeople[2].color))))
                {
                    score3 += bank3;
                    bank3 = 0;
                    updatelabelfour();
                    label22.Text = $"It's {People.allpeople[3].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[3].color);
                    button2.BackColor = Color.FromName(People.allpeople[3].color);
                }
                else if ((button1.BackColor == (Color.FromName(People.allpeople[3].color))))
                {
                    score4 += bank4;
                    bank4 = 0;
                    updatelabelfour();
                    label22.Text = $"It's {People.allpeople[0].playername}'s turn";
                    label22.Visible = true;
                    button1.BackColor = Color.FromName(People.allpeople[0].color);
                    button2.BackColor = Color.FromName(People.allpeople[0].color);
                }
            }
        }

       
    }
}
