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
using Tarea4Aplicada1WPF.UI;

namespace Tarea4Aplicada1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3cap8 ejercicio3Cap8 = new Ejercicio3cap8();
            ejercicio3Cap8.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Ejercicio5cap8 ejercicio5Cap8 = new Ejercicio5cap8();
            ejercicio5Cap8.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Ejercicio1cap9 ejercicio1Cap9 = new Ejercicio1cap9();
            ejercicio1Cap9.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Ejercicio3cap9 ejercicio3Cap9 = new Ejercicio3cap9();
            ejercicio3Cap9.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Ejercicio4cap9 ejercicio4Cap9 = new Ejercicio4cap9();
            ejercicio4Cap9.Show();
        }
    }
}
