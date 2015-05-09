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
    /// <summary>
    /// This class handles the gui for the highscore pane
    /// </summary>
    public partial class HighScore_Form : Form
    {
        private HighScore HS = new HighScore();

        public HighScore HS1
        {
            get { return HS; }
            set { HS = value; }
        }
        /// <summary>
        /// initialize HighScore_Form 
        /// </summary>
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
                HS1.CheckHighscores();
            }
        }

        private void LoadNameLabels(List<Label> NLL)
        {
            for (int i = 0; i < 5; i++ )
            {
                NLL[i].Text = HS1.HighScores[i].Name;
            }      
        }

        private void LoadScoresLabels(List<Label> SLL)
        {
            for (int i = 0; i < 5; i++)
            {
                SLL[i].Text = HS1.HighScores[i].Score.ToString() ;
            }
        }

        private void LoadPictureBoxes(List<PictureBox> PBL)
        {
            for (int i = 0; i < 5; i++ )
            {
                //duck.jpg
                if (HS1.HighScores[i].AvatarInt == 1)
                { PBL[i].Image = Properties.Resources.duck; }
                //burns.gif
                if (HS1.HighScores[i].AvatarInt == 2)
                { PBL[i].Image = Properties.Resources.burns; }
                //fox.png
                if (HS1.HighScores[i].AvatarInt == 3)
                { PBL[i].Image = Properties.Resources.fox; }
                //hentai
                if (HS1.HighScores[i].AvatarInt == 4)
                { PBL[i].Image = Properties.Resources.hentai; }
                //badboi
                if (HS1.HighScores[i].AvatarInt == 5)
                { PBL[i].Image = Properties.Resources.badass; }
                //mouse
                if (HS1.HighScores[i].AvatarInt == 6)
                { PBL[i].Image = Properties.Resources.mouse; }
                //dog
                if (HS1.HighScores[i].AvatarInt == 7)
                { PBL[i].Image = Properties.Resources.jake; }
                //smiley
                if (HS1.HighScores[i].AvatarInt == 8)
                { PBL[i].Image = Properties.Resources.simley; }
                //VADER
                if (HS1.HighScores[i].AvatarInt == 9)
                { PBL[i].Image = Properties.Resources.DarthVaderheadshot; }
            }
        }
    }
}
