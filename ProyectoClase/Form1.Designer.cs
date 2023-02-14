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
            this.botonEmpezar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.etiquetaPrueba = new System.Windows.Forms.Label();
            this.botonColor = new System.Windows.Forms.Button();
            this.datosDisco = new System.Windows.Forms.Button();
            this.salidaDatosDisco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salidaDatosEquipo
            // 
            this.salidaDatosEquipo.BackColor = System.Drawing.Color.Black;
            this.salidaDatosEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salidaDatosEquipo.Location = new System.Drawing.Point(322, 84);
            this.salidaDatosEquipo.Multiline = true;
            this.salidaDatosEquipo.Name = "salidaDatosEquipo";
            this.salidaDatosEquipo.Size = new System.Drawing.Size(399, 97);
            this.salidaDatosEquipo.TabIndex = 0;
            // 
            // botonEmpezar
            // 
            this.botonEmpezar.Location = new System.Drawing.Point(132, 103);
            this.botonEmpezar.Name = "botonEmpezar";
            this.botonEmpezar.Size = new System.Drawing.Size(165, 62);
            this.botonEmpezar.TabIndex = 1;
            this.botonEmpezar.Text = "Clíckame!";
            this.botonEmpezar.UseVisualStyleBackColor = true;
            this.botonEmpezar.Click += new System.EventHandler(this.botonEmpezar_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(374, 404);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(101, 34);
            this.borrar.TabIndex = 2;
            this.borrar.Text = "Reset";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // etiquetaPrueba
            // 
            this.etiquetaPrueba.AutoSize = true;
            this.etiquetaPrueba.Location = new System.Drawing.Point(334, 25);
            this.etiquetaPrueba.Name = "etiquetaPrueba";
            this.etiquetaPrueba.Size = new System.Drawing.Size(91, 15);
            this.etiquetaPrueba.TabIndex = 3;
            this.etiquetaPrueba.Text = "Texto de prueba";
            // 
            // botonColor
            // 
            this.botonColor.Location = new System.Drawing.Point(12, 380);
            this.botonColor.Name = "botonColor";
            this.botonColor.Size = new System.Drawing.Size(137, 58);
            this.botonColor.TabIndex = 4;
            this.botonColor.Text = "Púlsame!";
            this.botonColor.UseVisualStyleBackColor = true;
            this.botonColor.Click += new System.EventHandler(this.botonColor_Click);
            // 
            // datosDisco
            // 
            this.datosDisco.Location = new System.Drawing.Point(153, 245);
            this.datosDisco.Name = "datosDisco";
            this.datosDisco.Size = new System.Drawing.Size(120, 54);
            this.datosDisco.TabIndex = 5;
            this.datosDisco.Text = "Datos Disco";
            this.datosDisco.UseVisualStyleBackColor = true;
            this.datosDisco.Click += new System.EventHandler(this.datosDisco_Click);
            // 
            // salidaDatosDisco
            // 
            this.salidaDatosDisco.Location = new System.Drawing.Point(322, 224);
            this.salidaDatosDisco.Multiline = true;
            this.salidaDatosDisco.Name = "salidaDatosDisco";
            this.salidaDatosDisco.Size = new System.Drawing.Size(399, 75);
            this.salidaDatosDisco.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salidaDatosDisco);
            this.Controls.Add(this.datosDisco);
            this.Controls.Add(this.botonColor);
            this.Controls.Add(this.etiquetaPrueba);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.botonEmpezar);
            this.Controls.Add(this.salidaDatosEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox salidaDatosEquipo;
        private Button botonEmpezar;
        private Button borrar;
        private Label etiquetaPrueba;
        private Button botonColor;
        private Button datosDisco;
        private TextBox salidaDatosDisco;
    }
}