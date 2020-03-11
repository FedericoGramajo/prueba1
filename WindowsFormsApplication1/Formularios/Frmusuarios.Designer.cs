namespace WindowsFormsApplication1.Formularios
{
    partial class FrmUsuarios
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
            this.lblempresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtusuario = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldomicilio = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtnomusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtusuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblempresa
            // 
            this.lblempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempresa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblempresa.Location = new System.Drawing.Point(262, 3);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(228, 94);
            this.lblempresa.TabIndex = 19;
            this.lblempresa.Text = "Empresa";
            this.lblempresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.microsoft;
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dtusuario
            // 
            this.dtusuario.AllowUserToAddRows = false;
            this.dtusuario.AllowUserToDeleteRows = false;
            this.dtusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtusuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtusuario.Location = new System.Drawing.Point(0, 10);
            this.dtusuario.Name = "dtusuario";
            this.dtusuario.ReadOnly = true;
            this.dtusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtusuario.Size = new System.Drawing.Size(508, 135);
            this.dtusuario.TabIndex = 0;
            this.dtusuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtusuario_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtusuario);
            this.groupBox2.Location = new System.Drawing.Point(31, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 149);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(110, 31);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(348, 31);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 2;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(110, 75);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtdomicilio.TabIndex = 3;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(348, 75);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 4;
            // 
            // lblnombre
            // 
            this.lblnombre.Location = new System.Drawing.Point(20, 31);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(68, 23);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldomicilio
            // 
            this.lbldomicilio.Location = new System.Drawing.Point(20, 72);
            this.lbldomicilio.Name = "lbldomicilio";
            this.lbldomicilio.Size = new System.Drawing.Size(68, 23);
            this.lbldomicilio.TabIndex = 12;
            this.lbldomicilio.Text = "Domicilio";
            // 
            // lbltelefono
            // 
            this.lbltelefono.Location = new System.Drawing.Point(278, 31);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(64, 23);
            this.lbltelefono.TabIndex = 13;
            this.lbltelefono.Text = "Telefono";
            // 
            // lbldni
            // 
            this.lbldni.Location = new System.Drawing.Point(278, 72);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(64, 23);
            this.lbldni.TabIndex = 14;
            this.lbldni.Text = "DNI";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(23, 161);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(150, 161);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 8;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.Location = new System.Drawing.Point(20, 118);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(68, 23);
            this.lblusuario.TabIndex = 18;
            this.lblusuario.Text = "Usuario";
            // 
            // txtnomusuario
            // 
            this.txtnomusuario.Location = new System.Drawing.Point(110, 118);
            this.txtnomusuario.Name = "txtnomusuario";
            this.txtnomusuario.Size = new System.Drawing.Size(100, 20);
            this.txtnomusuario.TabIndex = 5;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(348, 118);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 6;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.Location = new System.Drawing.Point(278, 118);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(64, 23);
            this.lblcontraseña.TabIndex = 21;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.lblcontraseña);
            this.groupBox1.Controls.Add(this.txtcontraseña);
            this.groupBox1.Controls.Add(this.txtnomusuario);
            this.groupBox1.Controls.Add(this.lblusuario);
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
            this.groupBox1.Location = new System.Drawing.Point(31, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 190);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(379, 161);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnlimpiar.Size = new System.Drawing.Size(101, 23);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar Formulario";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(267, 161);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtidusuario
            // 
            this.txtidusuario.Enabled = false;
            this.txtidusuario.Location = new System.Drawing.Point(327, 77);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(100, 20);
            this.txtidusuario.TabIndex = 23;
            this.txtidusuario.Text = "0";
            this.txtidusuario.Visible = false;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(481, 454);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 488);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.lblempresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUsuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtusuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtusuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldomicilio;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtnomusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnlimpiar;
    }
}