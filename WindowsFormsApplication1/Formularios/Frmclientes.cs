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
using Newtonsoft.Json;

namespace WindowsFormsApplication1.Formularios
{
    public partial class Frmclientes : Form
    {
        List<Cliente> lista = new List<Cliente>();
        Cliente cliente;
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = FuncionesClientes.Mostrar();
            dtclientes.DataSource = lista;
           /* if (dtclientes.Rows.Count != 0)
            {
                dtclientes.Columns["Idcliente"].Visible = false;
            }*/
        }




        private void RecargarLista() 
        {

            dtclientes.DataSource = null;
            dtclientes.DataSource = lista;
            //dtclientes.Columns["idcliente"].Visible = false;
         


        }

    
        //AGREGAR
        private void btnagregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

          
            cliente.Nombre = txtnombre.Text;
            cliente.Dni = txtdni.Text;
            cliente.Direccion = txtdomicilio.Text;
            cliente.Telefono = txttelefono.Text;

           
            if (txtnombre.Text != "" && txtdni.Text != "" && txtdomicilio.Text != "" && txttelefono.Text != "")
                {
                 if (FuncionesClientes.Agregar(cliente))
                     {
                  DataTable tabla_ultimo_id   = Sqlcliente.Mostrar("select top 1 idcliente from cliente order by idcliente desc ");
                   DataRow Filtro = tabla_ultimo_id.Select().FirstOrDefault();
                    cliente.Idcliente = Filtro.Field<int>("idcliente");
                    lista.Add(cliente);
                        MessageBox.Show("El cliente fue agregago con exito");
                        RecargarLista();
                        txtnombre.Text = "";
                        txtdni.Text = "";
                        txtdomicilio.Text = "";
                        txttelefono.Text = "";
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


//MODIFICAR
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtidcliente.Text != "0")
            {
                cliente = (Cliente)dtclientes.CurrentRow.DataBoundItem;
                lista.Remove(cliente);
                cliente = new Cliente();
                cliente.Idcliente = Convert.ToInt16(txtidcliente.Text);
                cliente.Nombre = txtnombre.Text;
                cliente.Dni = txtdni.Text;
                cliente.Direccion = txtdomicilio.Text;
                cliente.Telefono = txttelefono.Text;

                if (txtnombre.Text != "" && txtdni.Text != "" && txtdomicilio.Text != "" && txttelefono.Text != "")
                {
                    if (FuncionesClientes.Modificar(cliente))
                    {

                        lista.Add(cliente);

                        MessageBox.Show("El cliente fue modificado con exito");
                        RecargarLista();
                        txtidcliente.Text = "";
                        txtnombre.Text = "";
                        txtdni.Text = "";
                        txtdomicilio.Text = "";
                        txttelefono.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no fue modificado, por favor revise los datos");
                }
            }
            else
            {
                MessageBox.Show("Seleccionar cliente");
            }
        }

//ELIMINAR
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtidcliente.Text != "0")
            {
                cliente = (Cliente)dtclientes.CurrentRow.DataBoundItem;
                lista.Remove(cliente);
                cliente = new Cliente();
                cliente.Idcliente = Convert.ToInt16(txtidcliente.Text);
                if (txtnombre.Text != "" && txtdni.Text != "" && txtdomicilio.Text != "" && txttelefono.Text != "")
                {
                    if (FuncionesClientes.Eliminar(cliente))
                    {

                        MessageBox.Show("El cliente fue eliminado con exito");
                        RecargarLista();
                        txtidcliente.Text = "";
                        txtnombre.Text = "";
                        txtdni.Text = "";
                        txtdomicilio.Text = "";
                        txttelefono.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en el sistema, intente en unos momentos");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no fue eliminado, por favor revise los datos");
                }
            }
            else
            {
                MessageBox.Show("Seleccionar cliente");
            }
        }











        private void dtclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcliente.Text = dtclientes.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
            txtnombre.Text = dtclientes.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txtdni.Text = dtclientes.Rows[e.RowIndex].Cells["dni"].Value.ToString();
            txtdomicilio.Text = dtclientes.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            txttelefono.Text = dtclientes.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
           

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmUsuarios frm = new FrmUsuarios();

            frm.Show();
        }
    }
}
