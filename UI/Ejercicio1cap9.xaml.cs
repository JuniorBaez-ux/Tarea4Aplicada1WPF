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
    /// Interaction logic for Ejercicio1cap9.xaml
    /// </summary>
    public partial class Ejercicio1cap9 : Window
    {
        public Ejercicio1cap9()
        {
            InitializeComponent();
        }

        private void AlmacenarButton_Click(object sender, RoutedEventArgs e)
        {
            Producto p;
            p.nombre = NombreTextBox.Text;
            p.cantidad = int.Parse(CantidadTextBox.Text);
            p.precio = double.Parse(PrecioTextBox.Text);

            if (p.nombre != null)
            {
                MessageBox.Show("El producto fue almacenado correctamente");
            }
            else 
            {
                MessageBox.Show("El producto no pudo ser almacenado correctamente");
            }
        }

        struct Producto
        {
            public string nombre;
            public double precio;
            public int cantidad;
        }
    }
}
