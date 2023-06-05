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
            this.dtpCaducidad = new System.Windows.Forms.DateTimePicker();
            this.cmAgregar = new System.Windows.Forms.Button();
            this.chkCaduce = new System.Windows.Forms.CheckBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lstTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoproducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.mrcAgregarproducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcAgregarproducto
            // 
            this.mrcAgregarproducto.Controls.Add(this.dtpCaducidad);
            this.mrcAgregarproducto.Controls.Add(this.cmAgregar);
            this.mrcAgregarproducto.Controls.Add(this.chkCaduce);
            this.mrcAgregarproducto.Controls.Add(this.txtCantidad);
            this.mrcAgregarproducto.Controls.Add(this.lblCantidad);
            this.mrcAgregarproducto.Controls.Add(this.lstTipoProducto);
            this.mrcAgregarproducto.Controls.Add(this.lblTipoproducto);
            this.mrcAgregarproducto.Controls.Add(this.txtProducto);
            this.mrcAgregarproducto.Controls.Add(this.lblProducto);
            this.mrcAgregarproducto.Location = new System.Drawing.Point(12, 12);
            this.mrcAgregarproducto.Name = "mrcAgregarproducto";
            this.mrcAgregarproducto.Size = new System.Drawing.Size(255, 264);
            this.mrcAgregarproducto.TabIndex = 0;
            this.mrcAgregarproducto.TabStop = false;
            this.mrcAgregarproducto.Text = "Agregar producto";
            this.mrcAgregarproducto.Enter += new System.EventHandler(this.mrcAgregarproducto_Enter);
            // 
            // dtpCaducidad
            // 
            this.dtpCaducidad.Location = new System.Drawing.Point(24, 171);
            this.dtpCaducidad.Name = "dtpCaducidad";
            this.dtpCaducidad.Size = new System.Drawing.Size(200, 20);
            this.dtpCaducidad.TabIndex = 1;
            // 
            // cmAgregar
            // 
            this.cmAgregar.Location = new System.Drawing.Point(84, 223);
            this.cmAgregar.Name = "cmAgregar";
            this.cmAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmAgregar.TabIndex = 1;
            this.cmAgregar.Text = "Agregar";
            this.cmAgregar.UseVisualStyleBackColor = true;
            this.cmAgregar.Click += new System.EventHandler(this.cmAgregar_Click);
            // 
            // chkCaduce
            // 
            this.chkCaduce.AutoSize = true;
            this.chkCaduce.Location = new System.Drawing.Point(96, 135);
            this.chkCaduce.Name = "chkCaduce";
            this.chkCaduce.Size = new System.Drawing.Size(63, 17);
            this.chkCaduce.TabIndex = 6;
            this.chkCaduce.Text = "Caduce";
            this.chkCaduce.UseVisualStyleBackColor = true;
            this.chkCaduce.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(62, 96);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(173, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 99);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lstTipoProducto
            // 
            this.lstTipoProducto.FormattingEnabled = true;
            this.lstTipoProducto.Items.AddRange(new object[] {
            "Cocina",
            "Heladera",
            "Limpieza"});
            this.lstTipoProducto.Location = new System.Drawing.Point(85, 61);
            this.lstTipoProducto.Name = "lstTipoProducto";
            this.lstTipoProducto.Size = new System.Drawing.Size(150, 21);
            this.lstTipoProducto.TabIndex = 3;
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
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(62, 28);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(173, 20);
            this.txtProducto.TabIndex = 1;
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
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 288);
            this.Controls.Add(this.mrcAgregarproducto);
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcAgregarproducto.ResumeLayout(false);
            this.mrcAgregarproducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcAgregarproducto;
        private System.Windows.Forms.ComboBox lstTipoProducto;
        private System.Windows.Forms.Label lblTipoproducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox chkCaduce;
        private System.Windows.Forms.DateTimePicker dtpCaducidad;
        private System.Windows.Forms.Button cmAgregar;
    }
}