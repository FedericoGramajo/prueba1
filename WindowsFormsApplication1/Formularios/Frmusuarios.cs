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
        DataTable f;
        List<Usuario> lista = new List<Usuario>();
        Usuario usuario;
        public FrmUsuarios(DataTable a)
        {

            f = a;
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
            dtusuario.Columns["contraseña"].Visible = false;

        }

        //-*-------------------------------------------------------

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
                    DataTable tabla_ultimo_id = Sqlcliente.Mostrar("select top 1 idusuario from usuario order by idusuario desc ");
                    DataRow Filtro = tabla_ultimo_id.Select().FirstOrDefault();
                    usuario.IdUsuario= Filtro.Field<int>("idusuario");
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

            if (txtidusuario.Text != "0")
            {
            
            usuario = new Usuario();

            usuario.IdUsuario = Convert.ToInt16(txtidusuario.Text);
            usuario.Nombre = txtnombre.Text;
            usuario.Dni = txtdni.Text;
            usuario.Direccion = txtdomicilio.Text;
            usuario.Telefono = txttelefono.Text;
            usuario.UsuarioNom = txtnomusuario.Text;
            usuario.Contraseña = txtcontraseña.Text;
                var filtro2 = lista.Where(s => s.IdUsuario == usuario.IdUsuario).FirstOrDefault();
                
                if (txtnombre.Text != "" && txtdni.Text != "" && txtdomicilio.Text != "" && txttelefono.Text != "" && txtnomusuario.Text != "" && txtcontraseña.Text != "")
                    {
                    if (filtro2.Contraseña == usuario.Contraseña)
                    {
                        if (FuncionesUsuarios.Modificar(usuario))
                        {

                            var filtro = lista.Where(s => s.IdUsuario == usuario.IdUsuario).FirstOrDefault();
                            filtro.Nombre = usuario.Nombre;
                            filtro.Dni = usuario.Dni;
                            filtro.Direccion = usuario.Direccion;
                            filtro.Telefono = usuario.Telefono;
                            filtro.UsuarioNom = usuario.UsuarioNom;
                            


                            MessageBox.Show("El usuario fue modificado con exito");

                            RecargarLista();
                            txtnombre.Text = "";
                            txtdomicilio.Text = "";
                            txtdni.Text = "";
                            txttelefono.Text = "";
                            txtnomusuario.Text = "";
                            txtcontraseña.Text = "";
                            txtidusuario.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error en el sistema, intente en unos momentos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
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
                usuario = new Usuario();
                usuario.IdUsuario = Convert.ToInt16(txtidusuario.Text);
                var filtro2 = lista.Where(s => s.IdUsuario == usuario.IdUsuario).FirstOrDefault();


                if (filtro2.Contraseña == txtcontraseña.Text)
                {

                    if (FuncionesUsuarios.Eliminar(Convert.ToInt16(txtidusuario.Text)))
                    {

                        MessageBox.Show("El Usuario fue eliminado correctamente");
                        var filtro = lista.Where(s => s.IdUsuario == Convert.ToInt16(txtidusuario.Text)).FirstOrDefault();
                        lista.Remove(filtro);
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
                    MessageBox.Show("Contraseña incorrecta");
                    txtcontraseña.Text = "";
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

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frm = new FrmMenu(f);

            frm.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtdomicilio.Text = "";
            txtdni.Text = "";
            txttelefono.Text = "";
            txtnomusuario.Text = "";
            txtcontraseña.Text = "";
            txtidusuario.Text = "";
        }
    }


  
}
