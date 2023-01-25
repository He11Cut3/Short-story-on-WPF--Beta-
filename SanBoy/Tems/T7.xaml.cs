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
    /// Логика взаимодействия для T7.xaml
    /// </summary>
    public partial class T7 : UserControl
    {
        public T7()
        {
            InitializeComponent();
            Sensss_1.Text = "вид скитальца лежащего на земле и существа в тени";
        }

        private void N8_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T8 t2 = new T8();
            TS_8.Children.Add(t2);
        }
    }
}
