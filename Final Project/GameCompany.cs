using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final_Project
{
    public class GameCompany
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int Founded { get; set; }
        public string CompanyImage { get; set; }
        public virtual List<VideoGame> VideoGames { get; set; }

        public override string ToString()
        {
            return CompanyName;
        }
    }
    public class VideoGame
    {
        [Key]
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string GameImage { get; set; }
        public int GameRelease { get; set; }
        public int CompanyID { get; set; }
        public virtual GameCompany GameCompany { get; set; }

        public override string ToString()
        {
            return GameName;
        }
    }
    public class GameCompanyData : DbContext
    {
        public GameCompanyData() : base("MyGameCompanyData") { }

        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<GameCompany> GameCompanies { get; set; }

    }
}
