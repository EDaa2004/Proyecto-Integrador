using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalidaEcu
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void GestióntoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmGestión formulario = new frmGestión();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();
        }

        private void ConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmConsultas formulario = new frmConsultas();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();
        }

        private void EstadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmEstadísticas formulario = new frmEstadísticas();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();
        }
    }
}
