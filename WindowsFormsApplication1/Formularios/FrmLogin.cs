﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Objetos;
using WindowsFormsApplication1.Funciones;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.\\SQL_UAI ; database=prueba ; integrated security = true");
        //SqlConnection coneccion = new SqlConnection("server=FEDERICO-PC\\SQLEXPRESS ; database=prueba ; integrated security = true");
        public void Logear(string usuarionom, string contraseña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT idusuario, usuarionom from usuario where usuarionom= @nomusu  AND contraseña = @pass", con);
                cmd.Parameters.AddWithValue("nomusu", usuarionom);
                cmd.Parameters.AddWithValue("pass", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {


                    this.Hide();
                    FrmMenu frm = new FrmMenu(dt);

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }

            }
            catch (Exception ex)

            {
                throw ex;
            }
            finally
            {
                con.Close();
            }





        }

        private void btningresar_OnClick(object sender, EventArgs e)
        {
            Logear(this.txtusuario.Text, this.txtcontraseña.Text);

        }

       

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '*';

        }

       
    }
}
