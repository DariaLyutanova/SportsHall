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
using System.Windows.Shapes;

namespace SportsHall.Viev.Windows
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void HideButton_Click(object sender, RoutedEventArgs e)
        {
            // Добавляет возможность сварачивать программу при нажатии на соответствующию кнопку
            WindowState = WindowState.Minimized; 
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрывает программу
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Позволяет перемещать окно по всей облости экрана 
            this.DragMove();
        }

        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            // Аунтификация пользователей в программе
            // В последствии тут бедут добавлена База Данных
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 60;
            doubleAnimation.To = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(3);
            BorderError.BeginAnimation(HeightProperty, doubleAnimation);
            doubleAnimation.EasingFunction = new QuadraticEase();
            
            #region ADMIN
            // Учётка админа
            if (LoginTB.Text == "Admin" && PasswordPB.Password == "12")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Лютанова.Дарья" && PasswordPB.Password == "23052003") 
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Куряева.Елизовета" && PasswordPB.Password == "04022003")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Волков.Владислав" && PasswordPB.Password == "23102003")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Миронов.Владислав" && PasswordPB.Password == "24042003")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }
            #endregion
            #region WORKER
            // Учётка сотрудников
            if (LoginTB.Text == "Worker" && PasswordPB.Password == "12")
            {
                MainWorker mainWorker = new MainWorker();
                mainWorker.Show();
                this.Close();
            }

            if (LoginTB.Text == "Ефимов.Сергей" && PasswordPB.Password == "101001")
            {
                MainWorker mainWorker = new MainWorker();
                mainWorker.Show();
                this.Close();
            }

            if (LoginTB.Text == "Михеев.Степан" && PasswordPB.Password == "101002")
            {
                MainWorker mainWorker = new MainWorker();
                mainWorker.Show();
                this.Close();
            }
            #endregion

            // Тут идёт проверка на наличае ошибок (пока что на пустату)
            if (LoginTB.Text == null && PasswordPB.Password == null || LoginTB.Text == null || PasswordPB.Password == null)
            {
                BorderError.Visibility = Visibility;
                BorderText.Text = "Поля пустые";
                //Добавить анимацию плавного появления Border (Сверху вниз), который так же плавно и проподёт
            }
            if(LoginTB.Text != null && PasswordPB.Password != null || LoginTB.Text != null || PasswordPB.Password != null)
            {
                BorderError.Visibility = Visibility;
                BorderText.Text = "Вас нет в нашей БД";
                PasswordPB.Password = null;
            }
        }
    }
}
