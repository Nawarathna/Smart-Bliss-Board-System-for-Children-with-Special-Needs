using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleframe.cs
{
    public partial class ADDtutor : Form
    {
        public ADDtutor()
        {
            InitializeComponent();
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ADDtutor_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
