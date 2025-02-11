using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SalidaEcu
{
    // Nodo
    public class Node
    {
        public string Data { get; set; } 
        public Node Next { get; set; }    

        public Node(string data)
        {
            Data = data;
            Next = null; 
        }
    }

    // Lista Enlazada
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        // Agregar nuevo nodo ala lista
        public void Add(string data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode; 
            }
            else
            {
                Node current = head;
                while (current.Next != null) 
                {
                    current = current.Next;
                }
                current.Next = newNode; 
            }
        }

        // Eliminar un nodo por su codigo
        public void Remove(string data)
        {
            if (head == null) return; 
            if (head.Data == data)
            {
                head = head.Next; 
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next; 
            }
        }

        // Mostrar todos los nodos de la lista
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data); 
                current = current.Next;
            }
        }

        // Buscar un nodo por su codigo
        public Node Find(string data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                    return current; 
                current = current.Next;
            }
            return null; 
        }

        // Verificar si la lista está vacía.
        public bool IsEmpty()
        {
            return head == null;
        }
    }

    public partial class frmGestión : Form
    {
        private LinkedList linkedList; 

        public frmGestión()
        {
            InitializeComponent();
            linkedList = new LinkedList(); 
        }

        private void frmGestión_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;TrustServerCertificate=true; integrated security = true; Initial Catalog=BaseSalidaEcu";
            SqlConnection conn = new SqlConnection(connectionString);

            string queryCanton = "SELECT * FROM Canton;";
            SqlCommand scmdCanton = new SqlCommand(queryCanton, conn);
            SqlDataAdapter sdapCanton = new SqlDataAdapter(scmdCanton);
            DataSet dataSetCanton = new DataSet();
            sdapCanton.Fill(dataSetCanton);
            cmbCanton.DataSource = dataSetCanton.Tables[0];
            cmbCanton.ValueMember = "idCanton";
            cmbCanton.DisplayMember = "nombCanton";

            string queryAnio = "SELECT * FROM Anio;";
            SqlCommand scmdAnio = new SqlCommand(queryAnio, conn);
            SqlDataAdapter sdapAnio = new SqlDataAdapter(scmdAnio);
            DataSet dataSetAnio = new DataSet();
            sdapAnio.Fill(dataSetAnio);
            cmbAnio.DataSource = dataSetAnio.Tables[0];
            cmbAnio.ValueMember = "idAnio";
            cmbAnio.DisplayMember = "nombAnio";

            string queryMedio = "SELECT * FROM Medio;";
            SqlCommand scmdMedio = new SqlCommand(queryMedio, conn);
            SqlDataAdapter sdapMedio = new SqlDataAdapter(scmdMedio);
            DataSet dataSetMedio = new DataSet();
            sdapMedio.Fill(dataSetMedio);
            cmbMedio.DataSource = dataSetMedio.Tables[0];
            cmbMedio.ValueMember = "idMedio";
            cmbMedio.DisplayMember = "nombMedio";

            string queryMotivo = "SELECT * FROM Motivo;";
            SqlCommand scmdMotivo = new SqlCommand(queryMotivo, conn);
            SqlDataAdapter sdapMotivo = new SqlDataAdapter(scmdMotivo);
            DataSet dataSetMotivo = new DataSet();
            sdapMotivo.Fill(dataSetMotivo);
            cmbMotivo.DataSource = dataSetMotivo.Tables[0];
            cmbMotivo.ValueMember = "idMotivo";
            cmbMotivo.DisplayMember = "nombMotivo";

            string queryDestino = "SELECT * FROM Destino;";
            SqlCommand scmdDestino = new SqlCommand(queryDestino, conn);
            SqlDataAdapter sdapDestino = new SqlDataAdapter(scmdDestino);
            DataSet dataSetDestino = new DataSet();
            sdapDestino.Fill(dataSetDestino);
            cmbDestino.DataSource = dataSetDestino.Tables[0];
            cmbDestino.ValueMember = "idDestino";
            cmbDestino.DisplayMember = "nombDestino";

            string queryGenero = "SELECT * FROM Genero;";
            SqlCommand scmdGenero = new SqlCommand(queryGenero, conn);
            SqlDataAdapter sdapGenero = new SqlDataAdapter(scmdGenero);
            DataSet dataSetGenero = new DataSet();
            sdapGenero.Fill(dataSetGenero);
            cmbGenero.DataSource = dataSetGenero.Tables[0];
            cmbGenero.ValueMember = "idGenero";
            cmbGenero.DisplayMember = "nombGenero";

            string queryNacionaliad = "SELECT * FROM Nacionalidad;";
            SqlCommand scmdNacionaliad = new SqlCommand(queryNacionaliad, conn);
            SqlDataAdapter sdapNacionaliad = new SqlDataAdapter(scmdNacionaliad);
            DataSet dataSetNacionaliad = new DataSet();
            sdapNacionaliad.Fill(dataSetNacionaliad);
            cmbNacionalidad.DataSource = dataSetNacionaliad.Tables[0];
            cmbNacionalidad.ValueMember = "idNacionalidad";
            cmbNacionalidad.DisplayMember = "nombNacionalidad";

            LimpiarFormulario();
        }

        // Método para agregar un formulario a la lista enlazada
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string canton = cmbCanton.SelectedItem.ToString();
            string anio = cmbAnio.SelectedItem.ToString();
            string entry = $"Codigo: {codigo}, Canton: {canton}, Anio: {anio}";

            linkedList.Add(entry); 
            MessageBox.Show("Formulario agregado a la lista.");
        }

        // Método para eliminar un formulario de la lista enlazada
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            // Creamos una cadena representando del formulario
            string entryToRemove = $"Codigo: {codigo}";

            linkedList.Remove(entryToRemove); 
            MessageBox.Show("Formulario eliminado de la lista.");
        }

        // Método para modificar un formulario en la lista enlazada
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string canton = cmbCanton.SelectedItem.ToString();
            string anio = cmbAnio.SelectedItem.ToString();

            
            string modifiedEntry = $"Codigo: {codigo}, Canton: {canton}, Anio: {anio}";

            // Buscamos el formulario en la lista y lo reemplazamos
            linkedList.Remove($"Codigo: {codigo}");
            linkedList.Add(modifiedEntry); 
            MessageBox.Show("Formulario modificado correctamente.");
        }

        private void LimpiarFormulario()
        {
            txtCodBusq.Text = "";
            txtCodigo.Text = "";
            cmbCanton.SelectedIndex = -1;
            cmbAnio.SelectedIndex = -1;
            cmbMedio.SelectedIndex = -1;
            cmbMotivo.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtCantidad.Text = "";
            cmbNacionalidad.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
        }
    }
}
