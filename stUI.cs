using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace sampleframe.cs
{
    public partial class stUI : Form
    {
        public stUI()
        {
            InitializeComponent();
        }

        

        private void button2_Click_3(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Hello";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Nawarathna\Downloads\2020-05-21\wave\Hello.wav");
            splayer.Play();
        }

        private void stUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMessage.Text =  " ";
        }

        private void btnGoodBye_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Good Bye";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Good bye.wav");
            splayer.Play();
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "I";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\i.wav");
            splayer.Play();
        }

        private void btnYou_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "you";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\You.wav");
            splayer.Play();
        }

        private void btnWash_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "wash";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Wash.wav");
            splayer.Play();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "like";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Like.wav");
            splayer.Play();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "eye";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Eye.wav");
            splayer.Play();
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "hand";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Hand.wav");
            splayer.Play();
        }

        private void btnToilet_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "toilet";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Toilet.wav");
            splayer.Play();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "food";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Food.wav");
            splayer.Play();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "no";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\No.wav");
            splayer.Play();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "yes";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Yes.wav");
            splayer.Play();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "man";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Man.wav");
            splayer.Play();
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "woman";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Woman.wav");
            splayer.Play();
        }

        private void btnWant_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "want";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Want.wav");
            splayer.Play();
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "sad";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Sad.wav");
            splayer.Play();
        }

        private void btnMouth_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "mouth";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Mouth.wav");
            splayer.Play();
        }

        private void btnLeg_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "leg";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Leg.wav");
            splayer.Play();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "drink";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Drink.wav");
            splayer.Play();
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "house";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\House.wav");
            splayer.Play();
        }

        private void btnBrother_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "brother";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Brother.wav");
            splayer.Play();
        }

        private void btnSister_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "sister";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Sister.wav");
            splayer.Play();
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "mother";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Mother.wav");
            splayer.Play();
        }

        private void btnFather_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "father";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Father .wav");
            splayer.Play();
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "happy";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Happy.wav");
            splayer.Play();
        }

        private void btnAngry_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "angry";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Angry.wav");
            splayer.Play();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "big";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Big.wav");
            splayer.Play();
        }

        private void btnLittle_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "small";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Small.wav");
            splayer.Play();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "animal";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Animal.wav");
            splayer.Play();
        }

        private void btnIndicator_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "indicator";
            SoundPlayer splayer = new SoundPlayer(@"H:\level 3\1 nd semester\uni 3rd year\1st semester\project\Project Version\2020-05-09\wave\Indicator.wav");
            splayer.Play();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            txtMessage.Text = " ";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMessage.Text != string.Empty)
                {
                    int txtlength = txtMessage.Text.Length;
                    if (txtlength != 1)
                    {

                        txtMessage.Text = txtMessage.Text.Substring(0, txtMessage.Text.LastIndexOf(" ")).Trim();

                    }
                    else
                    {
                        txtMessage.Text = 0.ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
