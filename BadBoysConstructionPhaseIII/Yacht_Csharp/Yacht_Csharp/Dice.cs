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
    public class Dice
    {
        public Random rand = new Random();
        private int dice_num = 5;

        public int Dice_num
        {
            get { return dice_num; }
            set { dice_num = value; }
        }

        private List<int> faces = new List<int> {0,0,0,0,0};
        public List<int> Faces
        {
            get { return faces; }
            set { faces = value; }
        }

        private List<bool> faces_held = new List<bool> {false,false,false,false,false};
        public List<bool> Faces_held
        {
            get { return faces_held; }
            set { faces_held = value; }
        }

        public void roll_dice()
        {
            for (int i = 0; i < faces.Count; i++)
            {
                if (faces_held[i] == false)
                {
                    Faces[i] = rand.Next(1, 7);
                }
            }
        }

        public void reset_dice()
        {
            for (int i = 0; i < faces.Count; i++)
            {
                Faces_held[i] = false;
                Faces[i] = 0;
                dice_num = 5;
            }
        }
    }
}
