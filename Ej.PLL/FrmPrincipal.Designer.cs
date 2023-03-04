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
            this.lstOmnibus = new System.Windows.Forms.ListBox();
            this.lstTaxis = new System.Windows.Forms.ListBox();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOmnibus
            // 
            this.lstOmnibus.FormattingEnabled = true;
            this.lstOmnibus.Location = new System.Drawing.Point(12, 67);
            this.lstOmnibus.Name = "lstOmnibus";
            this.lstOmnibus.Size = new System.Drawing.Size(188, 394);
            this.lstOmnibus.TabIndex = 0;
            // 
            // lstTaxis
            // 
            this.lstTaxis.FormattingEnabled = true;
            this.lstTaxis.Location = new System.Drawing.Point(250, 67);
            this.lstTaxis.Name = "lstTaxis";
            this.lstTaxis.Size = new System.Drawing.Size(188, 394);
            this.lstTaxis.TabIndex = 1;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(12, 491);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(110, 50);
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.Text = "Avanzar...";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(168, 491);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(110, 50);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Nuevo transporte...";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(328, 491);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(110, 50);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "Detenerse...";
            this.btnDetener.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.lstTaxis);
            this.Controls.Add(this.lstOmnibus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOmnibus;
        private System.Windows.Forms.ListBox lstTaxis;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}