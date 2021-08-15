namespace CapaVista
{
    partial class Form11
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
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_idCategoria_CATEPELI = new System.Windows.Forms.TextBox();
            this.BTN_modificar_CATEPELI = new System.Windows.Forms.Button();
            this.BTN_agregar_CATEPELI = new System.Windows.Forms.Button();
            this.BTN_regresar_CATEPELI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_nombre_CATEPELI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_des_CATEPELI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categorias de peliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID de categoria";
            // 
            // TXT_idCategoria_CATEPELI
            // 
            this.TXT_idCategoria_CATEPELI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_idCategoria_CATEPELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_idCategoria_CATEPELI.Location = new System.Drawing.Point(196, 76);
            this.TXT_idCategoria_CATEPELI.Name = "TXT_idCategoria_CATEPELI";
            this.TXT_idCategoria_CATEPELI.Size = new System.Drawing.Size(184, 30);
            this.TXT_idCategoria_CATEPELI.TabIndex = 14;
            // 
            // BTN_modificar_CATEPELI
            // 
            this.BTN_modificar_CATEPELI.BackColor = System.Drawing.Color.Gold;
            this.BTN_modificar_CATEPELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_modificar_CATEPELI.ForeColor = System.Drawing.Color.Black;
            this.BTN_modificar_CATEPELI.Location = new System.Drawing.Point(105, 218);
            this.BTN_modificar_CATEPELI.Name = "BTN_modificar_CATEPELI";
            this.BTN_modificar_CATEPELI.Size = new System.Drawing.Size(118, 48);
            this.BTN_modificar_CATEPELI.TabIndex = 35;
            this.BTN_modificar_CATEPELI.Text = "Modificar";
            this.BTN_modificar_CATEPELI.UseVisualStyleBackColor = false;
            this.BTN_modificar_CATEPELI.Click += new System.EventHandler(this.BTN_modificar_CATEPELI_Click);
            // 
            // BTN_agregar_CATEPELI
            // 
            this.BTN_agregar_CATEPELI.BackColor = System.Drawing.Color.Gold;
            this.BTN_agregar_CATEPELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_agregar_CATEPELI.ForeColor = System.Drawing.Color.Black;
            this.BTN_agregar_CATEPELI.Location = new System.Drawing.Point(259, 218);
            this.BTN_agregar_CATEPELI.Name = "BTN_agregar_CATEPELI";
            this.BTN_agregar_CATEPELI.Size = new System.Drawing.Size(118, 48);
            this.BTN_agregar_CATEPELI.TabIndex = 36;
            this.BTN_agregar_CATEPELI.Text = "Agregar";
            this.BTN_agregar_CATEPELI.UseVisualStyleBackColor = false;
            this.BTN_agregar_CATEPELI.Click += new System.EventHandler(this.BTN_agregar_CATEPELI_Click);
            // 
            // BTN_regresar_CATEPELI
            // 
            this.BTN_regresar_CATEPELI.BackColor = System.Drawing.Color.Gold;
            this.BTN_regresar_CATEPELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_regresar_CATEPELI.ForeColor = System.Drawing.Color.Black;
            this.BTN_regresar_CATEPELI.Location = new System.Drawing.Point(409, 218);
            this.BTN_regresar_CATEPELI.Name = "BTN_regresar_CATEPELI";
            this.BTN_regresar_CATEPELI.Size = new System.Drawing.Size(118, 48);
            this.BTN_regresar_CATEPELI.TabIndex = 37;
            this.BTN_regresar_CATEPELI.Text = "Regresar";
            this.BTN_regresar_CATEPELI.UseVisualStyleBackColor = false;
            this.BTN_regresar_CATEPELI.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(54, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nombre";
            // 
            // TXT_nombre_CATEPELI
            // 
            this.TXT_nombre_CATEPELI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_nombre_CATEPELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nombre_CATEPELI.Location = new System.Drawing.Point(171, 119);
            this.TXT_nombre_CATEPELI.Name = "TXT_nombre_CATEPELI";
            this.TXT_nombre_CATEPELI.Size = new System.Drawing.Size(209, 30);
            this.TXT_nombre_CATEPELI.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(405, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Descripción";
            // 
            // TXT_des_CATEPELI
            // 
            this.TXT_des_CATEPELI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_des_CATEPELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_des_CATEPELI.Location = new System.Drawing.Point(525, 76);
            this.TXT_des_CATEPELI.Name = "TXT_des_CATEPELI";
            this.TXT_des_CATEPELI.Size = new System.Drawing.Size(184, 30);
            this.TXT_des_CATEPELI.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(417, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(525, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_categoria,
            this.descripcion,
            this.Nombre,
            this.usuario});
            this.dataGridView1.Location = new System.Drawing.Point(74, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 150);
            this.dataGridView1.TabIndex = 44;
            // 
            // ID_categoria
            // 
            this.ID_categoria.HeaderText = "ID_CATEGORIA";
            this.ID_categoria.Name = "ID_categoria";
            this.ID_categoria.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "NOMBRE";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "DESCRIPCION";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(545, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 48);
            this.button1.TabIndex = 45;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_des_CATEPELI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_nombre_CATEPELI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_regresar_CATEPELI);
            this.Controls.Add(this.BTN_agregar_CATEPELI);
            this.Controls.Add(this.BTN_modificar_CATEPELI);
            this.Controls.Add(this.TXT_idCategoria_CATEPELI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Categoria de peliculas";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_idCategoria_CATEPELI;
        private System.Windows.Forms.Button BTN_modificar_CATEPELI;
        private System.Windows.Forms.Button BTN_agregar_CATEPELI;
        private System.Windows.Forms.Button BTN_regresar_CATEPELI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_nombre_CATEPELI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_des_CATEPELI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}