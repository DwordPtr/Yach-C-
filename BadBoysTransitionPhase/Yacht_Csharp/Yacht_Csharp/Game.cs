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
    [Serializable()]
    class Game
    {
        /// <summary>
        /// The number of players in a game
        /// </summary>
        private int numPlayer;
        public int NumPlayer
        {
            get { return numPlayer; }
            set { numPlayer = value; }
        }

        private List<Player> playerList = new List<Player>();
        internal List<Player> PlayerList
        {
            get { return playerList; }
            set { playerList = value; }
        }

        private int gameRound = 0;
        public int GameRound
        {
            get { return gameRound; }
            set { gameRound = value; }
        }

        private int playerTurn = 0;
        public int PlayerTurn
        {
            get { return playerTurn; }
            set { playerTurn = value; }
        }

        private Dice gameDice = new Dice();
        public Dice GameDice
        {
            get { return gameDice; }
            set { gameDice = value; }
        }

        /// <summary>
        /// This method creates a player object
        /// for each player in the game
        /// </summary>
        /// <param name="numplayers"></param>
        public void initialize_players(int numplayers)
        {
            for (int f = 0; f < numplayers; f++)
            {
                Player p = new Player();
                playerList.Add(p);

            }
        }
    }
}
