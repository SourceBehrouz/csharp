using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrainingWMSoftware
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int rotateangle = 90;
        int cell1;
        int cell2;
        int cell3;
        int cell4;
        int cell5;
        int cell6;
        int level = 2;
        int suceed = 0;
        int forward = 1;
        int timeshow = 1000;
        int timebetween = 100;
        int counter = 1;
        int hitcounter;
        int[] hitcountArray = new int[7];
        Image i1 ;
        Image i2 ;
        Image i3 ;
        Image i4 ;


      
        public void clickbutton()
        {

            hitcounter++;
            if (hitcounter == 7 && level == 6)
            {
            //    textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString() + "  " + hitcountArray[6].ToString();
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
                    sound.SoundLocation = "Fchord.wav"; level = 4;
                    sound.Play();
                    suceed = 0;
                    level = 4;
                    timer1.Interval = timer1.Interval - 200;

                }
            }
            if (hitcounter == 6 && level == 5)
            {
             //   textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString();
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
              //  textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString();
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
               // textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() ;
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() ;
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
              //  textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() ;
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString()  ;
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
                    if ((cell2 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell1 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                }
                int correcteness = (int)Math.Round((double)(correctness1 + correctness2 ) * 50);
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

      
        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0; this.Bounds = Screen.PrimaryScreen.Bounds;
            i1 = pictureBox18.Image;
            i2 = pictureBox19.Image;
            i3 = pictureBox20.Image;
            i4 = pictureBox21.Image;
            radioButton1.Checked = true;
            WindowState = FormWindowState.Maximized;
            timer1.Stop();
            timer1.Interval = timeshow;
            label4.Text = level.ToString();
            label4.Refresh();
            for (int j = 1; j <= 16; j++)
            {
                string ballname = "picturebox" + j.ToString();
                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.ImageLocation = Application.StartupPath+"\\images\\40828.jpg";
                }
            }
 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            traineeInformation.LastEvent = DateTime.Now;

            System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath + @"\\lastevent.txt", true);
            sw.Close();
            System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath + @"\\lastevent.txt");
            string s2 = sr.ReadLine();
            sr.Close();
            if (s2 == null)
            {
                sw = new System.IO.StreamWriter(Application.StartupPath + @"\\lastevent.txt", true);
                sw.Write(DateTime.Now);
                sw.Close();
            }
            else
            {
                System.IO.File.Delete(Application.StartupPath + @"\\lastevent.txt");
                sw = new System.IO.StreamWriter(Application.StartupPath + @"\\lastevent.txt", true);
                sw.Write(DateTime.Now);
                sw.Close();
            }

            
            
            
            pictureBox18.Image = i1;
            pictureBox19.Image = i2;
            pictureBox20.Image = i3;
            pictureBox21.Image = i4;

            if (radioButton1.Checked)
                rotateangle = 90;
            else if (radioButton2.Checked )
                rotateangle = 180;
            else rotateangle = 270;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
 //           radioButton3.Enabled = false;
            string ballname = "";
            Control[] ctls;
            for (int j = 1; j <= 16; j++)
            {
                 ballname = "picturebox" + j.ToString();
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                        pic.ImageLocation = Application.StartupPath+"\\images\\40828.jpg";
                }
            }
             ballname = "picturebox1";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 0);
                tableLayoutPanel1.SetRow(pic, 0);
            }
            ballname = "picturebox2";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 1);
                tableLayoutPanel1.SetRow(pic, 0);
            }
            ballname = "picturebox3";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 2);
                tableLayoutPanel1.SetRow(pic, 0);
            }
            ballname = "picturebox4";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 3);
                tableLayoutPanel1.SetRow(pic, 0);
            }
            ballname = "picturebox5";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 0);
                tableLayoutPanel1.SetRow(pic, 1);
            }
            ballname = "picturebox6";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 1);
                tableLayoutPanel1.SetRow(pic, 1);
            }
            ballname = "picturebox7";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 2);
                tableLayoutPanel1.SetRow(pic, 1);
            }
            ballname = "picturebox8";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 3);
                tableLayoutPanel1.SetRow(pic, 1);
            }
            ballname = "picturebox9";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 0);
                tableLayoutPanel1.SetRow(pic, 2);
            }
            ballname = "picturebox10";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 1);
                tableLayoutPanel1.SetRow(pic, 2);
            }
            ballname = "picturebox11";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 2);
                tableLayoutPanel1.SetRow(pic, 2);
            }
            ballname = "picturebox12";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 3);
                tableLayoutPanel1.SetRow(pic, 2);
            }
            ballname = "picturebox13";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 0);
                tableLayoutPanel1.SetRow(pic, 3);
            }
            ballname = "picturebox14";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 1);
                tableLayoutPanel1.SetRow(pic, 3);
            }
            ballname = "picturebox15";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 2);
                tableLayoutPanel1.SetRow(pic, 3);
            }
            ballname = "picturebox16";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                pic.Visible = true;
                //  pic.Image.
                tableLayoutPanel1.SetColumn(pic, 3);
                tableLayoutPanel1.SetRow(pic, 3);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Refresh();
            textBox2.Refresh();
            textBox3.Refresh();
          label4.Refresh();
          if (level == 2)
          {
              if (counter == 3)
              {
                  ballname = "picturebox" + cell2.ToString();
                  ctls = this.Controls.Find(ballname, true);
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
              for (int j = 1; j <= 16; j++)
              {
                  ballname = "pictureBox" + j.ToString();
                  ctls = this.Controls.Find(ballname, true);
                  if (ctls.Length > 0)
                  {
                      PictureBox pic = ctls[0] as PictureBox;
                      if (pic != null)
                          pic.Visible = false;
                  }
              }


          } else
          if (level == 3)
          {
              if (counter == 4)
              {
                  ballname = "picturebox" + cell3.ToString();
                  ctls = this.Controls.Find(ballname, true);
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
                  ballname = "pictureBox" + j.ToString();
                  ctls = this.Controls.Find(ballname, true);
                  if (ctls.Length > 0)
                  {
                      PictureBox pic = ctls[0] as PictureBox;
                      if (pic != null)
                          pic.Visible = false;
                  }
              }


          }else 
          if (level == 4)
            {
                if (counter == 5)
                {
                     ballname = "picturebox" + cell4.ToString();
                     ctls = this.Controls.Find(ballname, true);
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
                     ballname = "pictureBox" + j.ToString();
                     ctls = this.Controls.Find(ballname, true);
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
                     ballname = "picturebox" + cell5.ToString();
                     ctls = this.Controls.Find(ballname, true);
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
                     ballname = "pictureBox" + j.ToString();
                    ctls = this.Controls.Find(ballname, true);
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
                     ballname = "picturebox" + cell6.ToString();
                     ctls = this.Controls.Find(ballname, true);
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
                     ballname = "pictureBox" + j.ToString();
                     ctls = this.Controls.Find(ballname, true);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rotateangle == 90)
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
                                    pic.Visible = false;
                            }

                        }
 
                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                         //   pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                        //    pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                        ///    pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                       //     pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                        //    pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                        //    pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                        //    pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                         //   pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                         //   pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                      //      pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                        //    pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                         //   pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                         //   pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                         //   pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                        //    pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                         //   pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }

                        for (int j = 1; j <= 16; j++)
                        {
                            ballname = "picturebox" + j.ToString();
                            ctls = this.Controls.Find(ballname, true);
                            if (ctls.Length > 0)
                            {
                                PictureBox pic = ctls[0] as PictureBox;
                                if (pic != null)
                                pic.ImageLocation = Application.StartupPath + "\\images\\40828.jpg";
                                pic.Refresh();
                            }
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            ballname = "picturebox" + j.ToString();
                            ctls = this.Controls.Find(ballname, true);
                            if (ctls.Length > 0)
                            {
                                PictureBox pic = ctls[0] as PictureBox;
                                if (pic != null)
                                    pic.Show();
                            }
                        }
                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox21.Image;
                        pictureBox21.Image = pictureBox20.Image;
                        pictureBox20.Image = pictureBox19.Image;
                        pictureBox19.Image = i;

                          
                       timer1.Stop();
                        counter = 0;

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
                    counter++;

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
                                    pic.ImageLocation = Application.StartupPath + "\\images\\40828.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox21.Image;
                        pictureBox21.Image = pictureBox20.Image;
                        pictureBox20.Image = pictureBox19.Image;
                        pictureBox19.Image = i;

 
                        timer1.Stop();

                    }
     
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
                                    pic.ImageLocation = Application.StartupPath + "\\images\\40828.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox21.Image;
                        pictureBox21.Image = pictureBox20.Image;
                        pictureBox20.Image = pictureBox19.Image;
                        pictureBox19.Image = i;

 
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
                    hitcounter = 1;

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
                                    pic.ImageLocation = Application.StartupPath + "\\images\\40828.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox21.Image;
                        pictureBox21.Image = pictureBox20.Image;
                        pictureBox20.Image = pictureBox19.Image;
                        pictureBox19.Image = i;

                        timer1.Stop();

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
                    hitcounter = 1;



                }


            }
            else if (rotateangle == 180)
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
                                    pic.ImageLocation = Application.StartupPath + "\\images\\40828.jpg";
                                pic.Visible = false;
                                pic.Refresh();

                            }
                        }

                        System.Threading.Thread.Sleep(200);
                       
                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            ballname = "picturebox" + j.ToString();
                            ctls = this.Controls.Find(ballname, true);
                            if (ctls.Length > 0)
                            {
                                PictureBox pic = ctls[0] as PictureBox;
                                if (pic != null)
                                {
                                     pic.ImageLocation = Application.StartupPath + "\\images\\40828.jpg";
                                    //      Image oldImage = pictureBox.Image;
                                    //pic.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                                    //pic.ImageLocation = Application.StartupPath + "\\images\\29.gif";

                                    //  textBox1.Text = textBox1.Text + " " + j.ToString();
                                    pic.Refresh();
                                }

                            }

                        }

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

                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox20.Image;
                        pictureBox20.Image = i;
                        i = pictureBox21.Image;
                        pictureBox21.Image = pictureBox19.Image;
                        pictureBox19.Image = i;
                       

                        tableLayoutPanel1.Refresh();
                        

                        timer1.Stop();
                        counter = 0;

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
//                                if (pic != null)
//                                    pic.ImageLocation = Application.StartupPath + "\\images\\408282.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            ballname = "picturebox" + j.ToString();
                            ctls = this.Controls.Find(ballname, true);
                            if (ctls.Length > 0)
                            {
                                PictureBox pic = ctls[0] as PictureBox;
                                if (pic != null)
                                    pic.Refresh();
                                    pic.Visible = true;
                            }
                        }

                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox20.Image;
                        pictureBox20.Image = i;
                        i = pictureBox21.Image;
                        pictureBox21.Image = pictureBox19.Image;
                        pictureBox19.Image = i;

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
 //                               if (pic != null)
 //                                   pic.Visible = false;
  //                                  pic.ImageLocation = Application.StartupPath + "\\images\\408282.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
//  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
//  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }

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


                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox20.Image;
                        pictureBox20.Image = i;
                        i = pictureBox21.Image;
                        pictureBox21.Image = pictureBox19.Image;
                        pictureBox19.Image = i;
                       

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
                    hitcounter = 1;

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
                                //                                if (pic != null)
                                //                                    pic.ImageLocation = Application.StartupPath + "\\images\\408282.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            ballname = "picturebox" + j.ToString();
                            ctls = this.Controls.Find(ballname, true);
                            if (ctls.Length > 0)
                            {
                                PictureBox pic = ctls[0] as PictureBox;
                                if (pic != null)
                                    pic.Refresh();
                                pic.Visible = true;
                            }
                        }

                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox20.Image;
                        pictureBox20.Image = i;
                        i = pictureBox21.Image;
                        pictureBox21.Image = pictureBox19.Image;
                        pictureBox19.Image = i;
                       

                        timer1.Stop();

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
                    hitcounter = 1;


                    if (level == 6)
                    {

                        for (int j = 1; j <= 16; j++)
                        {
                            ballname = "picturebox" + j.ToString();
                            ctls = this.Controls.Find(ballname, true);
                            if (ctls.Length > 0)
                            {
                                PictureBox pic = ctls[0] as PictureBox;
                                //                                if (pic != null)
                                //                                    pic.ImageLocation = Application.StartupPath + "\\images\\408282.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            ballname = "picturebox" + j.ToString();
                            ctls = this.Controls.Find(ballname, true);
                            if (ctls.Length > 0)
                            {
                                PictureBox pic = ctls[0] as PictureBox;
                                if (pic != null)
                                    pic.Refresh();
                                pic.Visible = true;
                            }
                        }


                        Image i = pictureBox18.Image;
                        pictureBox18.Image = pictureBox20.Image;
                        pictureBox20.Image = i;
                        i = pictureBox21.Image;
                        pictureBox21.Image = pictureBox19.Image;
                        pictureBox19.Image = i;

                        timer1.Stop();

                    }

                    counter++;

                }



            }
            else if (rotateangle == 270)
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
                                    pic.ImageLocation = Application.StartupPath + "\\images\\40828.jpg";
                            }
                        }

                        ballname = "picturebox1";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox2";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox3";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox4";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 0);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox5";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox6";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox7";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox8";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 1);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox9";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox10";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox11";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox12";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 2);
                            tableLayoutPanel1.SetRow(pic, 0);
                        }
                        ballname = "picturebox13";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 3);
                        }
                        ballname = "picturebox14";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 2);
                        }
                        ballname = "picturebox15";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 1);
                        }
                        ballname = "picturebox16";
                        ctls = this.Controls.Find(ballname, true);
                        if (ctls.Length > 0)
                        {
                            PictureBox pic = ctls[0] as PictureBox;
                            pic.Visible = true;
                            //  pic.Image.
                            tableLayoutPanel1.SetColumn(pic, 3);
                            tableLayoutPanel1.SetRow(pic, 0);
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
                    hitcounter = 1;

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
                    hitcounter = 1;


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


                    }

                }


            }
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}