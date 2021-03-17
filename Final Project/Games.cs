using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public abstract class Games
    {
        //properties
        public string Name { get; set; }
        public  int Pegi { get; set; }

        public string GameImage { get; set; }
        public List<Description> SynopsisList { get; set; }

        //default constructor 
        public Games() : this("Unknown", 0,"Unknown") { }
        

        
        public Games(string name, int pegi, string gameImage)
        {
            name = Name;
            pegi = Pegi;
            gameImage = GameImage;
            SynopsisList = new List<Description>();
        }
        public override string ToString()
        {
            return Name + "(" + Pegi + ")";
        }

        public string DisplayList()
        {
            string s = "";

            foreach (var item in SynopsisList)
            {
                s += item + "\n";
            }

            return s;
        }

       /* public string DisplayScore()
        {
            string s = "";

            foreach (var item in SynopsisList)
            {
                s += item + "\n";
            }

            return s;
        }*/

    }
    public class Platformer : Games
    {
        public override string ToString()
        {
            return base.ToString() + " - Platformer";
        }
    }
    public class RPG: Games
    {
        public override string ToString()
        {
            return base.ToString() + " - RPG";
        }
    }
    public class Horror: Games
    {
        public override string ToString()
        {
            return base.ToString() + " - Horror";
        }
    }
    public class Puzzle: Games
    {
        public override string ToString()
        {
            return base.ToString() + " - Puzzle";
        }
    }
}
