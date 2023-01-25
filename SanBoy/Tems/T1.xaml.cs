using SanBoy.Tems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SanBoy.Tems
{
    /// <summary>
    /// Логика взаимодействия для T1.xaml
    /// </summary>
    public partial class T1 : UserControl
    {
        public T1()
        {
            InitializeComponent();
            Sensss_1.Text = "Да уж ну и дыра. Никогда не думал, что такая высокооплачиваемая работа будет находится в таком месте";
        }
        

        private void N1_Click(object sender, RoutedEventArgs e)
        {
            Sensss_1.Text = "";
            T2 t2 = new T2();
            TS_2.Children.Add(t2);
        }
    }
}
