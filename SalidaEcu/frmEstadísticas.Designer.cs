namespace SalidaEcu
{
    partial class frmEstadísticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            label10 = new Label();
            cmbCanton = new ComboBox();
            panel1 = new Panel();
            label5 = new Label();
            lbModeloEcu2 = new Label();
            lbModeloEcu1 = new Label();
            chartEcu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            lbModeloExt2 = new Label();
            lbModeloExt1 = new Label();
            label3 = new Label();
            chartExt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartEcu).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 34.8F, FontStyle.Bold);
            label1.Location = new Point(483, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 67);
            label1.TabIndex = 0;
            label1.Text = "Estadísticas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(50, 81);
            label10.Name = "label10";
            label10.Size = new Size(85, 26);
            label10.TabIndex = 36;
            label10.Text = "Cantón:";
            // 
            // cmbCanton
            // 
            cmbCanton.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCanton.Font = new Font("Times New Roman", 13.8F);
            cmbCanton.FormattingEnabled = true;
            cmbCanton.Location = new Point(141, 78);
            cmbCanton.Name = "cmbCanton";
            cmbCanton.Size = new Size(197, 34);
            cmbCanton.TabIndex = 30;
            cmbCanton.SelectedIndexChanged += cmbCanton_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbModeloEcu2);
            panel1.Controls.Add(lbModeloEcu1);
            panel1.Controls.Add(chartEcu);
            panel1.Location = new Point(23, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 464);
            panel1.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(237, 9);
            label5.Name = "label5";
            label5.Size = new Size(132, 26);
            label5.TabIndex = 37;
            label5.Text = "Ecuatorianos";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbModeloEcu2
            // 
            lbModeloEcu2.AutoSize = true;
            lbModeloEcu2.Font = new Font("Times New Roman", 13.8F);
            lbModeloEcu2.Location = new Point(155, 403);
            lbModeloEcu2.Name = "lbModeloEcu2";
            lbModeloEcu2.Size = new Size(22, 26);
            lbModeloEcu2.TabIndex = 36;
            lbModeloEcu2.Text = "a";
            lbModeloEcu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbModeloEcu1
            // 
            lbModeloEcu1.AutoSize = true;
            lbModeloEcu1.Font = new Font("Times New Roman", 13.8F);
            lbModeloEcu1.Location = new Point(155, 333);
            lbModeloEcu1.Name = "lbModeloEcu1";
            lbModeloEcu1.Size = new Size(22, 26);
            lbModeloEcu1.TabIndex = 35;
            lbModeloEcu1.Text = "a";
            lbModeloEcu1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartEcu
            // 
            chartArea1.Name = "ChartArea1";
            chartEcu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartEcu.Legends.Add(legend1);
            chartEcu.Location = new Point(12, 47);
            chartEcu.Name = "chartEcu";
            chartEcu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "2014";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            chartEcu.Series.Add(series1);
            chartEcu.Size = new Size(581, 248);
            chartEcu.TabIndex = 34;
            chartEcu.Text = "chart3";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbModeloExt2);
            panel2.Controls.Add(lbModeloExt1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(chartExt);
            panel2.Location = new Point(650, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 464);
            panel2.TabIndex = 40;
            // 
            // lbModeloExt2
            // 
            lbModeloExt2.AutoSize = true;
            lbModeloExt2.Font = new Font("Times New Roman", 13.8F);
            lbModeloExt2.Location = new Point(154, 403);
            lbModeloExt2.Name = "lbModeloExt2";
            lbModeloExt2.Size = new Size(22, 26);
            lbModeloExt2.TabIndex = 38;
            lbModeloExt2.Text = "a";
            lbModeloExt2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbModeloExt1
            // 
            lbModeloExt1.AutoSize = true;
            lbModeloExt1.Font = new Font("Times New Roman", 13.8F);
            lbModeloExt1.Location = new Point(154, 333);
            lbModeloExt1.Name = "lbModeloExt1";
            lbModeloExt1.Size = new Size(22, 26);
            lbModeloExt1.TabIndex = 37;
            lbModeloExt1.Text = "a";
            lbModeloExt1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(244, 9);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 35;
            label3.Text = "Extranjeros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartExt
            // 
            chartArea2.Name = "ChartArea1";
            chartExt.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartExt.Legends.Add(legend2);
            chartExt.Location = new Point(12, 47);
            chartExt.Name = "chartExt";
            chartExt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "2014";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            chartExt.Series.Add(series2);
            chartExt.Size = new Size(581, 248);
            chartExt.TabIndex = 34;
            chartExt.Text = "chart1";
            // 
            // frmEstadísticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 607);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(cmbCanton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEstadísticas";
            Text = "Estadísticas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartEcu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartExt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label10;
        private ComboBox cmbCanton;
        private Panel panel1;
        private Label label5;
        private Label lbModeloEcu2;
        private Label lbModeloEcu1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEcu;
        private Panel panel2;
        private Label lbModeloExt2;
        private Label lbModeloExt1;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExt;
    }
}