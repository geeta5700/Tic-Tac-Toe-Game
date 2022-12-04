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
using tic_tac_toe.Windows;

namespace tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnUserVsUserClicked(object sender, RoutedEventArgs e)
        {
            alertLabel.Content = "Clicking OnUserVsUserClicked";
            UserVsUser userVsUserPage = new UserVsUser();
            userVsUserPage.Show();
            this.Close();
        }

        private void OnUserVsComputerClicked(object sender, RoutedEventArgs e)
        {
            alertLabel.Content = "Clicking OnUserVsComputerClicked";
            UserVsComputer userVsComputerPage = new UserVsComputer();
            userVsComputerPage.Show();
            this.Close();
        }
        private void OnResumeGameClicked(object sender, RoutedEventArgs e)
        {
            alertLabel.Content = "Clicking OnResumeGameClicked";
            ResumeGame resumeGamePage = new ResumeGame();
            resumeGamePage.Show();
            this.Close();
        }
    }
}
