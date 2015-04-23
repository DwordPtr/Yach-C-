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
    public partial class Gameplay_Form : Form
    {
        public List<int> scores_dice = new List<int> { 0, 0, 0, 0, 0};
        public bool gameSaveState = false;

        private Gamesetup_Form gamesetup;

        public Gamesetup_Form Gamesetup
        {
            get { return gamesetup; }
            set { gamesetup = value; }
        }
        
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
            rolldiceList.View = View.Details;
            LoadPlayerAvatar();
            chooseScore_button.Enabled = false;
            
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

            for (int i = 0; i < gamesetup.inF.GameClass.GameDice.Faces.Count; i++)
                gamesetup.inF.GameClass.GameDice.Faces_held[i] = false;

            if (rolldiceList.Items.Count > 0)
            {
                for (int i = 0; i < gamesetup.inF.GameClass.GameDice.Faces.Count; i++)
                {
                    if (rolldiceList.Items[i].Checked == true)
                        gamesetup.inF.GameClass.GameDice.Faces_held[i] = true;
                }
            }

            rolldiceList.Items.Clear();
            gamesetup.inF.GameClass.GameDice.roll_dice();

            for (int i = 0; i < gamesetup.inF.GameClass.GameDice.Faces.Count; i++)
            {
                rolldiceList.Items.Add(gamesetup.inF.GameClass.GameDice.Faces[i].ToString());
                if (gamesetup.inF.GameClass.GameDice.Faces_held[i] == true)
                    rolldiceList.Items[i].Checked = true;
            }
            
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

                        RefreshPlayerList();
                        gamesetup.inF.GameClass.GameDice.reset_dice();
                        RefreshScoresList();
                        rolldiceList.Items.Clear();
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
            //implement load and save highscores through serialization!!!!!
            //then add a form on the initialization for to load and display highscores!!!!

            HighScore HS1;
            FileStream fs;
            //foreach (Player aa in hs.HighScores)
            //    MessageBox.Show(aa.Name.ToString() + "\n" + aa.Score.ToString() + "\n", "HighScores");

            BinaryFormatter formatter = new BinaryFormatter();

            if (File.Exists("HighScores.YC#"))
            {
                fs = new FileStream("HighScores.YC#", FileMode.Open);
                HS1 = (HighScore)formatter.Deserialize(fs);
            }
            else { fs = new FileStream("HighScores.YC#", FileMode.Create); HS1 = new HighScore(); }

            HS1.CheckHighscores(gamesetup.inF.GameClass.PlayerList);

            //save highscores:

            try
            {
                formatter.Serialize(fs, HS1);
            }
            catch (SerializationException SE)
            {
                MessageBox.Show("Failed to Save. Reason: " + SE.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

        }
    }   
}
