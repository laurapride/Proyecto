
namespace EstacionamientoSistema.modulos
{
    partial class Usuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjButton1 = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.rjTextBox24 = new EstacionamientoSistema.controlesPersonalizados.RJTextBox2();
            this.rjTextBox23 = new EstacionamientoSistema.controlesPersonalizados.RJTextBox2();
            this.rjTextBox21 = new EstacionamientoSistema.controlesPersonalizados.RJTextBox2();
            this.rjTextBox22 = new EstacionamientoSistema.controlesPersonalizados.RJTextBox2();
            this.rjButton2 = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.rjButton3 = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Usuarios";
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaUsuarios.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.tablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.correo,
            this.telefono,
            this.tarjeta});
            this.tablaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaUsuarios.Location = new System.Drawing.Point(321, 110);
            this.tablaUsuarios.MultiSelect = false;
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUsuarios.Size = new System.Drawing.Size(506, 230);
            this.tablaUsuarios.TabIndex = 7;
            this.tablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // tarjeta
            // 
            this.tarjeta.HeaderText = "Tarjeta";
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.ReadOnly = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(29, 370);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(250, 40);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Registrar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjTextBox24
            // 
            this.rjTextBox24.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox24.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBox24.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox24.BorderRadius = 13;
            this.rjTextBox24.BorderSize = 1;
            this.rjTextBox24.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rjTextBox24.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox24.Location = new System.Drawing.Point(29, 308);
            this.rjTextBox24.Multiline = false;
            this.rjTextBox24.Name = "rjTextBox24";
            this.rjTextBox24.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox24.PasswordChar = false;
            this.rjTextBox24.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox24.PlaceholderText = "xxxx-xxxx-xxxx-xxxx";
            this.rjTextBox24.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox24.TabIndex = 5;
            this.rjTextBox24.Texts = "";
            this.rjTextBox24.UnderlinedStyle = false;
            // 
            // rjTextBox23
            // 
            this.rjTextBox23.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox23.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBox23.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox23.BorderRadius = 13;
            this.rjTextBox23.BorderSize = 1;
            this.rjTextBox23.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rjTextBox23.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox23.Location = new System.Drawing.Point(29, 243);
            this.rjTextBox23.Multiline = false;
            this.rjTextBox23.Name = "rjTextBox23";
            this.rjTextBox23.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox23.PasswordChar = false;
            this.rjTextBox23.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox23.PlaceholderText = "833-398-4895";
            this.rjTextBox23.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox23.TabIndex = 4;
            this.rjTextBox23.Texts = "";
            this.rjTextBox23.UnderlinedStyle = false;
            // 
            // rjTextBox21
            // 
            this.rjTextBox21.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox21.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBox21.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox21.BorderRadius = 13;
            this.rjTextBox21.BorderSize = 1;
            this.rjTextBox21.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rjTextBox21.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox21.Location = new System.Drawing.Point(29, 110);
            this.rjTextBox21.Multiline = false;
            this.rjTextBox21.Name = "rjTextBox21";
            this.rjTextBox21.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox21.PasswordChar = false;
            this.rjTextBox21.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox21.PlaceholderText = "Pedro";
            this.rjTextBox21.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox21.TabIndex = 3;
            this.rjTextBox21.Texts = "";
            this.rjTextBox21.UnderlinedStyle = false;
            // 
            // rjTextBox22
            // 
            this.rjTextBox22.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox22.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBox22.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox22.BorderRadius = 13;
            this.rjTextBox22.BorderSize = 1;
            this.rjTextBox22.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rjTextBox22.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox22.Location = new System.Drawing.Point(29, 177);
            this.rjTextBox22.Multiline = false;
            this.rjTextBox22.Name = "rjTextBox22";
            this.rjTextBox22.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox22.PasswordChar = false;
            this.rjTextBox22.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox22.PlaceholderText = "ejemplo@correo.com";
            this.rjTextBox22.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox22.TabIndex = 2;
            this.rjTextBox22.Texts = "";
            this.rjTextBox22.UnderlinedStyle = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.SlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(321, 370);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(176, 39);
            this.rjButton2.TabIndex = 8;
            this.rjButton2.Text = "Modificar";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.Firebrick;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Firebrick;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(651, 371);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(176, 39);
            this.rjButton3.TabIndex = 9;
            this.rjButton3.Text = "Eliminar";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tarjeta";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjTextBox24);
            this.Controls.Add(this.rjTextBox23);
            this.Controls.Add(this.rjTextBox21);
            this.Controls.Add(this.rjTextBox22);
            this.Controls.Add(this.label1);
            this.Name = "Usuario";
            this.Size = new System.Drawing.Size(860, 437);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private controlesPersonalizados.RJTextBox2 rjTextBox22;
        private controlesPersonalizados.RJTextBox2 rjTextBox21;
        private controlesPersonalizados.RJTextBox2 rjTextBox23;
        private controlesPersonalizados.RJTextBox2 rjTextBox24;
        private controlesPersonalizados.RJButton rjButton1;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjeta;
        private controlesPersonalizados.RJButton rjButton2;
        private controlesPersonalizados.RJButton rjButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
