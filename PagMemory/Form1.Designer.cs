
namespace PagMemory
{
    partial class FSimulador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAgregarP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBTamaño = new System.Windows.Forms.TextBox();
            this.TbProceso1 = new System.Windows.Forms.TextBox();
            this.bFinalizarP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInforma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbEjecucion = new System.Windows.Forms.ListBox();
            this.LbEspera = new System.Windows.Forms.ListBox();
            this.LbFinalizado = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LbEspera2 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dGVMemory = new System.Windows.Forms.DataGridView();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salirbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proceso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamaño";
            // 
            // bAgregarP
            // 
            this.bAgregarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAgregarP.Location = new System.Drawing.Point(19, 126);
            this.bAgregarP.Name = "bAgregarP";
            this.bAgregarP.Size = new System.Drawing.Size(130, 28);
            this.bAgregarP.TabIndex = 6;
            this.bAgregarP.Text = "Agregar Proceso";
            this.bAgregarP.UseVisualStyleBackColor = true;
            this.bAgregarP.Click += new System.EventHandler(this.bAgregarP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tBTamaño);
            this.groupBox1.Controls.Add(this.TbProceso1);
            this.groupBox1.Controls.Add(this.bAgregarP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // tBTamaño
            // 
            this.tBTamaño.Location = new System.Drawing.Point(72, 80);
            this.tBTamaño.Name = "tBTamaño";
            this.tBTamaño.Size = new System.Drawing.Size(85, 22);
            this.tBTamaño.TabIndex = 8;
            // 
            // TbProceso1
            // 
            this.TbProceso1.Location = new System.Drawing.Point(72, 24);
            this.TbProceso1.Name = "TbProceso1";
            this.TbProceso1.Size = new System.Drawing.Size(85, 22);
            this.TbProceso1.TabIndex = 7;
            // 
            // bFinalizarP
            // 
            this.bFinalizarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFinalizarP.Location = new System.Drawing.Point(17, 126);
            this.bFinalizarP.Name = "bFinalizarP";
            this.bFinalizarP.Size = new System.Drawing.Size(130, 28);
            this.bFinalizarP.TabIndex = 8;
            this.bFinalizarP.Text = "Finalizar Proceso";
            this.bFinalizarP.UseVisualStyleBackColor = true;
            this.bFinalizarP.Click += new System.EventHandler(this.bFinalizarP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInforma);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bFinalizarP);
            this.groupBox2.Location = new System.Drawing.Point(216, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 165);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminar";
            // 
            // lblInforma
            // 
            this.lblInforma.AutoSize = true;
            this.lblInforma.Location = new System.Drawing.Point(74, 80);
            this.lblInforma.Name = "lblInforma";
            this.lblInforma.Size = new System.Drawing.Size(12, 17);
            this.lblInforma.TabIndex = 10;
            this.lblInforma.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proceso a finalizar...";
            // 
            // LbEjecucion
            // 
            this.LbEjecucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbEjecucion.FormattingEnabled = true;
            this.LbEjecucion.ItemHeight = 16;
            this.LbEjecucion.Location = new System.Drawing.Point(16, 47);
            this.LbEjecucion.Name = "LbEjecucion";
            this.LbEjecucion.Size = new System.Drawing.Size(90, 308);
            this.LbEjecucion.TabIndex = 11;
            this.LbEjecucion.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LbEspera
            // 
            this.LbEspera.FormattingEnabled = true;
            this.LbEspera.ItemHeight = 16;
            this.LbEspera.Location = new System.Drawing.Point(125, 47);
            this.LbEspera.Name = "LbEspera";
            this.LbEspera.Size = new System.Drawing.Size(41, 308);
            this.LbEspera.TabIndex = 12;
            // 
            // LbFinalizado
            // 
            this.LbFinalizado.FormattingEnabled = true;
            this.LbFinalizado.ItemHeight = 16;
            this.LbFinalizado.Location = new System.Drawing.Point(234, 47);
            this.LbFinalizado.Name = "LbFinalizado";
            this.LbFinalizado.Size = new System.Drawing.Size(89, 308);
            this.LbFinalizado.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "En espera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Finalizado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "En ejecución";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LbEspera2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.LbFinalizado);
            this.groupBox3.Controls.Add(this.LbEspera);
            this.groupBox3.Controls.Add(this.LbEjecucion);
            this.groupBox3.Location = new System.Drawing.Point(21, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 374);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información";
            // 
            // LbEspera2
            // 
            this.LbEspera2.FormattingEnabled = true;
            this.LbEspera2.ItemHeight = 16;
            this.LbEspera2.Location = new System.Drawing.Point(165, 47);
            this.LbEspera2.Name = "LbEspera2";
            this.LbEspera2.Size = new System.Drawing.Size(41, 308);
            this.LbEspera2.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dGVMemory);
            this.groupBox4.Location = new System.Drawing.Point(395, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 694);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Memoria";
            // 
            // dGVMemory
            // 
            this.dGVMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proceso,
            this.Tamaño});
            this.dGVMemory.Location = new System.Drawing.Point(20, 40);
            this.dGVMemory.Name = "dGVMemory";
            this.dGVMemory.RowHeadersWidth = 51;
            this.dGVMemory.RowTemplate.Height = 24;
            this.dGVMemory.Size = new System.Drawing.Size(326, 632);
            this.dGVMemory.TabIndex = 0;
            this.dGVMemory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMemory_CellClick);
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Nombre del Proceso";
            this.Proceso.MinimumWidth = 6;
            this.Proceso.Name = "Proceso";
            this.Proceso.Width = 125;
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño Proceso";
            this.Tamaño.MinimumWidth = 6;
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Width = 125;
            // 
            // salirbutton
            // 
            this.salirbutton.Location = new System.Drawing.Point(126, 639);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(112, 34);
            this.salirbutton.TabIndex = 21;
            this.salirbutton.Text = "Salir";
            this.salirbutton.UseVisualStyleBackColor = true;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // FSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 730);
            this.Controls.Add(this.salirbutton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FSimulador";
            this.Text = "Simulador: Paginación de Memoria";
            this.Load += new System.EventHandler(this.FSimulador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMemory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAgregarP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bFinalizarP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LbEjecucion;
        private System.Windows.Forms.ListBox LbEspera;
        private System.Windows.Forms.ListBox LbFinalizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBTamaño;
        private System.Windows.Forms.TextBox TbProceso1;
        private System.Windows.Forms.DataGridView dGVMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.Label lblInforma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbEspera2;
        private System.Windows.Forms.Button salirbutton;
    }
}

