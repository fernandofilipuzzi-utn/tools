﻿
namespace Ej3_QR_Desktop
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQR = new System.Windows.Forms.Button();
            this.tbCadenaDeEntrada = new System.Windows.Forms.TextBox();
            this.openFileDialogLogo = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLoadLogo = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBackColor = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(468, 66);
            this.btnQR.Margin = new System.Windows.Forms.Padding(4);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(89, 74);
            this.btnQR.TabIndex = 27;
            this.btnQR.Text = "Generar QR";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // tbCadenaDeEntrada
            // 
            this.tbCadenaDeEntrada.Location = new System.Drawing.Point(12, 23);
            this.tbCadenaDeEntrada.Multiline = true;
            this.tbCadenaDeEntrada.Name = "tbCadenaDeEntrada";
            this.tbCadenaDeEntrada.Size = new System.Drawing.Size(545, 31);
            this.tbCadenaDeEntrada.TabIndex = 29;
            // 
            // openFileDialogLogo
            // 
            this.openFileDialogLogo.FileName = "openFileDialogLogo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 54);
            this.button1.TabIndex = 33;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLoadLogo);
            this.groupBox1.Location = new System.Drawing.Point(230, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 131);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logo";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbLogo.Location = new System.Drawing.Point(6, 18);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(97, 102);
            this.pbLogo.TabIndex = 31;
            this.pbLogo.TabStop = false;
            // 
            // btnLoadLogo
            // 
            this.btnLoadLogo.Image = global::Ej3_QR_Desktop.Properties.Resources.openfile_70;
            this.btnLoadLogo.Location = new System.Drawing.Point(119, 11);
            this.btnLoadLogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadLogo.Name = "btnLoadLogo";
            this.btnLoadLogo.Size = new System.Drawing.Size(71, 56);
            this.btnLoadLogo.TabIndex = 32;
            this.btnLoadLogo.UseVisualStyleBackColor = true;
            this.btnLoadLogo.Click += new System.EventHandler(this.btnLoadLogo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbBackColor);
            this.groupBox2.Controls.Add(this.pbColor);
            this.groupBox2.Location = new System.Drawing.Point(230, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 91);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección de Colores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Color de fondo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "imagen color";
            // 
            // pbBackColor
            // 
            this.pbBackColor.BackColor = System.Drawing.Color.White;
            this.pbBackColor.Location = new System.Drawing.Point(119, 19);
            this.pbBackColor.Name = "pbBackColor";
            this.pbBackColor.Size = new System.Drawing.Size(45, 42);
            this.pbBackColor.TabIndex = 32;
            this.pbBackColor.TabStop = false;
            this.pbBackColor.Click += new System.EventHandler(this.obDefinirColor_Click);
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Blue;
            this.pbColor.Location = new System.Drawing.Point(22, 19);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(45, 42);
            this.pbColor.TabIndex = 31;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.obDefinirColor_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::Ej3_QR_Desktop.Properties.Resources.copy_paste_70;
            this.btnCopy.Location = new System.Drawing.Point(471, 206);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(89, 75);
            this.btnCopy.TabIndex = 30;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Contenido del QR";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbCadenaDeEntrada);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQR);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.TextBox tbCadenaDeEntrada;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLoadLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbBackColor;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

