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
    class Straight : ScoringOptions
    {
        public Straight()
        {   
            Score = 0;
            ScoringName = "Straight";
            IsChosen = false;
        }

        public override int checkScore(List<int> faces)
        {
            Score = 30;
            faces.Sort();
            for (int i = 1; i < faces.Count; i++)
            {
                if (faces[i] != faces[i - 1]+1)
                    Score = 0;
            }

            return Score;
        }
    }
}
