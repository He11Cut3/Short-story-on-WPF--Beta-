using SanBoy.Win_Sens;
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
    /// Логика взаимодействия для T16.xaml
    /// </summary>
    public partial class T16 : UserControl
    {
        public T16()
        {
            InitializeComponent();

            Sensss_1.Text = "Конец беты <3";
        }

        private void N16_Click(object sender, RoutedEventArgs e)
        {
            Sen_1 sen_1 = new Sen_1();
            Window.GetWindow(this).Close();
            M_W m_W = new M_W();
            m_W.ShowDialog();
        }
     }
}
