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
    class Yacht_C_sharp : ScoringOptions
    {
        public Yacht_C_sharp()
        {   
            Score = 0;
            ScoringName = "Yacht C#";
            IsChosen = false;
        }

        public override int checkScore(List<int> faces)
        {
            Score = 50;
            for (int i = 1; i < faces.Count; i++)
            {
                if (faces[i] == 0)
                    Score = 0;
                if (faces[i] != faces[i - 1])
                    Score = 0;
            }

            return Score;
        } 
    }
}
