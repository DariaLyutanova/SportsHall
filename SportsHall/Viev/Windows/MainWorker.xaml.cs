using SportsHall.Viev.Page;
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

namespace SportsHall.Viev.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWorker.xaml
    /// </summary>
    public partial class MainWorker
    {
        public MainWorker()
        {
            InitializeComponent();
            MainFrame.Navigate(new SubscribersPage());
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void HideButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubscribersPage());

            SubscribersButton.Foreground = Brushes.White;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
        }

        private void HallButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HallPage());

            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.White;
            ListSubscribersButton.Foreground = Brushes.Gray;
        }

        private void ListSubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListSubscribersPage());

            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.White;
        }
    }
}
