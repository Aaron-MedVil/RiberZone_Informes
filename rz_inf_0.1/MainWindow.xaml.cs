using rz_inf_0._1.Models;
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

namespace rz_inf_0._1 {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private Logic.RestSharp rs = new Logic.RestSharp();
        private Logic.PDFGenerator pdfGen = new Logic.PDFGenerator();
        private Logic.EmailGenerator emailGen = new Logic.EmailGenerator();

        /// <summary>
        /// Metodo que inicia los componentes
        /// </summary>
        public MainWindow() => InitializeComponent();

        #region Eventos click MainWindow

        /// <summary>Genera un fichero PDF con los productos</summary>
        /// <param name="sender">Elemento que ejecuta el metodo/param>
        /// <param name="e">Parametros del evento</param>
        private void pdfProductos_Click(object sender, RoutedEventArgs e) => pdfGen.generarPDFProductos(rs.getProductTemplate());

        /// <summary>Envia un email con los productos</summary>
        /// <param name="sender">Elemento que ejecuta el metodo/param>
        /// <param name="e">Parametros del evento</param>
        private void emailProductos_Click(object sender, RoutedEventArgs e) => emailGen.generarEmailProductos(rs.getProductTemplate());



        /// <summary>Genera un fichero PDF con los pedidos</summary>
        /// <param name="sender">Elemento que ejecuta el metodo/param>
        /// <param name="e">Parametros del evento</param>
        private void pdfPedidos_Click(object sender, RoutedEventArgs e) => pdfGen.generarPDFPedidos(rs.getOrders());

        /// <summary>Envia un email con los pedidos</summary>
        /// <param name="sender">Elemento que ejecuta el metodo/param>
        /// <param name="e">Parametros del evento</param>
        private void emailPedidos_Click(object sender, RoutedEventArgs e) => emailGen.generarEmailPedidos(rs.getOrders());



        /// <summary>Genera un fichero PDF con las facturas</summary>
        /// <param name="sender">Elemento que ejecuta el metodo/param>
        /// <param name="e">Parametros del evento</param>ram>
        private void pdfFacturas_Click(object sender, RoutedEventArgs e) { /* pdfGen.generarPDFFacturas(rs.getInvoices()); */ }

        /// <summary>Envia un email con las facturas</summary>
        /// <param name="sender">Elemento que ejecuta el metodo/param>
        /// <param name="e">Parametros del evento</param>
        private void emailFacturas_Click(object sender, RoutedEventArgs e) { /* emailGen.generarEmailFacturas(rs.getInvoices()); */ }
        #endregion
    }
}
