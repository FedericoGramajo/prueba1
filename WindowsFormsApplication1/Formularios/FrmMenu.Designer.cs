﻿namespace WindowsFormsApplication1.Formularios
{
    partial class FrmMenu
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
            this.btnousuario = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnnotadepedido = new System.Windows.Forms.Button();
            this.lblmenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnousuario
            // 
            this.btnousuario.Location = new System.Drawing.Point(76, 119);
            this.btnousuario.Name = "btnousuario";
            this.btnousuario.Size = new System.Drawing.Size(142, 24);
            this.btnousuario.TabIndex = 1;
            this.btnousuario.Text = "Nuevo Usuario";
            this.btnousuario.UseVisualStyleBackColor = true;
            this.btnousuario.Click += new System.EventHandler(this.btnousuario_Click);
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(76, 72);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(142, 24);
            this.btncliente.TabIndex = 4;
            this.btncliente.Text = "Nuevo Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Onclick);
            // 
            // btnnotadepedido
            // 
            this.btnnotadepedido.Location = new System.Drawing.Point(76, 166);
            this.btnnotadepedido.Name = "btnnotadepedido";
            this.btnnotadepedido.Size = new System.Drawing.Size(142, 24);
            this.btnnotadepedido.TabIndex = 5;
            this.btnnotadepedido.Text = "Nota de Pedido";
            this.btnnotadepedido.UseVisualStyleBackColor = true;
            // 
            // lblmenu
            // 
            this.lblmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.Location = new System.Drawing.Point(73, 24);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(145, 30);
            this.lblmenu.TabIndex = 6;
            this.lblmenu.Text = "Menu";
            this.lblmenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 228);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.btnnotadepedido);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.btnousuario);
            this.Name = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnousuario;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnnotadepedido;
        private System.Windows.Forms.Label lblmenu;
    }
}