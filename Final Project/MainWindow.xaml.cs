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

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Games> allGames = new List<Games>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Genre names added to the combo box
            string[] genres = { "All", "Platformer", "RPG", "Horror", "Puzzle" };
            cbxGenre.ItemsSource = genres;

            //Platformer Games
            Games g1 = new Platformer() { Name = "Celeste", RealeaseYear = 2018, Score = 9.5 };
            Games g2 = new Platformer() { Name = "Super Mario Odyssey", RealeaseYear = 2017, Score = 8.0 };
            Games g3 = new Platformer() { Name = "Crash 4", RealeaseYear = 2020, Score = 9.0 };
            Games g4 = new Platformer() { Name = "A Hat in Time", RealeaseYear = 2017, Score = 7.6 };

            //Role Playing Games
            Games g5 = new RPG() { Name = "Final Fantasy VII", RealeaseYear = 1996, Score = 9.0};
            Games g6 = new RPG() { Name = "Persona 5", RealeaseYear = 2016, Score = 9.9};
            Games g7 = new RPG() { Name = "The Witcher 3", RealeaseYear = 2015, Score = 8.3 };

            //Horror Games
            Games g8 = new Horror() { Name = "Outlast", RealeaseYear = 2014, Score = 6.3 };
            Games g9 = new Horror() { Name = "Phasmophobia", RealeaseYear = 2020, Score = 7.8 };
            Games g10 = new Horror() { Name = "Resident Evil VILLAGE", RealeaseYear = 2021, Score = 9.0 };

            //Puzzle Games
            Games g11 = new Puzzle() { Name = "Bejeweled 3", RealeaseYear = 2010, Score = 8.2 };
            Games g12 = new Puzzle() { Name = "Candy Crush", RealeaseYear = 2012, Score = 2.5 };


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

        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedGenre = cbxGenre.SelectedItem as string;

            List<Games> filteredList = new List<Games>();

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

        private void LbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
