namespace ProyectoClase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salidaDatosEquipo = new System.Windows.Forms.TextBox();
            this.botonDatosEquipo = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.etiquetaPrueba = new System.Windows.Forms.Label();
            this.botonColor = new System.Windows.Forms.Button();
            this.datosDisco = new System.Windows.Forms.Button();
            this.salidaDatosDisco = new System.Windows.Forms.TextBox();
            this.botonIP = new System.Windows.Forms.Button();
            this.salidaIP = new System.Windows.Forms.TextBox();
            this.cuadroColorBateria = new System.Windows.Forms.PictureBox();
            this.salidaBateria = new System.Windows.Forms.TextBox();
            this.ComprobarBateria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorBateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salidaDatosEquipo
            // 
            this.salidaDatosEquipo.BackColor = System.Drawing.Color.White;
            this.salidaDatosEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.salidaDatosEquipo.Location = new System.Drawing.Point(138, 282);
            this.salidaDatosEquipo.Multiline = true;
            this.salidaDatosEquipo.Name = "salidaDatosEquipo";
            this.salidaDatosEquipo.Size = new System.Drawing.Size(252, 97);
            this.salidaDatosEquipo.TabIndex = 0;
            // 
            // botonDatosEquipo
            // 
            this.botonDatosEquipo.BackColor = System.Drawing.Color.White;
            this.botonDatosEquipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonDatosEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.botonDatosEquipo.Location = new System.Drawing.Point(12, 297);
            this.botonDatosEquipo.Name = "botonDatosEquipo";
            this.botonDatosEquipo.Size = new System.Drawing.Size(120, 62);
            this.botonDatosEquipo.TabIndex = 1;
            this.botonDatosEquipo.Text = "Datos del equipo";
            this.botonDatosEquipo.UseVisualStyleBackColor = false;
            this.botonDatosEquipo.Click += new System.EventHandler(this.botonEmpezar_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.White;
            this.borrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.borrar.Location = new System.Drawing.Point(265, 404);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(101, 34);
            this.borrar.TabIndex = 2;
            this.borrar.Text = "Reset";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // etiquetaPrueba
            // 
            this.etiquetaPrueba.AutoSize = true;
            this.etiquetaPrueba.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etiquetaPrueba.ForeColor = System.Drawing.Color.Aqua;
            this.etiquetaPrueba.Location = new System.Drawing.Point(329, 12);
            this.etiquetaPrueba.Name = "etiquetaPrueba";
            this.etiquetaPrueba.Size = new System.Drawing.Size(183, 20);
            this.etiquetaPrueba.TabIndex = 3;
            this.etiquetaPrueba.Text = "Form Jesús Carrillo";
            // 
            // botonColor
            // 
            this.botonColor.BackColor = System.Drawing.Color.White;
            this.botonColor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.botonColor.Location = new System.Drawing.Point(28, 404);
            this.botonColor.Name = "botonColor";
            this.botonColor.Size = new System.Drawing.Size(104, 34);
            this.botonColor.TabIndex = 4;
            this.botonColor.Text = "Púlsame!";
            this.botonColor.UseVisualStyleBackColor = false;
            this.botonColor.Click += new System.EventHandler(this.botonColor_Click);
            // 
            // datosDisco
            // 
            this.datosDisco.BackColor = System.Drawing.Color.White;
            this.datosDisco.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.datosDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.datosDisco.Location = new System.Drawing.Point(12, 193);
            this.datosDisco.Name = "datosDisco";
            this.datosDisco.Size = new System.Drawing.Size(120, 54);
            this.datosDisco.TabIndex = 5;
            this.datosDisco.Text = "Datos Disco";
            this.datosDisco.UseVisualStyleBackColor = false;
            this.datosDisco.Click += new System.EventHandler(this.datosDisco_Click);
            // 
            // salidaDatosDisco
            // 
            this.salidaDatosDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.salidaDatosDisco.Location = new System.Drawing.Point(138, 182);
            this.salidaDatosDisco.Multiline = true;
            this.salidaDatosDisco.Name = "salidaDatosDisco";
            this.salidaDatosDisco.Size = new System.Drawing.Size(219, 75);
            this.salidaDatosDisco.TabIndex = 6;
            // 
            // botonIP
            // 
            this.botonIP.BackColor = System.Drawing.Color.White;
            this.botonIP.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.botonIP.Location = new System.Drawing.Point(12, 97);
            this.botonIP.Name = "botonIP";
            this.botonIP.Size = new System.Drawing.Size(120, 44);
            this.botonIP.TabIndex = 7;
            this.botonIP.Text = "Get IP";
            this.botonIP.UseVisualStyleBackColor = false;
            this.botonIP.Click += new System.EventHandler(this.botonIP_Click);
            // 
            // salidaIP
            // 
            this.salidaIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.salidaIP.Location = new System.Drawing.Point(138, 80);
            this.salidaIP.Multiline = true;
            this.salidaIP.Name = "salidaIP";
            this.salidaIP.Size = new System.Drawing.Size(184, 78);
            this.salidaIP.TabIndex = 8;
            this.salidaIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cuadroColorBateria
            // 
            this.cuadroColorBateria.BackColor = System.Drawing.Color.White;
            this.cuadroColorBateria.Location = new System.Drawing.Point(688, 12);
            this.cuadroColorBateria.Name = "cuadroColorBateria";
            this.cuadroColorBateria.Size = new System.Drawing.Size(100, 50);
            this.cuadroColorBateria.TabIndex = 9;
            this.cuadroColorBateria.TabStop = false;
            // 
            // salidaBateria
            // 
            this.salidaBateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.salidaBateria.Location = new System.Drawing.Point(688, 68);
            this.salidaBateria.Multiline = true;
            this.salidaBateria.Name = "salidaBateria";
            this.salidaBateria.Size = new System.Drawing.Size(100, 23);
            this.salidaBateria.TabIndex = 10;
            // 
            // ComprobarBateria
            // 
            this.ComprobarBateria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComprobarBateria.Location = new System.Drawing.Point(688, 97);
            this.ComprobarBateria.Name = "ComprobarBateria";
            this.ComprobarBateria.Size = new System.Drawing.Size(100, 44);
            this.ComprobarBateria.TabIndex = 11;
            this.ComprobarBateria.Text = "Check Battery";
            this.ComprobarBateria.UseVisualStyleBackColor = true;
            this.ComprobarBateria.Click += new System.EventHandler(this.ComprobarBateria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\jesus\\Desktop\\homer-gif.gif";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(396, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComprobarBateria);
            this.Controls.Add(this.salidaBateria);
            this.Controls.Add(this.cuadroColorBateria);
            this.Controls.Add(this.salidaIP);
            this.Controls.Add(this.botonIP);
            this.Controls.Add(this.salidaDatosDisco);
            this.Controls.Add(this.datosDisco);
            this.Controls.Add(this.botonColor);
            this.Controls.Add(this.etiquetaPrueba);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.botonDatosEquipo);
            this.Controls.Add(this.salidaDatosEquipo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorBateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox salidaDatosEquipo;
        private Button botonDatosEquipo;
        private Button borrar;
        private Label etiquetaPrueba;
        private Button botonColor;
        private Button datosDisco;
        private TextBox salidaDatosDisco;
        private Button botonIP;
        private TextBox salidaIP;
        private PictureBox cuadroColorBateria;
        private TextBox salidaBateria;
        private Button ComprobarBateria;
        private PictureBox pictureBox1;
    }
}