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

namespace JackMalone_S00199917
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();

            var query = from game in db.Games
                        select game;

            lbxGames.ItemsSource = query.ToList();
        }
        
        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = lbxGames.SelectedItem as Game;

            if (selectedGame != null)
            {
                tbxDescription.Text = selectedGame.Description;
                tbxName.Text = selectedGame.Name;
                tbxPrice.Text = string.Format($"{selectedGame.Price:c}");
            }
        }

        private void tbxSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxSearch.Text = "";
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbxSearch.Text == null || tbxSearch.Text == "")
            {
                var query = from game in db.Games
                            select game;

                lbxGames.ItemsSource = query.ToList();
            }
            else
            {
                var query = from game in db.Games
                            where game.Platform.Contains(tbxSearch.Text.ToString())
                            select game;

                lbxGames.ItemsSource = query.ToList();
            }
        }
    }
}