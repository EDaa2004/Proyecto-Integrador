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
    public partial class frmEstadísticas : Form
    {
        public frmEstadísticas()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;TrustServerCertificate=true; integrated security = true; Initial Catalog=BaseSalidaEcu"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT idCanton, nombCanton FROM Canton", connection);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbCanton.DisplayMember = "nombCanton";
                cmbCanton.ValueMember = "idCanton";
                cmbCanton.DataSource = dt;

                connection.Close();
            }
        }

        private void cmbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCanton.SelectedItem != null)
            {
                string cantonSeleccionada = cmbCanton.Text;
                MostrarDatos(cantonSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Cantón.");
            }
        }

        private void MostrarDatos(string canton)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;TrustServerCertificate=true; integrated security = true; Initial Catalog=BaseSalidaEcu"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Analisis_Ecuatorianos", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                DataRow[] rows = dt.Select($"Canton = '{canton}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    chartEcu.Series["2014"].Points.Clear();
                    for (int i = 2014; i <= 2023; i++)
                    {
                        string columnName = i.ToString();
                        if (row.Table.Columns.Contains(columnName))
                        {
                            chartEcu.Series["2014"].Points.AddXY(i, row[columnName]);
                        }
                    }
                    double Mo1 = Convert.ToDouble(row["2014"]);
                    double M1 = Convert.ToDouble(row["2018"]);
                    int t1 = 5;
                    double K1 = (Math.Log(M1 / Mo1)) / t1;
                    double P_prime1 = K1 * M1;
                    double Mo2 = Convert.ToDouble(row["2019"]);
                    double M2 = Convert.ToDouble(row["2023"]);
                    int t2 = 5;
                    double K2 = (Math.Log(M2 / Mo2)) / t2;
                    double P_prime2 = K2 * M2;
                    lbModeloEcu1.Text = $"Periodo 2014-2018:\nK1: {K1:F4}     P'(t1): {P_prime1:F4}";
                    lbModeloEcu2.Text = $"Periodo 2019-2023:\nK2: {K2:F4}     P'(t2): {P_prime2:F4}";
                }
                else
                {
                    MessageBox.Show("No hay datos para la marca seleccionada.");
                }
                SqlCommand command2 = new SqlCommand("Analisis_Extranjeros", connection);
                command2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                connection.Close();
                DataRow[] rows2 = dt2.Select($"Canton = '{canton}'");
                if (rows2.Length > 0)
                {
                    DataRow row = rows2[0];
                    chartExt.Series["2014"].Points.Clear();
                    for (int i = 2014; i <= 2023; i++)
                    {
                        string columnName = i.ToString();
                        if (row.Table.Columns.Contains(columnName))
                        {
                            chartExt.Series["2014"].Points.AddXY(i, row[columnName]);
                        }
                    }
                    double Mo1 = Convert.ToDouble(row["2014"]);
                    double M1 = Convert.ToDouble(row["2018"]);
                    int t1 = 5;
                    double K1 = (Math.Log(M1 / Mo1)) / t1;
                    double P_prime1 = K1 * M1;
                    double Mo2 = Convert.ToDouble(row["2019"]);
                    double M2 = Convert.ToDouble(row["2023"]);
                    int t2 = 5;
                    double K2 = (Math.Log(M2 / Mo2)) / t2;
                    double P_prime2 = K2 * M2;
                    lbModeloExt1.Text = $"Periodo 2014-2018:\nK1: {K1:F4}     P'(t1): {P_prime1:F4}";
                    lbModeloExt2.Text = $"Periodo 2019-2023:\nK2: {K2:F4}     P'(t2): {P_prime2:F4}";
                }
                else
                {
                    MessageBox.Show("No hay datos para la marca seleccionada.");
                }
            }
        }
    }
}
