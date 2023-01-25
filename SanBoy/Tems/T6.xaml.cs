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
    /// Логика взаимодействия для T6.xaml
    /// </summary>
    public partial class T6 : UserControl
    {
        public T6()
        {
            InitializeComponent();
            Sensss_1.Text = "-Эй я тебя слышал выходи";
        }

        private void N7_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T7 t2 = new T7();
            TS_7.Children.Add(t2);
        }
    }
}
