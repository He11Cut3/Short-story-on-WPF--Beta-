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
    /// Логика взаимодействия для T3.xaml
    /// </summary>
    public partial class T3 : UserControl
    {
        public T3()
        {
            InitializeComponent();
            Sensss_1.Text = "мда… разве это то самое место о котором говорил семпай. не очень похоже. \r\n Даже не знаю стоит ли мне заходить";
        }

        private void N3_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T4 t2 = new T4();
            TS_4.Children.Add(t2);
        }
    }
}
