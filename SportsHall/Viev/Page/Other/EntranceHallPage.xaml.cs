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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportsHall.Viev.Page.Other
{
    /// <summary>
    /// Логика взаимодействия для EntranceHallPage.xaml
    /// </summary>
    public partial class EntranceHallPage
    {
        public EntranceHallPage()
        {
            InitializeComponent();
        }

        private void ProhodkaItsHall_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 60;
            doubleAnimation.To = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(3);
            BorderInfo.BeginAnimation(HeightProperty, doubleAnimation);
            BorderError.BeginAnimation(HeightProperty, doubleAnimation);
            doubleAnimation.EasingFunction = new QuadraticEase();

            if (IDSubscribersTextBox.Text != null)
            {
                BorderInfo.Visibility = Visibility.Visible;
                BorderInfoText.Text = "ДОБРО ПОЖАЛОВАТЬ,\nХОРОШЕЙ ТРЕНИРОВКИ";
            }

            if (IDSubscribersTextBox.Text == null)
            {
                BorderError.Visibility = Visibility.Visible;
                BorderErrorText.Text = "ПОЛЕ НЕ МОЖЕ БЫТЬ ПУСТЫМ";
            }
        }
    }
}
