using rz_inf_0._1.Models;
using System.Collections.Generic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Windows;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace rz_inf_0._1.Logic {
    class PDFGenerator {

        private Rectangle PageSize = new Rectangle(700f, 1024f);

        /// <summary>Genera un fichero PDF con los datos de los productos</summary>
        /// <param name="products">Lista con los datos de los productos</param>
        public void generarPDFProductos(List<ProductTemplate> products) {

            SaveFileDialog dlg = new SaveFileDialog { Filter = "PDF File(*.pdf)|*.pdf", FileName = "Productos" };

            if (dlg.ShowDialog() == true) {

                string[] nomCols = new string[] { "Id", "Nombre", "Precio", "Categoria" };
                float[] anchoCols = new float[] { 170.25f, 170.25f, 170.25f, 170.25f };
                float yPos = 940f;

                try {

                    /* ========== CREAR FILE ========== */
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    Document doc = new Document(PageSize);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    /* ========== CABECERA ========== */
                    BaseColor foregroundTitle = new BaseColor(28, 40, 51);
                    Font fontTitle = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 32f, Font.BOLD, foregroundTitle);
                    Chunk chkTitle = new Chunk($"PRODUCTOS", fontTitle);
                    Phrase textTitle = new Phrase(0f, chkTitle);
                    doc.Add(new Paragraph(textTitle));

                    /* ========== TABLA DE CABECERA ========== */
                    PdfPTable titulos = new PdfPTable(nomCols.Length) {
                        DefaultCell = {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_CENTER,
                        BackgroundColor = new BaseColor(173, 68, 99),
                        FixedHeight = 20f
                    }
                    };
                    titulos.SetTotalWidth(anchoCols);
                    foreach (string col in nomCols) { titulos.AddCell(col); }
                    titulos.WriteSelectedRows(0, -1, 10f, yPos, writer.DirectContent);

                    /* ========== TABLA DE DATOS ========== */
                    PdfPTable datos = new PdfPTable(nomCols.Length) {
                        DefaultCell = {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_CENTER,
                            FixedHeight = 20f
                    }
                    };
                    datos.SetTotalWidth(anchoCols);

                    foreach (ProductTemplate s in products) {

                        if (yPos <= 60) {
                            yPos = 1000f - 20;
                            doc.NewPage();
                            titulos.WriteSelectedRows(0, -1, 10f, 1000f, writer.DirectContent);
                        }
                        else { yPos = yPos - 20; }

                        datos.AddCell(s.Id.ToString());
                        datos.AddCell(s.Name.ToString());
                        datos.AddCell(s.ListPrice.ToString());
                        datos.AddCell(s.CategName.ToString());

                        datos.WriteSelectedRows(0, -1, 10f, yPos, writer.DirectContent);
                        datos = new PdfPTable(nomCols.Length) {
                            DefaultCell = {
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            VerticalAlignment = Element.ALIGN_CENTER,
                            FixedHeight = 20f
                        }
                        };
                        datos.SetTotalWidth(anchoCols);
                    }

                    // Cierra el fichero
                    doc.Close();
                    openPdf(dlg.FileName);
                }
                catch (Exception) { MessageBox.Show("Se ha producido un error al generar el fichero PDF"); }
            }
        }

        /// <summary>Genera un fichero PDF con los datos de los pedidos</summary>
        /// <param name="pedidos">Lista con los datos de los pedidos</param>
        public void generarPDFPedidos(List<OrderSale> pedidos) {

            SaveFileDialog dlg = new SaveFileDialog { Filter = "PDF File(*.pdf)|*.pdf", FileName = "Pedidos" };

            if (dlg.ShowDialog() == true) {

                string[] nomCols = new string[] { "Id", "Nombre", "Fecha", "Pago", "Sin tasas", "Total" };
                float[] anchoCols = new float[] { 113.5f, 113.5f, 113.5f, 113.5f, 113.5f, 113.5f };
                float yPos = 940f;

                try {

                    /* ========== CREAR FILE ========== */
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    Document doc = new Document(PageSize);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    /* ========== CABECERA ========== */
                    BaseColor foregroundTitle = new BaseColor(28, 40, 51);
                    Font fontTitle = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 32f, Font.BOLD, foregroundTitle);
                    Chunk chkTitle = new Chunk($"PEDIDOS", fontTitle);
                    Phrase textTitle = new Phrase(0f, chkTitle);
                    doc.Add(new Paragraph(textTitle));

                    /* ========== TABLA DE CABECERA ========== */
                    PdfPTable titulos = new PdfPTable(nomCols.Length) {
                        DefaultCell = {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_CENTER,
                        BackgroundColor = new BaseColor(173, 68, 99),
                        FixedHeight = 20f
                    }
                    };
                    titulos.SetTotalWidth(anchoCols);
                    foreach (string col in nomCols) { titulos.AddCell(col); }
                    titulos.WriteSelectedRows(0, -1, 10f, yPos, writer.DirectContent);

                    /* ========== TABLA DE DATOS ========== */
                    PdfPTable datos = new PdfPTable(nomCols.Length) {
                        DefaultCell = {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_CENTER,
                            FixedHeight = 20f
                    }
                    };
                    datos.SetTotalWidth(anchoCols);

                    foreach (OrderSale s in pedidos) {

                        if (yPos <= 60) {
                            yPos = 1000f - 20;
                            doc.NewPage();
                            titulos.WriteSelectedRows(0, -1, 10f, 1000f, writer.DirectContent);
                        }
                        else { yPos = yPos - 20; }

                        datos.AddCell(s.Id.ToString());
                        datos.AddCell(s.Name.ToString());
                        datos.AddCell(s.DateOrder.ToString());
                        datos.AddCell(s.RequirePayment.ToString());
                        datos.AddCell(s.AmountUntaxed.ToString());
                        datos.AddCell(s.AmountTotal.ToString());

                        datos.WriteSelectedRows(0, -1, 10f, yPos, writer.DirectContent);
                        datos = new PdfPTable(nomCols.Length) {
                            DefaultCell = {
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            VerticalAlignment = Element.ALIGN_CENTER,
                            FixedHeight = 20f
                        }
                        };
                        datos.SetTotalWidth(anchoCols);
                    }

                    // Cierra el fichero
                    doc.Close();
                    openPdf(dlg.FileName);
                }
                catch (Exception) { MessageBox.Show("Se ha producido un error al generar el fichero PDF"); }
            }
        }





        public void generarPDFFacturas() { }

        /// <summary>Abre un fichero PDF</summary>
        /// <param name="pdfName">Ruta del fichero</param>
        public void openPdf(string pdfName) {

            try {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(@pdfName) { UseShellExecute = true };
                p.Start();
            }
            catch (Exception) { MessageBox.Show("Error al abrir el fichero " + pdfName.ToString()); }
        }
    }
}
