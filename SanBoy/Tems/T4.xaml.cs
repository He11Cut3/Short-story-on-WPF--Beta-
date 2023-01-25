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
    /// Логика взаимодействия для T4.xaml
    /// </summary>
    public partial class T4 : UserControl
    {
        public T4()
        {
            InitializeComponent();
            Sensss_1.Text = "даже не знаю стоит ли мне заходить";
        }

        private void Ver_Click_1(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T10 t2 = new T10();
            TS_10.Children.Add(t2);
        }

        private void Ver_Click_2(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T5 t2 = new T5();
            TS_5.Children.Add(t2);
        }

        private void Ver_Click_3(object sender, RoutedEventArgs e) 
        {
            System.Diagnostics.Process.Start("https://vk.com/chel__id");
            System.Diagnostics.Process.Start("https://vk.com/he11cut3");
            System.Diagnostics.Process.Start("https://vk.com/fairduck");
        }
    }
}
