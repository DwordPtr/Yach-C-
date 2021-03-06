﻿using System;
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
    class Trips : ScoringOptions
    {
        public Trips()
        {   
            Score = 0;
            ScoringName = "Trips";
            IsChosen = false;
        }

        public override int checkScore(List<int> faces)
        {
            Score = faces.Sum();
            int mode = faces.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;
            int cond = 0;
            for (int i = 0; i < faces.Count; i++)
                if (faces[i] == mode)
                    cond++;
            if (cond < 3)
                Score = 0;

            return Score;
        }
    }
}
