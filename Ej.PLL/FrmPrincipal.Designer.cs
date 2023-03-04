namespace Ej.PLL.Forms
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
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvTransportes = new System.Windows.Forms.DataGridView();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(12, 491);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(110, 50);
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.Text = "Avanzar...";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(168, 491);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(110, 50);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Nuevo transporte...";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(328, 491);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(110, 50);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "Detenerse...";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblTitulo.Location = new System.Drawing.Point(115, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 26);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Listado de transportes";
            // 
            // dgvTransportes
            // 
            this.dgvTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportes.Location = new System.Drawing.Point(12, 38);
            this.dgvTransportes.Name = "dgvTransportes";
            this.dgvTransportes.Size = new System.Drawing.Size(426, 432);
            this.dgvTransportes.TabIndex = 6;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.lblPlaceholder.Location = new System.Drawing.Point(22, 234);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(407, 35);
            this.lblPlaceholder.TabIndex = 7;
            this.lblPlaceholder.Text = "Sin transportes en sistema...";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 549);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.dgvTransportes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnAvanzar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvTransportes;
        private System.Windows.Forms.Label lblPlaceholder;
    }
}