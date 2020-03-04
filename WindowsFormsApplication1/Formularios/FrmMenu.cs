using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Formularios
{
    public partial class FrmMenu : Form
    {
        DataTable dt;
        public FrmMenu( DataTable a)
        {
            dt = a;

            InitializeComponent();
        }

        private void btncliente_Onclick(object sender, EventArgs e)
        {
            this.Hide();

            Frmclientes frm = new Frmclientes(dt);

            frm.ShowDialog();
        }



        private void btnousuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmUsuarios frm = new FrmUsuarios(dt);

            frm.ShowDialog();
        }

        private void btnnotadepedido_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmNotaPedido frm = new FrmNotaPedido(dt);

            frm.ShowDialog();
        }

        private void btnservicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmServicios frm = new FrmServicios(dt);
            frm.ShowDialog();
        }
    }
}
