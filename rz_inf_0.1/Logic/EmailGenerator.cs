using rz_inf_0._1.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace rz_inf_0._1.Logic {
    class EmailGenerator {

        private const string defCorreo = "riberzone@hotmail.com";
        private SmtpClient smtpClient = new SmtpClient("smtp.office365.com") {
            Port = 587,
            Credentials = new NetworkCredential(defCorreo, "*ContrasenyaProyecto1*"),
            EnableSsl = true,
        };
        private const string tableStyle = "style='border: 1px solid black; text-align: center;'";

        /// <summary>Envia un correo de los productos</summary>
        /// <param name="productos">Lista con los datos de los productos</param>
        public void generarEmailProductos(List<ProductTemplate> productos) {

            MailMessage message = new MailMessage(defCorreo, "a.medina.v.96@hotmail.com");
            message.IsBodyHtml = true;
            message.Subject = "Productos Riberzone";

            string msg = $"<table {tableStyle}>";

            string tableHeader = "<tr>" +
                $"<th {tableStyle}>Id</th>" +
                $"<th {tableStyle}>Nombre</th>" +
                $"<th {tableStyle}>Precio</th>" +
                $"<th {tableStyle}>Categoria</th>" +
                "</tr>";

            string tableBody = "";

            productos.ForEach(p => {
                tableBody += $"<tr>" +
                $"<td {tableStyle}>{p.Id}</td>" +
                $"<td {tableStyle}>{p.Name}</td>" +
                $"<td {tableStyle}>{p.ListPrice}</td>" +
                $"<td {tableStyle}>{p.CategName}</td>" +
                $"</tr>";
            });

            msg += $"{tableHeader}{tableBody}</table>";

            message.Body = msg;

            try {
                smtpClient.Send(message);
                MessageBox.Show("Email enviado. Revise la bandeja de entrada");
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); }
        }

        public void generarEmailFacturas() {}

        /// <summary>Envia un correo de los pedidos</summary>
        /// <param name="pedidos">Lista con los datos de los pedidos</param>
        public void generarEmailPedidos(List<OrderSale> pedidos) {

            MailMessage message = new MailMessage(defCorreo, "a.medina.v.96@hotmail.com");
            message.IsBodyHtml = true;
            message.Subject = "Pedidos Riberzone";

            string msg = $"<table {tableStyle}>";

            string tableHeader = "<tr>" +
                $"<th {tableStyle}>Id</th>" +
                $"<th {tableStyle}>Nombre</th>" +
                $"<th {tableStyle}>fecha</th>" +
                $"<th {tableStyle}>Pago</th>" +
                $"<th {tableStyle}>Sin tasas</th>" +
                $"<th {tableStyle}>Total</th>" +
                "</tr>";

            string tableBody = "";

            pedidos.ForEach(p => {
                tableBody += $"<tr>" +
                $"<td {tableStyle}>{p.Id}</td>" +
                $"<td {tableStyle}>{p.Name}</td>" +
                $"<td {tableStyle}>{p.DateOrder}</td>" +
                $"<td {tableStyle}>{p.RequirePayment}</td>" +
                $"<td {tableStyle}>{p.AmountUntaxed}</td>" +
                $"<td {tableStyle}>{p.AmountTotal}</td>" +
                $"</tr>";
            });

            msg += $"{tableHeader}{tableBody}</table>";

            message.Body = msg;

            try {
                smtpClient.Send(message);
                MessageBox.Show("Email enviado. Revise la bandeja de entrada");
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); }
        }
    }
}
