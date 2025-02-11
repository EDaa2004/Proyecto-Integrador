namespace SalidaEcu
{
    partial class frmGestión
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestión));
            label1 = new Label();
            txtCodBusq = new TextBox();
            label10 = new Label();
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            cmbGenero = new ComboBox();
            label11 = new Label();
            cmbNacionalidad = new ComboBox();
            label7 = new Label();
            txtCodigo = new TextBox();
            label9 = new Label();
            txtCantidad = new TextBox();
            cmbDestino = new ComboBox();
            cmbMotivo = new ComboBox();
            cmbMedio = new ComboBox();
            cmbAnio = new ComboBox();
            cmbCanton = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 34.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(1251, 67);
            label1.TabIndex = 0;
            label1.Text = "Gestión del Formulario de salida de Ecuatorianos\r\n";
            // 
            // txtCodBusq
            // 
            txtCodBusq.Font = new Font("Times New Roman", 19.8000011F);
            txtCodBusq.Location = new Point(940, 148);
            txtCodBusq.Name = "txtCodBusq";
            txtCodBusq.Size = new Size(179, 45);
            txtCodBusq.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 19.8000011F);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(598, 151);
            label10.Name = "label10";
            label10.Size = new Size(336, 39);
            label10.TabIndex = 20;
            label10.Text = "Código del Formulario:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century", 19.8000011F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1110, 129);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(61, 76);
            btnBuscar.TabIndex = 19;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbGenero);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbNacionalidad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(cmbDestino);
            groupBox1.Controls.Add(cmbMotivo);
            groupBox1.Controls.Add(cmbMedio);
            groupBox1.Controls.Add(cmbAnio);
            groupBox1.Controls.Add(cmbCanton);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(99, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1072, 371);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de datos";
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Times New Roman", 19.8000011F);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(738, 166);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(308, 45);
            cmbGenero.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 19.8000011F);
            label11.Location = new Point(529, 177);
            label11.Name = "label11";
            label11.Size = new Size(124, 39);
            label11.TabIndex = 18;
            label11.Text = "Genero:";
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidad.Font = new Font("Times New Roman", 19.8000011F);
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Location = new Point(225, 288);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(266, 45);
            cmbNacionalidad.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 19.8000011F);
            label7.Location = new Point(24, 288);
            label7.Name = "label7";
            label7.Size = new Size(205, 39);
            label7.TabIndex = 16;
            label7.Text = "Nacionalidad:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Times New Roman", 19.8000011F);
            txtCodigo.Location = new Point(183, 54);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(308, 45);
            txtCodigo.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 19.8000011F);
            label9.Location = new Point(24, 60);
            label9.Name = "label9";
            label9.Size = new Size(126, 39);
            label9.TabIndex = 14;
            label9.Text = "Código:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Times New Roman", 19.8000011F);
            txtCantidad.Location = new Point(738, 228);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(308, 45);
            txtCantidad.TabIndex = 13;
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.Font = new Font("Times New Roman", 19.8000011F);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(738, 115);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(308, 45);
            cmbDestino.TabIndex = 11;
            // 
            // cmbMotivo
            // 
            cmbMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivo.Font = new Font("Times New Roman", 19.8000011F);
            cmbMotivo.FormattingEnabled = true;
            cmbMotivo.Location = new Point(738, 54);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(308, 45);
            cmbMotivo.TabIndex = 10;
            // 
            // cmbMedio
            // 
            cmbMedio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedio.Font = new Font("Times New Roman", 19.8000011F);
            cmbMedio.FormattingEnabled = true;
            cmbMedio.Location = new Point(183, 225);
            cmbMedio.Name = "cmbMedio";
            cmbMedio.Size = new Size(308, 45);
            cmbMedio.TabIndex = 9;
            // 
            // cmbAnio
            // 
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnio.Font = new Font("Times New Roman", 19.8000011F);
            cmbAnio.FormattingEnabled = true;
            cmbAnio.Location = new Point(183, 171);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(308, 45);
            cmbAnio.TabIndex = 8;
            // 
            // cmbCanton
            // 
            cmbCanton.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCanton.Font = new Font("Times New Roman", 19.8000011F);
            cmbCanton.FormattingEnabled = true;
            cmbCanton.Location = new Point(183, 113);
            cmbCanton.Name = "cmbCanton";
            cmbCanton.Size = new Size(308, 45);
            cmbCanton.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 19.8000011F);
            label8.Location = new Point(529, 231);
            label8.Name = "label8";
            label8.Size = new Size(147, 39);
            label8.TabIndex = 6;
            label8.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 19.8000011F);
            label6.Location = new Point(529, 121);
            label6.Name = "label6";
            label6.Size = new Size(130, 39);
            label6.TabIndex = 4;
            label6.Text = "Destino:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.8000011F);
            label5.Location = new Point(529, 60);
            label5.Name = "label5";
            label5.Size = new Size(124, 39);
            label5.TabIndex = 3;
            label5.Text = "Motivo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F);
            label4.Location = new Point(24, 231);
            label4.Name = "label4";
            label4.Size = new Size(114, 39);
            label4.TabIndex = 2;
            label4.Text = "Medio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F);
            label3.Location = new Point(24, 177);
            label3.Name = "label3";
            label3.Size = new Size(84, 39);
            label3.TabIndex = 1;
            label3.Text = "Año:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F);
            label2.Location = new Point(24, 121);
            label2.Name = "label2";
            label2.Size = new Size(122, 39);
            label2.TabIndex = 0;
            label2.Text = "Cantón:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(4, 92, 164);
            btnAgregar.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(261, 586);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(176, 61);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(4, 92, 164);
            btnModificar.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(553, 586);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(176, 61);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(4, 92, 164);
            btnEliminar.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(837, 586);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(176, 61);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmGestión
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 668);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCodBusq);
            Controls.Add(label10);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGestión";
            Text = "frmGestión";
            Load += frmGestión_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodBusq;
        private Label label10;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private TextBox txtCodigo;
        private Label label9;
        private TextBox txtCantidad;
        private ComboBox cmbDestino;
        private ComboBox cmbMotivo;
        private ComboBox cmbMedio;
        private ComboBox cmbAnio;
        private ComboBox cmbCanton;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ComboBox cmbGenero;
        private Label label11;
        private ComboBox cmbNacionalidad;
    }
}