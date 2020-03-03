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
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btncliente_Onclick(object sender, EventArgs e)
        {
            this.Hide();

            Frmclientes frm = new Frmclientes();

            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnousuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmUsuarios frm = new FrmUsuarios();

            frm.Show();
        }
    }
}
