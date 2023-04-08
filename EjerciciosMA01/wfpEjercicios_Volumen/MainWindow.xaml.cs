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

namespace wfpEjercicios_Volumen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Por convención las variables y funciones del programa están declaradas en inglés, sin embargo, la interfaz con el usuario retorna los mensajes y resultados en idioma español. JAMM
        //Declaración de Variables Globales

        double pi = 3.14;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //Limpieza de Inputs y Output
            this.txtHeight.Text = string.Empty;
            this.txtRadius.Text = string.Empty;
            this.lblVolumeResult.Content = string.Empty;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Declaración de Varaiables
            String strHeight, strRadius;
            double height, radius, volume, radiusSquared;

            strHeight = this.txtHeight.Text;
            strRadius = this.txtRadius.Text;

            double.TryParse(strHeight, out  height);
            double.TryParse(strRadius, out radius);

            //Cálculo de Volumen
            radiusSquared = radius * radius;
            volume = pi * height * radiusSquared;

            //Visualización en Ventana
            this.lblVolumeResult.Content = volume.ToString();
        }
    }
}
