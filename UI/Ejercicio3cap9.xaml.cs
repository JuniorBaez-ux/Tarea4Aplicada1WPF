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
    /// Interaction logic for Ejercicio3cap9.xaml
    /// </summary>
    public partial class Ejercicio3cap9 : Window
    {
        public Ejercicio3cap9()
        {
            InitializeComponent();
        }

        private void almacenarInformacion_Click(object sender, RoutedEventArgs e)
        {
            Dueño dueño;
            dueño.nombre = nombreDueñoTextBox.Text;
            dueño.direccion = direccionDueñoTextBox.Text;
            dueño.edad = int.Parse(edadDueñoTextBox.Text);
            dueño.mascota.nombreM = nombreMascotaTextBox.Text;
            dueño.mascota.tipo = tipoMascotaTextBox.Text;
            dueño.mascota.raza = razaMascotaTextBox.Text;

            if (nombreDueñoTextBox != null && nombreMascotaTextBox != null)
            {
                MessageBox.Show("La informacion fue almacenada con exito");
            }
            else
            {
                MessageBox.Show("La informacion no pudo ser almacenada con exito");
            }
        }

        public struct Dueño
        {
            public string nombre;
            public string direccion;
            public int edad;
            public Mascota mascota;
        }

        public struct Mascota
        {
            public string nombreM;
            public string tipo;
            public string raza;

            public Mascota(string nombrem, string tipoM, string razaM)
            {
                nombreM = nombrem;
                tipo  = tipoM;
                raza = razaM;
            }
        }
    }
}
