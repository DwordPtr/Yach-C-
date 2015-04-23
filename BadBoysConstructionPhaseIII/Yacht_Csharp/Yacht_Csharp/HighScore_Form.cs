using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Yacht_Csharp
{
    public partial class HighScore_Form : Form
    {
        private HighScore HS = new HighScore();

        public HighScore HS1
        {
            get { return HS; }
            set { HS = value; }
        }

        public HighScore_Form()
        {
            InitializeComponent();
        }

        private void HighScore_Form_Load(object sender, EventArgs e)
        {
            LoadHighScores();

            List<Label> NameLabelList = new List<Label>();
            NameLabelList.Add(NameLabel1);
            NameLabelList.Add(NameLabel2);
            NameLabelList.Add(NameLabel3);
            NameLabelList.Add(NameLabel4);
            NameLabelList.Add(NameLabel5);

            List<Label> ScoresLabelList = new List<Label>();
            ScoresLabelList.Add(ScoreLabel1);
            ScoresLabelList.Add(ScoreLabel2);
            ScoresLabelList.Add(ScoreLabel3);
            ScoresLabelList.Add(ScoreLabel4);
            ScoresLabelList.Add(ScoreLabel5);

            List<PictureBox> PictureBoxList = new List<PictureBox>();
            PictureBoxList.Add(pictureBox1);
            PictureBoxList.Add(pictureBox2);
            PictureBoxList.Add(pictureBox3);
            PictureBoxList.Add(pictureBox4);
            PictureBoxList.Add(pictureBox5);

            LoadNameLabels(NameLabelList);
            LoadScoresLabels(ScoresLabelList);
            LoadPictureBoxes(PictureBoxList);

        }

        private void LoadHighScores()
        {
            if (File.Exists("HighScores.YC#"))
            {
                FileStream fs = new FileStream("HighScores.YC#", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();
                HS1 = (HighScore)formatter.Deserialize(fs);

                fs.Close();
            }
            else
            {
                HS1 = new HighScore();
                HS1.CheckHighscores();

            }
        }

        private void LoadNameLabels(List<Label> NLL)
        {
            int i = 0;
            foreach (Player pp in HS1.HighScores)
            {
                NLL[i].Text = pp.Name; 
                i++;
            }
                
        }

        private void LoadScoresLabels(List<Label> SLL)
        {
            int i = 0;
            foreach (Player pp in HS1.HighScores)
            { 
                SLL[i].Text = pp.Score.ToString();
                //MessageBox.Show(HS1.HighScores[i].Score.ToString() + " " + s.Text);
                i++; 

            }
        }

        private void LoadPictureBoxes(List<PictureBox> PBL)
        {
            int i = 0;
            foreach (Player pp in HS1.HighScores)
            {
                //MessageBox.Show(HS1.HighScores[i].AvatarInt.ToString());
                //duck.jpg
                if (pp.AvatarInt == 1)
                { PBL[i].Image = Properties.Resources.duck; }
                //burns.gif
                if (pp.AvatarInt == 2)
                { PBL[i].Image = Properties.Resources.burns; }
                //fox.png
                if (pp.AvatarInt == 3)
                { PBL[i].Image = Properties.Resources.fox; }
                //hentai
                if (pp.AvatarInt == 4)
                { PBL[i].Image = Properties.Resources.hentai; }
                //badboi
                if (pp.AvatarInt == 5)
                { PBL[i].Image = Properties.Resources.badass; }
                //mouse
                if (pp.AvatarInt == 6)
                { PBL[i].Image = Properties.Resources.mouse; }
                //dog
                if (pp.AvatarInt == 7)
                { PBL[i].Image = Properties.Resources.jake; }
                //smiley
                if (pp.AvatarInt == 8)
                { PBL[i].Image = Properties.Resources.simley; }
                //VADER
                if (pp.AvatarInt == 9)
                { PBL[i].Image = Properties.Resources.DarthVaderheadshot; }

                i++;
            }
        }
    }
}
