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
    /// Логика взаимодействия для T11.xaml
    /// </summary>
    public partial class T11 : UserControl
    {
        public T11()
        {
            InitializeComponent();
            Sensss_1.Text = "-Ау есть Кто нибудь? \r\n ответа не последовало ";
        }

        private void N11_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T12 t2 = new T12();
            TS_12.Children.Add(t2);
        }
    }
}
