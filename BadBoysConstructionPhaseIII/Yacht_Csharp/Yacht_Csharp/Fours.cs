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
    class Fours : ScoringOptions
    {
        public Fours()
        {   
            Score = 0;
            ScoringName = "Fours";
            IsChosen = false;
        }

        public override int checkScore(List<int> faces)
        {
            Score = 0;
            for (int i = 0; i < faces.Count; i++)
            {
                if (faces[i] == 4)
                {
                    Score = Score + 4;
                }
            }

            return Score;
        }
    }
}
