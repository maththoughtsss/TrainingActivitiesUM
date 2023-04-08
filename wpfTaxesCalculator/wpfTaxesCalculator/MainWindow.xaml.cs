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

namespace wpfTaxesCalculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Por convención las variables y funciones del programa están declaradas en inglés, sin embargo, la interfaz con el usuario retorna los mensajes y resultados en idioma español. JAMM
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            this.txtAmount.Text = string.Empty;
            this.txtTax.Text = string.Empty;
            
            this.lblAmountWithoutTaxes.Content = string.Empty;
            this.lblTotalAmountTaxes.Content = string.Empty;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Declaración de Variables
            String strAmount, strTax;
            double amount, tax, amountTax, amountWithouTax;

            //Captura de datos desde TextBox como tipo String
            strAmount = this.txtAmount.Text;
            strTax = this.txtTax.Text;

            //Conversión de Variables a tipo double
            double.TryParse(strAmount, out amount);
            double.TryParse(strTax, out tax);

            //Cálculo de Impuestos
            tax = tax / 100;
            amountTax = amount * tax;
            amountWithouTax = amount - amountTax;

            //Visualización en MessageBox
            MessageBox.Show("El total correspondiente a impuestos es: " + amountTax);

            //Visualización de resultados en Ventana
            this.lblAmountWithoutTaxes.Content = amountWithouTax.ToString();
            this.lblTotalAmountTaxes.Content = amountTax.ToString();
        }
    }
}
