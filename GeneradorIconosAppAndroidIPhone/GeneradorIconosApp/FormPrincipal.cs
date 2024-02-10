using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorIconosApp
{
    public partial class FormPrincipal : Form
    {
        string pathImagenOrigen = "";
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
                pathImagenOrigen= openFileDialog1.FileName;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathDestino = folderBrowserDialog1.SelectedPath;
                Armador armador = new Armador(pathImagenOrigen, pathDestino);
                armador.GenerarFicheros();
            }


        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (sender == pbColor)
                    pbColor.BackColor = colorDialog1.Color;
                else
                    pbBackColor.BackColor = colorDialog1.Color;
            }
        }

        private void pbBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (sender == pbColor)
                    pbColor.BackColor = colorDialog1.Color;
                else
                    pbBackColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            /*
            if (qrCodeImage != null)
            {
                Bitmap opaqueImage = new Bitmap(qrCodeImage.Width, qrCodeImage.Height);
                using (Graphics g = Graphics.FromImage(opaqueImage))
                {
                    g.Clear(Color.White);
                    g.DrawImage(qrCodeImage, 0, 0);
                    Clipboard.SetImage(opaqueImage);
                }
            }
            */
        }
    }
}
