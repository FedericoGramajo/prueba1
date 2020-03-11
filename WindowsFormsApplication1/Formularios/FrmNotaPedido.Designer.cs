namespace WindowsFormsApplication1.Formularios
{
    partial class FrmNotaPedido
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
            this.txtusuarionom = new System.Windows.Forms.TextBox();
            this.txttiposerv = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.txtidserv = new System.Windows.Forms.TextBox();
            this.btnnuevoserv = new System.Windows.Forms.Button();
            this.btnnuevoped = new System.Windows.Forms.Button();
            this.btnpedidos = new System.Windows.Forms.Button();
            this.dtservicios = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtservicios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Servicio";
            // 
            // txtusuarionom
            // 
            this.txtusuarionom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtusuarionom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtusuarionom.Enabled = false;
            this.txtusuarionom.Location = new System.Drawing.Point(134, 119);
            this.txtusuarionom.Name = "txtusuarionom";
            this.txtusuarionom.Size = new System.Drawing.Size(100, 20);
            this.txtusuarionom.TabIndex = 5;
            // 
            // txttiposerv
            // 
            this.txttiposerv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txttiposerv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttiposerv.Location = new System.Drawing.Point(134, 173);
            this.txttiposerv.Name = "txttiposerv";
            this.txttiposerv.Size = new System.Drawing.Size(100, 20);
            this.txttiposerv.TabIndex = 1;
            // 
            // txtidcliente
            // 
            this.txtidcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtidcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtidcliente.Location = new System.Drawing.Point(240, 73);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(26, 20);
            this.txtidcliente.TabIndex = 8;
            // 
            // txtidusuario
            // 
            this.txtidusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtidusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtidusuario.Location = new System.Drawing.Point(240, 122);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(25, 20);
            this.txtidusuario.TabIndex = 9;
            // 
            // txtidserv
            // 
            this.txtidserv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtidserv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtidserv.Location = new System.Drawing.Point(240, 173);
            this.txtidserv.Name = "txtidserv";
            this.txtidserv.Size = new System.Drawing.Size(25, 20);
            this.txtidserv.TabIndex = 10;
            // 
            // btnnuevoserv
            // 
            this.btnnuevoserv.Location = new System.Drawing.Point(513, 18);
            this.btnnuevoserv.Name = "btnnuevoserv";
            this.btnnuevoserv.Size = new System.Drawing.Size(61, 49);
            this.btnnuevoserv.TabIndex = 5;
            this.btnnuevoserv.Text = "Nuevo servicio";
            this.btnnuevoserv.UseVisualStyleBackColor = true;
            this.btnnuevoserv.Click += new System.EventHandler(this.btnnuevoserv_Click);
            // 
            // btnnuevoped
            // 
            this.btnnuevoped.Location = new System.Drawing.Point(589, 18);
            this.btnnuevoped.Name = "btnnuevoped";
            this.btnnuevoped.Size = new System.Drawing.Size(61, 49);
            this.btnnuevoped.TabIndex = 6;
            this.btnnuevoped.Text = "Nuevo Pedido";
            this.btnnuevoped.UseVisualStyleBackColor = true;
            // 
            // btnpedidos
            // 
            this.btnpedidos.Location = new System.Drawing.Point(434, 18);
            this.btnpedidos.Name = "btnpedidos";
            this.btnpedidos.Size = new System.Drawing.Size(61, 49);
            this.btnpedidos.TabIndex = 4;
            this.btnpedidos.Text = "Notas de Pedido";
            this.btnpedidos.UseVisualStyleBackColor = true;
            this.btnpedidos.Click += new System.EventHandler(this.btnpedidos_Click);
            // 
            // dtservicios
            // 
            this.dtservicios.AllowUserToAddRows = false;
            this.dtservicios.AllowUserToDeleteRows = false;
            this.dtservicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtservicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtservicios.Location = new System.Drawing.Point(26, 210);
            this.dtservicios.Name = "dtservicios";
            this.dtservicios.ReadOnly = true;
            this.dtservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtservicios.Size = new System.Drawing.Size(645, 150);
            this.dtservicios.TabIndex = 14;
            this.dtservicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtservicios_CellClick);
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbltotal.Location = new System.Drawing.Point(358, 142);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(79, 44);
            this.lbltotal.TabIndex = 15;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(484, 142);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar servicio";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(605, 371);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 7;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // FrmNotaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 406);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dtservicios);
            this.Controls.Add(this.btnpedidos);
            this.Controls.Add(this.btnnuevoped);
            this.Controls.Add(this.btnnuevoserv);
            this.Controls.Add(this.txtidserv);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.txttiposerv);
            this.Controls.Add(this.txtusuarionom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNotaPedido";
            this.Text = "FrmNotaPedido";
            this.Load += new System.EventHandler(this.FrmNotaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtservicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusuarionom;
        private System.Windows.Forms.TextBox txttiposerv;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.TextBox txtidserv;
        private System.Windows.Forms.Button btnnuevoserv;
        private System.Windows.Forms.Button btnnuevoped;
        private System.Windows.Forms.Button btnpedidos;
        private System.Windows.Forms.DataGridView dtservicios;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnvolver;
    }
}