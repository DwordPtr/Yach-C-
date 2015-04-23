using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yacht_Csharp
{
    public partial class Playersetup_Form : Form
    {
        private int Avint = 1;
        private Gamesetup_Form gamesetup;

        public Gamesetup_Form Gamesetup
        {
            get { return gamesetup; }
            set { gamesetup = value; }
        }

        public Playersetup_Form()
        {
            InitializeComponent();
        }

        private void Gamesetup_Form_Load(object sender, EventArgs e)
        {
            gamesetup = (Gamesetup_Form)this.Owner;
            label2.Text = "Player "+(gamesetup.Numplayeriter+1).ToString();
            textBox1.Text = "++Player " + (gamesetup.Numplayeriter + 1) + "++".ToString();
            pictureBox9.Image = pictureBox1.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gamesetup.inF.GameClass.PlayerList[gamesetup.Numplayeriter].Name = textBox1.Text;
            gamesetup.inF.GameClass.PlayerList[gamesetup.Numplayeriter].AvatarInt = Avint;

            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox1.Image;
            Avint = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox2.Image;
            Avint = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox3.Image;
            Avint = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox4.Image;
            Avint = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox5.Image;
            Avint = 5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox6.Image;
            Avint = 6;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox7.Image;
            Avint = 7;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox8.Image;
            Avint = 8;
        }    
    }

}
