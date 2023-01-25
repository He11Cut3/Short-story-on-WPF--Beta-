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

namespace SanBoy.Tems
{
    /// <summary>
    /// Логика взаимодействия для T13.xaml
    /// </summary>
    public partial class T13 : UserControl
    {
        public T13()
        {
            InitializeComponent();
            Sensss_1.Text = "...";
            N14.Visibility = Visibility.Visible;
            N15.Visibility = Visibility.Collapsed;
            N16.Visibility = Visibility.Collapsed;
            N17.Visibility = Visibility.Collapsed;
            N18.Visibility = Visibility.Collapsed;
            N19.Visibility = Visibility.Collapsed;
        }

        private void N14_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "- Как думаешь брат, он действительно придёт?";
            N14.Visibility = Visibility.Collapsed;
            N15.Visibility = Visibility.Visible;
            N16.Visibility = Visibility.Collapsed;
            N17.Visibility = Visibility.Collapsed;
            N18.Visibility = Visibility.Collapsed;
            N19.Visibility = Visibility.Collapsed;
        }

        private void N15_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "-Кто знает, но не думаю что кто то настолько жадный испугается какого то здания и уйдёт так и не получив наживу.";
            N14.Visibility = Visibility.Collapsed;
            N15.Visibility = Visibility.Collapsed;
            N16.Visibility = Visibility.Visible;
            N17.Visibility = Visibility.Collapsed;
            N18.Visibility = Visibility.Collapsed;
            N19.Visibility = Visibility.Collapsed;
        }

        private void N16_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "- Кто знает кто знает";
            N14.Visibility = Visibility.Collapsed;
            N15.Visibility = Visibility.Collapsed;
            N16.Visibility = Visibility.Collapsed;
            N17.Visibility = Visibility.Visible;
            N18.Visibility = Visibility.Collapsed;
            N19.Visibility = Visibility.Collapsed;
        }

        private void N17_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "- Ну на такой счёт у нас есть наш пёсик на улице. ";
            N14.Visibility = Visibility.Collapsed;
            N15.Visibility = Visibility.Collapsed;
            N16.Visibility = Visibility.Collapsed;
            N17.Visibility = Visibility.Collapsed;
            N18.Visibility = Visibility.Visible;
            N19.Visibility = Visibility.Collapsed;
        }

        private void N18_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "-Тоже верно, если бы он и развернулся тот бы ему перегрыз глотку моментом.";
            N14.Visibility = Visibility.Collapsed;
            N15.Visibility = Visibility.Collapsed;
            N16.Visibility = Visibility.Collapsed;
            N17.Visibility = Visibility.Collapsed;
            N18.Visibility = Visibility.Collapsed;
            N19.Visibility = Visibility.Visible;
        }
        private void N19_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T14 t2 = new T14();
            TS_14.Children.Add(t2);
        }
    }
}
