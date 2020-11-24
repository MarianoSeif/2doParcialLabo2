namespace Seif.Mariano._2doParcial_Labo2
{
    partial class FormCartelera
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
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.dtgTerminados = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPedidoListo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTerminados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.AllowUserToAddRows = false;
            this.dtgPedidos.AllowUserToDeleteRows = false;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(26, 31);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.ReadOnly = true;
            this.dtgPedidos.RowHeadersVisible = false;
            this.dtgPedidos.Size = new System.Drawing.Size(442, 339);
            this.dtgPedidos.TabIndex = 0;
            // 
            // dtgTerminados
            // 
            this.dtgTerminados.AllowUserToAddRows = false;
            this.dtgTerminados.AllowUserToDeleteRows = false;
            this.dtgTerminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTerminados.Location = new System.Drawing.Point(512, 31);
            this.dtgTerminados.Name = "dtgTerminados";
            this.dtgTerminados.ReadOnly = true;
            this.dtgTerminados.RowHeadersVisible = false;
            this.dtgTerminados.Size = new System.Drawing.Size(442, 339);
            this.dtgTerminados.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(26, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 44);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPedidoListo
            // 
            this.lblPedidoListo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPedidoListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoListo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPedidoListo.Location = new System.Drawing.Point(0, 444);
            this.lblPedidoListo.Name = "lblPedidoListo";
            this.lblPedidoListo.Size = new System.Drawing.Size(984, 38);
            this.lblPedidoListo.TabIndex = 5;
            this.lblPedidoListo.Text = "label1";
            this.lblPedidoListo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 482);
            this.Controls.Add(this.lblPedidoListo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgTerminados);
            this.Controls.Add(this.dtgPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCartelera";
            this.Text = "2do Parcial Labo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCartelera_FormClosing);
            this.Load += new System.EventHandler(this.FormCartelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTerminados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.DataGridView dtgTerminados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPedidoListo;
    }
}

