namespace pryMiPrimerApp
{
    partial class frmAlacena
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
            this.mrcAgregarproducto = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblTipoproducto = new System.Windows.Forms.Label();
            this.lstTipoproducto = new System.Windows.Forms.ComboBox();
            this.mrcLugarproducto = new System.Windows.Forms.GroupBox();
            this.optHeladera = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.mrcAgregarproducto.SuspendLayout();
            this.mrcLugarproducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcAgregarproducto
            // 
            this.mrcAgregarproducto.Controls.Add(this.mrcLugarproducto);
            this.mrcAgregarproducto.Controls.Add(this.lstTipoproducto);
            this.mrcAgregarproducto.Controls.Add(this.lblTipoproducto);
            this.mrcAgregarproducto.Controls.Add(this.txtProducto);
            this.mrcAgregarproducto.Controls.Add(this.lblProducto);
            this.mrcAgregarproducto.Location = new System.Drawing.Point(12, 12);
            this.mrcAgregarproducto.Name = "mrcAgregarproducto";
            this.mrcAgregarproducto.Size = new System.Drawing.Size(294, 202);
            this.mrcAgregarproducto.TabIndex = 0;
            this.mrcAgregarproducto.TabStop = false;
            this.mrcAgregarproducto.Text = "Agregar producto";
            this.mrcAgregarproducto.Enter += new System.EventHandler(this.mrcAgregarproducto_Enter);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(6, 31);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(62, 28);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(173, 20);
            this.txtProducto.TabIndex = 1;
            // 
            // lblTipoproducto
            // 
            this.lblTipoproducto.AutoSize = true;
            this.lblTipoproducto.Location = new System.Drawing.Point(6, 64);
            this.lblTipoproducto.Name = "lblTipoproducto";
            this.lblTipoproducto.Size = new System.Drawing.Size(73, 13);
            this.lblTipoproducto.TabIndex = 2;
            this.lblTipoproducto.Text = "Tipo producto";
            this.lblTipoproducto.Click += new System.EventHandler(this.lblTipoproducto_Click);
            // 
            // lstTipoproducto
            // 
            this.lstTipoproducto.FormattingEnabled = true;
            this.lstTipoproducto.Location = new System.Drawing.Point(85, 61);
            this.lstTipoproducto.Name = "lstTipoproducto";
            this.lstTipoproducto.Size = new System.Drawing.Size(150, 21);
            this.lstTipoproducto.TabIndex = 3;
            // 
            // mrcLugarproducto
            // 
            this.mrcLugarproducto.Controls.Add(this.radioButton3);
            this.mrcLugarproducto.Controls.Add(this.radioButton2);
            this.mrcLugarproducto.Controls.Add(this.optHeladera);
            this.mrcLugarproducto.Location = new System.Drawing.Point(8, 95);
            this.mrcLugarproducto.Name = "mrcLugarproducto";
            this.mrcLugarproducto.Size = new System.Drawing.Size(280, 101);
            this.mrcLugarproducto.TabIndex = 4;
            this.mrcLugarproducto.TabStop = false;
            this.mrcLugarproducto.Text = "Lugar producto";
            // 
            // optHeladera
            // 
            this.optHeladera.AutoSize = true;
            this.optHeladera.Location = new System.Drawing.Point(6, 43);
            this.optHeladera.Name = "optHeladera";
            this.optHeladera.Size = new System.Drawing.Size(28, 17);
            this.optHeladera.TabIndex = 5;
            this.optHeladera.TabStop = true;
            this.optHeladera.Text = "-";
            this.optHeladera.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Baño";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(188, 43);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.mrcAgregarproducto);
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcAgregarproducto.ResumeLayout(false);
            this.mrcAgregarproducto.PerformLayout();
            this.mrcLugarproducto.ResumeLayout(false);
            this.mrcLugarproducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcAgregarproducto;
        private System.Windows.Forms.ComboBox lstTipoproducto;
        private System.Windows.Forms.Label lblTipoproducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox mrcLugarproducto;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton optHeladera;
    }
}