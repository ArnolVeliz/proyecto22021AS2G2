namespace CapaVista
{
    partial class Form7
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_idRegistro_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.TXT_alquiler_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.TXT_pagototal_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.TXT_abono_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.TXT_vuelto_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_numeroTarjeta_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.TXT_fechaExp_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.TXT_titular_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.TXT_efectivo_REGISTROPAGO = new System.Windows.Forms.TextBox();
            this.BTN_modificar_REGISTROPAGO = new System.Windows.Forms.Button();
            this.BTN_agregar_REGISTROPAGO = new System.Windows.Forms.Button();
            this.BTN_regresar_REGISTROPAGO = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Id_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(95, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID de registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(95, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID de Metodo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(95, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pago total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(95, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Abono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(95, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vuelto";
            // 
            // TXT_idRegistro_REGISTROPAGO
            // 
            this.TXT_idRegistro_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_idRegistro_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_idRegistro_REGISTROPAGO.Location = new System.Drawing.Point(226, 110);
            this.TXT_idRegistro_REGISTROPAGO.Name = "TXT_idRegistro_REGISTROPAGO";
            this.TXT_idRegistro_REGISTROPAGO.Size = new System.Drawing.Size(184, 30);
            this.TXT_idRegistro_REGISTROPAGO.TabIndex = 14;
            // 
            // TXT_alquiler_REGISTROPAGO
            // 
            this.TXT_alquiler_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_alquiler_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_alquiler_REGISTROPAGO.Location = new System.Drawing.Point(226, 149);
            this.TXT_alquiler_REGISTROPAGO.Name = "TXT_alquiler_REGISTROPAGO";
            this.TXT_alquiler_REGISTROPAGO.Size = new System.Drawing.Size(184, 30);
            this.TXT_alquiler_REGISTROPAGO.TabIndex = 15;
            // 
            // TXT_pagototal_REGISTROPAGO
            // 
            this.TXT_pagototal_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_pagototal_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_pagototal_REGISTROPAGO.Location = new System.Drawing.Point(226, 189);
            this.TXT_pagototal_REGISTROPAGO.Name = "TXT_pagototal_REGISTROPAGO";
            this.TXT_pagototal_REGISTROPAGO.Size = new System.Drawing.Size(184, 30);
            this.TXT_pagototal_REGISTROPAGO.TabIndex = 16;
            // 
            // TXT_abono_REGISTROPAGO
            // 
            this.TXT_abono_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_abono_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_abono_REGISTROPAGO.Location = new System.Drawing.Point(226, 231);
            this.TXT_abono_REGISTROPAGO.Name = "TXT_abono_REGISTROPAGO";
            this.TXT_abono_REGISTROPAGO.Size = new System.Drawing.Size(184, 30);
            this.TXT_abono_REGISTROPAGO.TabIndex = 17;
            // 
            // TXT_vuelto_REGISTROPAGO
            // 
            this.TXT_vuelto_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_vuelto_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_vuelto_REGISTROPAGO.Location = new System.Drawing.Point(226, 274);
            this.TXT_vuelto_REGISTROPAGO.Name = "TXT_vuelto_REGISTROPAGO";
            this.TXT_vuelto_REGISTROPAGO.Size = new System.Drawing.Size(184, 30);
            this.TXT_vuelto_REGISTROPAGO.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(435, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Número de tarjetas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(435, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha de expiración";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(435, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Titular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(435, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Efectivo";
            // 
            // TXT_numeroTarjeta_REGISTROPAGO
            // 
            this.TXT_numeroTarjeta_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_numeroTarjeta_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_numeroTarjeta_REGISTROPAGO.Location = new System.Drawing.Point(617, 59);
            this.TXT_numeroTarjeta_REGISTROPAGO.Name = "TXT_numeroTarjeta_REGISTROPAGO";
            this.TXT_numeroTarjeta_REGISTROPAGO.Size = new System.Drawing.Size(170, 30);
            this.TXT_numeroTarjeta_REGISTROPAGO.TabIndex = 23;
            // 
            // TXT_fechaExp_REGISTROPAGO
            // 
            this.TXT_fechaExp_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_fechaExp_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_fechaExp_REGISTROPAGO.Location = new System.Drawing.Point(617, 98);
            this.TXT_fechaExp_REGISTROPAGO.Name = "TXT_fechaExp_REGISTROPAGO";
            this.TXT_fechaExp_REGISTROPAGO.Size = new System.Drawing.Size(170, 30);
            this.TXT_fechaExp_REGISTROPAGO.TabIndex = 24;
            // 
            // TXT_titular_REGISTROPAGO
            // 
            this.TXT_titular_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_titular_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_titular_REGISTROPAGO.Location = new System.Drawing.Point(527, 141);
            this.TXT_titular_REGISTROPAGO.Name = "TXT_titular_REGISTROPAGO";
            this.TXT_titular_REGISTROPAGO.Size = new System.Drawing.Size(184, 30);
            this.TXT_titular_REGISTROPAGO.TabIndex = 25;
            // 
            // TXT_efectivo_REGISTROPAGO
            // 
            this.TXT_efectivo_REGISTROPAGO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_efectivo_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_efectivo_REGISTROPAGO.Location = new System.Drawing.Point(527, 180);
            this.TXT_efectivo_REGISTROPAGO.Name = "TXT_efectivo_REGISTROPAGO";
            this.TXT_efectivo_REGISTROPAGO.Size = new System.Drawing.Size(184, 30);
            this.TXT_efectivo_REGISTROPAGO.TabIndex = 26;
            // 
            // BTN_modificar_REGISTROPAGO
            // 
            this.BTN_modificar_REGISTROPAGO.BackColor = System.Drawing.Color.Gold;
            this.BTN_modificar_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_modificar_REGISTROPAGO.ForeColor = System.Drawing.Color.Black;
            this.BTN_modificar_REGISTROPAGO.Location = new System.Drawing.Point(172, 335);
            this.BTN_modificar_REGISTROPAGO.Name = "BTN_modificar_REGISTROPAGO";
            this.BTN_modificar_REGISTROPAGO.Size = new System.Drawing.Size(118, 48);
            this.BTN_modificar_REGISTROPAGO.TabIndex = 27;
            this.BTN_modificar_REGISTROPAGO.Text = "Modificar";
            this.BTN_modificar_REGISTROPAGO.UseVisualStyleBackColor = false;
            this.BTN_modificar_REGISTROPAGO.Click += new System.EventHandler(this.BTN_modificar_REGISTROPAGO_Click);
            // 
            // BTN_agregar_REGISTROPAGO
            // 
            this.BTN_agregar_REGISTROPAGO.BackColor = System.Drawing.Color.Gold;
            this.BTN_agregar_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_agregar_REGISTROPAGO.ForeColor = System.Drawing.Color.Black;
            this.BTN_agregar_REGISTROPAGO.Location = new System.Drawing.Point(322, 335);
            this.BTN_agregar_REGISTROPAGO.Name = "BTN_agregar_REGISTROPAGO";
            this.BTN_agregar_REGISTROPAGO.Size = new System.Drawing.Size(118, 48);
            this.BTN_agregar_REGISTROPAGO.TabIndex = 32;
            this.BTN_agregar_REGISTROPAGO.Text = "Agregar";
            this.BTN_agregar_REGISTROPAGO.UseVisualStyleBackColor = false;
            this.BTN_agregar_REGISTROPAGO.Click += new System.EventHandler(this.BTN_agregar_REGISTROPAGO_Click);
            // 
            // BTN_regresar_REGISTROPAGO
            // 
            this.BTN_regresar_REGISTROPAGO.BackColor = System.Drawing.Color.Gold;
            this.BTN_regresar_REGISTROPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_regresar_REGISTROPAGO.ForeColor = System.Drawing.Color.Black;
            this.BTN_regresar_REGISTROPAGO.Location = new System.Drawing.Point(472, 335);
            this.BTN_regresar_REGISTROPAGO.Name = "BTN_regresar_REGISTROPAGO";
            this.BTN_regresar_REGISTROPAGO.Size = new System.Drawing.Size(118, 48);
            this.BTN_regresar_REGISTROPAGO.TabIndex = 33;
            this.BTN_regresar_REGISTROPAGO.Text = "Regresar";
            this.BTN_regresar_REGISTROPAGO.UseVisualStyleBackColor = false;
            this.BTN_regresar_REGISTROPAGO.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(95, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "ID Reg";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(226, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 30);
            this.textBox1.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(437, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "ID de Factura";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(581, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 30);
            this.textBox2.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(437, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Usuario";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(552, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 30);
            this.textBox3.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_reg,
            this.Id_Registro,
            this.Id_Metodo,
            this.Total_Pago,
            this.Abono,
            this.Vuelto,
            this.Num_TC,
            this.Fecha_Exp,
            this.Titular,
            this.Efectivo,
            this.Id_Factura,
            this.Usuario});
            this.dataGridView1.Location = new System.Drawing.Point(22, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(906, 193);
            this.dataGridView1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 41;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id_reg
            // 
            this.Id_reg.HeaderText = "Id_reg";
            this.Id_reg.Name = "Id_reg";
            this.Id_reg.ReadOnly = true;
            // 
            // Id_Registro
            // 
            this.Id_Registro.HeaderText = "Id_Registro";
            this.Id_Registro.Name = "Id_Registro";
            this.Id_Registro.ReadOnly = true;
            // 
            // Id_Metodo
            // 
            this.Id_Metodo.HeaderText = "Id_Metodo";
            this.Id_Metodo.Name = "Id_Metodo";
            this.Id_Metodo.ReadOnly = true;
            // 
            // Total_Pago
            // 
            this.Total_Pago.HeaderText = "Total_Pago";
            this.Total_Pago.Name = "Total_Pago";
            this.Total_Pago.ReadOnly = true;
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.Name = "Abono";
            this.Abono.ReadOnly = true;
            // 
            // Vuelto
            // 
            this.Vuelto.HeaderText = "Vuelto";
            this.Vuelto.Name = "Vuelto";
            this.Vuelto.ReadOnly = true;
            // 
            // Num_TC
            // 
            this.Num_TC.HeaderText = "Num_TC";
            this.Num_TC.Name = "Num_TC";
            this.Num_TC.ReadOnly = true;
            // 
            // Fecha_Exp
            // 
            this.Fecha_Exp.HeaderText = "Fecha_Exp";
            this.Fecha_Exp.Name = "Fecha_Exp";
            this.Fecha_Exp.ReadOnly = true;
            // 
            // Titular
            // 
            this.Titular.HeaderText = "Titular";
            this.Titular.Name = "Titular";
            this.Titular.ReadOnly = true;
            // 
            // Efectivo
            // 
            this.Efectivo.HeaderText = "Efectivo";
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.ReadOnly = true;
            // 
            // Id_Factura
            // 
            this.Id_Factura.HeaderText = "Id_Factura";
            this.Id_Factura.Name = "Id_Factura";
            this.Id_Factura.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(974, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BTN_regresar_REGISTROPAGO);
            this.Controls.Add(this.BTN_agregar_REGISTROPAGO);
            this.Controls.Add(this.BTN_modificar_REGISTROPAGO);
            this.Controls.Add(this.TXT_efectivo_REGISTROPAGO);
            this.Controls.Add(this.TXT_titular_REGISTROPAGO);
            this.Controls.Add(this.TXT_fechaExp_REGISTROPAGO);
            this.Controls.Add(this.TXT_numeroTarjeta_REGISTROPAGO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXT_vuelto_REGISTROPAGO);
            this.Controls.Add(this.TXT_abono_REGISTROPAGO);
            this.Controls.Add(this.TXT_pagototal_REGISTROPAGO);
            this.Controls.Add(this.TXT_alquiler_REGISTROPAGO);
            this.Controls.Add(this.TXT_idRegistro_REGISTROPAGO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Registro de pagos";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_idRegistro_REGISTROPAGO;
        private System.Windows.Forms.TextBox TXT_alquiler_REGISTROPAGO;
        private System.Windows.Forms.TextBox TXT_pagototal_REGISTROPAGO;
        private System.Windows.Forms.TextBox TXT_abono_REGISTROPAGO;
        private System.Windows.Forms.TextBox TXT_vuelto_REGISTROPAGO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_numeroTarjeta_REGISTROPAGO;
        private System.Windows.Forms.TextBox TXT_fechaExp_REGISTROPAGO;
        private System.Windows.Forms.TextBox TXT_titular_REGISTROPAGO;
        private System.Windows.Forms.TextBox TXT_efectivo_REGISTROPAGO;
        private System.Windows.Forms.Button BTN_modificar_REGISTROPAGO;
        private System.Windows.Forms.Button BTN_agregar_REGISTROPAGO;
        private System.Windows.Forms.Button BTN_regresar_REGISTROPAGO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}