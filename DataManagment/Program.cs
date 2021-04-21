using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project;

namespace DataManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCompanyData db = new GameCompanyData();

            using (db)
            {
                GameCompany c1 = new GameCompany() { CompanyID = 1, CompanyName = "Square Enix", Founded = 1975, CompanyImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Square_Enix_logo.svg/1200px-Square_Enix_logo.svg.png" };
                GameCompany c2 = new GameCompany() { CompanyID = 2, CompanyName = "Bethesda", Founded = 1986, CompanyImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Bethesda_Game_Studios_logo.svg/1200px-Bethesda_Game_Studios_logo.svg.png" };
                GameCompany c3 = new GameCompany() { CompanyID = 3, CompanyName = "Atlus", Founded = 1986, CompanyImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Atlus_logo_%282014%29.svg/1200px-Atlus_logo_%282014%29.svg.png" };
                GameCompany c4 = new GameCompany() { CompanyID = 4, CompanyName = "Nintendo", Founded = 1889, CompanyImage = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/d2a7fa0d-5fd4-4d4d-a4c9-c673b80862d4/dbjyfvc-82c7a4e1-e499-4b97-9c60-aa94b16b4753.png/v1/fill/w_1024,h_387,strp/nintendo_logo_transparent_by_epycwyn_dbjyfvc-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD0zODciLCJwYXRoIjoiXC9mXC9kMmE3ZmEwZC01ZmQ0LTRkNGQtYTRjOS1jNjczYjgwODYyZDRcL2RianlmdmMtODJjN2E0ZTEtZTQ5OS00Yjk3LTljNjAtYWE5NGIxNmI0NzUzLnBuZyIsIndpZHRoIjoiPD0xMDI0In1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.N-YrJ7G3oEIZPVQpwzJS0y6Dp_-wLnQMk3LWV--Obpk" };

                VideoGame g1 = new VideoGame() { GameID = 1, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g2 = new VideoGame() { GameID = 2, GameName = "Dragon Quest XI", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g3 = new VideoGame() { GameID = 3, GameName = "", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };

                VideoGame g4 = new VideoGame() { GameID = 4, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g5 = new VideoGame() { GameID = 5, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g6 = new VideoGame() { GameID = 6, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };

                VideoGame g7 = new VideoGame() { GameID = 7, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g8 = new VideoGame() { GameID = 8, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g9 = new VideoGame() { GameID = 9, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };

                VideoGame g10 = new VideoGame() { GameID = 10, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g11 = new VideoGame() { GameID = 11, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };
                VideoGame g12 = new VideoGame() { GameID = 12, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "" };

            }
        }
    }
}
