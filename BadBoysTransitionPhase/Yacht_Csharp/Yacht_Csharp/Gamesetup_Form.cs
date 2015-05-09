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
    /// <summary>
    /// This class is the form that sets the number of players
    /// </summary>
    public partial class Gamesetup_Form : Form
    {

        private int numplayeriter = 0;
        /// <summary>
        /// This represents the number of players in a game
        /// </summary>
        public int Numplayeriter
        {
            get { return numplayeriter; }
            set { numplayeriter = value; }
        }
        /// <summary>
        /// This passes the reference of the data to the deeper forms
        /// </summary>
        public Initialization_Form inF;
        /// <summary>
        /// A call to initialize the form
        /// </summary>
        public Gamesetup_Form()
        {
            InitializeComponent();
            
        }
        private void Gamesetup_Form_Load(object sender, EventArgs e)
        {
            inF = (Initialization_Form)this.Owner;

            if (inF.FromFirstForm == true)
            {
                Gameplay_Form gp = new Gameplay_Form();
                gp.Owner = this;
                gp.ShowDialog();

                inF.FromFirstForm = true;
                this.Close();
            }
        }

        private void StartGame_button_Click(object sender, EventArgs e)
        {
            inF.GameClass.NumPlayer = 0;

            if (radioButton1.Checked == true)
                inF.GameClass.NumPlayer = 1;
            if (radioButton2.Checked == true)
                inF.GameClass.NumPlayer = 2;
            if (radioButton3.Checked == true)
                inF.GameClass.NumPlayer = 3;
            if (radioButton4.Checked == true)
                inF.GameClass.NumPlayer = 4;
            if (radioButton5.Checked == true)
                inF.GameClass.NumPlayer = 5;
            if (radioButton6.Checked == true)
                inF.GameClass.NumPlayer = 6;
            if (radioButton7.Checked == true)
                inF.GameClass.NumPlayer = 7;
            if (radioButton8.Checked == true)
                inF.GameClass.NumPlayer = 8;

            inF.GameClass.initialize_players(inF.GameClass.NumPlayer);

            for (int numPlayerIteration = 0; numPlayerIteration < inF.GameClass.NumPlayer; numPlayerIteration++)
            {
                numplayeriter = numPlayerIteration;
                Playersetup_Form ps = new Playersetup_Form();
                ps.Owner = this;
                ps.ShowDialog();
            }
            
            Gameplay_Form gp = new Gameplay_Form();
            gp.Owner = this;
            gp.ShowDialog();

            inF.GameClass = null;
            inF.GameClass = new Game();
            inF.FromFirstForm = true;
            this.Close();

        }
        private void Gamesetup_FormClosed(object sender, EventArgs e)
        {
            inF.FromFirstForm = true;
        }
    }
}
