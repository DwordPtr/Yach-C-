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
    /// <summary>
    ///  This is the form that displays all of the Gameplay options
    /// </summary>
    public partial class Gameplay_Form : Form
    {
        /// <summary>
        /// This dice list is used to check scores so that the gameplay dice is not manipulated by the checkscores functions
        /// </summary>
        
        public List<int> scores_dice = new List<int> { 0, 0, 0, 0, 0};
        /// <summary>
        /// This is a list that holds all of the picture boxes that display the dice that are held
        /// </summary>
        
        public List<PictureBox> HeldDiceBoxList = new List<PictureBox>();
        /// <summary>
        /// This is a list that holds all of the picture boxes that display the dice that are rolled
        /// </summary>
        public List<PictureBox> RollDiceBoxList = new List<PictureBox>();

        /// <summary>
        /// A boolean that is used to check whether this gamestate is saved 
        /// </summary>
        public bool gameSaveState = false;

        private Gamesetup_Form gamesetup;
        
        /// <summary>
        /// Form Initialization function
        /// </summary>
        public Gameplay_Form()
        {
            InitializeComponent();
            //LoadPlayerAvatar();
        }

        private void Gamesetup_Form_Load(object sender, EventArgs e)
        {
            gamesetup = (Gamesetup_Form)this.Owner;
            RefreshScoresList();
            RefreshPlayerList();
            LoadPlayerAvatar();
            chooseScore_button.Enabled = false;
            InitDiceBoxes();
        }

        private void InitDiceBoxes()
        {
            HeldDiceBoxList.Add(HeldDiceBox1);
            HeldDiceBoxList.Add(HeldDiceBox2);
            HeldDiceBoxList.Add(HeldDiceBox3);
            HeldDiceBoxList.Add(HeldDiceBox4);
            HeldDiceBoxList.Add(HeldDiceBox5);

            RollDiceBoxList.Add(RollDice1);
            RollDiceBoxList.Add(RollDice2);
            RollDiceBoxList.Add(RollDice3);
            RollDiceBoxList.Add(RollDice4);
            RollDiceBoxList.Add(RollDice5);
        }

        private void ResetDiceBox()
        {
            foreach (PictureBox p in HeldDiceBoxList)
                p.Image = null;
            foreach (PictureBox p in RollDiceBoxList)
                p.Image = null;
        }

        private void RefreshRollDice()
        {
            for (int i = 0; i < gamesetup.inF.GameClass.GameDice.Faces.Count; i++)
            {
                if (gamesetup.inF.GameClass.GameDice.Faces_held[i] == false)
                {
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 1)
                        RollDiceBoxList[i].Image = Properties.Resources.rolldice1;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 2)
                        RollDiceBoxList[i].Image = Properties.Resources.rolldice2;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 3)
                        RollDiceBoxList[i].Image = Properties.Resources.rolldice3;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 4)
                        RollDiceBoxList[i].Image = Properties.Resources.rolldice4;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 5)
                        RollDiceBoxList[i].Image = Properties.Resources.rolldice5;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 6)
                        RollDiceBoxList[i].Image = Properties.Resources.rolldice6;
                }
            }
        }

        private void RefreshHeldDice()
        {
            for (int i = 0; i < gamesetup.inF.GameClass.GameDice.Faces.Count; i++)
            {
                if (gamesetup.inF.GameClass.GameDice.Faces_held[i] == true)
                {
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 1)
                        HeldDiceBoxList[i].Image = Properties.Resources.dice1;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 2)
                        HeldDiceBoxList[i].Image = Properties.Resources.dice2;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 3)
                        HeldDiceBoxList[i].Image = Properties.Resources.dice3;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 4)
                        HeldDiceBoxList[i].Image = Properties.Resources.dice4;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 5)
                        HeldDiceBoxList[i].Image = Properties.Resources.dice5;
                    if (gamesetup.inF.GameClass.GameDice.Faces[i] == 6)
                        HeldDiceBoxList[i].Image = Properties.Resources.dice6;
                }
            }
        }

        private void RefreshPlayerList()
        {
            playerList.View = View.Details;
            playerList.Items.Clear();
            foreach (Player p in gamesetup.inF.GameClass.PlayerList)
            {
                var item = new ListViewItem();
                item.Text = p.Name.ToString();
                item.SubItems.Add(p.Score.ToString());
                playerList.Items.Add(item); 
            }
        }

        private void RefreshScoresList()
        {
            for (int i = 0; i < 5; i++)
            { scores_dice[i] = gamesetup.inF.GameClass.GameDice.Faces[i]; }

            scoresList.Items.Clear();

            foreach (ScoringOptions o in gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].ScoringOptions)
            {
                
                var item = new ListViewItem();
                item.Text = o.ScoringName.ToString();

                if (o.IsChosen == true)
                {
                    item.SubItems.Add(o.Score.ToString());
                    item.Font = new System.Drawing.Font("Consolas", 12, System.Drawing.FontStyle.Strikeout | FontStyle.Bold | FontStyle.Italic);
                }
                else 
                {
                    o.checkScore(scores_dice);
                    item.SubItems.Add(o.Score.ToString());
                }
                
                scoresList.Items.Add(item);
            }
        }

        private void ButtonStatus()
        {
            gamesetup.inF.GameClass.GameRound++;

            if (gamesetup.inF.GameClass.GameRound >= 3)
            {
                rollDice_button.Enabled = false;
            }
        }

        private void RefreshButtons()
        {
            gamesetup.inF.GameClass.GameRound = 0;
            rollDice_button.Enabled = true;
        }

        private void rollDice_button_Click(object sender, EventArgs e)
        {
            chooseScore_button.Enabled = true;
            ButtonStatus();
            gamesetup.inF.GameClass.GameDice.roll_dice();

            ResetDiceBox();
            RefreshRollDice();
            RefreshHeldDice();
            RefreshScoresList();
        }

        private void chooseScore_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool Chosen = false;
            ListView.SelectedListViewItemCollection selectedItems = scoresList.SelectedItems;

            if (selectedItems.Count > 0)
            {
                foreach (ListViewItem item in selectedItems)
                {
                    
                    foreach (ScoringOptions o in gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].ScoringOptions)
                    {

                        if (i == item.Index)
                        {
                            if (o.IsChosen == true)
                                Chosen = true;
                            o.IsChosen = true;
                        }
                        i++;
                    }
                    if (Chosen == false)
                    {
                        gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].Score += int.Parse(item.SubItems[1].Text);
                        RefreshButtons();
                        gamesetup.inF.GameClass.PlayerTurn++;

                        if (gamesetup.inF.GameClass.PlayerTurn == gamesetup.inF.GameClass.NumPlayer)
                            gamesetup.inF.GameClass.PlayerTurn = 0;

                        ResetDiceBox();
                        RefreshPlayerList();
                        gamesetup.inF.GameClass.GameDice.reset_dice();
                        RefreshScoresList();
                        LoadPlayerAvatar();
                        chooseScore_button.Enabled = false;
                        CheckEndGame();
                    }
                    else
                        MessageBox.Show("That Scoring Option has already been chosen! \n Please Choose Again!");
                }     
            }
            else { MessageBox.Show("Please Select a Scoring option!"); }
        }

        private void LoadPlayerAvatar()
        {
            label1.Text = gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].Name;
            //duck.jpg
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 1)
            { AvatarBox.Image = Properties.Resources.duck; }
            //burns.gif
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 2)
            { AvatarBox.Image = Properties.Resources.burns; }
            //fox.png
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 3)
            { AvatarBox.Image = Properties.Resources.fox; }
            //hentai
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 4)
            { AvatarBox.Image = Properties.Resources.hentai; }
            //badboi
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 5)
            { AvatarBox.Image = Properties.Resources.badass; }
            //mouse
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 6)
            { AvatarBox.Image = Properties.Resources.mouse; }
            //dog
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 7)
            { AvatarBox.Image = Properties.Resources.jake; }
            //smiley
            if (gamesetup.inF.GameClass.PlayerList[gamesetup.inF.GameClass.PlayerTurn].AvatarInt == 8)
            { AvatarBox.Image = Properties.Resources.simley; }
        }

        private void EasterEgg2_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EasterEgg Unlocked");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameSaveState == false)
            {
                //MessageBox.Show("The game is not saved");
                string message = "Do you want to save the game before you exit?";
                string caption = "The Game is not currently Saved.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
                if (result.ToString() == "Yes")
                    SaveTheGame();
                if (result.ToString() == "No")  
                    this.Close(); 
            }
            else { this.Close(); }
        }

        private void saveGameStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTheGame();
            gameSaveState = true;
        }

        private void Gameplay_FormClosed(object sender, EventArgs e)
        {
            gamesetup.inF.GameClass = null;
            gamesetup.inF.GameClass = new Game();
        }

        private void SaveTheGame()
        {
            FileStream fs = new FileStream("Game.YC#", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, gamesetup.inF.GameClass);
            }
            catch (SerializationException SE)
            {
                MessageBox.Show("Failed to Save. Reason: " + SE.Message);
                throw;
            }
            finally
            {
                fs.Close();
                MessageBox.Show("Game Sucessully Saved!");
            }
        }

        private void CheckEndGame()

        {
            bool endgame = true;
            for (int i = 0; i < gamesetup.inF.GameClass.NumPlayer; i++)
            {
                foreach (ScoringOptions o in gamesetup.inF.GameClass.PlayerList[i].ScoringOptions)
                    if (o.IsChosen == false)
                        endgame = false;
            }

            if (endgame == true)
            {
                MessageBox.Show("'Tis the End");

                CheckHighScores();

                HighScore_Form hsf = new HighScore_Form();
                hsf.ShowDialog();

                gamesetup.inF.GameClass = null;
                gamesetup.inF.GameClass = new Game();
                this.Close();
            }
        }

        private void CheckHighScores()
        {
            HighScore HS1;
            FileStream fs;
            //foreach (Player aa in HS1.HighScores)
            //    MessageBox.Show(aa.Name.ToString() + "\n" + aa.Score.ToString() + "\n", "HighScores");

            BinaryFormatter formatter = new BinaryFormatter();

            if (File.Exists("HighScores.YC#"))
            {
                fs = new FileStream("HighScores.YC#", FileMode.Open);
                HS1 = (HighScore)formatter.Deserialize(fs);
                HS1.CheckHighscores(gamesetup.inF.GameClass.PlayerList);
                fs.Close();
            }
            else 
            {
                HS1 = new HighScore();
                HS1.PresetHighScores();
                HS1.CheckHighscores(gamesetup.inF.GameClass.PlayerList);
            }
            
            

            //save highscores:

            FileStream fs2 = new FileStream("HighScores.YC#", FileMode.OpenOrCreate);
            formatter.Serialize(fs2, HS1);
            fs2.Close();

        }

        private void RollDice1_Click(object sender, EventArgs e)
        {
            if (RollDice1.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[0] = true;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void RollDice2_Click(object sender, EventArgs e)
        {
            if (RollDice2.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[1] = true;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void RollDice3_Click(object sender, EventArgs e)
        {
            if (RollDice3.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[2] = true;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void RollDice4_Click(object sender, EventArgs e)
        {
            if (RollDice4.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[3] = true;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void RollDice5_Click(object sender, EventArgs e)
        {
            if (RollDice5.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[4] = true;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void HeldDiceBox1_Click(object sender, EventArgs e)
        {
            if (HeldDiceBox1.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[0] = false;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void HeldDiceBox2_Click(object sender, EventArgs e)
        {
            if (HeldDiceBox2.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[1] = false;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void HeldDiceBox3_Click(object sender, EventArgs e)
        {
            if (HeldDiceBox3.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[2] = false;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void HeldDiceBox4_Click(object sender, EventArgs e)
        {
            if (HeldDiceBox4.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[3] = false;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }

        private void HeldDiceBox5_Click(object sender, EventArgs e)
        {
            if (HeldDiceBox5.Image != null)
            {
                gamesetup.inF.GameClass.GameDice.Faces_held[4] = false;
                ResetDiceBox();
                RefreshRollDice();
                RefreshHeldDice();
            }
        }
    }   
}
