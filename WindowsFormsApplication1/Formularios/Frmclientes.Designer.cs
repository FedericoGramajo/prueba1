namespace WindowsFormsApplication1.Formularios
{
    partial class Frmclientes
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lbldni = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldomicilio = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtclientes = new System.Windows.Forms.DataGridView();
            this.lblempresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.btnusuario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.lbldni);
            this.groupBox1.Controls.Add(this.lbltelefono);
            this.groupBox1.Controls.Add(this.lbldomicilio);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.txtdomicilio);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Location = new System.Drawing.Point(27, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(373, 119);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(198, 125);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 16;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(41, 119);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 15;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lbldni
            // 
            this.lbldni.Location = new System.Drawing.Point(278, 72);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(64, 23);
            this.lbldni.TabIndex = 14;
            this.lbldni.Text = "DNI";
            // 
            // lbltelefono
            // 
            this.lbltelefono.Location = new System.Drawing.Point(278, 31);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(64, 23);
            this.lbltelefono.TabIndex = 13;
            this.lbltelefono.Text = "Telefono";
            // 
            // lbldomicilio
            // 
            this.lbldomicilio.Location = new System.Drawing.Point(20, 72);
            this.lbldomicilio.Name = "lbldomicilio";
            this.lbldomicilio.Size = new System.Drawing.Size(68, 23);
            this.lbldomicilio.TabIndex = 12;
            this.lbldomicilio.Text = "Domicilio";
            // 
            // lblnombre
            // 
            this.lblnombre.Location = new System.Drawing.Point(20, 31);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(68, 23);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "Nombre";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(348, 75);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 10;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(110, 75);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtdomicilio.TabIndex = 8;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(348, 31);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(110, 31);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtclientes);
            this.groupBox2.Location = new System.Drawing.Point(27, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtclientes
            // 
            this.dtclientes.AllowUserToAddRows = false;
            this.dtclientes.AllowUserToDeleteRows = false;
            this.dtclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtclientes.Location = new System.Drawing.Point(0, 5);
            this.dtclientes.Name = "dtclientes";
            this.dtclientes.ReadOnly = true;
            this.dtclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtclientes.Size = new System.Drawing.Size(508, 124);
            this.dtclientes.TabIndex = 0;
            this.dtclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtclientes_CellClick);
            // 
            // lblempresa
            // 
            this.lblempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempresa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblempresa.Location = new System.Drawing.Point(276, 23);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(228, 60);
            this.lblempresa.TabIndex = 15;
            this.lblempresa.Text = "Empresa";
            this.lblempresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.microsoft;
            this.pictureBox1.Location = new System.Drawing.Point(27, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(388, 85);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(64, 20);
            this.txtidcliente.TabIndex = 16;
            this.txtidcliente.Text = "0";
            // 
            // btnusuario
            // 
            this.btnusuario.Location = new System.Drawing.Point(225, 415);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(75, 23);
            this.btnusuario.TabIndex = 18;
            this.btnusuario.Text = "usuarios";
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.lblempresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmclientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldomicilio;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblempresa;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dtclientes;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Button btnusuario;
    }
}

