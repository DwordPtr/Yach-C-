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
    class Stretch : ScoringOptions
    {
        public Stretch()
        {
            Score = 0;
            ScoringName = "Stretch";
            IsChosen = false;
        }


        public override int checkScore(List<int> faces)
        {
            Score = 25;
            faces.Sort();
            List<int> cond = new List<int>();
            cond.Add(faces[0]);
            for (int i = 0; i < faces.Count - 1; i++)
            {
                if (faces[i] == faces[i + 1] - 1)
                    cond.Add(faces[i + 1]);
            }

            if (cond.Count > 3)
            {
                for (int i = 0; i < cond.Count - 1; i++)
                {
                    if (cond[i] != cond[i + 1] - 1)
                    {
                        Score = 0;
                    }
                }
            }
            else { Score = 0; }

            return Score;
        }
    }
}
