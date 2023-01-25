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
    /// Логика взаимодействия для T12.xaml
    /// </summary>
    public partial class T12 : UserControl
    {
        public T12()
        {
            InitializeComponent();
            Sensss_1.Text = "с верхних этажей пронеслись словно ураган по раковинам моих ушей шабуршашие звуки. Мурашки сами невольно проявились \r\n на коже. Да сразу видно дому не первый десяток лет. Да и ремонт тут давно не делали ";
        }

        private void N12_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T13 t2 = new T13();
            TS_13.Children.Add(t2);
        }
    }
}
