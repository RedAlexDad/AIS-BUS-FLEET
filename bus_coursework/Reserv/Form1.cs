using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using bus_coursework.MyClass;
using DGVPrinterHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Sample {
    public partial class Form1 : Form {
        Director controller;

        public Form1() {
            InitializeComponent();
            controller = new Director(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = controller.UpdateArmChair();
        }

        private void button2_Click(object sender, EventArgs e) {
            //controller.Add(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e) {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Индекс_руководителя"].Value.ToString()));
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        // Печать отчета
        private void button10_Click(object sender, EventArgs e) {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "SIMPLE PRINT";
            printer.SubTitle = string.Format("Product", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "List of Products";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);

        }

        private void button11_Click(object sender, EventArgs e) {
            if(dataGridView1.Rows.Count > 0) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if(sfd.ShowDialog() == DialogResult.OK) {
                    if(File.Exists(sfd.FileName)) {
                        try {
                            File.Delete(sfd.FileName);
                        } catch(IOException ex) {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if(!fileError) {
                        try {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn column in dataGridView1.Columns) {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach(DataGridViewRow row in dataGridView1.Rows) {
                                foreach(DataGridViewCell cell in row.Cells) {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using(FileStream stream = new FileStream(sfd.FileName, FileMode.Create)) {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        } catch(Exception ex) {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            } else {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
