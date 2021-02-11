using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Description
    {
        public string Synopsis { get; set; }
        public double Score { get; set; }
        public int ReleaseYear { get; set; }

        public Description()
        {

        }

        public Description(string synopsis, double score, int releaseYear)
        {
            synopsis = Synopsis;
            score = Score;
            releaseYear = ReleaseYear;
        }

        public override string ToString()
        {
            return string.Format($"{Synopsis} - released in {ReleaseYear}. Average user score of {Score}");

        }
    }
}
