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
    /// Логика взаимодействия для T2.xaml
    /// </summary>
    public partial class T2 : UserControl
    {
        public T2()
        {
            InitializeComponent();
            Sensss_1.Text = "И при всём при этом такой шум, ненавижу маленькие города.";
        }

        private void N2_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T3 t2 = new T3();
            TS_3.Children.Add(t2);
        }
    }
}
