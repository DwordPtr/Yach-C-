using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Yacht_Csharp
{
    public partial class Initialization_Form : Form
    {
        private Game gameClass = new Game();
        internal Game GameClass
        {
            get { return gameClass; }
            set { gameClass = value; }
        }

        private bool fromForm = true;
        public bool FromFirstForm
        {
            get { return fromForm; }
            set { fromForm = value; }
        }

        public Initialization_Form()
        {
            InitializeComponent();
        }

        private void EasterEgg1_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Easter Egg 1 found");
        }

        private void NewGame_button_Click(object sender, EventArgs e)
        {
            FromFirstForm = false;
            Gamesetup_Form gamesetup = new Gamesetup_Form();
            gamesetup.Owner = this;
            gamesetup.ShowDialog();
        }

        private void LoadSavedGame_button_Click(object sender, EventArgs e)
        {
            if (File.Exists("Game.YC#"))
            {
                FileStream fs = new FileStream("Game.YC#", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();
                GameClass = (Game)formatter.Deserialize(fs);

                fs.Close();

                Gamesetup_Form gamesetup = new Gamesetup_Form();
                gamesetup.Owner = this;
                gamesetup.ShowDialog();
            }
            else { MessageBox.Show("There is no saved game!"); }
            
        }

        private void ViewHS_button_Click(object sender, EventArgs e)
        {
            HighScore_Form hsf = new HighScore_Form();
            hsf.ShowDialog();
        }
    }
}
