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
            //просто так это место не нужно трогать. 
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
            /*
             * Штута которая создаёт анимацию, нун же находится настройка для анимации и далее
             * енформация для входа в учётную запесь данной АИС
             */
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 60;
            doubleAnimation.To = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(3);
            BorderError.BeginAnimation(HeightProperty, doubleAnimation);
            doubleAnimation.EasingFunction = new QuadraticEase();
            
            #region ADMIN
            // Учётка админа
            if (LoginTB.Text == "Admin" && PasswordPB.Password == "12" || LoginTB.Text == "Admin" && PasswordTB.Text == "12")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Лютанова.Дарья" && PasswordPB.Password == "23052003" || LoginTB.Text == "Лютанова.Дарья" && PasswordTB.Text == "23052003") 
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Куряева.Елизавета" && PasswordPB.Password == "04022003" || LoginTB.Text == "Куряева.Елизавета" && PasswordTB.Text == "04022003")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Волков.Владислав" && PasswordPB.Password == "23102003" || LoginTB.Text == "Волков.Владислав" && PasswordTB.Text == "23102003")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }

            if (LoginTB.Text == "Миронов.Владислав" && PasswordPB.Password == "24042003" || LoginTB.Text == "Миронов.Владислав" && PasswordTB.Text == "24042003")
            {
                MainAdmin mainAdmin = new MainAdmin();
                mainAdmin.Show();
                this.Close();
            }
            #endregion
            #region WORKER
            // Учётка сотрудников
            if (LoginTB.Text == "Worker" && PasswordPB.Password == "12" || LoginTB.Text == "Worker" && PasswordTB.Text == "12")
            {
                MainWorker mainWorker = new MainWorker();
                mainWorker.Show();
                this.Close();
            }

            if (LoginTB.Text == "Ефимов.Сергей" && PasswordPB.Password == "101001" || LoginTB.Text == "Ефимов.Сергей" && PasswordTB.Text == "101001")
            {
                MainWorker mainWorker = new MainWorker();
                mainWorker.Show();
                this.Close();
            }

            if (LoginTB.Text == "Михеев.Степан" && PasswordPB.Password == "101002" || LoginTB.Text == "Михеев.Степан" && PasswordTB.Text == "101002")
            {
                MainWorker mainWorker = new MainWorker();
                mainWorker.Show();
                this.Close();
            }
            #endregion

            // Тут идёт проверка на наличае ошибок (пока что на пустату)
            if (LoginTB.Text == null && PasswordPB.Password == null ||
                LoginTB.Text == null || PasswordPB.Password == null ||
                LoginTB.Text == null && PasswordTB.Text == null ||
                LoginTB.Text == null || PasswordTB.Text == null)
            {
                BorderError.Visibility = Visibility;
                BorderText.Text = "Поля пустые";
                
            }
            if(LoginTB.Text != null && PasswordPB.Password != null ||
                LoginTB.Text != null || PasswordPB.Password != null ||
                LoginTB.Text != null && PasswordTB.Text != null ||
                LoginTB.Text != null || PasswordTB.Text != null)
            {
                BorderError.Visibility = Visibility;
                BorderText.Text = "Вас нет в нашей БД";
                PasswordTB.Text = null;

                PasswordPB.Password = null;
                PasswordPB.Password = null;
            }
        }

        private void VisiblePassword_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Логика работы элемента ToggleButton с именем "VisiblePassword".
             * Проверка на нажатие:
             * Если да, то конвертируются значения из элемента Password с именем "PasswordPB" и передается
             * в элемент TextBox с именем "PasswordTB". Идёт замена одной картинки на другую, меняется
             * надпись на кнопке и прячем PasswordPB.
             * Если нет, то конвертируются значения из элемента TextBox с именем "PasswordTB" и передается
             * в элемент Password с именем "PasswordPB". Идёт замена одной картинки на другую, меняется
             * надпись на кнопке и прячем TextBox.
             */
            if (VisiblePassword.IsChecked == true)
            {
                string pw;
                pw = PasswordPB.Password;
                PasswordTB.Text = pw;
                PasswordPB.Visibility = Visibility.Collapsed;
                PasswordTB.Visibility = Visibility.Visible;
                ImageOne.Visibility = Visibility.Collapsed;
                ImageTho.Visibility = Visibility.Visible;
                VisiblePassword.Content = "СКРЫТЬ ПАРОЛЬ";
            }
            else
            {
                string pw;
                pw = PasswordTB.Text;
                PasswordPB.Password = pw;
                PasswordPB.Visibility = Visibility.Visible;
                PasswordTB.Visibility = Visibility.Collapsed;
                ImageOne.Visibility = Visibility.Visible;
                ImageTho.Visibility = Visibility.Collapsed;
                VisiblePassword.Content = "ПОКАЗАТЬ ПАРОЛЬ";
            }
        }
    }
}
