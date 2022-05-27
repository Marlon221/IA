namespace IA
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
            this.GboxConfiguracion = new System.Windows.Forms.GroupBox();
            this.LabelMensaje = new System.Windows.Forms.Label();
            this.BtnMontarArchivo = new System.Windows.Forms.Button();
            this.CBoxEntrenamiento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoxFuncion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxRed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelPatron = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelSalida = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelEntrada = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelTamaño = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBoxCapas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GboxConfiguracion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboxConfiguracion
            // 
            this.GboxConfiguracion.Controls.Add(this.CBoxCapas);
            this.GboxConfiguracion.Controls.Add(this.label5);
            this.GboxConfiguracion.Controls.Add(this.LabelMensaje);
            this.GboxConfiguracion.Controls.Add(this.BtnMontarArchivo);
            this.GboxConfiguracion.Controls.Add(this.CBoxEntrenamiento);
            this.GboxConfiguracion.Controls.Add(this.label3);
            this.GboxConfiguracion.Controls.Add(this.CBoxFuncion);
            this.GboxConfiguracion.Controls.Add(this.label2);
            this.GboxConfiguracion.Controls.Add(this.CBoxRed);
            this.GboxConfiguracion.Controls.Add(this.label1);
            this.GboxConfiguracion.Location = new System.Drawing.Point(12, 12);
            this.GboxConfiguracion.Name = "GboxConfiguracion";
            this.GboxConfiguracion.Size = new System.Drawing.Size(328, 194);
            this.GboxConfiguracion.TabIndex = 0;
            this.GboxConfiguracion.TabStop = false;
            this.GboxConfiguracion.Text = "Configuracion";
            // 
            // LabelMensaje
            // 
            this.LabelMensaje.AutoSize = true;
            this.LabelMensaje.Location = new System.Drawing.Point(6, 160);
            this.LabelMensaje.Name = "LabelMensaje";
            this.LabelMensaje.Size = new System.Drawing.Size(0, 15);
            this.LabelMensaje.TabIndex = 7;
            // 
            // BtnMontarArchivo
            // 
            this.BtnMontarArchivo.Location = new System.Drawing.Point(92, 148);
            this.BtnMontarArchivo.Name = "BtnMontarArchivo";
            this.BtnMontarArchivo.Size = new System.Drawing.Size(103, 31);
            this.BtnMontarArchivo.TabIndex = 6;
            this.BtnMontarArchivo.Text = "Montar archivo";
            this.BtnMontarArchivo.UseVisualStyleBackColor = true;
            this.BtnMontarArchivo.Click += new System.EventHandler(this.BtnMontarArchivo_Click);
            // 
            // CBoxEntrenamiento
            // 
            this.CBoxEntrenamiento.FormattingEnabled = true;
            this.CBoxEntrenamiento.Location = new System.Drawing.Point(178, 117);
            this.CBoxEntrenamiento.Name = "CBoxEntrenamiento";
            this.CBoxEntrenamiento.Size = new System.Drawing.Size(128, 23);
            this.CBoxEntrenamiento.TabIndex = 5;
            this.CBoxEntrenamiento.SelectedIndexChanged += new System.EventHandler(this.CBoxEntrenamiento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Regla de entrenamiento: ";
            // 
            // CBoxFuncion
            // 
            this.CBoxFuncion.FormattingEnabled = true;
            this.CBoxFuncion.Location = new System.Drawing.Point(162, 83);
            this.CBoxFuncion.Name = "CBoxFuncion";
            this.CBoxFuncion.Size = new System.Drawing.Size(144, 23);
            this.CBoxFuncion.TabIndex = 3;
            this.CBoxFuncion.SelectedIndexChanged += new System.EventHandler(this.CBoxFuncion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcion de activacion: ";
            // 
            // CBoxRed
            // 
            this.CBoxRed.FormattingEnabled = true;
            this.CBoxRed.Items.AddRange(new object[] {
            "Perceptron",
            "Adaline",
            "Backpropagation"});
            this.CBoxRed.Location = new System.Drawing.Point(107, 17);
            this.CBoxRed.Name = "CBoxRed";
            this.CBoxRed.Size = new System.Drawing.Size(199, 23);
            this.CBoxRed.TabIndex = 1;
            this.CBoxRed.SelectedIndexChanged += new System.EventHandler(this.CBoxRed_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de red: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelPatron);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LabelSalida);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LabelEntrada);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LabelTamaño);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados neurona";
            // 
            // LabelPatron
            // 
            this.LabelPatron.AutoSize = true;
            this.LabelPatron.Location = new System.Drawing.Point(137, 96);
            this.LabelPatron.Name = "LabelPatron";
            this.LabelPatron.Size = new System.Drawing.Size(0, 15);
            this.LabelPatron.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Patrones: ";
            // 
            // LabelSalida
            // 
            this.LabelSalida.AutoSize = true;
            this.LabelSalida.Location = new System.Drawing.Point(137, 70);
            this.LabelSalida.Name = "LabelSalida";
            this.LabelSalida.Size = new System.Drawing.Size(0, 15);
            this.LabelSalida.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Salidas: ";
            // 
            // LabelEntrada
            // 
            this.LabelEntrada.AutoSize = true;
            this.LabelEntrada.Location = new System.Drawing.Point(137, 44);
            this.LabelEntrada.Name = "LabelEntrada";
            this.LabelEntrada.Size = new System.Drawing.Size(0, 15);
            this.LabelEntrada.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Entradas: ";
            // 
            // LabelTamaño
            // 
            this.LabelTamaño.AutoSize = true;
            this.LabelTamaño.Location = new System.Drawing.Point(137, 19);
            this.LabelTamaño.Name = "LabelTamaño";
            this.LabelTamaño.Size = new System.Drawing.Size(0, 15);
            this.LabelTamaño.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tamaño de la matriz: ";
            // 
            // CBoxCapas
            // 
            this.CBoxCapas.FormattingEnabled = true;
            this.CBoxCapas.Items.AddRange(new object[] {
            "Perceptron",
            "Adaline",
            "Backpropagation"});
            this.CBoxCapas.Location = new System.Drawing.Point(107, 50);
            this.CBoxCapas.Name = "CBoxCapas";
            this.CBoxCapas.Size = new System.Drawing.Size(199, 23);
            this.CBoxCapas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capas: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GboxConfiguracion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GboxConfiguracion.ResumeLayout(false);
            this.GboxConfiguracion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboxConfiguracion;
        private System.Windows.Forms.Label LabelMensaje;
        private System.Windows.Forms.Button BtnMontarArchivo;
        private System.Windows.Forms.ComboBox CBoxEntrenamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBoxFuncion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelPatron;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelTamaño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBoxCapas;
        private System.Windows.Forms.Label label5;
    }
}
