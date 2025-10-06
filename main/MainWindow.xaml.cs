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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prueba
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Storyboard inicio = (Storyboard)Resources["entrada"];
            inicio.Begin();
        }

   

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window Login = new Window1();
            Login.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window Login = new Window2();
            Login.Show();
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Window Login = new Window3();
            Login.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window Login = new Window2();
            Login.Show();
        }
    }


}
