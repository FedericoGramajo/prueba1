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
    public partial class FrmServicios : Form
    {
        DataTable s;
        List<Servicio> lista = new List<Servicio>();
        Servicio servicio;

        public FrmServicios(DataTable k)
        {
            s = k;
            InitializeComponent();
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            lista = FuncionesServicios.Mostrar();
            dtservicios.DataSource = lista;
            if (dtservicios.Rows.Count != 0)
            {
                dtservicios.Columns["idservicio"].Visible = false;
            }
        }
        private void RecargarLista()
        {

            dtservicios.DataSource = null;
            dtservicios.DataSource = lista;
            dtservicios.Columns["idservicio"].Visible = false;



        }


        //AGREGAR
        private void btnagregar_Click(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio();

            servicio.nomcorto = txtnomcorto.Text;
            servicio.unmedida = txtunmedida.Text;
            servicio.descripcion = txtdescripcion.Text;
            servicio.montoxunmedida = txtprecioxunmedida.Text;
            servicio.fechaDato = txtfechadato.Text;



            if (txtnomcorto.Text != "" && txtunmedida.Text != "" && txtdescripcion.Text != "" && txtprecioxunmedida.Text != "" && txtfechadato.Text != "")
            {
                if (FuncionesServicios.Agregar(servicio))
                {
                    DataTable tabla_ultimo_id = Sqlcliente.Mostrar("select top 1 idservicio from servicio order by idservicio desc ");
                    DataRow Filtro = tabla_ultimo_id.Select().FirstOrDefault();
                    servicio.idservicio = Filtro.Field<int>("idservicio");
                    lista.Add(servicio);
                    MessageBox.Show("El cliente fue agregago con exito");
                    RecargarLista();
                    txtnomcorto.Text = "";
                    txtunmedida.Text = "";
                    txtdescripcion.Text = "";
                    txtprecioxunmedida.Text = "";
                    txtfechadato.Text = "";
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
            if (txtidservicio.Text != "0")
            {

                servicio = new Servicio();

                servicio.idservicio = Convert.ToInt16(txtidservicio.Text);
                servicio.nomcorto = txtnomcorto.Text;
                servicio.unmedida = txtunmedida.Text;
                servicio.descripcion = txtdescripcion.Text;
                servicio.montoxunmedida = txtprecioxunmedida.Text;
                servicio.fechaDato = txtfechadato.Text;

                if (txtnomcorto.Text != "" && txtunmedida.Text != "" && txtdescripcion.Text != "" && txtprecioxunmedida.Text != "" && txtfechadato.Text != "")
                {
                    if (FuncionesServicios.Modificar(servicio))
                    {
                        var filtro = lista.Where(s => s.idservicio == servicio.idservicio).FirstOrDefault();
                        filtro.nomcorto = servicio.nomcorto;
                        filtro.unmedida = servicio.unmedida;
                        filtro.descripcion = servicio.descripcion;
                        filtro.montoxunmedida = servicio.montoxunmedida;
                        filtro.fechaDato = servicio.fechaDato;


                        MessageBox.Show("El cliente fue modificado con exito");

                        RecargarLista();
                        txtnomcorto.Text = "";
                        txtunmedida.Text = "";
                        txtdescripcion.Text = "";
                        txtprecioxunmedida.Text = "";
                        txtfechadato.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en el sistema, intente en unos momentos");
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
            if (txtdescripcion.Text != "0")
            {

                if (FuncionesServicios.Eliminar(Convert.ToInt16(txtidservicio.Text)))
                {

                    MessageBox.Show("El cliente fue eliminado con exito");
                    Servicio filtro = lista.Where(s => s.idservicio == Convert.ToInt16(txtidservicio.Text)).FirstOrDefault();
                    lista.Remove(filtro);
                    RecargarLista();
                    txtnomcorto.Text = "";
                    txtunmedida.Text = "";
                    txtdescripcion.Text = "";
                    txtprecioxunmedida.Text = "";
                    txtfechadato.Text = "";
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en el sistema, intente en unos momentos");
                }

            }
            else
            {
                MessageBox.Show("Seleccionar cliente");
            }
        }











        private void dtclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidservicio.Text = dtservicios.Rows[e.RowIndex].Cells["idservicio"].Value.ToString();
            txtnomcorto.Text = dtservicios.Rows[e.RowIndex].Cells["nomcorto"].Value.ToString();
            txtunmedida.Text = dtservicios.Rows[e.RowIndex].Cells["unmedida"].Value.ToString();
            txtdescripcion.Text = dtservicios.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            txtprecioxunmedida.Text = dtservicios.Rows[e.RowIndex].Cells["montoxunmedida"].Value.ToString();
            txtfechadato.Text = dtservicios.Rows[e.RowIndex].Cells["fechaDato"].Value.ToString();

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frm = new FrmMenu(s);

            frm.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtidservicio.Text = "";
            txtnomcorto.Text = "";
            txtunmedida.Text = "";
            txtdescripcion.Text = "";
            txtprecioxunmedida.Text = "";
            txtfechadato.Text = "";
        }

     
    }
}
