
namespace WindowsFormsApp1
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_idTipoUsuario_TIPOUSUARIO = new System.Windows.Forms.TextBox();
            this.BTN_modificar_TIPOUSUARIO = new System.Windows.Forms.Button();
            this.TXT_agregar_TIPOUSUARIO = new System.Windows.Forms.Button();
            this.TXT_regresar_TIPOUSUARIO = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_nom_TIPOUSUARIO = new System.Windows.Forms.TextBox();
            this.txt_descripcion_TIPOUSUARIO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipos de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID de usuario";
            // 
            // TXT_idTipoUsuario_TIPOUSUARIO
            // 
            this.TXT_idTipoUsuario_TIPOUSUARIO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_idTipoUsuario_TIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_idTipoUsuario_TIPOUSUARIO.Location = new System.Drawing.Point(188, 71);
            this.TXT_idTipoUsuario_TIPOUSUARIO.Name = "TXT_idTipoUsuario_TIPOUSUARIO";
            this.TXT_idTipoUsuario_TIPOUSUARIO.Size = new System.Drawing.Size(184, 30);
            this.TXT_idTipoUsuario_TIPOUSUARIO.TabIndex = 15;
            // 
            // BTN_modificar_TIPOUSUARIO
            // 
            this.BTN_modificar_TIPOUSUARIO.BackColor = System.Drawing.Color.Gold;
            this.BTN_modificar_TIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_modificar_TIPOUSUARIO.ForeColor = System.Drawing.Color.Black;
            this.BTN_modificar_TIPOUSUARIO.Location = new System.Drawing.Point(179, 213);
            this.BTN_modificar_TIPOUSUARIO.Name = "BTN_modificar_TIPOUSUARIO";
            this.BTN_modificar_TIPOUSUARIO.Size = new System.Drawing.Size(118, 48);
            this.BTN_modificar_TIPOUSUARIO.TabIndex = 36;
            this.BTN_modificar_TIPOUSUARIO.Text = "Modificar";
            this.BTN_modificar_TIPOUSUARIO.UseVisualStyleBackColor = false;
            // 
            // TXT_agregar_TIPOUSUARIO
            // 
            this.TXT_agregar_TIPOUSUARIO.BackColor = System.Drawing.Color.Gold;
            this.TXT_agregar_TIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_agregar_TIPOUSUARIO.ForeColor = System.Drawing.Color.Black;
            this.TXT_agregar_TIPOUSUARIO.Location = new System.Drawing.Point(338, 213);
            this.TXT_agregar_TIPOUSUARIO.Name = "TXT_agregar_TIPOUSUARIO";
            this.TXT_agregar_TIPOUSUARIO.Size = new System.Drawing.Size(118, 48);
            this.TXT_agregar_TIPOUSUARIO.TabIndex = 37;
            this.TXT_agregar_TIPOUSUARIO.Text = "Agregar";
            this.TXT_agregar_TIPOUSUARIO.UseVisualStyleBackColor = false;
            // 
            // TXT_regresar_TIPOUSUARIO
            // 
            this.TXT_regresar_TIPOUSUARIO.BackColor = System.Drawing.Color.Gold;
            this.TXT_regresar_TIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_regresar_TIPOUSUARIO.ForeColor = System.Drawing.Color.Black;
            this.TXT_regresar_TIPOUSUARIO.Location = new System.Drawing.Point(500, 213);
            this.TXT_regresar_TIPOUSUARIO.Name = "TXT_regresar_TIPOUSUARIO";
            this.TXT_regresar_TIPOUSUARIO.Size = new System.Drawing.Size(118, 48);
            this.TXT_regresar_TIPOUSUARIO.TabIndex = 38;
            this.TXT_regresar_TIPOUSUARIO.Text = "Regresar";
            this.TXT_regresar_TIPOUSUARIO.UseVisualStyleBackColor = false;
            this.TXT_regresar_TIPOUSUARIO.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(55, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(398, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Descripción";
            // 
            // TXT_nom_TIPOUSUARIO
            // 
            this.TXT_nom_TIPOUSUARIO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_nom_TIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nom_TIPOUSUARIO.Location = new System.Drawing.Point(170, 115);
            this.TXT_nom_TIPOUSUARIO.Name = "TXT_nom_TIPOUSUARIO";
            this.TXT_nom_TIPOUSUARIO.Size = new System.Drawing.Size(202, 30);
            this.TXT_nom_TIPOUSUARIO.TabIndex = 41;
            // 
            // txt_descripcion_TIPOUSUARIO
            // 
            this.txt_descripcion_TIPOUSUARIO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_descripcion_TIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_TIPOUSUARIO.Location = new System.Drawing.Point(518, 73);
            this.txt_descripcion_TIPOUSUARIO.Name = "txt_descripcion_TIPOUSUARIO";
            this.txt_descripcion_TIPOUSUARIO.Size = new System.Drawing.Size(184, 30);
            this.txt_descripcion_TIPOUSUARIO.TabIndex = 42;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_descripcion_TIPOUSUARIO);
            this.Controls.Add(this.TXT_nom_TIPOUSUARIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_regresar_TIPOUSUARIO);
            this.Controls.Add(this.TXT_agregar_TIPOUSUARIO);
            this.Controls.Add(this.BTN_modificar_TIPOUSUARIO);
            this.Controls.Add(this.TXT_idTipoUsuario_TIPOUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "Tipo de usuario";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_idTipoUsuario_TIPOUSUARIO;
        private System.Windows.Forms.Button BTN_modificar_TIPOUSUARIO;
        private System.Windows.Forms.Button TXT_agregar_TIPOUSUARIO;
        private System.Windows.Forms.Button TXT_regresar_TIPOUSUARIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_nom_TIPOUSUARIO;
        private System.Windows.Forms.TextBox txt_descripcion_TIPOUSUARIO;
    }
}