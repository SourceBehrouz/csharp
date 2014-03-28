using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrainingWMSoftware
{
    public partial class Backward_Digit_Span : Form
    {
        int cell1;
        int cell2;
        int cell3;
        int cell4;
        int cell5;
        int cell6;
        int cell7;
        int cell8;
        int cell9;
        int timebetween = 2000;

        int level = 2;
        int suceed = 0;
        int forward = 1;
        int hitcounter;
        int[] hitcountArray = {0,1,2,3,4,5,6,7,8,9,10};

        public Backward_Digit_Span()
        {
            InitializeComponent();
        }
        private void clickbottton()
        {

            if (hitcounter == 10 && level == 9)
            {
                //             textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString() + "  " + hitcountArray[6].ToString() + "  " + hitcountArray[7].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() + "  " + cell4.ToString() + "  " + cell5.ToString() + "  " + cell6.ToString() + "  " + cell7.ToString() + " " + cell8.ToString()+ " " + cell9.ToString();
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                int correctness5;
                int correctness6;
                int correctness7;
                int correctness8;
                int correctness9;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell4 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell5 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell6 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    if ((cell7 == hitcountArray[7])) correctness7 = 1; else correctness7 = 0;
                    if ((cell8 == hitcountArray[8])) correctness8 = 1; else correctness8 = 0;
                    if ((cell9 == hitcountArray[9])) correctness9 = 1; else correctness9 = 0;
                }
                else
                {
                    if ((cell9 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell8 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell7 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell6 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell5 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell4 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    if ((cell3 == hitcountArray[7])) correctness7 = 1; else correctness7 = 0;
                    if ((cell2 == hitcountArray[8])) correctness8 = 1; else correctness8 = 0;
                    if ((cell1 == hitcountArray[9])) correctness9 = 1; else correctness9 = 0;
                }
                int correcteness = (int)Math.Round((double)((correctness1 + correctness2 + correctness3 + correctness4 + correctness5 + correctness6 + correctness7 + correctness8+correctness9) * 11.11));
                textBox3.Text = correcteness.ToString();
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play(); suceed = 0;
                }

            }
            if (hitcounter == 9 && level == 8)
            {
                //             textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString() + "  " + hitcountArray[6].ToString() + "  " + hitcountArray[7].ToString();
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() + "  " + cell4.ToString() + "  " + cell5.ToString() + "  " + cell6.ToString() + "  " + cell7.ToString()+ " " + cell8.ToString();
                int correctness1;
                int correctness2;
                int correctness3;
                int correctness4;
                int correctness5;
                int correctness6;
                int correctness7;
                int correctness8;
                if (forward == 1)
                {
                    if ((cell1 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell2 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell3 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell4 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell5 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell6 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    if ((cell7 == hitcountArray[7])) correctness7 = 1; else correctness7 = 0;
                    if ((cell8 == hitcountArray[8])) correctness8 = 1; else correctness8 = 0;
                }
                else
                {
                    if ((cell8 == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                    if ((cell7 == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    if ((cell6 == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    if ((cell5 == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    if ((cell4 == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    if ((cell3 == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    if ((cell2 == hitcountArray[7])) correctness7 = 1; else correctness7 = 0;
                    if ((cell1 == hitcountArray[8])) correctness8 = 1; else correctness8 = 0;
                }
                int correcteness = (int)Math.Round((double)((correctness1 + correctness2 + correctness3 + correctness4 + correctness5 + correctness6 + correctness7+correctness8) * 12.5));
                textBox3.Text = correcteness.ToString();
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play(); suceed = 0;
                }

            }
            if (hitcounter == 8 && level == 7)
            {
                //             textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString() + "  " + hitcountArray[6].ToString() + "  " + hitcountArray[7].ToString();
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
                int correcteness = (int)Math.Round((double)((correctness1 + correctness2 + correctness3 + correctness4 + correctness5 + correctness6 + correctness7) * 14.28));
                textBox3.Text = correcteness.ToString();
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play(); suceed = 0;
                }

            }
            if (hitcounter == 7 && level == 6)
            {
                //               textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString() + "  " + hitcountArray[6].ToString() ;
                textBox2.Text = cell1.ToString() + "  " + cell2.ToString() + "  " + cell3.ToString() + "  " + cell4.ToString() + "  " + cell5.ToString() + "  " + cell6.ToString();
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
                textBox3.Text = correcteness.ToString();
                if (correcteness == 100) suceed++; else suceed = 0;
                if (suceed == 2)
                {
                    level++;
                    label4.Text = level.ToString();
                    label4.ForeColor = Color.Red;
                    label4.Refresh();
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "chord.wav";
                    sound.Play(); suceed = 0;
                }

            }
            if (hitcounter == 6 && level == 5)
            {
                //               textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString() + "  " + hitcountArray[5].ToString();
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
                int correcteness = (int)Math.Round(((double)(correctness1 + correctness2 + correctness3 + correctness4 + correctness5) * 20));
                textBox3.Text = correcteness.ToString();
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
                //             textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString();
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
                textBox3.Text = correcteness.ToString();
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
                //             textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString();
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
                int correcteness = (int)Math.Round((double)(correctness1 + correctness2 + correctness3) * 33.3);
                textBox3.Text = correcteness.ToString();
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
                    //             textBox1.Text = hitcountArray[1].ToString() + "  " + hitcountArray[2].ToString() + "  " + hitcountArray[3].ToString() + "  " + hitcountArray[4].ToString();
                    textBox2.Text = cell1.ToString() + "  " + cell2.ToString();
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
                    int correcteness = (int)Math.Round((double)(correctness1 + correctness2) * 50);
                    textBox3.Text = correcteness.ToString();
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


            
            
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            button1.Enabled = false;
            Random random = new Random();
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

                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }




                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                hitcounter = 1;
                button1.Enabled = true;


            }

            if (level == 3)
            {

                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }

                cell3 = random.Next(0, 9);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(0, 9);
                }



                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);


                hitcounter = 1;
                button1.Enabled = true;


            }

            if (level == 4)
            {
 
                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }

                cell3 = random.Next(0, 9);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(0, 9);
                }

                cell4 = random.Next(0, 9);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(0, 9);
                }


                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell4.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                hitcounter = 1;
                button1.Enabled = true;


            }
            else if (level == 5)
            {

                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }

                cell3 = random.Next(0, 9);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(0, 9);
                }

                cell4 = random.Next(0, 9);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(0, 9);
                }

                cell5 = random.Next(0, 9);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(0, 9);
                }

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell4.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell5.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);
                hitcounter = 1;
                button1.Enabled = true;

            }
            else if (level == 6)
            {


                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }

                cell3 = random.Next(0, 9);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(0, 9);
                }

                cell4 = random.Next(0, 9);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(0, 9);
                }

                cell5 = random.Next(0, 9);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(0, 9);
                }

                cell6 = random.Next(0, 9);
                while ((cell6 == cell1) || (cell6 == cell2) || (cell6 == cell3) || (cell6 == cell4) || (cell6 == cell5))
                {
                    cell6 = random.Next(0, 9);
                }
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell4.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell5.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell6.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);
                
            }
            else if (level == 7)
            {


                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }

                cell3 = random.Next(0, 9);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(0, 9);
                }

                cell4 = random.Next(0, 9);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(0, 9);
                }

                cell5 = random.Next(0, 9);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(0, 9);
                }

                cell6 = random.Next(0, 9);
                while ((cell6 == cell1) || (cell6 == cell2) || (cell6 == cell3) || (cell6 == cell4) || (cell6 == cell5))
                {
                    cell6 = random.Next(0, 9);
                }
                cell7 = random.Next(0, 9);
                while ((cell7 == cell1) || (cell7 == cell2) || (cell7 == cell3) || (cell7 == cell4) || (cell7 == cell5) || (cell7 == cell6))
                {
                    cell7 = random.Next(0, 9);
                }
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell4.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell5.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell6.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell7.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);
            }
            else if (level == 8)
            {


                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }

                cell3 = random.Next(0, 9);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(0, 9);
                }

                cell4 = random.Next(0, 9);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(0, 9);
                }

                cell5 = random.Next(0, 9);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(0, 9);
                }

                cell6 = random.Next(0, 9);
                while ((cell6 == cell1) || (cell6 == cell2) || (cell6 == cell3) || (cell6 == cell4) || (cell6 == cell5))
                {
                    cell6 = random.Next(0, 9);
                }
                cell7 = random.Next(0, 9);
                while ((cell7 == cell1) || (cell7 == cell2) || (cell7 == cell3) || (cell7 == cell4) || (cell7 == cell5) || (cell7 == cell6))
                {
                    cell7 = random.Next(0, 9);
                }
                cell8 = random.Next(0, 9);
                while ((cell8 == cell1) || (cell8 == cell2) || (cell8 == cell3) || (cell8 == cell4) || (cell8 == cell5) || (cell8 == cell6)||(cell8 == cell7))
                {
                    cell8 = random.Next(0, 9);
                }
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell4.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell5.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell6.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell7.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell8.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);
            }
            else if (level == 9)
            {


                cell1 = random.Next(0, 9);
                cell2 = random.Next(0, 9);
                while (cell2 == cell1)
                {
                    cell2 = random.Next(0, 9);
                }

                cell3 = random.Next(0, 9);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(0, 9);
                }

                cell4 = random.Next(0, 9);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(0, 9);
                }

                cell5 = random.Next(0, 9);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(0, 9);
                }

                cell6 = random.Next(0, 9);
                while ((cell6 == cell1) || (cell6 == cell2) || (cell6 == cell3) || (cell6 == cell4) || (cell6 == cell5))
                {
                    cell6 = random.Next(0, 9);
                }
                cell7 = random.Next(0, 9);
                while ((cell7 == cell1) || (cell7 == cell2) || (cell7 == cell3) || (cell7 == cell4) || (cell7 == cell5) || (cell7 == cell6))
                {
                    cell7 = random.Next(0, 9);
                }
                cell8 = random.Next(0, 9);
                while ((cell8 == cell1) || (cell8 == cell2) || (cell8 == cell3) || (cell8 == cell4) || (cell8 == cell5) || (cell8 == cell6) || (cell8 == cell7))
                {
                    cell8 = random.Next(0, 9);
                }
                cell9 = random.Next(0, 9);
                while ((cell9 == cell1) || (cell9 == cell2) || (cell9 == cell3) || (cell9 == cell4) || (cell9 == cell5) || (cell9 == cell6) || (cell9 == cell7)||(cell9 == cell8))
                {
                    cell9 = random.Next(0, 9);
                }
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "sounds/numbers/" + cell1.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell2.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell4.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell5.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell6.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell7.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell8.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);

                player.SoundLocation = "sounds/numbers/" + cell9.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(timebetween);
            }
            hitcounter = 1;
            button1.Enabled = true;




        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 0;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "0";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 1;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "1";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 2;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "2";


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 3;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "3";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 4;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "4";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 5;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "5";

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 6;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "6";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 7;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "7";

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 9;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "9";
        }

        private void Backward_Digit_Span_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0; this.Bounds = Screen.PrimaryScreen.Bounds;
            WindowState = FormWindowState.Maximized;
            label4.Text = level.ToString();
            label4.ForeColor = Color.Red;
            label4.Refresh();
            radioButton1.Checked = true;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 8;
            hitcounter++;
            clickbottton();
            textBox1.Text = textBox1.Text + " " + "8";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



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