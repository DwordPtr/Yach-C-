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
    /// Dice is the class that holds all of the methods and performs all of the functions for dice
    /// </summary>
    [Serializable()]
    public class Dice
    {
        private Random rand = new Random();
        private int dice_num = 5;

        private List<int> faces = new List<int> {0,0,0,0,0};

        /// <summary>
        /// Faces is a list of integers that correspond to the value of each rolled dice
        /// </summary>
        public List<int> Faces
        {
            get { return faces; }
            set { faces = value; }
        }

        private List<bool> faces_held = new List<bool> {false,false,false,false,false};

        /// <summary>
        /// Faces_held is a list of booleans that correspond to whether or not a dice is held
        /// </summary>
        public List<bool> Faces_held
        {
            get { return faces_held; }
            set { faces_held = value; }
        }

        /// <summary>
        /// roll dice is a method that generates a random number from 1-6 for each dice that is not held
        /// </summary>
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

        /// <summary>
        /// reset_dice is a method that sets each face value of dice to 0 and marks them all as not held.
        /// </summary>
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
