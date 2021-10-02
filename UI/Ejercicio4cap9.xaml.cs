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
    /// Interaction logic for Ejercicio4cap9.xaml
    /// </summary>
    public partial class Ejercicio4cap9 : Window
    {
        public Ejercicio4cap9()
        {
            InitializeComponent();
            neumaticosComboBox.ItemsSource = Enum.GetValues(typeof(Neumaticos));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Neumaticos neumaticos = (Neumaticos)this.neumaticosComboBox.SelectedItem;
            MessageBox.Show("Eleccion Confirmada");
        }
        public enum Neumaticos
        {
            Neumatico_Radial,
            Neumatico_Diagonal,
            Neumatico_de_Verano,
            Neumatico_de_Invierno,
            Neumatico_AllSeasons,
            Neumatico_Asimetrico,
            Neumatico_Direccional,
            Neumatico_Tubeless,
            Neumatico_de_Perfil_Bajo,
            Neumatico_Recauchutado,
            Neumatico_Runflat,
            Neumatico_Ecologicos
        }

    }
}
