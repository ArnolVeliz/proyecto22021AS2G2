namespace CapaVista
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_idmetodo_METODOPAGO = new System.Windows.Forms.TextBox();
            this.BTN_modificar_METODOPAGO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_nom_METODOPAGO = new System.Windows.Forms.TextBox();
            this.TXT_regresar_METODOPAGO = new System.Windows.Forms.Button();
            this.TXT_agregar_METODOPAGO = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_descripcion_METODOPAGO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Metodos de pago";
            // 
            // TXT_idmetodo_METODOPAGO
            // 
            this.TXT_idmetodo_METODOPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_idmetodo_METODOPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_idmetodo_METODOPAGO.Location = new System.Drawing.Point(182, 69);
            this.TXT_idmetodo_METODOPAGO.Name = "TXT_idmetodo_METODOPAGO";
            this.TXT_idmetodo_METODOPAGO.Size = new System.Drawing.Size(203, 30);
            this.TXT_idmetodo_METODOPAGO.TabIndex = 3;
            // 
            // BTN_modificar_METODOPAGO
            // 
            this.BTN_modificar_METODOPAGO.BackColor = System.Drawing.Color.Gold;
            this.BTN_modificar_METODOPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_modificar_METODOPAGO.ForeColor = System.Drawing.Color.Black;
            this.BTN_modificar_METODOPAGO.Location = new System.Drawing.Point(79, 171);
            this.BTN_modificar_METODOPAGO.Name = "BTN_modificar_METODOPAGO";
            this.BTN_modificar_METODOPAGO.Size = new System.Drawing.Size(118, 48);
            this.BTN_modificar_METODOPAGO.TabIndex = 5;
            this.BTN_modificar_METODOPAGO.Text = "Modificar";
            this.BTN_modificar_METODOPAGO.UseVisualStyleBackColor = false;
            this.BTN_modificar_METODOPAGO.Click += new System.EventHandler(this.BTN_modificar_METODOPAGO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID metodo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del metodo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 12;
            // 
            // TXT_nom_METODOPAGO
            // 
            this.TXT_nom_METODOPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_nom_METODOPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nom_METODOPAGO.Location = new System.Drawing.Point(225, 110);
            this.TXT_nom_METODOPAGO.Name = "TXT_nom_METODOPAGO";
            this.TXT_nom_METODOPAGO.Size = new System.Drawing.Size(161, 30);
            this.TXT_nom_METODOPAGO.TabIndex = 19;
            // 
            // TXT_regresar_METODOPAGO
            // 
            this.TXT_regresar_METODOPAGO.BackColor = System.Drawing.Color.Gold;
            this.TXT_regresar_METODOPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_regresar_METODOPAGO.ForeColor = System.Drawing.Color.Black;
            this.TXT_regresar_METODOPAGO.Location = new System.Drawing.Point(377, 171);
            this.TXT_regresar_METODOPAGO.Name = "TXT_regresar_METODOPAGO";
            this.TXT_regresar_METODOPAGO.Size = new System.Drawing.Size(118, 48);
            this.TXT_regresar_METODOPAGO.TabIndex = 30;
            this.TXT_regresar_METODOPAGO.Text = "Regresar";
            this.TXT_regresar_METODOPAGO.UseVisualStyleBackColor = false;
            this.TXT_regresar_METODOPAGO.Click += new System.EventHandler(this.button3_Click);
            // 
            // TXT_agregar_METODOPAGO
            // 
            this.TXT_agregar_METODOPAGO.BackColor = System.Drawing.Color.Gold;
            this.TXT_agregar_METODOPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_agregar_METODOPAGO.ForeColor = System.Drawing.Color.Black;
            this.TXT_agregar_METODOPAGO.Location = new System.Drawing.Point(224, 171);
            this.TXT_agregar_METODOPAGO.Name = "TXT_agregar_METODOPAGO";
            this.TXT_agregar_METODOPAGO.Size = new System.Drawing.Size(118, 48);
            this.TXT_agregar_METODOPAGO.TabIndex = 31;
            this.TXT_agregar_METODOPAGO.Text = "Agregar";
            this.TXT_agregar_METODOPAGO.UseVisualStyleBackColor = false;
            this.TXT_agregar_METODOPAGO.Click += new System.EventHandler(this.TXT_agregar_METODOPAGO_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(399, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(399, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descripcion";
            // 
            // TXT_descripcion_METODOPAGO
            // 
            this.TXT_descripcion_METODOPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_descripcion_METODOPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_descripcion_METODOPAGO.Location = new System.Drawing.Point(519, 72);
            this.TXT_descripcion_METODOPAGO.Name = "TXT_descripcion_METODOPAGO";
            this.TXT_descripcion_METODOPAGO.Size = new System.Drawing.Size(186, 30);
            this.TXT_descripcion_METODOPAGO.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(406, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(516, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 30);
            this.textBox1.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Metodo,
            this.Nombre,
            this.Descripcion,
            this.Usuario});
            this.dataGridView1.Location = new System.Drawing.Point(25, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 137);
            this.dataGridView1.TabIndex = 37;
            // 
            // Id_Metodo
            // 
            this.Id_Metodo.HeaderText = "Id_Metodo";
            this.Id_Metodo.Name = "Id_Metodo";
            this.Id_Metodo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 47);
            this.button1.TabIndex = 38;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(732, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_descripcion_METODOPAGO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXT_agregar_METODOPAGO);
            this.Controls.Add(this.TXT_regresar_METODOPAGO);
            this.Controls.Add(this.TXT_nom_METODOPAGO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_modificar_METODOPAGO);
            this.Controls.Add(this.TXT_idmetodo_METODOPAGO);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Metodo de pago";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_idmetodo_METODOPAGO;
        private System.Windows.Forms.Button BTN_modificar_METODOPAGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_nom_METODOPAGO;
        private System.Windows.Forms.Button TXT_regresar_METODOPAGO;
        private System.Windows.Forms.Button TXT_agregar_METODOPAGO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_descripcion_METODOPAGO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.Button button1;
    }
}