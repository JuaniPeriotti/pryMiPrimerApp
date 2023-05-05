namespace pryMiPrimerApp
{
    partial class frmFinanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanzas));
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lbDeposito = new System.Windows.Forms.Label();
            this.mrcGastos = new System.Windows.Forms.GroupBox();
            this.lblVarios = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtVarios = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtimpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblTOTA = new System.Windows.Forms.Label();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mrcIngresos.SuspendLayout();
            this.mrcGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.Controls.Add(this.lbDeposito);
            this.mrcIngresos.Location = new System.Drawing.Point(23, 20);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(155, 58);
            this.mrcIngresos.TabIndex = 0;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(81, 23);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(56, 20);
            this.txtDeposito.TabIndex = 1;
            // 
            // lbDeposito
            // 
            this.lbDeposito.AutoSize = true;
            this.lbDeposito.Location = new System.Drawing.Point(19, 26);
            this.lbDeposito.Name = "lbDeposito";
            this.lbDeposito.Size = new System.Drawing.Size(52, 13);
            this.lbDeposito.TabIndex = 0;
            this.lbDeposito.Text = "Deposito:";
            // 
            // mrcGastos
            // 
            this.mrcGastos.Controls.Add(this.lblVarios);
            this.mrcGastos.Controls.Add(this.lblComida);
            this.mrcGastos.Controls.Add(this.lblImpuestos);
            this.mrcGastos.Controls.Add(this.txtVarios);
            this.mrcGastos.Controls.Add(this.txtComida);
            this.mrcGastos.Controls.Add(this.txtimpuestos);
            this.mrcGastos.Controls.Add(this.txtAlquiler);
            this.mrcGastos.Controls.Add(this.lblAlquiler);
            this.mrcGastos.Location = new System.Drawing.Point(23, 84);
            this.mrcGastos.Name = "mrcGastos";
            this.mrcGastos.Size = new System.Drawing.Size(155, 162);
            this.mrcGastos.TabIndex = 1;
            this.mrcGastos.TabStop = false;
            this.mrcGastos.Text = "Gastos";
            // 
            // lblVarios
            // 
            this.lblVarios.AutoSize = true;
            this.lblVarios.Location = new System.Drawing.Point(13, 116);
            this.lblVarios.Name = "lblVarios";
            this.lblVarios.Size = new System.Drawing.Size(39, 13);
            this.lblVarios.TabIndex = 8;
            this.lblVarios.Text = "Varios:";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(13, 90);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(45, 13);
            this.lblComida.TabIndex = 7;
            this.lblComida.Text = "Comida:";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(13, 64);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(58, 13);
            this.lblImpuestos.TabIndex = 6;
            this.lblImpuestos.Text = "Impuestos:";
            // 
            // txtVarios
            // 
            this.txtVarios.Location = new System.Drawing.Point(81, 109);
            this.txtVarios.Name = "txtVarios";
            this.txtVarios.Size = new System.Drawing.Size(56, 20);
            this.txtVarios.TabIndex = 5;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(81, 83);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(56, 20);
            this.txtComida.TabIndex = 4;
            // 
            // txtimpuestos
            // 
            this.txtimpuestos.Location = new System.Drawing.Point(81, 57);
            this.txtimpuestos.Name = "txtimpuestos";
            this.txtimpuestos.Size = new System.Drawing.Size(56, 20);
            this.txtimpuestos.TabIndex = 3;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(81, 31);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(56, 20);
            this.txtAlquiler.TabIndex = 2;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(13, 38);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(44, 13);
            this.lblAlquiler.TabIndex = 2;
            this.lblAlquiler.Text = "Alquiler:";
            // 
            // lblTOTA
            // 
            this.lblTOTA.AutoSize = true;
            this.lblTOTA.Location = new System.Drawing.Point(35, 292);
            this.lblTOTA.Name = "lblTOTA";
            this.lblTOTA.Size = new System.Drawing.Size(45, 13);
            this.lblTOTA.TabIndex = 9;
            this.lblTOTA.Text = "TOTAL:";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.Lime;
            this.cmdGrabar.Location = new System.Drawing.Point(29, 252);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(69, 23);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "GRABAR";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Silver;
            this.cmdCancelar.Location = new System.Drawing.Point(104, 252);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(76, 23);
            this.cmdCancelar.TabIndex = 11;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(86, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "_______________";
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(199, 314);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.lblTOTA);
            this.Controls.Add(this.mrcGastos);
            this.Controls.Add(this.mrcIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinanzas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.mrcGastos.ResumeLayout(false);
            this.mrcGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lbDeposito;
        private System.Windows.Forms.GroupBox mrcGastos;
        private System.Windows.Forms.TextBox txtVarios;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtimpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblVarios;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblTOTA;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblTotal;
    }
}

