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
            //Adding companies and games to the databases
            GameCompanyData db = new GameCompanyData();

            using (db)
            {
                GameCompany c1 = new GameCompany() { CompanyID = 1, CompanyName = "Square Enix", Founded = 1975, CompanyImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Square_Enix_logo.svg/1200px-Square_Enix_logo.svg.png" };
                GameCompany c2 = new GameCompany() { CompanyID = 2, CompanyName = "Bethesda", Founded = 1986, CompanyImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Bethesda_Game_Studios_logo.svg/1200px-Bethesda_Game_Studios_logo.svg.png" };
                GameCompany c3 = new GameCompany() { CompanyID = 3, CompanyName = "Atlus", Founded = 1986, CompanyImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Atlus_logo_%282014%29.svg/1200px-Atlus_logo_%282014%29.svg.png" };
                GameCompany c4 = new GameCompany() { CompanyID = 4, CompanyName = "Nintendo", Founded = 1889, CompanyImage = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/d2a7fa0d-5fd4-4d4d-a4c9-c673b80862d4/dbjyfvc-82c7a4e1-e499-4b97-9c60-aa94b16b4753.png/v1/fill/w_1024,h_387,strp/nintendo_logo_transparent_by_epycwyn_dbjyfvc-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD0zODciLCJwYXRoIjoiXC9mXC9kMmE3ZmEwZC01ZmQ0LTRkNGQtYTRjOS1jNjczYjgwODYyZDRcL2RianlmdmMtODJjN2E0ZTEtZTQ5OS00Yjk3LTljNjAtYWE5NGIxNmI0NzUzLnBuZyIsIndpZHRoIjoiPD0xMDI0In1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.N-YrJ7G3oEIZPVQpwzJS0y6Dp_-wLnQMk3LWV--Obpk" };

                VideoGame g1 = new VideoGame() { GameID = 1, GameName = "Final Fantasy VII", GameRelease = 1997, CompanyID = 1, GameCompany = c1, GameImage = "https://s1.gaming-cdn.com/images/products/1683/orig/final-fantasy-vii-cover.jpg" };
                VideoGame g2 = new VideoGame() { GameID = 2, GameName = "Dragon Quest XI", GameRelease = 2017, CompanyID = 1, GameCompany = c1, GameImage = "https://upload.wikimedia.org/wikipedia/en/4/4c/Dragon_Quest_XI_cover_art.jpg" };
                VideoGame g3 = new VideoGame() { GameID = 3, GameName = "Nier Automata", GameRelease = 2017, CompanyID = 1, GameCompany = c1, GameImage = "https://www.mobygames.com/images/covers/l/623192-nier-automata-game-of-the-yorha-edition-playstation-4-front-cover.png" };

                VideoGame g4 = new VideoGame() { GameID = 4, GameName = "Skyrim", GameRelease = 2011, CompanyID = 2, GameCompany = c2, GameImage = "https://upload.wikimedia.org/wikipedia/en/1/15/The_Elder_Scrolls_V_Skyrim_cover.png" };
                VideoGame g5 = new VideoGame() { GameID = 5, GameName = "Doom Eternal", GameRelease = 2020, CompanyID = 2, GameCompany = c2, GameImage = "https://upload.wikimedia.org/wikipedia/en/9/9d/Cover_Art_of_Doom_Eternal.png" };
                VideoGame g6 = new VideoGame() { GameID = 6, GameName = "Fallout: New Vegas", GameRelease = 2010, CompanyID = 2, GameCompany = c2, GameImage = "https://static.wikia.nocookie.net/fallout/images/f/ff/FNV_box_art_%28US%29.jpg/revision/latest?cb=20150327233343" };

                VideoGame g7 = new VideoGame() { GameID = 7, GameName = "Persona 5 Royal", GameRelease = 2019, CompanyID = 3, GameCompany = c3, GameImage = "https://www.mobygames.com/images/covers/l/636447-persona-5-royal-playstation-4-front-cover.jpg" };
                VideoGame g8 = new VideoGame() { GameID = 8, GameName = "Shin Megami Tensei Nocturne: III", GameRelease = 2003, CompanyID = 3, GameCompany = c3, GameImage = "https://upload.wikimedia.org/wikipedia/en/7/7c/Shin_Megami_Tensei_Nocturne_NA_cover.png" };
                VideoGame g9 = new VideoGame() { GameID = 9, GameName = "Persona 4 Golden", GameRelease = 2012, CompanyID = 3, GameCompany = c3, GameImage = "https://gbatemp.net/data/reviews/boxart/full/1426.jpg?1592731478" };

                VideoGame g10 = new VideoGame() { GameID = 10, GameName = "Super Smash Bros. Melee", GameRelease = 2001, CompanyID = 4, GameCompany = c4, GameImage = "https://upload.wikimedia.org/wikipedia/en/7/75/Super_Smash_Bros_Melee_box_art.png" };
                VideoGame g11 = new VideoGame() { GameID = 11, GameName = "Rhythm Heaven Fever", GameRelease = 2011, CompanyID = 4, GameCompany = c4, GameImage = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bb/Rhythm-heaven-fever.jpg/220px-Rhythm-heaven-fever.jpg" };
                VideoGame g12 = new VideoGame() { GameID = 12, GameName = "Super Mario Odyssey", GameRelease = 2017, CompanyID = 4, GameCompany = c4, GameImage = "https://static-ie.gamestop.ie/images/products/257778/3max.jpg" };

                db.GameCompanies.Add(c1);
                db.GameCompanies.Add(c2);
                db.GameCompanies.Add(c3);
                db.GameCompanies.Add(c4);
                Console.WriteLine("Added Game Companies to db");

                db.VideoGames.Add(g1);
                db.VideoGames.Add(g2);
                db.VideoGames.Add(g3);
                db.VideoGames.Add(g4);
                db.VideoGames.Add(g5);
                db.VideoGames.Add(g6);
                db.VideoGames.Add(g7);
                db.VideoGames.Add(g8);
                db.VideoGames.Add(g9);
                db.VideoGames.Add(g10);
                db.VideoGames.Add(g11);
                db.VideoGames.Add(g12);
                Console.WriteLine("Added Video Games to db");

                db.SaveChanges();
                Console.WriteLine("Saved all to db");

            }
        }
    }
}
