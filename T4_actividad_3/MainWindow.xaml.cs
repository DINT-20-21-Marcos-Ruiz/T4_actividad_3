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

namespace T4_actividad_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Superheroe superheroe;
        List<Superheroe> lista = Superheroe.GetSamples();
        int contador;
        int posicion = 0;
        public MainWindow()
        {
            InitializeComponent();
            //VER SUPER HEROE
            superheroe_Grid.DataContext = lista[posicion];
            totalPag_TextBlock.Text = Convert.ToString(Superheroe.GetSamples().Count);
            pagActual_TextBlock.Text = "1";

            //PESTAÑA NUEVO SUPER HEROES
            superheroe = new Superheroe();
            superheroe.Heroe = true;
            newHeroe_Grid.DataContext = superheroe;
        }
        public void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            Superheroe superheroeTemporal = (Superheroe)newHeroe_Grid.DataContext;
            superheroeTemporal.Nombre = "";
            superheroeTemporal.Imagen = "";
            superheroeTemporal.Vengador = false;
            superheroeTemporal.Villano = false;
            superheroeTemporal.Xmen = false;
            superheroeTemporal.Heroe = true;

        }

        public void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            lista.Add(superheroe);
            contador = Convert.ToInt32(totalPag_TextBlock.Text) + 1;
            totalPag_TextBlock.Text = Convert.ToString(contador);
            superheroe = new Superheroe();
            superheroe.Heroe = true;
            newHeroe_Grid.DataContext = superheroe;
            MessageBox.Show("Superhéroe insertado con exito", "Superhéroes", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void Avanzar_MouseUp(object sender, MouseEventArgs e)
        {
            if (posicion + 1 < lista.Count())
            {
                posicion += 1;
                superheroe_Grid.DataContext = lista[posicion];
                pagActual_TextBlock.Text = Convert.ToString(posicion + 1);
            }
        }
        public void Retroceder_MouseUp(object sender, MouseEventArgs e)
        {
            if (posicion > 0)
            {
                posicion -= 1;
                superheroe_Grid.DataContext = lista[posicion];
                pagActual_TextBlock.Text = Convert.ToString(posicion + 1);
            }
        }
    }
}
