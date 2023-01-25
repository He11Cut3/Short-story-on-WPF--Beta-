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
    /// Логика взаимодействия для T5.xaml
    /// </summary>
    public partial class T5 : UserControl
    {
        public T5()
        {
            InitializeComponent();
            Sensss_1.Text = "что это за звук?";
        }
        
    private void N6_Click(object sender, RoutedEventArgs e)
       
        {
            Sensss_1.Text = "";
            T6 t2 = new T6();
            TS_6.Children.Add(t2);
        }
    }
}
