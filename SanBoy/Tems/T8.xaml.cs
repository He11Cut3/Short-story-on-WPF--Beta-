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
    /// Логика взаимодействия для T8.xaml
    /// </summary>
    public partial class T8 : UserControl
    {
        public T8()
        {
            InitializeComponent();
            Sensss_1.Text = "- И я тебя, лучше бы ты просто ушёл.)";
        }

        private void N9_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T9 t2 = new T9();
            TS_9.Children.Add(t2);
        }
    }
}
