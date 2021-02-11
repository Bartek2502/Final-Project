using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Games
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public DateTime RealeaseDate { get; set; }

        public Games()
        {

        }
        public Games(string name, double score, DateTime realeaseDate)
        {
            name = Name;
            score = Score;
            realeaseDate = RealeaseDate;   
        }

    }
}
