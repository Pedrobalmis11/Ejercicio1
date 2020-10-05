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

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numAleatorio;
        public MainWindow()
        {
            numAleatorio = generarNum();
            InitializeComponent();
            
        }

        private int generarNum()
        {
            Random generador = new Random();

            int result = generador.Next(0, 101);

            return result;

        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
           
            if(int.Parse(numeroTextBox.Text) == numAleatorio)
            {
                resultadoTextBlock.Text = "Has acertado";

            }else if(int.Parse(numeroTextBox.Text) > numAleatorio)
            {
                resultadoTextBlock.Text = "Te has pasado";
            }
            else
            {
                resultadoTextBlock.Text = "Te has quedado corto";
            }

        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numAleatorio = generarNum();
            resultadoTextBlock.Text = "";
            numeroTextBox.Text = "";
        }
    }
}
