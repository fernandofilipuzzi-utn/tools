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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace GeneradorIconosApp
{
    public partial class FormPrincipal : Form
    {
        Image imagen = null;
        Image imagenEditada = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagen = Image.FromFile(openFileDialog1.FileName);
                imagenEditada = imagen;
                pictureBox1.Image = imagen;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathDestino = folderBrowserDialog1.SelectedPath;
                Armador armador = new Armador(imagenEditada, pathDestino);
                armador.MargenPorc = Convert.ToDouble(numericUpDown1.Value);
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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap opaqueImage = new Bitmap(pictureBox1.Image);
                using (Graphics g = Graphics.FromImage(opaqueImage))
                {
                    Clipboard.SetImage(opaqueImage);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Bitmap ImagenOpaca = new Bitmap(imagen);
                using (Graphics g = Graphics.FromImage(ImagenOpaca))
                {
                    g.Clear(pbBackColor.BackColor);
                    g.DrawImage(imagen, 0, 0);
                    pictureBox1.Image = ImagenOpaca;
                }
            }
            else
            {
                imagenEditada = imagen;
                pictureBox1.Image = imagen;
            }
        }
    }
}
