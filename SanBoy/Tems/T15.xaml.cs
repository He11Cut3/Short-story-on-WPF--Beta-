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
    /// Логика взаимодействия для T15.xaml
    /// </summary>
    public partial class T15 : UserControl
    {
        public T15()
        {
            InitializeComponent();
            Sensss_1.Text = "-О ты всё таки пришёл.";
        }

        private void N15_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T16 t2 = new T16();
            TS_16.Children.Add(t2);
        }
    }
}
