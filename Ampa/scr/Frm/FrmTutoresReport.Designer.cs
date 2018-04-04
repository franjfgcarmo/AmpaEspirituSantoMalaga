namespace Ampa.Frm
{
    partial class FrmTutoresReport
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
            this.ampaDataSet1 = new Ampa.Entities.AmpaDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbApellidos = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ampaDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ampaDataSet1
            // 
            this.ampaDataSet1.DataSetName = "AmpaDataSet";
            this.ampaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbApellidos);
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por";
            // 
            // rdbApellidos
            // 
            this.rdbApellidos.AutoSize = true;
            this.rdbApellidos.Location = new System.Drawing.Point(136, 17);
            this.rdbApellidos.Name = "rdbApellidos";
            this.rdbApellidos.Size = new System.Drawing.Size(83, 21);
            this.rdbApellidos.TabIndex = 2;
            this.rdbApellidos.TabStop = true;
            this.rdbApellidos.Text = "Apellidos";
            this.rdbApellidos.UseVisualStyleBackColor = true;
            this.rdbApellidos.CheckedChanged += new System.EventHandler(this.rdbApellidos_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(12, 17);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(76, 21);
            this.rdbNombre.TabIndex = 0;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 422);
            this.panel1.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(853, 422);
            this.reportViewer1.TabIndex = 2;
            // 
            // FrmTutoresReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTutoresReport";
            this.Text = "Listados de Tutores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTutoresReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ampaDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Entities.AmpaDataSet ampaDataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbApellidos;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}