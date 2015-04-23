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
    public class Player
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int score = 0;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private int avatarInt;
        public int AvatarInt
        {
            get { return avatarInt; }
            set { avatarInt = value; }
        }

        private List<object> scoringOptions = new List<object>();
        public List<object> ScoringOptions
        {
            get { return scoringOptions; }
            set { scoringOptions = value; }
        }

        public Player()
        {
            //make classes for every scroring option, and then append them to scoring options

            //Lower Level Scoring - pts = how many of selected die is in the hand
            
            //  Aces
            //  Deucs
            //  Threes
            //  Fours
            //  Fives
            //  Sixes

            
            Aces ace = new Aces();
            scoringOptions.Add(ace);
            Deuces duece = new Deuces();
            scoringOptions.Add(duece);
            Threes three = new Threes();
            scoringOptions.Add(three);
            Fours four = new Fours();
            scoringOptions.Add(four);
            Fives five = new Fives();
            scoringOptions.Add(five);
            Sixes six = new Sixes();
            scoringOptions.Add(six);

            //Upper Level Scoring - Specialized scoring options

            //  Trips - 3 of a kind (adds up all dice in the hand if true)
            //  Quads - 4 of a kind (adds up all dice in the hand if true)
            //  Full House - two of any kind + three of any kind (25pts)
            //  Stretch - Run of four (1,2,3,4::2,3,4,5::3,4,5,6) (30pts)
            //  Straight - Run of five (1,2,3,4,5::2,3,4,5,6) (40pts)
            //  Yacht-Csharp - 5 of a kind (automatically 50pts)

            Trips trips = new Trips();
            scoringOptions.Add(trips);

            Quads quads = new Quads();
            scoringOptions.Add(quads);

            FullHouse fullhouse = new FullHouse();
            scoringOptions.Add(fullhouse);

            Stretch stretch = new Stretch();
            scoringOptions.Add(stretch);

            Straight straight = new Straight();
            scoringOptions.Add(straight);

            LuckyDip luckydip = new LuckyDip();
            scoringOptions.Add(luckydip);

            Yacht_C_sharp yachtcsharp = new Yacht_C_sharp();
            scoringOptions.Add(yachtcsharp);
        }
    }
}
