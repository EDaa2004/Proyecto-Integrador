using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalidaEcu
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
            string connectionString = "Data Source=.\\sqlexpress;TrustServerCertificate=true; integrated security = true; Initial Catalog=BaseSalidaEcu";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT F.Codigo as Código, A.nombAnio as Año, C.nombCanton as Cantón, D.nombDestino as Destino, ME.nombMedio as Medio, MO.nombMotivo as Motivo, g.nombGenero AS Genero, N.nombNacionalidad as Nacionalidad, F.cantidad as Cantidad\r\nFROM Formulario F\r\nINNER JOIN Anio A ON F.idAnio = A.idAnio\r\nINNER JOIN Canton C ON F.idCanton = C.idCanton\r\nINNER JOIN Destino D ON F.idDestino = D.idDestino\r\nINNER JOIN Medio ME ON F.idMedio = ME.idMedio\r\nINNER JOIN Motivo MO ON F.idMotivo = MO.idMotivo\r\nINNER JOIN Genero G ON F.idGenero = G.idGenero\r\nINNER JOIN Nacionalidad N ON F.idnacionalidad = N.idNacionalidad\r\n;";

            SqlCommand scmd = new SqlCommand(query, conn);
            SqlDataAdapter sdap = new SqlDataAdapter(scmd);
            DataSet dataSet = new DataSet();
            sdap.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void txtCodBusq_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;TrustServerCertificate=true; integrated security = true; Initial Catalog=BaseSalidaEcu";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT F.Codigo as Código, A.nombAnio as Año, C.nombCanton as Cantón, D.nombDestino as Destino, ME.nombMedio as Medio, MO.nombMotivo as Motivo, F.cantidad as Cantidad\r\nFROM Formulario F\r\nINNER JOIN Anio A ON F.idAnio = A.idAnio\r\nINNER JOIN Canton C ON F.idCanton = C.idCanton\r\nINNER JOIN Destino D ON F.idDestino = D.idDestino\r\nINNER JOIN Medio ME ON F.idMedio = ME.idMedio\r\nINNER JOIN Motivo MO ON F.idMotivo = MO.idMotivo\r\nwhere codigo like @txtCodBusq;";
            SqlCommand scmd = new SqlCommand(query, conn);
            scmd.Parameters.AddWithValue("@txtCodBusq", txtCodBusq.Text + "%");
            SqlDataAdapter sdap = new SqlDataAdapter(scmd);
            DataSet dataSet = new DataSet();
            sdap.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
