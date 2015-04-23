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
    public abstract class ScoringOptions
    {
        private bool isChosen;

        public bool IsChosen
        {
            get { return isChosen; }
            set { isChosen = value; }
        }
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        private string scoringName;

        public string ScoringName
        {
            get { return scoringName; }
            set { scoringName = value; }
        }

        public abstract int checkScore(List<int> faces);
    }
}
