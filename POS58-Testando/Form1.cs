using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS58_Testando
{
    public partial class Form1 : Form
    {
        Double total_pedido = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            total_pedido = 0;
            if (chbox_smash.Checked != false)
            {
                total_pedido += (Convert.ToDouble(num_smash.Value) * 10.0);
            }
            if (chbox_chopp.Checked != false)
            {
                total_pedido += (Convert.ToDouble(num_chopp.Value) * 10.0);
            }
            lbl_total.Text = "Total: " + total_pedido.ToString("c");
            btn_imprimir.Enabled = true;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("teste", 580, 500);

            //printPreviewDialog1.Show();
            printDocument1.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Testando", new Font("Comic Sans MS", 26), Brushes.Red, new Point(3, 0));
            e.Graphics.DrawString("________________________________", new Font("Comic Sans MS", 20), Brushes.Black, new Point(0, 17));
            if (chbox_chopp.Checked != false)
            {
                e.Graphics.DrawString(num_chopp.Value + "x  CHOPP  | " + (num_chopp.Value * 10).ToString("C"), new Font("Arial Narrow", 8), Brushes.Black, new Point(1, 55));
            }
            if (chbox_smash.Checked != false)
            {
                e.Graphics.DrawString(num_smash.Value + "x  Smash Burguer | " + (num_smash.Value * 10).ToString("C"), new Font("Arial Narrow", 8), Brushes.Black, new Point(1, 70));
            }

            e.Graphics.DrawString("Total do Pedido:", new Font("Arial Narrow", 11), Brushes.Black, new Point(1, 125));
            e.Graphics.DrawString(total_pedido.ToString("c"), new Font("Arial Narrow", 11), Brushes.Black, new Point(1, 145));


            e.Graphics.DrawString("________________________________", new Font("Comic Sans MS", 20), Brushes.Black, new Point(0, 150));
            e.Graphics.DrawString("Pedido feito as " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + " | " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Arial Narrow", 7), Brushes.Black, new Point(8, 190));


        }
    }
}
