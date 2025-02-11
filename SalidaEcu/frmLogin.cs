using System.Data.SqlClient;

namespace SalidaEcu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;TrustServerCertificate=true;Integrated Security=true;Initial Catalog=BaseSalidaEcu";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Usuario WHERE Usuario = @NombUsuario AND Contrase�a = @Contrasena";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombUsuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrase�a.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.Hide();
                        frmFormulario frm = new frmFormulario();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contrase�a incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
