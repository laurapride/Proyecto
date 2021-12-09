
namespace EstacionamientoSistema.modulos
{
    partial class Salida
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
            this.components = new System.ComponentModel.Container();
            this.cbIdtipo = new System.Windows.Forms.ComboBox();
            this.idtipoV = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIdtipo
            // 
            this.cbIdtipo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbIdtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdtipo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdtipo.FormattingEnabled = true;
            this.cbIdtipo.Items.AddRange(new object[] {
            "Bicicleta",
            "Ciclomotor",
            "Motocicleta",
            "Automóvil",
            "Camionetas "});
            this.cbIdtipo.Location = new System.Drawing.Point(400, 90);
            this.cbIdtipo.Name = "cbIdtipo";
            this.cbIdtipo.Size = new System.Drawing.Size(145, 31);
            this.cbIdtipo.TabIndex = 22;
            // 
            // idtipoV
            // 
            this.idtipoV.AutoSize = true;
            this.idtipoV.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtipoV.Location = new System.Drawing.Point(270, 94);
            this.idtipoV.Name = "idtipoV";
            this.idtipoV.Size = new System.Drawing.Size(135, 23);
            this.idtipoV.TabIndex = 21;
            this.idtipoV.Text = "Tipo de Vehiculo:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmodelo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo.Location = new System.Drawing.Point(400, 145);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(148, 30);
            this.txtmodelo.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Modelo:";
            // 
            // txtDueño
            // 
            this.txtDueño.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDueño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDueño.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueño.Location = new System.Drawing.Point(661, 89);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(148, 30);
            this.txtDueño.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dueño:";
            // 
            // txtcolor
            // 
            this.txtcolor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcolor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(106, 144);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(148, 30);
            this.txtcolor.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Color:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbusqueda.Location = new System.Drawing.Point(106, 91);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(148, 30);
            this.txtbusqueda.TabIndex = 14;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placas:";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.salir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.Location = new System.Drawing.Point(400, 262);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 40);
            this.salir.TabIndex = 23;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar.Location = new System.Drawing.Point(702, 146);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(94, 40);
            this.buscar.TabIndex = 24;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.cbIdtipo);
            this.Controls.Add(this.idtipoV);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDueño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Name = "Salida";
            this.Size = new System.Drawing.Size(860, 348);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIdtipo;
        private System.Windows.Forms.Label idtipoV;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buscar;
    }
}
