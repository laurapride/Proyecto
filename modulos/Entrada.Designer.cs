
namespace EstacionamientoSistema.modulos
{
    partial class Entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idtipoV = new System.Windows.Forms.Label();
            this.cbIdtipo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsregistrar = new System.Windows.Forms.ToolStripLabel();
            this.tcconsultar = new System.Windows.Forms.ToolStripLabel();
            this.tseliminar = new System.Windows.Forms.ToolStripLabel();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.tslactualizar = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placas:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbusqueda.Location = new System.Drawing.Point(106, 77);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(148, 30);
            this.txtbusqueda.TabIndex = 2;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // txtcolor
            // 
            this.txtcolor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcolor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(106, 130);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(148, 30);
            this.txtcolor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color:";
            // 
            // txtDueño
            // 
            this.txtDueño.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDueño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDueño.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueño.Location = new System.Drawing.Point(661, 75);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(148, 30);
            this.txtDueño.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dueño:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmodelo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo.Location = new System.Drawing.Point(400, 131);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(148, 30);
            this.txtmodelo.TabIndex = 10;
            this.txtmodelo.TextChanged += new System.EventHandler(this.txtmodelo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modelo:";
            // 
            // idtipoV
            // 
            this.idtipoV.AutoSize = true;
            this.idtipoV.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtipoV.Location = new System.Drawing.Point(270, 80);
            this.idtipoV.Name = "idtipoV";
            this.idtipoV.Size = new System.Drawing.Size(135, 23);
            this.idtipoV.TabIndex = 11;
            this.idtipoV.Text = "Tipo de Vehiculo:";
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
            this.cbIdtipo.Location = new System.Drawing.Point(400, 76);
            this.cbIdtipo.Name = "cbIdtipo";
            this.cbIdtipo.Size = new System.Drawing.Size(145, 31);
            this.cbIdtipo.TabIndex = 12;
            this.cbIdtipo.SelectedIndexChanged += new System.EventHandler(this.cbIdtipo_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStrip2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsregistrar,
            this.tcconsultar,
            this.tseliminar,
            this.tslactualizar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(858, 29);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip";
            // 
            // tsregistrar
            // 
            this.tsregistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsregistrar.Image = global::EstacionamientoSistema.Properties.Resources._2549f65d783e274ae114b281b865ffdb1;
            this.tsregistrar.Name = "tsregistrar";
            this.tsregistrar.Size = new System.Drawing.Size(109, 26);
            this.tsregistrar.Text = "Registrar";
            this.tsregistrar.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tcconsultar
            // 
            this.tcconsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tcconsultar.Name = "tcconsultar";
            this.tcconsultar.Size = new System.Drawing.Size(72, 26);
            this.tcconsultar.Text = "Buscar";
            this.tcconsultar.Click += new System.EventHandler(this.tcconsultar_Click);
            // 
            // tseliminar
            // 
            this.tseliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tseliminar.Name = "tseliminar";
            this.tseliminar.Size = new System.Drawing.Size(81, 26);
            this.tseliminar.Text = "Eliminar";
            this.tseliminar.Click += new System.EventHandler(this.tseliminar_Click);
            // 
            // dgvdatos
            // 
            this.dgvdatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(170, 186);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.Size = new System.Drawing.Size(530, 227);
            this.dgvdatos.TabIndex = 13;
            this.dgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatos_CellContentClick);
            // 
            // tslactualizar
            // 
            this.tslactualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tslactualizar.Name = "tslactualizar";
            this.tslactualizar.Size = new System.Drawing.Size(102, 26);
            this.tslactualizar.Text = "Actualizar";
            this.tslactualizar.Click += new System.EventHandler(this.tslactualizar_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvdatos);
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
            this.Name = "Entrada";
            this.Size = new System.Drawing.Size(858, 435);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idtipoV;
        private System.Windows.Forms.ComboBox cbIdtipo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsregistrar;
        private System.Windows.Forms.ToolStripLabel tcconsultar;
        private System.Windows.Forms.ToolStripLabel tseliminar;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.ToolStripLabel tslactualizar;
    }
}
