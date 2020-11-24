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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dtgPedidos.AllowUserToResizeColumns = false;
            this.dtgPedidos.AllowUserToResizeRows = false;
            this.dtgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPedidos.EnableHeadersVisualStyles = false;
            this.dtgPedidos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgPedidos.Location = new System.Drawing.Point(26, 31);
            this.dtgPedidos.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtgPedidos.MultiSelect = false;
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.ReadOnly = true;
            this.dtgPedidos.RowHeadersVisible = false;
            this.dtgPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgPedidos.Size = new System.Drawing.Size(442, 339);
            this.dtgPedidos.TabIndex = 0;
            // 
            // dtgTerminados
            // 
            this.dtgTerminados.AllowUserToAddRows = false;
            this.dtgTerminados.AllowUserToDeleteRows = false;
            this.dtgTerminados.AllowUserToResizeColumns = false;
            this.dtgTerminados.AllowUserToResizeRows = false;
            this.dtgTerminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTerminados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTerminados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTerminados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgTerminados.EnableHeadersVisualStyles = false;
            this.dtgTerminados.Location = new System.Drawing.Point(512, 31);
            this.dtgTerminados.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtgTerminados.Name = "dtgTerminados";
            this.dtgTerminados.ReadOnly = true;
            this.dtgTerminados.RowHeadersVisible = false;
            this.dtgTerminados.Size = new System.Drawing.Size(442, 339);
            this.dtgTerminados.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(26, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 44);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPedidoListo
            // 
            this.lblPedidoListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoListo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPedidoListo.Location = new System.Drawing.Point(-1, 386);
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
            this.BackColor = System.Drawing.SystemColors.WindowText;
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

