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
using System.Windows.Shapes;

namespace Tarea4Aplicada1WPF.UI
{
    /// <summary>
    /// Interaction logic for Ejercicio3cap8.xaml
    /// </summary>
    public partial class Ejercicio3cap8 : Window
    {
        public Ejercicio3cap8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HoraTextBox.Text = getTime().ToString();
        }

        private DateTime getTime()
        {
            var tiempo = DateTime.Now;
            return tiempo;
        }
    }
}
