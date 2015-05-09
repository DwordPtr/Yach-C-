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
    class FullHouse : ScoringOptions
    {
        public FullHouse()
        {
            Score = 0;
            ScoringName = "Full House";
            IsChosen = false;
        }


        public override int checkScore(List<int> faces)
        {
            Score = 0;

            faces.Sort();
            int mode = faces.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;
            int lowerparam = faces[0];
            int higherparam = faces[4];
            int cond = 0;

            if (lowerparam == mode)
            {
                for (int i = 0; i < 3; i++)
                    if (faces[i] == lowerparam)
                        cond++;
                for (int i = 3; i < 5; i++)
                    if (faces[i] == higherparam)
                        cond++;
            }

            if (higherparam == mode)
            {
                for (int i = 0; i < 2; i++)
                    if (faces[i] == lowerparam)
                        cond++;
                for (int i = 2; i < 5; i++)
                    if (faces[i] == higherparam)
                        cond++;
            }

            if (cond == 5)
                Score = 25;

            return Score;
        }
    }
}
