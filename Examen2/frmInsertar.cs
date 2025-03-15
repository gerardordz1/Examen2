using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class frmInsertar : Form
    {
        public frmInsertar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Datos datos = new Datos();
            bool f = datos.comando("INSERT INTO usuarios (APATERNO, AMATERNO, nombre, telefono, correo) VALUES ('" +
            txtAPaterno.Text + "','" + txtAMaterno.Text + "','" + txtNombre.Text + "','" +
            txtTelefono.Text + "','" + txtCorreo.Text + "')");
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
