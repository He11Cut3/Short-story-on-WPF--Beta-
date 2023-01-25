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
    /// Логика взаимодействия для T14.xaml
    /// </summary>
    public partial class T14 : UserControl
    {
        public T14()
        {
            InitializeComponent();
            Sensss_1.Text = "Ужас перепалнявший меня сложно было описать впринципе";
            N14_1.Visibility = Visibility.Visible;
            N14_2.Visibility = Visibility.Collapsed;
            N14_3.Visibility = Visibility.Collapsed;
        }


        private void N14_1_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "но выхода нет придётся идти до конца";
            N14_1.Visibility = Visibility.Collapsed;
            N14_2.Visibility = Visibility.Visible;
            N14_3.Visibility = Visibility.Collapsed;
        }

        private void N14_2_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "- Вы кто такие? и зачем вам я?";
            N14_1.Visibility = Visibility.Collapsed;
            N14_2.Visibility = Visibility.Collapsed;
            N14_3.Visibility = Visibility.Visible;
        }

        private void N14_3_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T15 t2 = new T15();
            TS_15.Children.Add(t2);
        }
    }
}
