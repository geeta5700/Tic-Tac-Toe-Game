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
using System.Windows.Shapes;

namespace tic_tac_toe.Windows
{
    /// <summary>
    /// Interaction logic for UserVsComputer.xaml
    /// </summary>
    public partial class UserVsComputer : Window
    {
        string user;
        char[,] ticTacToe;
        int count;
        bool isWinner;

        public UserVsComputer()
        {
            InitializeComponent();
            this.isWinner = false;
            this.count = 0;
            this.user = "User_X";
            this.ticTacToe = new char[3, 3];
            this.ChangeActionContent();
        }

        private void ChangeActionContent()
        {
            actionLabel.Content = this.user + " needs to play";
        }

        private void ToggleUser()
        {
            if (this.user.Equals("User_X"))
            {
                this.user = "User_O";
            }
            else
            {
                this.user = "User_X";
            }
        }

        private void DisableAllButtons()
        {
            button00.IsHitTestVisible = false;
            button01.IsHitTestVisible = false;
            button02.IsHitTestVisible = false;
            button10.IsHitTestVisible = false;
            button11.IsHitTestVisible = false;
            button12.IsHitTestVisible = false;
            button20.IsHitTestVisible = false;
            button21.IsHitTestVisible = false;
            button22.IsHitTestVisible = false;
        }

        private void CheckWinner()
        {
            // check for row
            if (this.ticTacToe[0, 0] != '\0' && this.ticTacToe[0, 1] != '\0' && this.ticTacToe[0, 2] != '\0')
            {
                if (this.ticTacToe[0, 0] == this.ticTacToe[0, 1] && this.ticTacToe[0, 0] == this.ticTacToe[0, 2])
                {
                    button00.Background = Brushes.Green;
                    button01.Background = Brushes.Green;
                    button02.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }

            if (this.ticTacToe[1, 0] != '\0' && this.ticTacToe[1, 1] != '\0' && this.ticTacToe[1, 2] != '\0')
            {
                if (this.ticTacToe[1, 0] == this.ticTacToe[1, 1] && this.ticTacToe[1, 0] == this.ticTacToe[1, 2])
                {
                    button10.Background = Brushes.Green;
                    button11.Background = Brushes.Green;
                    button12.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }

            if (this.ticTacToe[2, 0] != '\0' && this.ticTacToe[2, 1] != '\0' && this.ticTacToe[2, 2] != '\0')
            {
                if (this.ticTacToe[2, 0] == this.ticTacToe[2, 1] && this.ticTacToe[2, 0] == this.ticTacToe[2, 2])
                {
                    button20.Background = Brushes.Green;
                    button21.Background = Brushes.Green;
                    button22.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }

            // check for column
            if (this.ticTacToe[0, 0] != '\0' && this.ticTacToe[1, 0] != '\0' && this.ticTacToe[2, 0] != '\0')
            {
                if (this.ticTacToe[0, 0] == this.ticTacToe[1, 0] && this.ticTacToe[0, 0] == this.ticTacToe[2, 0])
                {
                    button00.Background = Brushes.Green;
                    button10.Background = Brushes.Green;
                    button20.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }

            if (this.ticTacToe[0, 1] != '\0' && this.ticTacToe[1, 1] != '\0' && this.ticTacToe[2, 1] != '\0')
            {
                if (this.ticTacToe[0, 1] == this.ticTacToe[1, 1] && this.ticTacToe[0, 1] == this.ticTacToe[2, 1])
                {
                    button01.Background = Brushes.Green;
                    button11.Background = Brushes.Green;
                    button21.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }

            if (this.ticTacToe[0, 2] != '\0' && this.ticTacToe[1, 2] != '\0' && this.ticTacToe[2, 2] != '\0')
            {
                if (this.ticTacToe[0, 2] == this.ticTacToe[1, 2] && this.ticTacToe[0, 2] == this.ticTacToe[2, 2])
                {
                    button02.Background = Brushes.Green;
                    button12.Background = Brushes.Green;
                    button22.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }

            // check for diagonals
            if (this.ticTacToe[0, 0] != '\0' && this.ticTacToe[1, 1] != '\0' && this.ticTacToe[2, 2] != '\0')
            {
                if (this.ticTacToe[0, 0] == this.ticTacToe[1, 1] && this.ticTacToe[0, 0] == this.ticTacToe[2, 2])
                {
                    button00.Background = Brushes.Green;
                    button11.Background = Brushes.Green;
                    button22.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }

            if (this.ticTacToe[0, 2] != '\0' && this.ticTacToe[1, 1] != '\0' && this.ticTacToe[2, 0] != '\0')
            {
                if (this.ticTacToe[0, 2] == this.ticTacToe[1, 1] && this.ticTacToe[0, 2] == this.ticTacToe[2, 0])
                {
                    button02.Background = Brushes.Green;
                    button11.Background = Brushes.Green;
                    button20.Background = Brushes.Green;
                    this.DisableAllButtons();
                    this.isWinner = true;
                    return;
                }
            }
        }

        private void OnBackClicked(object sender, RoutedEventArgs e)
        {
            actionLabel.Content = "Clicking back button";
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void OnButtonClick00(object sender, RoutedEventArgs e)
        {
            // Update the button
            button00.Content = this.user == "User_X" ? "X" : "O";
            button00.IsHitTestVisible = false;
            this.ticTacToe[0, 0] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick01(object sender, RoutedEventArgs e)
        {
            // Update the button
            button01.Content = this.user == "User_X" ? "X" : "O";
            button01.IsHitTestVisible = false;
            this.ticTacToe[0, 1] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick02(object sender, RoutedEventArgs e)
        {
            // Update the button
            button02.Content = this.user == "User_X" ? "X" : "O";
            button02.IsHitTestVisible = false;
            this.ticTacToe[0, 2] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick10(object sender, RoutedEventArgs e)
        {
            // Update the button
            button10.Content = this.user == "User_X" ? "X" : "O";
            button10.IsHitTestVisible = false;
            this.ticTacToe[1, 0] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick11(object sender, RoutedEventArgs e)
        {
            // Update the button
            button11.Content = this.user == "User_X" ? "X" : "O";
            button11.IsHitTestVisible = false;
            this.ticTacToe[1, 1] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick12(object sender, RoutedEventArgs e)
        {
            // Update the button
            button12.Content = this.user == "User_X" ? "X" : "O";
            button12.IsHitTestVisible = false;
            this.ticTacToe[1, 2] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick20(object sender, RoutedEventArgs e)
        {
            // Update the button
            button20.Content = this.user == "User_X" ? "X" : "O";
            button20.IsHitTestVisible = false;
            this.ticTacToe[2, 0] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick21(object sender, RoutedEventArgs e)
        {
            // Update the button
            button21.Content = this.user == "User_X" ? "X" : "O";
            button21.IsHitTestVisible = false;
            this.ticTacToe[2, 1] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void OnButtonClick22(object sender, RoutedEventArgs e)
        {
            // Update the button
            button22.Content = this.user == "User_X" ? "X" : "O";
            button22.IsHitTestVisible = false;
            this.ticTacToe[2, 2] = this.user == "User_X" ? 'X' : 'O';

            // check winner
            this.CheckWinner();

            // toggle the user
            this.ToggleUser();

            // print the next action
            this.ChangeActionContent();

            // increment count and check for non winning condition
            this.count++;
            this.ChangeColorIfNoOneWins();
        }

        private void ChangeColorIfNoOneWins()
        {
            if (this.count == 9 && !isWinner)
            {
                button00.Background = Brushes.Red;
                button01.Background = Brushes.Red;
                button02.Background = Brushes.Red;
                button10.Background = Brushes.Red;
                button11.Background = Brushes.Red;
                button12.Background = Brushes.Red;
                button20.Background = Brushes.Red;
                button21.Background = Brushes.Red;
                button22.Background = Brushes.Red;
                
                actionLabel.Content = "No one wins";
                actionLabel.Background = Brushes.Red;
            }
        }
    }
}

