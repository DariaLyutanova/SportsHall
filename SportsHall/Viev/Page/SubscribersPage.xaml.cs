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

            SurnameTextBox.Text = null;
            NameTextBox.Text = null;
            MiddleNameTextBox.Text = null;
            LessonsTextBox.Text = null;
            ValidFromYextBox.Text = null;
            ValidUntilTextBox.Text = null;
            PromoCodeTextBox.Text = null;
            DiscountTextBox.Text = null;
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 60;
            doubleAnimation.To = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(3);
            BorderInfo.BeginAnimation(HeightProperty, doubleAnimation);
            doubleAnimation.EasingFunction = new QuadraticEase();
            BorderInfo.Visibility = Visibility.Visible;
            BorderTextInfo.Text = "ДАННЫЕ УСПЕШНО СОХРАНЕНЫ";
        }
    }
}
