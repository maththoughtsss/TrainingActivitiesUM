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

namespace wpfIVACalculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaración de Variables Globales
        double price;
        double iva = 0.19;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Declaración de Variables Locales
            string strPrice;
            double ivaPrice,priceWithoutIVA;
            //Captura de variable como tipo String
            strPrice = txtPrice.Text;
            //Conversión a tipo double
            double.TryParse(strPrice, out price);
            //Cálculo de IVA
            ivaPrice = price * iva;
            //Precio sin IVA
            priceWithoutIVA = price - ivaPrice;
            //Mostrar en MessageBox
            MessageBox.Show("El IVA correspondiente al precio es: " + ivaPrice);
            //Mostrar el IVA en Ventana
            this.lblAmount.Content = ivaPrice.ToString();
            this.lblOriginalPriceAmount.Content = priceWithoutIVA.ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.txtPrice.Text = string.Empty;
            this.lblAmount.Content = string.Empty;
            this.lblOriginalPriceAmount.Content = string.Empty;
        }
    }
}
