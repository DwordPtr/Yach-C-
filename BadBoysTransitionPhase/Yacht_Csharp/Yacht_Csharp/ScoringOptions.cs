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
    /// Scoring Options is an abstract class for each of the defined Yacht-C# scoring options
    /// </summary>
    [Serializable()]
    public abstract class ScoringOptions
    {
        private bool isChosen;

        /// <summary>
        /// IsChosen is a boolean that gives 
        /// </summary>
        public bool IsChosen
        {
            get { return isChosen; }
            set { isChosen = value; }
        }
        private int score;
        /// <summary>
        /// The value of the score associated with the score type
        /// This is set according to different rules for the different derrived classes
        /// </summary>
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        private string scoringName;
        /// <summary>
        /// The name for each score type
        /// </summary>
        public string ScoringName
        {
            get { return scoringName; }
            set { scoringName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="faces"> Takes a list of ints that corresponds to each of the dice values</param>
        /// <returns></returns>
        public abstract int checkScore(List<int> faces);
    }
}
