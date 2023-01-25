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

namespace SanBoy.Win_Sens
{
    /// <summary>
    /// Логика взаимодействия для Sen_1.xaml
    /// </summary>
    public partial class Sen_1 : Window
    {
        public Sen_1()
        {
            InitializeComponent();
            New_Dest();
        }


        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            DragMove();
        }
        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void New_Dest()
        {
            T1 t1 = new T1();
            TS_1.Children.Add(t1);
        }

        private void N1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void N2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void N3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void N4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void N5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void N6_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
