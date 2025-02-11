namespace SalidaEcu
{
    partial class frmFormulario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulario));
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            formularioToolStripMenuItem = new ToolStripMenuItem();
            formularioToolStripMenuItem1 = new ToolStripMenuItem();
            estadisticaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DodgerBlue;
            menuStrip1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formularioToolStripMenuItem, formularioToolStripMenuItem1, estadisticaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1282, 46);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // formularioToolStripMenuItem
            // 
            formularioToolStripMenuItem.ForeColor = Color.White;
            formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            formularioToolStripMenuItem.Size = new Size(141, 42);
            formularioToolStripMenuItem.Text = "Gestión";
            formularioToolStripMenuItem.Click += GestióntoolStripMenuItem1_Click;
            // 
            // formularioToolStripMenuItem1
            // 
            formularioToolStripMenuItem1.ForeColor = Color.White;
            formularioToolStripMenuItem1.Name = "formularioToolStripMenuItem1";
            formularioToolStripMenuItem1.Size = new Size(174, 42);
            formularioToolStripMenuItem1.Text = "Consultas";
            formularioToolStripMenuItem1.Click += ConsultasToolStripMenuItem_Click;
            // 
            // estadisticaToolStripMenuItem
            // 
            estadisticaToolStripMenuItem.ForeColor = Color.White;
            estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            estadisticaToolStripMenuItem.Size = new Size(201, 42);
            estadisticaToolStripMenuItem.Text = "Estadísticas";
            estadisticaToolStripMenuItem.Click += EstadísticasToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 607);
            panel1.TabIndex = 2;
            // 
            // frmFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmFormulario";
            Text = "frmFormulario";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem formularioToolStripMenuItem;
        private ToolStripMenuItem formularioToolStripMenuItem1;
        private ToolStripMenuItem estadisticaToolStripMenuItem;
        private Panel panel1;
    }
}