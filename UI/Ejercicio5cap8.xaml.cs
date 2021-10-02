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
    /// Interaction logic for Ejercicio5cap8.xaml
    /// </summary>
    public partial class Ejercicio5cap8 : Window
    {
        string cadena1, cadena2;
        public Ejercicio5cap8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cadena1 = primeraOracionTextBox.Text;
            cadena2 = segundaOracionTextBox.Text;

            ResultadoTextBox.Text = Organizar(cadena1, cadena2).ToString();
        }

        private string Organizar(string cadena1, string cadena2)
        {
            string conjunto = cadena1 + cadena2;

            return String.Concat(conjunto.OrderBy(a => a)); ;
        }
    }
}
