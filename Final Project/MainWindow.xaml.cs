﻿/* Bartlomiej Sajdok  
 * S00196895
 * Software level 8
 * Year 2 Object Oriented Development
 * Github link: https://github.com/Bartek2502/Final-Project
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;

using System.Windows.Threading;

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Games> allGames = new List<Games>(); // List for storing all the games for the second section
        GameCompanyData db = new GameCompanyData(); // Declaring the database

        // date time object for timer, only using minutes and seconds
        DateTime timeLimit = new DateTime(2021, 4, 13, 3, 30, 00, 00); 
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Calls a method to add all of the Games and Genres to the "Game Descriptions" section
            AddGamesAndGenres();

            try
            {
                //query to fill in the combo box with game companies in the second section
                var query = from gc in db.GameCompanies
                            orderby gc.CompanyName
                            select gc;

                var results = query.ToList();

                GameCompaniesBox.ItemsSource = results;

                //code for the timer 
                DispatcherTimer dt = new DispatcherTimer();
                dt.Interval = TimeSpan.FromSeconds(1); 
                //dt_Tick method will be called every second
                dt.Tick += dt_Tick;
                dt.Start();
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
           
        }

        void dt_Tick(object sender, EventArgs e)
        {
            //declaring minutes and seconds as only those will be needed for the timer
            int minute = timeLimit.Minute;
            int second = timeLimit.Second;
            timeLimit = timeLimit.AddSeconds(-1); // the timer will decrease by one second

            tblkSpecialTimer.Text = timeLimit.ToString($"{minute} : {second}");
        }
        private void AddGamesAndGenres()
        {
            //Genre names added to the combo box
            string[] genres = { "All", "Platformer", "RPG", "Horror", "Puzzle" };
            cbxGenre.ItemsSource = genres;

            string[] rating = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            cbxRate.ItemsSource = rating;
            //Platformer Games
            Games g1 = new Platformer() { Name = "Celeste", Pegi = 7, GameImage = "/images/celeste.jpg" };
            Games g2 = new Platformer() { Name = "Super Mario Odyssey", Pegi = 3, GameImage = "/images/odyssey.jpg" };
            Games g3 = new Platformer() { Name = "Crash 4", Pegi = 12, GameImage = "/images/crash.jpg" };
            Games g4 = new Platformer() { Name = "A Hat in Time", Pegi = 7, GameImage = "/images/hat.jpg" };

            //Role Playing Games
            Games g5 = new RPG() { Name = "Final Fantasy VII", Pegi = 12, GameImage = "/images/ff7.jpg" };
            Games g6 = new RPG() { Name = "Persona 5", Pegi = 16, GameImage = "/images/p5.jpg" };
            Games g7 = new RPG() { Name = "The Witcher 3", Pegi = 18, GameImage = "/images/witcher.jpg" };

            //Horror Games
            Games g8 = new Horror() { Name = "Outlast", Pegi = 18, GameImage = "/images/outlast.jpg" };
            Games g9 = new Horror() { Name = "Phasmophobia", Pegi = 12, GameImage = "/images/phas.jpg" };
            Games g10 = new Horror() { Name = "Resident Evil VILLAGE", Pegi = 18, GameImage = "/images/re8.jpg" };

            //Puzzle Games
            Games g11 = new Puzzle() { Name = "Bejeweled 3", Pegi = 3, GameImage = "/images/gem.jpg" };
            Games g12 = new Puzzle() { Name = "Candy Crush", Pegi = 3, GameImage = "/images/candy.jpg" };

            //Description for each of the games
            Description d1 = new Description()
            {
                Synopsis = "Celeste is a platform game in which players control a girl named Madeline as she makes her way up a mountain while avoiding various deadly obstacles. ",
                ReleaseYear = 2018,
                Score = 9.5,

            };

            Description d2 = new Description()
            {
                Synopsis = "Super Mario Odyssey is a platform game in which players control Mario as he travels across many different worlds, known as Kingdoms within the game, on the hat-shaped ship Odyssey",
                ReleaseYear = 2017,
                Score = 8.0,

            };

            Description d3 = new Description()
            {
                Synopsis = "It's About Time places players in control of five playable characters as they traverse multiple levels, each filled with enemies, crates, Wumpa fruit and hazards, with the objective being to get from the start point to the goal as with the original trilogy.",
                ReleaseYear = 2020,
                Score = 9.0,

            };

            Description d4 = new Description()
            {
                Synopsis = "A Hat in Time is a platform action-adventure game set in an open world environment and played from a third-person perspective.",
                ReleaseYear = 2017,
                Score = 7.9,

            };

            Description d5 = new Description()
            {
                Synopsis = "The gameplay of Final Fantasy VII is mostly comparable to earlier Final Fantasy games and Japanese role-playing games. The game features three modes of play: the world map, the field, and the battle screen.",
                ReleaseYear = 1997,
                Score = 9.7,

            };

            Description d6 = new Description()
            {
                Synopsis = "Persona 5 is a role-playing video game where the player takes on the role of a male high school student, codenamed Joker, who lives out a single year while attending school in modern-day Tokyo.",
                ReleaseYear = 2016,
                Score = 9.9,

            };

            Description d7 = new Description()
            {
                Synopsis = "The Witcher 3: Wild Hunt is an action role-playing game with a third-person perspective. Players control Geralt of Rivia, a monster slayer known as a Witcher.",
                ReleaseYear = 2015,
                Score = 8.3,

            };

            Description d8 = new Description()
            {
                Synopsis = "In Outlast, the player assumes the role of investigative journalist Miles Upshur, as he navigates a dilapidated psychiatric hospital in Leadville, Colorado that is overrun by homicidal patients.",
                ReleaseYear = 2014,
                Score = 5.5,

            };
            Description d9 = new Description()
            {
                Synopsis = "The player takes control of one member from a group of up to four players, in the roles of urban exploring ghost hunters, who are contracted to deal with ghosts inhabiting different abandoned facilities such as homes, schools, prisons and hospitals.",
                ReleaseYear = 2020,
                Score = 8.2,

            };

            Description d10 = new Description()
            {
                Synopsis = "Like Resident Evil 7 (2017), Resident Evil Village uses a first-person perspective. The inventory management system is similar to that of Resident Evil 4 (2005), featuring a briefcase.",
                ReleaseYear = 2021,
                Score = 9.0,

            };

            Description d11 = new Description()
            {
                Synopsis = "The core objective of Bejeweled 3 is similar to the previous installments in the series. Players swap any on-screen gem with an adjacent one to form chains of three or more gems of the same color.",
                ReleaseYear = 2010,
                Score = 7.8,

            };

            Description d12 = new Description()
            {
                Synopsis = "Candy Crush Saga is a match three game, where the core gameplay is based on swapping two adjacent candies among several on the gameboard as to make a row or column of at least 3 matching-colored candies.",
                ReleaseYear = 2012,
                Score = 2.4,

            };


            try
            {
                // adding synopsis to the game objects
                g1.SynopsisList.Add(d1);
                g2.SynopsisList.Add(d2);
                g3.SynopsisList.Add(d3);
                g4.SynopsisList.Add(d4);
                g5.SynopsisList.Add(d5);
                g6.SynopsisList.Add(d6);
                g7.SynopsisList.Add(d7);
                g8.SynopsisList.Add(d8);
                g9.SynopsisList.Add(d9);
                g10.SynopsisList.Add(d10);
                g11.SynopsisList.Add(d11);
                g12.SynopsisList.Add(d12);

                //Adding all the games to the list
                allGames.Add(g1);
                allGames.Add(g2);
                allGames.Add(g3);
                allGames.Add(g4);
                allGames.Add(g5);
                allGames.Add(g6);
                allGames.Add(g7);
                allGames.Add(g8);
                allGames.Add(g9);
                allGames.Add(g10);
                allGames.Add(g11);
                allGames.Add(g12);

                //Adding the list of games to the list box
                lbxGames.ItemsSource = allGames;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        //Method for displaying games based on different genres
        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedGenre = cbxGenre.SelectedItem as string;

            List<Games> filteredList = new List<Games>();
            try
            {
                switch (selectedGenre)
                {
                    case "All":
                        lbxGames.ItemsSource = allGames;
                        break;

                    case "Platformer":

                        foreach (Games game in allGames)
                        {
                            if (game is Platformer)
                                filteredList.Add(game);
                        }
                        lbxGames.ItemsSource = filteredList;
                        break;

                    case "RPG":

                        foreach (Games game in allGames)
                        {
                            if (game is RPG)
                                filteredList.Add(game);
                        }
                        lbxGames.ItemsSource = filteredList;
                        break;

                    case "Horror":

                        foreach (Games game in allGames)
                        {
                            if (game is Horror)
                                filteredList.Add(game);
                        }
                        lbxGames.ItemsSource = filteredList;
                        break;

                    case "Puzzle":
                        foreach (Games game in allGames)
                        {
                            if (game is Puzzle)
                                filteredList.Add(game);
                        }
                        lbxGames.ItemsSource = filteredList;
                        break;

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        //Changes the game displayed upon clicking on an item in the listbox
        private void LbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Games selectedGame = lbxGames.SelectedItem as Games;

            try
            {
                if (selectedGame != null)
                {
                    lbkDescription.Text = selectedGame.DisplayList();
                    string path = selectedGame.GameImage;
                    CoverImage.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        //Button for submitting a scored (only displays a message)
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Are you sure you want to submit the score?", "Review", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("The score has been submitted, allow for up 24 hours for the average score to update", "Success!");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("The score has not been submitted", "Canceled");
                    break;
            }
        }

        //Will display information and a logo about a company when one is selected
        private void GameCompanies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GameCompany selectedCompany = GameCompaniesBox.SelectedItem as GameCompany;

            try
            {
                if (selectedCompany != null)
                {
                    //updates the logo
                    CompanyLogo.Source = new BitmapImage(new Uri(selectedCompany.CompanyImage, UriKind.Absolute));
                    //updates the text
                    companyInfo.Text = selectedCompany.CompanyName + " Founded in " + selectedCompany.Founded;

                    //receives the game that the company made from the database
                    var query = from vg in db.VideoGames
                                where vg.CompanyID == selectedCompany.CompanyID
                                select vg;

                    var results = query.ToList();

                    lbxVideoGames.ItemsSource = results;
                    //This sets the game image and description to nothing so that it does not stay when switching companies
                    CoverImage1.Source = null;
                    gameInfo.Text = null;

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
           

        }

        //Displays game info when a game is selected
        private void LbxVideoGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                VideoGame selectedGame = lbxVideoGames.SelectedItem as VideoGame;
                if (selectedGame != null)
                {
                    CoverImage1.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Absolute));
                    gameInfo.Text = selectedGame.GameName + " Released in " + selectedGame.GameRelease;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        //Registers Json order number that is randomly generated in a json file
        private void ButtonBuy_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string data = JsonConvert.SerializeObject(GetRandomOrderNumbers(), Formatting.Indented);
                //saves the order number to this file
                using (StreamWriter sw = new StreamWriter("C:/Users/Lenovo/Desktop/Programming/Year 2 semester 2/Final Project/Final Project/orders.json"))
                {
                    sw.Write(data);
                    sw.Close();
                }
                MessageBox.Show("Your order has been placed and order number registered.");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        //generates the random order number
        private static List<OrderNumber> GetRandomOrderNumbers()
        {
            
            Random rand = new Random();
            List<OrderNumber> orderNumbers = new List<OrderNumber>();

            int randomOrderNumbers = rand.Next(1, 1000000);

            OrderNumber orderNr = new OrderNumber()
            {
                RandomOrderNumber = randomOrderNumbers.ToString("D7")
            };
            orderNumbers.Add(orderNr);

            return orderNumbers;
        }
    }
}
