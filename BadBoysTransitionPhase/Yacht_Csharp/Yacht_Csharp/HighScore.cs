using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Yacht_Csharp
{
    /// <summary>
    /// This class contains all the info for a list of highscores
    /// </summary>
    [Serializable()]
    public class HighScore
    {
        /// <summary>
        /// A list of player objects with the highest scores
        /// </summary>
        private List<Player> highScores = new List<Player>();
        /// <summary>
        /// The list of players with highscores
        /// </summary>
        public List<Player> HighScores
        {
            get { return highScores; }
            set { highScores = value; }
        }
        /// <summary>
        /// Presets the HighScores
        /// </summary>
        public void PresetHighScores()
        {
            Player Mark = new Player();
            Mark.AvatarInt = 8;
            Mark.Name = "Mark";
            Mark.Score = 150;

            Player BadBoy = new Player();
            BadBoy.AvatarInt = 5;
            BadBoy.Name = "BadBoy";
            BadBoy.Score = 225;

            Player Vader = new Player();
            Vader.AvatarInt = 9;
            Vader.Name = "Vader";
            Vader.Score = 300;

            Player Bran = new Player();
            Bran.AvatarInt = 4;
            Bran.Name = "Bran ToadSwole";
            Bran.Score = 275;

            Player Carry = new Player();
            Carry.AvatarInt = 6;
            Carry.Name = "Carry";
            Carry.Score = 100;

            highScores.Add(Carry);
            highScores.Add(Mark);
            highScores.Add(BadBoy);
            highScores.Add(Vader);
            highScores.Add(Bran);
        }

        private void MergePlayerlists(List<Player> gametimeplayers)
        {
            //add all players to the HighScores List
            foreach (Player p in gametimeplayers)
            {
                HighScores.Add(p);
            }
        }

        private void ClipHighScores()
        {
            int LenHS = HighScores.Count;
            for (int i = 5; i < LenHS; i++)
                HighScores.RemoveAt(i);
        }
        /// <summary>
        /// Read the player lists into high scores
        /// </summary>
        /// <param name="gametimeplayers"></param>
        public void CheckHighscores(List<Player> gametimeplayers)
        {
            MergePlayerlists(gametimeplayers);
            //PresetHighScores();
            //Its nasty, but Bubble Sort

            Player temp;
            for (int j = 0; j < HighScores.Count; j++)
                for (int i = 0; i < HighScores.Count-1; i++)
                    if (HighScores[i].Score < HighScores[i + 1].Score)
                    {
                        temp = HighScores[i];
                        HighScores[i] = HighScores[i + 1];
                        HighScores[i + 1] = temp;
                    }
            //ClipHighScores();
        }
        /// <summary>
        /// Overloaded Check HighScores
        /// loads in the presets if previous high scores don't exsist
        /// </summary>
        public void CheckHighscores()
        {
            PresetHighScores();

            Player temp;
            for (int j = 0; j < HighScores.Count; j++)
                for (int i = 0; i < HighScores.Count - 1; i++)
                    if (HighScores[i].Score < HighScores[i + 1].Score)
                    {
                        temp = HighScores[i];
                        HighScores[i] = HighScores[i + 1];
                        HighScores[i + 1] = temp;
                    }
        }

    }
}
