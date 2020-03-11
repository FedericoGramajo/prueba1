using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.Funciones;
using WindowsFormsApplication1.Objetos;
namespace WindowsFormsApplication1.Formularios
{
    public partial class FrmNotaPedido : Form
    {
        DataTable dt;
        List<Servicio> lista = new List<Servicio>();
        public int guard = 0;
        public int sum = 0;
        public FrmNotaPedido(DataTable e)
        {
            dt = e;
            InitializeComponent();
            string idusu = dt.Rows[0][0].ToString();
            txtidusuario.Text = idusu;
            string usunom = dt.Rows[0][1].ToString();
            txtusuarionom.Text = usunom;

        }



        SqlConnection con = new SqlConnection("server=.\\SQL_UAI ; database=prueba ; integrated security = true");
        //SqlConnection coneccion = new SqlConnection("server=FEDERICO-PC\\SQLEXPRESS ; database=prueba ; integrated security = true");
      /*  public void autocompletarcli(TextBox cajaTexto, string idcli)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre from cliente ", con);

                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr["Nombre"].ToString());
                }
                dr.Close();



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

        public void autocompletarserv(TextBox cajaTexto)
        {
            try
            {
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("SELECT nomcorto from servicio ", coneccion);

                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr["nomcorto"].ToString());

                }
                dr.Close();



            }
            catch (Exception ex)

            {
                throw ex;
            }
            finally
            {
                coneccion.Close();
            }
        }*/

        private void FrmNotaPedido_Load(object sender, EventArgs e)
        {
                  
            // autocompletarcli(txtclientenom);
            // autocompletarserv(txttiposerv);

            SqlCommand cm = new SqlCommand("select * from cliente",con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(1));
            }
            con.Close();

            lista = FuncionesServicios.Mostrar();
            dtservicios.DataSource = lista;
            if (dtservicios.Rows.Count != 0)
            {
                dtservicios.Columns["idservicio"].Visible = false;
            }
            

            
        }

        private void btnnota_Click(object sender, EventArgs e)
        {

        }

  
        public void dtservicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttiposerv.Text = dtservicios.Rows[e.RowIndex].Cells["nomcorto"].Value.ToString();
            txtidserv.Text = dtservicios.Rows[e.RowIndex].Cells["idservicio"].Value.ToString();
            guard= Convert.ToInt16(dtservicios.Rows[e.RowIndex].Cells["montoxunmedida"].Value.ToString());

            sum = sum +Convert.ToInt16( dtservicios.Rows[e.RowIndex].Cells["montoxunmedida"].Value.ToString());
            lbltotal.Text = Convert.ToString(sum);
           
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            sum = sum - guard;
            //sum = guard;
            lbltotal.Text = Convert.ToString(sum);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select * from cliente where nombre = '" + comboBox1.Text + "' ", con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                txtidcliente.Text = dr["idcliente"].ToString();
            }
            con.Close();
        }

      private void btnnuevoserv_Click(object sender, EventArgs e)
        {
            FrmServicios frm = new FrmServicios(dt);
            frm.ShowDialog();
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();
            frm.ShowDialog();
            
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frm = new FrmMenu(dt);
            frm.Show();

        }


        /* //cargar los datos para el autocomplete del textbox
textBox1.AutoCompleteCustomSource = Objetos.FuncionesPedido.AutoCompleClass.Autocomplete();
textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
textBox2.AutoCompleteCustomSource = Objetos.FuncionesPedido.AutoCompleClass.Autocomplete();
textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
// Cargo los datos que tendra el combobox

}*/
    }

     
    }

