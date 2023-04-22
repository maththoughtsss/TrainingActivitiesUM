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

namespace wpfEjercicios_Cambio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            this.txtEUR.Text = string.Empty;
            this.lblTotalCLP.Content = string.Empty;
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            //Declaración de Variables
            string strEur;
            double eur, eurValue,totalCLP;

            eurValue = 894.67;

            strEur = txtEUR.Text;

            //Conversión de Variable
            double.TryParse(strEur, out eur);

            //Conversión de Divisa
            totalCLP = eurValue * eur;

            //Visualizaciones
            MessageBox.Show("La cantidad de " + eur + " EUR corresponde a " + totalCLP + " CLP");
            this.lblTotalCLP.Content = totalCLP.ToString();
        }
    }
}
