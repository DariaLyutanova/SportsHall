using SportsHall.Viev.Page;
using SportsHall.Viev.Page.Admin;
using SportsHall.Viev.Page.Other;
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
    /// Логика взаимодействия для MainAdmin.xaml
    /// </summary>
    public partial class MainAdmin : Window
    {
        public MainAdmin()
        {
            InitializeComponent();
            MainFrame.Navigate(new SubscribersPage());
        }

        private void HideButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void SubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubscribersPage());

            SubscribersButton.Foreground = Brushes.White;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.Gray;
            
        }

        private void HallButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HallPage());

            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.White;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.Gray;
        }

        private void ListSubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListSubscribersPage());

            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.White;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.Gray;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void ListWorcerButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListWorkerPage());

            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.White;
            NewWorkwrButton.Foreground = Brushes.Gray;
        }

        private void NewWorkwrButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new NewWorkerPage());

            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.White;
        }
    }
}
