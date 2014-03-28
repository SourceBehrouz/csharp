using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrainingWMSoftware
{
    public partial class grid : Form
    {
        int timeshow = 1000;
        int timebetween = 100;
        int counter = 1;
        int hitcounter;
        int[] hitcountArray = new int[8];
        public grid()
        {
            InitializeComponent();
        }
        int cell1;
        int cell2;
        int cell3;
        int cell4;
        int cell5;
        int cell6;
        int cell7;
        int level = 2;
        int suceed = 0;
        int forward = 1;
        public void clickbutton()
        {
            hitcounter++;
            if (hitcounter == 8 && level == 7)
            {
               // textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString() + "  " + hitcountArray[6].ToString()+"  " + hitcountArray[7].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() + "  " + cell4.ToString() + "  " + cell5.ToString() + "  " + cell6.ToString() + "  " + cell7.ToString();
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                int correctness5;
                int correctness6;
                int correctness7;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell4 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell5 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell6 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    if ((cell7 == hitcountArray[7])) correctness7 = 1; else correctness7 = 0;
                }
                else
                {
                    if ((cell7 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell6 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell5 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell4 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell3 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell2 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    if ((cell1 == hitcountArray[7])) correctness7 = 1; else correctness7 = 0;
                }
                int correcteness = (int)Math.Round((double)((correctness1 + correctness2 + correctness3 + correctness4 + correctness5 + correctness6 + correctness7) *14.28));
                textBox3.Text = correcteness.ToString(); hitcounter = 0;
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "Fchord.wav"; level = 4;
                    sound.Play();
                    suceed = 0;

                }
            }
  
            if (hitcounter == 7 && level == 6)
            {
              //  textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString() + "  " + hitcountArray[6].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() + "  " + cell4.ToString() + "  " + cell5.ToString() + "  " + cell6.ToString();
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                int correctness5;
                int correctness6;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell4 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell5 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell6 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                }
                else
                {
                    if ((cell6 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell5 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell4 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell3 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell2 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell1 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                }
                int correcteness = (int)Math.Round((double)((correctness1 + correctness2 + correctness3 + correctness4 + correctness5 + correctness6) * 16.66));
                textBox3.Text = correcteness.ToString(); hitcounter = 0;
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav"; 
                    sound.Play();
                    suceed = 0;

                }
            }
            if (hitcounter == 6 && level == 5)
            {
              //  textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() + "  " + cell4.ToString() + "  " + cell5.ToString();
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                int correctness5;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell4 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell5 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                }
                else
                {
                    if ((cell5 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell4 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell2 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell1 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                }
                int correcteness = (int)Math.Round((double)(correctness1 + correctness2 + correctness3 + correctness4 + correctness5) * 20);
                textBox3.Text = correcteness.ToString(); hitcounter = 0;
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play();
                    suceed = 0;
                }
            }
            if (hitcounter == 5 && level == 4)
            {
               // textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() + "  " + cell4.ToString();
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell4 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                }
                else
                {
                    if ((cell4 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell3 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell2 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell1 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                }
                int correcteness = (int)Math.Round((double)(correctness1 + correctness2 + correctness3 + correctness4) * 25);
                textBox3.Text = correcteness.ToString(); hitcounter = 0;
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play();
                    suceed = 0;
                }
            }
            if (hitcounter == 4 && level == 3)
            {
                // textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString();
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                }
                else
                {
                    if ((cell3 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell1 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                }
                int correcteness = (int)Math.Round((double)(correctness1 + correctness2 + correctness3 ) * 33.3);
                textBox3.Text = correcteness.ToString(); hitcounter = 0;
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play();
                    suceed = 0;
                }
            }
            if (hitcounter == 3 && level == 2)
            {
                // textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() ;
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                }
                else
                {
                    if ((cell1 == hitcountArray[2])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[1])) correctness2 = 1; else correctness2 = 0;
                }
                int correcteness = (int)Math.Round((double)(correctness1 + correctness2) * 50);
                textBox3.Text = correcteness.ToString(); hitcounter = 0;
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play();
                    suceed = 0;
                }
            }



        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void grid_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0; 
            this.Bounds = Screen.PrimaryScreen.Bounds;          
            timer1.Interval = timeshow;
            label4.Text = level.ToString();
            label4.Refresh();
            radioButton1.Checked = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                string ballname = "pictureBox" + cell1.ToString();
                System.Windows.Forms.Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }
                counter++;

            }
            else if (counter == 2)
            {
                string ballname = "picturebox" + cell1.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                }


                ballname = "picturebox" + cell2.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }
                counter++;


            }
            else if (counter == 3)
            {
                string ballname = "picturebox" + cell2.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                }


                ballname = "picturebox" + cell3.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }
                if (level == 2)
                {
                    for (int j = 1; j <= 16; j++)
                    {
                        ballname = "picturebox" + j.ToString();
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            if (pic != null)
                                pic.Visible = true;
                        }
                    }
                    timer1.Stop();

                }
                counter++;


            }
            else if (counter == 4)
            {
                string ballname = "picturebox" + cell3.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                }


                ballname = "picturebox" + cell4.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }
                if (level == 3)
                {
                    for (int j = 1; j <= 16; j++)
                    {
                        ballname = "picturebox" + j.ToString();
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            if (pic != null)
                                pic.Visible = true;
                        }
                    }
                    timer1.Stop();

                }
                counter++;


            }

            else if (counter == 5)
            {
                string ballname = "picturebox" + cell4.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                }

                ballname = "picturebox" + cell5.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }

                if (level == 4)
                {
                    for (int j = 1; j <= 16; j++)
                    {
                        ballname = "picturebox" + j.ToString();
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            if (pic != null)
                                pic.Visible = true;
                        }
                    }
                    timer1.Stop();

                }
                counter++;


            }
            else if (counter == 6)
            {

                string ballname = "picturebox" + cell5.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                }

                ballname = "picturebox" + cell6.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }

                if (level == 5)
                {
                    for (int j = 1; j <= 16; j++)
                    {
                        ballname = "picturebox" + j.ToString();
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            if (pic != null)
                                pic.Visible = true;
                        }
                    }
                    timer1.Stop();
                    hitcounter = 1;

                }
                counter++;



            }
            else if (counter == 7)
            {

                string ballname = "picturebox" + cell6.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                }

                ballname = "picturebox" + cell7.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }


                if (level == 6)
                {

                    for (int j = 1; j <= 16; j++)
                    {
                        ballname = "picturebox" + j.ToString();
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            if (pic != null)
                                pic.Visible = true;
                        }
                    }
                    timer1.Stop();
                    hitcounter = 1;



                }
                counter++;

            }
            else if (counter == 8)
            {

                string ballname = "picturebox" + cell7.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                }
                ballname = "picturebox" + cell6.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = true;
                }



                if (level == 7)
                {

                    for (int j = 1; j <= 16; j++)
                    {
                        ballname = "picturebox" + j.ToString();
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            if (pic != null)
                                pic.Visible = true;
                        }
                    }
                    timer1.Stop();
                    hitcounter = 1;



                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            traineeInformation.LastEvent = DateTime.Now;




            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Refresh();
            textBox2.Refresh();
            textBox3.Refresh();
            if (radioButton1.Checked == true)
            {
                forward = 1;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                forward = 0;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            label4.Refresh();
            if (level == 2)
            {
                if (counter == 3)
                {
                    string ballname = "picturebox" + cell2.ToString();
                    Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }

                Random random = new Random();
                cell1 = random.Next(1, 16);
                cell2 = random.Next(1, 16);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(1, 16);
                }



                counter = 1;
                for (int j = 1; j <= 16; j++)
                {
                    string ballname = "pictureBox" + j.ToString();
                    System.Windows.Forms.Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }


            }
            if (level == 3)
            {
                if (counter == 4)
                {
                    string ballname = "picturebox" + cell3.ToString();
                    Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }

                Random random = new Random();
                cell1 = random.Next(1, 16);
                cell2 = random.Next(1, 16);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(1, 16);
                }

                cell3 = random.Next(1, 16);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(1, 16);
                }


                counter = 1;
                for (int j = 1; j <= 16; j++)
                {
                    string ballname = "pictureBox" + j.ToString();
                    System.Windows.Forms.Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }


            }
            if (level == 4)
            {
                if (counter == 5)
                {
                    string ballname = "picturebox" + cell4.ToString();
                    Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }

                Random random = new Random();
                cell1 = random.Next(1, 16);
                cell2 = random.Next(1, 16);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(1, 16);
                }

                cell3 = random.Next(1, 16);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(1, 16);
                }

                cell4 = random.Next(1, 16);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(1, 16);
                }


                counter = 1;
                for (int j = 1; j <= 16; j++)
                {
                    string ballname = "pictureBox" + j.ToString();
                    System.Windows.Forms.Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }


            }
            else if (level == 5)
            {
                if (counter == 6)
                {
                    string ballname = "picturebox" + cell5.ToString();
                    Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }

                Random random = new Random();
                cell1 = random.Next(1, 16);
                cell2 = random.Next(1, 16);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(1, 16);
                }

                cell3 = random.Next(1, 16);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(1, 16);
                }

                cell4 = random.Next(1, 16);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(1, 16);
                }

                cell5 = random.Next(1, 16);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(1, 16);
                }

                counter = 1;
                for (int j = 1; j <= 16; j++)
                {
                    string ballname = "pictureBox" + j.ToString();
                    System.Windows.Forms.Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }

            }
            else if (level == 6)
            {

                if (counter == 7)
                {
                    string ballname = "picturebox" + cell6.ToString();
                    Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }

                Random random = new Random();
                cell1 = random.Next(1, 16);
                cell2 = random.Next(1, 16);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(1, 16);
                }

                cell3 = random.Next(1, 16);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(1, 16);
                }

                cell4 = random.Next(1, 16);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(1, 16);
                }

                cell5 = random.Next(1, 16);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(1, 16);
                }

                cell6 = random.Next(1, 16);
                while ((cell6 == cell1) || (cell6 == cell2) || (cell6 == cell3) || (cell6 == cell4) || (cell6 == cell5))
                {
                    cell6 = random.Next(1, 16);
                }
                counter = 1;
                for (int j = 1; j <= 16; j++)
                {
                    string ballname = "pictureBox" + j.ToString();
                    System.Windows.Forms.Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }
            }
            else if (level == 7)
            {

                if (counter == 8)
                {
                    string ballname = "picturebox" + cell6.ToString();
                    Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }

                Random random = new Random();
                cell1 = random.Next(1, 16);
                cell2 = random.Next(1, 16);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(1, 16);
                }

                cell3 = random.Next(1, 16);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(1, 16);
                }

                cell4 = random.Next(1, 16);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(1, 16);
                }

                cell5 = random.Next(1, 16);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(1, 16);
                }

                cell6 = random.Next(1, 16);
                while ((cell6 == cell1) || (cell6 == cell2) || (cell6 == cell3) || (cell6 == cell4) || (cell6 == cell5))
                {
                    cell6 = random.Next(1, 16);
                }
                cell7 = random.Next(1, 16);
                while ((cell7 == cell1) || (cell7 == cell2) || (cell7 == cell3) || (cell7 == cell4) || (cell7 == cell5) || (cell7 == cell6))
                {
                    cell7 = random.Next(1, 16);
                }
                
                counter = 1;
                for (int j = 1; j <= 16; j++)
                {
                    string ballname = "pictureBox" + j.ToString();
                    System.Windows.Forms.Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                    }
                }



            }
            hitcounter = 1;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 1;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "1";


        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 2;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "2";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 3;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "3";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 4;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "4";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 5;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "5";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 6;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "6";


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 7;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "7";

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 8;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "8";


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 9;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "9";

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 10;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "10";


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 11;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "11";

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 12;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "12";

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 13;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "13";

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 14;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "14";

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 15;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "15";

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 16;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + "16";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string ballname = "test";
                Control[] ctls = this.Controls.Find(ballname, true);
                    PictureBox pic = ctls[0] as PictureBox;
                    tableLayoutPanel1.Controls.Add(pic, 2, 2);



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private bool _bFullScreenMode = false;

        private void grid_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Form1")
                {
                    form.Show();
                    return;
                }
            }
            Form child = new Form();
            child.Name = "Form1";
            child.Owner = this;
            child.Show(this);
            this.Visible = false;
       }
            

        }
    }
