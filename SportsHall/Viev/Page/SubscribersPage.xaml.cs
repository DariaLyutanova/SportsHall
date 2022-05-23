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

namespace SportsHall.Viev.Page
{
    /// <summary>
    /// Логика взаимодействия для SubscribersPage.xaml
    /// </summary>
    public partial class SubscribersPage 
    {
        public SubscribersPage()
        {
            InitializeComponent();
            
            //// Тут мы объявляем переменные
            //double Sum;

            //// Тут мы конвертируем данные, из типа String в тип Double
            //// Данные берутся из TextBox со своим именем (NumberClassesTB, PromoCodeTB, DiscountTB) 
            //double NumberClasses = Convert.ToDouble(NumberClassesTB.Text);
            //double PromoCode = Convert.ToDouble(PromoCodeTB.Text);
            //double Discount = Convert.ToDouble(DiscountTB.Text);


            //// Тут задаётся цена за 1 тренеровку без скидок и промокодов.
            //double number = 200;


            //// Тут мы выполнеяем обычные логические операции по умножению кол-во занятий на стоимость 1 тренировки
            //// Добавить:
            //// Работу способность с учётом скидки и промокода.
            //Sum = NumberClasses * number;

            //// Тут выводится в TextBlock нформация о стоимости абонимента с учётом скидки, промокода и кол-во занятий
            //// пока что тут попытки реализации умножения кол-во занятий на цену за 1 занятие
            //RezultText.Text = Sum.ToString();

        }

        private void SaveSubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            /* тут происходит очистка полей с информацией после нажатия на элемент Button
             * с именем "SaveSubscribersButton".
             * В последствии тут должен быть написан обработчик
             * который очищает поля, если данные были занесены в БД */

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 60;
            doubleAnimation.To = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(3);
            BorderInfo.BeginAnimation(HeightProperty, doubleAnimation);
            BorderError.BeginAnimation(HeightProperty, doubleAnimation);
            doubleAnimation.EasingFunction = new QuadraticEase();

            if (SurnameTextBox.Text == "" ||
                NameTextBox.Text == "" ||
                MiddleNameTextBox.Text == "" ||
                LessonsTextBox.Text == "" ||
                ValidFromYextBox.Text == "" ||
                ValidUntilTextBox.Text == "")
            {
                BorderError.Visibility = Visibility.Visible;
                BorderErrorText.Visibility = Visibility.Visible;
                BorderErrorText.Text = "ПОЛЕ ИЛИ ПОЛЯ ПУСТЫЕ";
                BorderInfo.Visibility = Visibility.Collapsed;
                BorderInfoText.Visibility = Visibility.Collapsed; //jjj
                return;
            }
            else
            {
                BorderInfo.Visibility = Visibility.Visible;
                BorderInfoText.Visibility = Visibility.Visible;
                BorderInfoText.Text = "НОВЫЙ ГОСТЬ ЗАРЕГИСТРИРОВАН. ДОБРО ПОЖАЛОВАТЬ";
                BorderError.Visibility = Visibility.Collapsed;
                BorderErrorText.Visibility = Visibility.Collapsed;
                SurnameTextBox.Text = "";
                NameTextBox.Text = "";
                MiddleNameTextBox.Text = "";
                LessonsTextBox.Text = "";
                ValidFromYextBox.Text = "";
                ValidUntilTextBox.Text = "";
                return;
            }
        }
    }
}
