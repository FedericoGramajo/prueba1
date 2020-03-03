using System;
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

namespace WindowsFormsApplication1.Formularios
{
    public partial class FrmUsuarios : Form
    {
        List<Usuario> lista = new List<Usuario>();
        Usuario usuario;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = FuncionesUsuarios.Mostrar();
                        dtusuario.DataSource = lista;
              if (dtusuario.Rows.Count != 0)
              {
                 dtusuario.Columns["IdUsuario"].Visible = false;
                dtusuario.Columns["contraseña"].Visible = false;
            }
        }

        private void RecargarLista()
        {
            dtusuario.DataSource = null;
            dtusuario.DataSource = lista;
            dtusuario.Columns["idusuario"].Visible = false;

        }

        //-*-------------------------------------------------------
        private void lblempresa_Click(object sender, EventArgs e)
        {

        }










        private void btnagregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtnombre.Text;
            usuario.Dni = txtdni.Text;
            usuario.Direccion = txtdomicilio.Text;
            usuario.Telefono = txttelefono.Text;
            usuario.UsuarioNom = txtnomusuario.Text;
            usuario.Contraseña = txtcontraseña.Text;

            if (txtnombre.Text != "" && txtdni.Text != "" && txtdomicilio.Text != "" && txttelefono.Text != "" && txtnomusuario.Text !="" && txtcontraseña.Text !="")
            {
                if (FuncionesUsuarios.Agregar(usuario))
                {
                    lista.Add(usuario);
                    MessageBox.Show("Se ha registro correctamente");
                    RecargarLista();
                    txtnombre.Text = "";
                    txtdomicilio.Text = "";
                    txtdni.Text = "";
                    txttelefono.Text = "";
                    txtnomusuario.Text = "";
                    txtcontraseña.Text = "";
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en el sistema, intente en unos momentos");
                }
            }
            else
            {
                MessageBox.Show("El cliente no fue agregago, por favor revise los datos");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            usuario = (Usuario)dtusuario.CurrentRow.DataBoundItem;
            lista.Remove(usuario);
            usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt16(txtidusuario.Text);
            usuario.Nombre = txtnombre.Text;
            usuario.Dni = txtdni.Text;
            usuario.Direccion = txtdomicilio.Text;
            usuario.Telefono = txttelefono.Text;
            usuario.UsuarioNom = txtnomusuario.Text;
            usuario.Contraseña = txtcontraseña.Text;

            if (txtidusuario.Text != "0")
            {
                    if (txtnombre.Text != "" && txtdni.Text != "" && txtdomicilio.Text != "" && txttelefono.Text != "" && txtnomusuario.Text != "" && txtcontraseña.Text != "")
                    {
                    if (FuncionesUsuarios.Modificar(usuario))
                        {
                            lista.Add(usuario);
                            MessageBox.Show("El usuario fue modificado con exito");
                            RecargarLista();
                            txtnombre.Text = "";
                            txtdomicilio.Text = "";
                            txtdni.Text = "";
                            txttelefono.Text = "";
                            txtnomusuario.Text = "";
                            txtcontraseña.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error en el sistema, intente en unos momentos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no fue modificado, por favor revise los datos");
                    }
                }
            else
            {
                MessageBox.Show("Selecciones un usuario");
            }

        }



        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtidusuario.Text != "0")
            {
                usuario = (Usuario)dtusuario.CurrentRow.DataBoundItem;
                lista.Remove(usuario);
                usuario = new Usuario();
                usuario.IdUsuario = Convert.ToInt16(txtidusuario.Text);

           
                if (txtnombre.Text != "" && txtdni.Text != "" && txtdomicilio.Text != "" && txttelefono.Text != "" && txtnomusuario.Text != "" && txtcontraseña.Text != "")
                {
                    if (FuncionesUsuarios.Eliminar(usuario))
                    {
                        MessageBox.Show("El Usuario fue eliminado correctamente");
                        RecargarLista();
                        txtnombre.Text = "";
                        txtdomicilio.Text = "";
                        txtdni.Text = "";
                        txttelefono.Text = "";
                        txtnomusuario.Text = "";
                        txtcontraseña.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en el sistema, intente en unos momentos");
                    }
                    }
                else
                {
                     MessageBox.Show("El usuario no fue eliminado, por favor revise los datos");
                }
                }
                else
                {
                MessageBox.Show("Selecciones un usuario");
                }
                
            }










        private void dtusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidusuario.Text = dtusuario.Rows[e.RowIndex].Cells["idusuario"].Value.ToString();
            txtnombre.Text = dtusuario.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txtdni.Text = dtusuario.Rows[e.RowIndex].Cells["dni"].Value.ToString();
            txtdomicilio.Text = dtusuario.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            txttelefono.Text = dtusuario.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            txtnomusuario.Text = dtusuario.Rows[e.RowIndex].Cells["usuarionom"].Value.ToString();
            dtusuario.Rows[e.RowIndex].Cells["contraseña"].Value.ToString();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '*';

        }

     
    }


  
}
