namespace Ampa.Frm
{
    partial class FrmSocios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocios));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoIdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocioIdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoIdTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsPrincipal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnNuevoCurso = new Ampa.Control.CustomButton();
            this.btnNuevoSocio = new Ampa.Control.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnInformes = new Ampa.Control.CustomButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAlumnos);
            this.panel2.Controls.Add(this.dgvSocios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 420);
            this.panel2.TabIndex = 9;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlumno,
            this.CursoIdAlumno,
            this.IdAlumno,
            this.SocioIdAlumno,
            this.ApellidoAlumno,
            this.Curso});
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAlumnos.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvAlumnos.Location = new System.Drawing.Point(0, 308);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1148, 98);
            this.dgvAlumnos.TabIndex = 1;
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.DataPropertyName = "Nombre";
            this.NombreAlumno.HeaderText = "Nombre";
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.ReadOnly = true;
            this.NombreAlumno.Width = 200;
            // 
            // CursoIdAlumno
            // 
            this.CursoIdAlumno.DataPropertyName = "CursoId";
            this.CursoIdAlumno.HeaderText = "CursoIdAlumno";
            this.CursoIdAlumno.Name = "CursoIdAlumno";
            this.CursoIdAlumno.ReadOnly = true;
            this.CursoIdAlumno.Visible = false;
            // 
            // IdAlumno
            // 
            this.IdAlumno.DataPropertyName = "Id";
            this.IdAlumno.HeaderText = "Id";
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            this.IdAlumno.Visible = false;
            // 
            // SocioIdAlumno
            // 
            this.SocioIdAlumno.DataPropertyName = "SocioId";
            this.SocioIdAlumno.HeaderText = "SocioId";
            this.SocioIdAlumno.Name = "SocioIdAlumno";
            this.SocioIdAlumno.ReadOnly = true;
            this.SocioIdAlumno.Visible = false;
            // 
            // ApellidoAlumno
            // 
            this.ApellidoAlumno.DataPropertyName = "Apellidos";
            this.ApellidoAlumno.HeaderText = "Apellidos";
            this.ApellidoAlumno.Name = "ApellidoAlumno";
            this.ApellidoAlumno.ReadOnly = true;
            this.ApellidoAlumno.Width = 200;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "Curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.AllowUserToResizeRows = false;
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CursoIdTutor,
            this.SocioId,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Movil,
            this.Email,
            this.EsPrincipal});
            this.dgvSocios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSocios.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvSocios.Location = new System.Drawing.Point(0, 0);
            this.dgvSocios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSocios.MultiSelect = false;
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.RowHeadersVisible = false;
            this.dgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocios.Size = new System.Drawing.Size(1148, 308);
            this.dgvSocios.TabIndex = 0;
            this.dgvSocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocios_CellClick);
            this.dgvSocios.SelectionChanged += new System.EventHandler(this.dgvSocios_SelectionChanged);
            this.dgvSocios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSocios_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // CursoIdTutor
            // 
            this.CursoIdTutor.DataPropertyName = "CursoId";
            this.CursoIdTutor.HeaderText = "CursoIdTutor";
            this.CursoIdTutor.Name = "CursoIdTutor";
            this.CursoIdTutor.ReadOnly = true;
            this.CursoIdTutor.Visible = false;
            // 
            // SocioId
            // 
            this.SocioId.DataPropertyName = "SocioId";
            this.SocioId.HeaderText = "Socio";
            this.SocioId.Name = "SocioId";
            this.SocioId.ReadOnly = true;
            this.SocioId.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 230;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 240;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 90;
            // 
            // Movil
            // 
            this.Movil.DataPropertyName = "Movil";
            this.Movil.HeaderText = "Móvil";
            this.Movil.Name = "Movil";
            this.Movil.ReadOnly = true;
            this.Movil.Width = 90;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 250;
            // 
            // EsPrincipal
            // 
            this.EsPrincipal.DataPropertyName = "EsPrincipal";
            this.EsPrincipal.HeaderText = "Tutor Principal";
            this.EsPrincipal.Name = "EsPrincipal";
            this.EsPrincipal.ReadOnly = true;
            this.EsPrincipal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsPrincipal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInformes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbmCurso);
            this.panel1.Controls.Add(this.lblCurso);
            this.panel1.Controls.Add(this.btnNuevoCurso);
            this.panel1.Controls.Add(this.btnNuevoSocio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 55);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(947, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cambiar de curso académico";
            // 
            // cbmCurso
            // 
            this.cbmCurso.FormattingEnabled = true;
            this.cbmCurso.Location = new System.Drawing.Point(945, 26);
            this.cbmCurso.Name = "cbmCurso";
            this.cbmCurso.Size = new System.Drawing.Size(201, 24);
            this.cbmCurso.TabIndex = 4;
            this.cbmCurso.SelectedIndexChanged += new System.EventHandler(this.cbmCurso_SelectedIndexChanged);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(749, 13);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(192, 25);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso 2015/2016";
            // 
            // btnNuevoCurso
            // 
            this.btnNuevoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnNuevoCurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevoCurso.FlatAppearance.BorderSize = 2;
            this.btnNuevoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCurso.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCurso.Location = new System.Drawing.Point(509, 4);
            this.btnNuevoCurso.Name = "btnNuevoCurso";
            this.btnNuevoCurso.Size = new System.Drawing.Size(117, 39);
            this.btnNuevoCurso.TabIndex = 2;
            this.btnNuevoCurso.Text = "Nuevo Curso";
            this.btnNuevoCurso.UseVisualStyleBackColor = false;
            this.btnNuevoCurso.Click += new System.EventHandler(this.btnNuevoCurso_Click);
            // 
            // btnNuevoSocio
            // 
            this.btnNuevoSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnNuevoSocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevoSocio.FlatAppearance.BorderSize = 2;
            this.btnNuevoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoSocio.ForeColor = System.Drawing.Color.White;
            this.btnNuevoSocio.Location = new System.Drawing.Point(390, 4);
            this.btnNuevoSocio.Name = "btnNuevoSocio";
            this.btnNuevoSocio.Size = new System.Drawing.Size(117, 39);
            this.btnNuevoSocio.TabIndex = 1;
            this.btnNuevoSocio.Text = "Nuevo Socio";
            this.btnNuevoSocio.UseVisualStyleBackColor = false;
            this.btnNuevoSocio.Click += new System.EventHandler(this.btnNuevoSocio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Búsqueda por \r\nNombre o Apellido:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(140, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(245, 23);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnInformes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInformes.FlatAppearance.BorderSize = 2;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Location = new System.Drawing.Point(627, 5);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(117, 39);
            this.btnInformes.TabIndex = 6;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // FrmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSocios";
            this.Load += new System.EventHandler(this.FrmSocios_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private Control.CustomButton btnNuevoSocio;
        private Control.CustomButton btnNuevoCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoIdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocioIdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoIdTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsPrincipal;
        private Control.CustomButton btnInformes;
        

    }
}