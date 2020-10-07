using System;
using System.Windows;
using System.Windows.Controls;


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
            try
            {
                if (int.Parse(numeroTextBox.Text) >= 0 && int.Parse(numeroTextBox.Text) <= 100)
                {
                    if (numeroTextBox.Text != "")
                    {
                        if (int.Parse(numeroTextBox.Text) == numAleatorio) resultadoTextBlock.Text = "¡Has acertado!";
                        else if (int.Parse(numeroTextBox.Text) > numAleatorio) resultadoTextBlock.Text = "¡Te has pasado!";
                        else resultadoTextBlock.Text = "¡Te has quedado corto!";
                    }
                    else resultadoTextBlock.Text = "¡El campo está vacio, introduce un número!";
                }
                else resultadoTextBlock.Text = "¡El número debe ser entre 0 y 100!";

            }
            catch (FormatException)
            {
                resultadoTextBlock.Text = "¡El valor debe ser un número!";
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
