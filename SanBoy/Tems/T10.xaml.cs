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
    /// Логика взаимодействия для T10.xaml
    /// </summary>
    public partial class T10 : UserControl
    {
        public T10()
        {
            InitializeComponent();
            Sensss_1.Text = "Ну хрен бы с ним была не была \r\n - Правильный выбор";
        }

        private void N10_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T11 t2 = new T11();
            TS_11.Children.Add(t2);
        }
    }
}
