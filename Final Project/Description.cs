using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Description
    {
        public string Synopsis { get; set; }
        public double Score { get; set; }
        public int ReleaseYear { get; set; }

        

        public Description()
        {

        }

        public Description(string synopsis, double score, int releaseYear, string gameImage)
        {
            synopsis = Synopsis;
            score = Score;
            releaseYear = ReleaseYear;
            
        }

        public override string ToString()
        {
            return string.Format($"{Synopsis} - released in {ReleaseYear}.\n\n Average user score of {Score}");

        }
    }
}
