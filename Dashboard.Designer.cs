
namespace EstacionamientoSistema
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_fecha = new System.Windows.Forms.Label();
            this.btn_cerrarSesion = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_usuario = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.btn_registro = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.btn_salida = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.btn_entrada = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.btn_dashboard = new EstacionamientoSistema.controlesPersonalizados.RJButton();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarSesion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.btn_cerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 50);
            this.panel1.TabIndex = 0;
            // 
            // txt_fecha
            // 
            this.txt_fecha.AutoSize = true;
            this.txt_fecha.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.ForeColor = System.Drawing.Color.White;
            this.txt_fecha.Location = new System.Drawing.Point(13, 13);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(175, 30);
            this.txt_fecha.TabIndex = 2;
            this.txt_fecha.Text = "Estacionamiento";
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarSesion.Image = global::EstacionamientoSistema.Properties.Resources.logout;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(983, 2);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(38, 45);
            this.btn_cerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrarSesion.TabIndex = 1;
            this.btn_cerrarSesion.TabStop = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btn_usuario);
            this.panel2.Controls.Add(this.btn_registro);
            this.panel2.Controls.Add(this.btn_salida);
            this.panel2.Controls.Add(this.btn_entrada);
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 437);
            this.panel2.TabIndex = 1;
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_usuario.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_usuario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_usuario.BorderRadius = 0;
            this.btn_usuario.BorderSize = 0;
            this.btn_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuario.FlatAppearance.BorderSize = 0;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_usuario.Image = global::EstacionamientoSistema.Properties.Resources.usuariosIcono;
            this.btn_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuario.Location = new System.Drawing.Point(0, 224);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(173, 56);
            this.btn_usuario.TabIndex = 9;
            this.btn_usuario.Tag = "5";
            this.btn_usuario.Text = "Usuarios";
            this.btn_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_usuario.TextColor = System.Drawing.Color.White;
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.botonesMenu_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_registro.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_registro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_registro.BorderRadius = 0;
            this.btn_registro.BorderSize = 0;
            this.btn_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registro.FlatAppearance.BorderSize = 0;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.ForeColor = System.Drawing.Color.White;
            this.btn_registro.Image = global::EstacionamientoSistema.Properties.Resources.registrosIcono;
            this.btn_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registro.Location = new System.Drawing.Point(0, 168);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(173, 56);
            this.btn_registro.TabIndex = 8;
            this.btn_registro.Tag = "4";
            this.btn_registro.Text = "Registro";
            this.btn_registro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registro.TextColor = System.Drawing.Color.White;
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.botonesMenu_Click);
            // 
            // btn_salida
            // 
            this.btn_salida.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_salida.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_salida.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_salida.BorderRadius = 0;
            this.btn_salida.BorderSize = 0;
            this.btn_salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_salida.FlatAppearance.BorderSize = 0;
            this.btn_salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salida.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salida.ForeColor = System.Drawing.Color.White;
            this.btn_salida.Image = global::EstacionamientoSistema.Properties.Resources.salidaIcono;
            this.btn_salida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salida.Location = new System.Drawing.Point(0, 112);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Size = new System.Drawing.Size(173, 56);
            this.btn_salida.TabIndex = 7;
            this.btn_salida.Tag = "3";
            this.btn_salida.Text = "Salida";
            this.btn_salida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salida.TextColor = System.Drawing.Color.White;
            this.btn_salida.UseVisualStyleBackColor = false;
            this.btn_salida.Click += new System.EventHandler(this.botonesMenu_Click);
            // 
            // btn_entrada
            // 
            this.btn_entrada.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_entrada.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_entrada.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_entrada.BorderRadius = 0;
            this.btn_entrada.BorderSize = 0;
            this.btn_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_entrada.FlatAppearance.BorderSize = 0;
            this.btn_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrada.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrada.ForeColor = System.Drawing.Color.White;
            this.btn_entrada.Image = global::EstacionamientoSistema.Properties.Resources.entradaIcono;
            this.btn_entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entrada.Location = new System.Drawing.Point(0, 56);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(173, 56);
            this.btn_entrada.TabIndex = 6;
            this.btn_entrada.Tag = "2";
            this.btn_entrada.Text = "Entrada";
            this.btn_entrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_entrada.TextColor = System.Drawing.Color.White;
            this.btn_entrada.UseVisualStyleBackColor = false;
            this.btn_entrada.Click += new System.EventHandler(this.botonesMenu_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_dashboard.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btn_dashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dashboard.BorderRadius = 0;
            this.btn_dashboard.BorderSize = 0;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = global::EstacionamientoSistema.Properties.Resources.dashboardIcono;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(173, 56);
            this.btn_dashboard.TabIndex = 5;
            this.btn_dashboard.Tag = "1";
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dashboard.TextColor = System.Drawing.Color.White;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.botonesMenu_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(173, 50);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(860, 437);
            this.panelGeneral.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 487);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarSesion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_cerrarSesion;
        private System.Windows.Forms.Label txt_fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGeneral;
        private controlesPersonalizados.RJButton btn_entrada;
        private controlesPersonalizados.RJButton btn_dashboard;
        private controlesPersonalizados.RJButton btn_usuario;
        private controlesPersonalizados.RJButton btn_registro;
        private controlesPersonalizados.RJButton btn_salida;
    }
}