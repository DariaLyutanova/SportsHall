using SportsHall.Viev.Page;
using SportsHall.Viev.Page.Admin;
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
            EntranceHallButton.Foreground = Brushes.White;
            MainFrame.Navigate(new EntranceHallPage());
            Title = "ГЛАВНОЕ ОКНО: ВХОД В ЗАЛ";
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

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void EntranceHallButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EntranceHallPage());
            Title = "ГЛАВНОЕ ОКНО: ВХОД В ЗАЛ";

            EntranceHallButton.Foreground = Brushes.White;
            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.Gray;
        }

        private void SubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubscribersPage());
            Title = "ГЛАВНОЕ ОКНО: АБОНЕМЕНТ";

            EntranceHallButton.Foreground = Brushes.Gray;
            SubscribersButton.Foreground = Brushes.White;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.Gray;
            
        }

        private void HallButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HallPage());
            Title = "ГЛАВНОЕ ОКНО: ЗАЛ";

            EntranceHallButton.Foreground = Brushes.Gray;
            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.White;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.Gray;
        }

        private void ListSubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListSubscribersPage());
            Title = "ГЛАВНОЕ ОКНО: СПИСОК АБОНЕМЕНТОВ";

            EntranceHallButton.Foreground = Brushes.Gray;
            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.White;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.Gray;
        }

        private void ListWorcerButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListWorkerPage());
            Title = "ГЛАВНОЕ ОКНО: СОТРУДНИКОВ";

            EntranceHallButton.Foreground = Brushes.Gray;
            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.White;
            NewWorkwrButton.Foreground = Brushes.Gray;
        }

        private void NewWorkwrButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new NewWorkerPage());
            Title = "ГЛАВНОЕ ОКНО: ДОБАВИТЬ СОТРУДНИКА";

            EntranceHallButton.Foreground = Brushes.Gray;
            SubscribersButton.Foreground = Brushes.Gray;
            HallButton.Foreground = Brushes.Gray;
            ListSubscribersButton.Foreground = Brushes.Gray;
            ListWorcerButton.Foreground = Brushes.Gray;
            NewWorkwrButton.Foreground = Brushes.White;
        }
    }
}
