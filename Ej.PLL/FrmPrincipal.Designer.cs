namespace Ej.PLL
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBotonRojo = new System.Windows.Forms.Button();
            this.btnExcepcion = new System.Windows.Forms.Button();
            this.lblErrorExcepciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(38, 100);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(175, 20);
            this.txtDividendo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese dos enteros";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(6, 196);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(244, 62);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "placeholderplaceholderplaceholderplaceholderplaceholderplaceholderplaceholderplac" +
    "eholderplaceholder";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(38, 152);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(175, 20);
            this.txtDivisor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDivisor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtDividendo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResultado.Location = new System.Drawing.Point(6, 361);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(95, 20);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "placeholder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Divisor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dividendo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(89, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Division";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblErrorExcepciones);
            this.groupBox2.Controls.Add(this.btnBotonRojo);
            this.groupBox2.Controls.Add(this.btnExcepcion);
            this.groupBox2.Location = new System.Drawing.Point(274, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 426);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excepciones";
            // 
            // btnBotonRojo
            // 
            this.btnBotonRojo.BackColor = System.Drawing.Color.IndianRed;
            this.btnBotonRojo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBotonRojo.Location = new System.Drawing.Point(48, 287);
            this.btnBotonRojo.Name = "btnBotonRojo";
            this.btnBotonRojo.Size = new System.Drawing.Size(155, 75);
            this.btnBotonRojo.TabIndex = 1;
            this.btnBotonRojo.Text = "Lanzar error personalizado";
            this.btnBotonRojo.UseVisualStyleBackColor = false;
            this.btnBotonRojo.Click += new System.EventHandler(this.btnBotonRojo_Click);
            // 
            // btnExcepcion
            // 
            this.btnExcepcion.Location = new System.Drawing.Point(48, 56);
            this.btnExcepcion.Name = "btnExcepcion";
            this.btnExcepcion.Size = new System.Drawing.Size(155, 75);
            this.btnExcepcion.TabIndex = 0;
            this.btnExcepcion.Text = "Lanzar error y mostrar mensaje y tipo";
            this.btnExcepcion.UseVisualStyleBackColor = true;
            this.btnExcepcion.Click += new System.EventHandler(this.btnExcepcion_Click);
            // 
            // lblErrorExcepciones
            // 
            this.lblErrorExcepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErrorExcepciones.ForeColor = System.Drawing.Color.Red;
            this.lblErrorExcepciones.Location = new System.Drawing.Point(6, 171);
            this.lblErrorExcepciones.Name = "lblErrorExcepciones";
            this.lblErrorExcepciones.Size = new System.Drawing.Size(244, 100);
            this.lblErrorExcepciones.TabIndex = 9;
            this.lblErrorExcepciones.Text = "placeholderplaceholderplaceholderplaceholderplaceholderplaceholderplaceholderplac" +
    "eholderplaceholder";
            this.lblErrorExcepciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBotonRojo;
        private System.Windows.Forms.Button btnExcepcion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblErrorExcepciones;
    }
}