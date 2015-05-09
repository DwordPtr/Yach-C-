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
    class Aces : ScoringOptions
    {
        public Aces()
        {   
            Score = 0;
            ScoringName = "Aces";
            IsChosen = false;
        }

        public override int checkScore(List<int> faces)
        {
            Score = 0;
            for (int i = 0; i < faces.Count; i++)
            {
                if (faces[i] == 1)
                {
                    Score = Score + 1;
                }
            }

            return Score;
        }   

    }
}
