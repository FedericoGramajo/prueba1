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


namespace WindowsFormsApplication1.Formularios
{
    public partial class FrmNotaPedido : Form
    {
        DataTable dt;
        public FrmNotaPedido(DataTable e)
        {
            dt = e;
            InitializeComponent();
            string usunom = dt.Rows[0][0].ToString();
            textBox2.Text = usunom;
        }


        SqlConnection coneccion = new SqlConnection("server=.\\SQL_UAI ; database=prueba ; integrated security = true");
        //SqlConnection coneccion = new SqlConnection("server=FEDERICO-PC\\SQLEXPRESS ; database=prueba ; integrated security = true");
        public void autocompletarcli(TextBox cajaTexto)
        {
            try
            {
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre from cliente ", coneccion);

                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr[ "Nombre"].ToString());
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
        }

      

        private void FrmNotaPedido_Load(object sender, EventArgs e)
        {
            autocompletarcli(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

                   }
    }
}
