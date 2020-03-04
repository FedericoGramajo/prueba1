namespace WindowsFormsApplication1.Formularios
{
    partial class FrmServicios
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
            this.btninicio = new System.Windows.Forms.Button();
            this.lblservicios = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtservicios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lblfechadato = new System.Windows.Forms.Label();
            this.txtfechadato = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblprecioxunmedida = new System.Windows.Forms.Label();
            this.lblunmedida = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblnomcorto = new System.Windows.Forms.Label();
            this.txtprecioxunmedida = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtunmedida = new System.Windows.Forms.TextBox();
            this.txtnomcorto = new System.Windows.Forms.TextBox();
            this.txtidservicio = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtservicios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(673, -18);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(48, 23);
            this.btninicio.TabIndex = 28;
            this.btninicio.Text = "Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            // 
            // lblservicios
            // 
            this.lblservicios.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblservicios.Location = new System.Drawing.Point(29, 23);
            this.lblservicios.Name = "lblservicios";
            this.lblservicios.Size = new System.Drawing.Size(196, 49);
            this.lblservicios.TabIndex = 25;
            this.lblservicios.Text = "SERVICIOS";
            this.lblservicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtservicios);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 176);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // dtservicios
            // 
            this.dtservicios.AllowUserToAddRows = false;
            this.dtservicios.AllowUserToDeleteRows = false;
            this.dtservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtservicios.Location = new System.Drawing.Point(0, 0);
            this.dtservicios.Name = "dtservicios";
            this.dtservicios.ReadOnly = true;
            this.dtservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtservicios.Size = new System.Drawing.Size(684, 171);
            this.dtservicios.TabIndex = 0;
            this.dtservicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtclientes_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.lblfechadato);
            this.groupBox1.Controls.Add(this.txtfechadato);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.lblprecioxunmedida);
            this.groupBox1.Controls.Add(this.lblunmedida);
            this.groupBox1.Controls.Add(this.lbldescripcion);
            this.groupBox1.Controls.Add(this.lblnomcorto);
            this.groupBox1.Controls.Add(this.txtprecioxunmedida);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtunmedida);
            this.groupBox1.Controls.Add(this.txtnomcorto);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 170);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(521, 129);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnlimpiar.Size = new System.Drawing.Size(101, 23);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "Limpiar Formulario";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lblfechadato
            // 
            this.lblfechadato.Location = new System.Drawing.Point(464, 75);
            this.lblfechadato.Name = "lblfechadato";
            this.lblfechadato.Size = new System.Drawing.Size(82, 23);
            this.lblfechadato.TabIndex = 19;
            this.lblfechadato.Text = "Actualizado al:";
            // 
            // txtfechadato
            // 
            this.txtfechadato.Location = new System.Drawing.Point(552, 75);
            this.txtfechadato.Name = "txtfechadato";
            this.txtfechadato.Size = new System.Drawing.Size(100, 20);
            this.txtfechadato.TabIndex = 18;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(373, 129);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(204, 129);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 16;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(46, 129);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 15;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblprecioxunmedida
            // 
            this.lblprecioxunmedida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblprecioxunmedida.Location = new System.Drawing.Point(235, 72);
            this.lblprecioxunmedida.Name = "lblprecioxunmedida";
            this.lblprecioxunmedida.Size = new System.Drawing.Size(107, 44);
            this.lblprecioxunmedida.TabIndex = 14;
            this.lblprecioxunmedida.Text = "Precio por unidad de medida:";
            // 
            // lblunmedida
            // 
            this.lblunmedida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblunmedida.Location = new System.Drawing.Point(20, 75);
            this.lblunmedida.Name = "lblunmedida";
            this.lblunmedida.Size = new System.Drawing.Size(67, 31);
            this.lblunmedida.TabIndex = 13;
            this.lblunmedida.Text = "Unidad de Medida:";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.Location = new System.Drawing.Point(274, 34);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(68, 23);
            this.lbldescripcion.TabIndex = 12;
            this.lbldescripcion.Text = "Descripción";
            // 
            // lblnomcorto
            // 
            this.lblnomcorto.Location = new System.Drawing.Point(3, 31);
            this.lblnomcorto.Name = "lblnomcorto";
            this.lblnomcorto.Size = new System.Drawing.Size(84, 23);
            this.lblnomcorto.TabIndex = 11;
            this.lblnomcorto.Text = "Nombre Corto:";
            // 
            // txtprecioxunmedida
            // 
            this.txtprecioxunmedida.Location = new System.Drawing.Point(348, 72);
            this.txtprecioxunmedida.Name = "txtprecioxunmedida";
            this.txtprecioxunmedida.Size = new System.Drawing.Size(100, 20);
            this.txtprecioxunmedida.TabIndex = 10;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(348, 34);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(304, 20);
            this.txtdescripcion.TabIndex = 8;
            // 
            // txtunmedida
            // 
            this.txtunmedida.AcceptsReturn = true;
            this.txtunmedida.Location = new System.Drawing.Point(93, 72);
            this.txtunmedida.Name = "txtunmedida";
            this.txtunmedida.Size = new System.Drawing.Size(100, 20);
            this.txtunmedida.TabIndex = 6;
            // 
            // txtnomcorto
            // 
            this.txtnomcorto.Location = new System.Drawing.Point(93, 31);
            this.txtnomcorto.Name = "txtnomcorto";
            this.txtnomcorto.Size = new System.Drawing.Size(100, 20);
            this.txtnomcorto.TabIndex = 4;
            // 
            // txtidservicio
            // 
            this.txtidservicio.Location = new System.Drawing.Point(272, 41);
            this.txtidservicio.Name = "txtidservicio";
            this.txtidservicio.Size = new System.Drawing.Size(100, 20);
            this.txtidservicio.TabIndex = 29;
            this.txtidservicio.Text = "0";
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 455);
            this.Controls.Add(this.txtidservicio);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.lblservicios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmServicios";
            this.Text = "FrmServicios";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtservicios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label lblservicios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtservicios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfechadato;
        private System.Windows.Forms.TextBox txtfechadato;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblprecioxunmedida;
        private System.Windows.Forms.Label lblunmedida;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblnomcorto;
        private System.Windows.Forms.TextBox txtprecioxunmedida;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtunmedida;
        private System.Windows.Forms.TextBox txtnomcorto;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtidservicio;
    }
}