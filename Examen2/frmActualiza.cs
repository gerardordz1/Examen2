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
    public partial class frmActualiza : Form
    {
        public frmActualiza(string id, string APATERNO, string AMATERNO, string NOMBRE,
            string TELEFONO, string CORREO)
        {
            InitializeComponent();
            txtID.Text = id;
            txtAPaterno.Text = APATERNO;
            txtAMaterno.Text = AMATERNO;
            txtNombre.Text = NOMBRE;
            txtTelefono.Text = TELEFONO;
            txtCorreo.Text = CORREO;

        }

        private void frmActualiza_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("UPDATE Usuarios SET " +
               "APATERNO = '" + txtAPaterno.Text + "', " +
               "AMATERNO = '" + txtAMaterno.Text + "', " +
               "NOMBRE = '" + txtNombre.Text + "', " +
               "TELEFONO = '" + txtTelefono.Text + "', " +
               "CORREO = '" + txtCorreo.Text + "' " +
               "WHERE ID = '" + txtID.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al actualizar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from usuarios where id = '" + txtID.Text + "'");
                if (f)
                {
                    MessageBox.Show("AUTOR ELIMINADO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error De Sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

