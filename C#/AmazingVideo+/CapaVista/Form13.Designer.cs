namespace CapaVista
{
    partial class Form13
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.id_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nit_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nit_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_MetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Factura,
            this.No_Factura,
            this.Nit_Empresa,
            this.No_Serie,
            this.Fecha_Emision,
            this.Contribuyente,
            this.Nombre_Cliente,
            this.Direccion,
            this.Nit_Cliente,
            this.Id_Registro,
            this.Id_MetodoPago,
            this.Usuario});
            this.dataGridView1.Location = new System.Drawing.Point(42, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(615, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regreso a Videos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_Factura
            // 
            this.id_Factura.HeaderText = "id_Factura";
            this.id_Factura.Name = "id_Factura";
            this.id_Factura.ReadOnly = true;
            // 
            // No_Factura
            // 
            this.No_Factura.HeaderText = "No_Factura";
            this.No_Factura.Name = "No_Factura";
            this.No_Factura.ReadOnly = true;
            // 
            // Nit_Empresa
            // 
            this.Nit_Empresa.HeaderText = "Nit_Empresa";
            this.Nit_Empresa.Name = "Nit_Empresa";
            this.Nit_Empresa.ReadOnly = true;
            // 
            // No_Serie
            // 
            this.No_Serie.HeaderText = "No_Serie";
            this.No_Serie.Name = "No_Serie";
            this.No_Serie.ReadOnly = true;
            // 
            // Fecha_Emision
            // 
            this.Fecha_Emision.HeaderText = "Fecha_Emision";
            this.Fecha_Emision.Name = "Fecha_Emision";
            this.Fecha_Emision.ReadOnly = true;
            // 
            // Contribuyente
            // 
            this.Contribuyente.HeaderText = "Contribuyente";
            this.Contribuyente.Name = "Contribuyente";
            this.Contribuyente.ReadOnly = true;
            // 
            // Nombre_Cliente
            // 
            this.Nombre_Cliente.HeaderText = "Nombre_Cliente";
            this.Nombre_Cliente.Name = "Nombre_Cliente";
            this.Nombre_Cliente.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Nit_Cliente
            // 
            this.Nit_Cliente.HeaderText = "Nit_Cliente";
            this.Nit_Cliente.Name = "Nit_Cliente";
            this.Nit_Cliente.ReadOnly = true;
            // 
            // Id_Registro
            // 
            this.Id_Registro.HeaderText = "Id_Registro";
            this.Id_Registro.Name = "Id_Registro";
            this.Id_Registro.ReadOnly = true;
            // 
            // Id_MetodoPago
            // 
            this.Id_MetodoPago.HeaderText = "Id_MetodoPago";
            this.Id_MetodoPago.Name = "Id_MetodoPago";
            this.Id_MetodoPago.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1356, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form13";
            this.Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nit_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Emision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nit_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}