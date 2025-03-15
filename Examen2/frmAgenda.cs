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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT * FROM usuarios");
            if (ds != null)
            {
                dgvAgenda.DataSource = ds.Tables[0];

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualiza actualiza = new frmActualiza(
                dgvAgenda[0, e.RowIndex].Value.ToString(),
                dgvAgenda[1, e.RowIndex].Value.ToString(),
                dgvAgenda[2, e.RowIndex].Value.ToString(),
                dgvAgenda[3, e.RowIndex].Value.ToString(),
                dgvAgenda[4, e.RowIndex].Value.ToString(),
                dgvAgenda[5, e.RowIndex].Value.ToString()
                );

            actualiza.Show();
        }

        public void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT ID AS ID, APATERNO AS " +
     "[APELLIDO PATERNO],AMATERNO AS [APELLIDO MATERNO], NOMBRE as NOMBRE," +
     "TELEFONO AS TELEFONO,CORREO AS CORREO FROM usuarios");

            if (ds != null)
            {
                dgvAgenda.DataSource = ds.Tables[0];
            }

        }

        private void frmAgenda_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void iNSERTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertar insertar = new frmInsertar();
            insertar.Show();

        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualiza actualiza = new frmActualiza(
                dgvAgenda[0, e.RowIndex].Value.ToString(),
                dgvAgenda[1, e.RowIndex].Value.ToString(),
                dgvAgenda[2, e.RowIndex].Value.ToString(),
                dgvAgenda[3, e.RowIndex].Value.ToString(),
                dgvAgenda[4, e.RowIndex].Value.ToString(),
                dgvAgenda[5, e.RowIndex].Value.ToString()
                );

            actualiza.Show();
        }
    }
}
