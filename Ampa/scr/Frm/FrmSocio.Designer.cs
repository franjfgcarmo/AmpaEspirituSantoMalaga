namespace Ampa.Frm
{
    partial class FrmSocio
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
            this.pnlAlumnos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtAlumnoId = new System.Windows.Forms.TextBox();
            this.btnNuevoAlumno = new Ampa.Control.CustomButton();
            this.btnGuardarAlumno = new Ampa.Control.CustomButton();
            this.btnEditarAlumno = new Ampa.Control.CustomButton();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCursoAlumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocioIdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTutores = new System.Windows.Forms.GroupBox();
            this.pnlEditTutor = new System.Windows.Forms.Panel();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.txtTutorId = new System.Windows.Forms.TextBox();
            this.btnNuevoTutor = new Ampa.Control.CustomButton();
            this.btnGuardarTutor = new Ampa.Control.CustomButton();
            this.btnEditarTutor = new Ampa.Control.CustomButton();
            this.txtApellidoTutor = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTelefonoTutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovilTutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailTutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreTutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdTutor = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsPrincipal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SocioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlImportarSocio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grdImportarSocios = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnImprimir = new Ampa.Control.CustomButton();
            this.btnImportarSocio = new Ampa.Control.CustomButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.BtnGuardarSocio = new Ampa.Control.CustomButton();
            this.BtnEditarSocio = new Ampa.Control.CustomButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.chkPagaPorBanco = new System.Windows.Forms.CheckBox();
            this.pnlAlumnos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.pnlTutores.SuspendLayout();
            this.pnlEditTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTutor)).BeginInit();
            this.pnlImportarSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdImportarSocios)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAlumnos
            // 
            this.pnlAlumnos.Controls.Add(this.panel1);
            this.pnlAlumnos.Controls.Add(this.dgvAlumno);
            this.pnlAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlumnos.ForeColor = System.Drawing.Color.White;
            this.pnlAlumnos.Location = new System.Drawing.Point(0, 362);
            this.pnlAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAlumnos.Name = "pnlAlumnos";
            this.pnlAlumnos.Padding = new System.Windows.Forms.Padding(2);
            this.pnlAlumnos.Size = new System.Drawing.Size(836, 133);
            this.pnlAlumnos.TabIndex = 10;
            this.pnlAlumnos.TabStop = false;
            this.pnlAlumnos.Text = "Alumnos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtAlumnoId);
            this.panel1.Controls.Add(this.btnNuevoAlumno);
            this.panel1.Controls.Add(this.btnGuardarAlumno);
            this.panel1.Controls.Add(this.btnEditarAlumno);
            this.panel1.Controls.Add(this.txtApellidoAlumno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCursoAlumno);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNombreAlumno);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(368, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 113);
            this.panel1.TabIndex = 10;
            // 
            // TxtAlumnoId
            // 
            this.TxtAlumnoId.Location = new System.Drawing.Point(414, 63);
            this.TxtAlumnoId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAlumnoId.Name = "TxtAlumnoId";
            this.TxtAlumnoId.Size = new System.Drawing.Size(44, 23);
            this.TxtAlumnoId.TabIndex = 13;
            this.TxtAlumnoId.Visible = false;
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnNuevoAlumno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoAlumno.FlatAppearance.BorderSize = 2;
            this.btnNuevoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAlumno.Location = new System.Drawing.Point(50, 60);
            this.btnNuevoAlumno.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(120, 28);
            this.btnNuevoAlumno.TabIndex = 3;
            this.btnNuevoAlumno.Text = "Nuevo Alumno";
            this.btnNuevoAlumno.UseVisualStyleBackColor = false;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnGuardarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarAlumno.FlatAppearance.BorderSize = 2;
            this.btnGuardarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAlumno.Location = new System.Drawing.Point(292, 60);
            this.btnGuardarAlumno.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(120, 28);
            this.btnGuardarAlumno.TabIndex = 5;
            this.btnGuardarAlumno.Text = "Guardar Alumno";
            this.btnGuardarAlumno.UseVisualStyleBackColor = false;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnEditarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarAlumno.FlatAppearance.BorderSize = 2;
            this.btnEditarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnEditarAlumno.Location = new System.Drawing.Point(171, 60);
            this.btnEditarAlumno.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Size = new System.Drawing.Size(120, 28);
            this.btnEditarAlumno.TabIndex = 4;
            this.btnEditarAlumno.Text = "Editar Alumno";
            this.btnEditarAlumno.UseVisualStyleBackColor = false;
            this.btnEditarAlumno.Click += new System.EventHandler(this.btnEditarAlumno_Click);
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(204, 21);
            this.txtApellidoAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(208, 23);
            this.txtApellidoAlumno.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(201, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellidos";
            // 
            // txtCursoAlumno
            // 
            this.txtCursoAlumno.Location = new System.Drawing.Point(413, 21);
            this.txtCursoAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.txtCursoAlumno.Name = "txtCursoAlumno";
            this.txtCursoAlumno.Size = new System.Drawing.Size(44, 23);
            this.txtCursoAlumno.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(410, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Curso";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(3, 21);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(200, 23);
            this.txtNombreAlumno.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AllowUserToAddRows = false;
            this.dgvAlumno.AllowUserToDeleteRows = false;
            this.dgvAlumno.AllowUserToResizeRows = false;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlumno,
            this.ApellidosAlumno,
            this.Curso,
            this.SocioIdAlumno,
            this.IdAlumno});
            this.dgvAlumno.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAlumno.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvAlumno.Location = new System.Drawing.Point(2, 18);
            this.dgvAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlumno.MultiSelect = false;
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.ReadOnly = true;
            this.dgvAlumno.RowHeadersVisible = false;
            this.dgvAlumno.RowTemplate.Height = 28;
            this.dgvAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumno.Size = new System.Drawing.Size(366, 113);
            this.dgvAlumno.TabIndex = 0;
            this.dgvAlumno.SelectionChanged += new System.EventHandler(this.dgvAlumno_SelectionChanged);
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.DataPropertyName = "Nombre";
            this.NombreAlumno.HeaderText = "Nombre";
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.ReadOnly = true;
            this.NombreAlumno.Width = 150;
            // 
            // ApellidosAlumno
            // 
            this.ApellidosAlumno.DataPropertyName = "Apellidos";
            this.ApellidosAlumno.HeaderText = "Apellidos";
            this.ApellidosAlumno.Name = "ApellidosAlumno";
            this.ApellidosAlumno.ReadOnly = true;
            this.ApellidosAlumno.Width = 160;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "Curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 50;
            // 
            // SocioIdAlumno
            // 
            this.SocioIdAlumno.DataPropertyName = "SocioId";
            this.SocioIdAlumno.HeaderText = "SocioIdAlumno";
            this.SocioIdAlumno.Name = "SocioIdAlumno";
            this.SocioIdAlumno.ReadOnly = true;
            this.SocioIdAlumno.Visible = false;
            // 
            // IdAlumno
            // 
            this.IdAlumno.DataPropertyName = "Id";
            this.IdAlumno.HeaderText = "IdAlumno";
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            this.IdAlumno.Visible = false;
            // 
            // pnlTutores
            // 
            this.pnlTutores.Controls.Add(this.pnlEditTutor);
            this.pnlTutores.Controls.Add(this.grdTutor);
            this.pnlTutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTutores.ForeColor = System.Drawing.Color.White;
            this.pnlTutores.Location = new System.Drawing.Point(0, 162);
            this.pnlTutores.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTutores.Name = "pnlTutores";
            this.pnlTutores.Padding = new System.Windows.Forms.Padding(2);
            this.pnlTutores.Size = new System.Drawing.Size(836, 200);
            this.pnlTutores.TabIndex = 9;
            this.pnlTutores.TabStop = false;
            this.pnlTutores.Text = "Tutores";
            // 
            // pnlEditTutor
            // 
            this.pnlEditTutor.Controls.Add(this.chkPrincipal);
            this.pnlEditTutor.Controls.Add(this.txtTutorId);
            this.pnlEditTutor.Controls.Add(this.btnNuevoTutor);
            this.pnlEditTutor.Controls.Add(this.btnGuardarTutor);
            this.pnlEditTutor.Controls.Add(this.btnEditarTutor);
            this.pnlEditTutor.Controls.Add(this.txtApellidoTutor);
            this.pnlEditTutor.Controls.Add(this.lblApellido);
            this.pnlEditTutor.Controls.Add(this.txtTelefonoTutor);
            this.pnlEditTutor.Controls.Add(this.label5);
            this.pnlEditTutor.Controls.Add(this.txtMovilTutor);
            this.pnlEditTutor.Controls.Add(this.label4);
            this.pnlEditTutor.Controls.Add(this.txtEmailTutor);
            this.pnlEditTutor.Controls.Add(this.label3);
            this.pnlEditTutor.Controls.Add(this.txtNombreTutor);
            this.pnlEditTutor.Controls.Add(this.label2);
            this.pnlEditTutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditTutor.Location = new System.Drawing.Point(2, 123);
            this.pnlEditTutor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEditTutor.Name = "pnlEditTutor";
            this.pnlEditTutor.Size = new System.Drawing.Size(832, 75);
            this.pnlEditTutor.TabIndex = 10;
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(6, 47);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(119, 21);
            this.chkPrincipal.TabIndex = 13;
            this.chkPrincipal.Text = "Tutor Principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtTutorId
            // 
            this.txtTutorId.Location = new System.Drawing.Point(733, 45);
            this.txtTutorId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTutorId.Name = "txtTutorId";
            this.txtTutorId.Size = new System.Drawing.Size(58, 23);
            this.txtTutorId.TabIndex = 12;
            this.txtTutorId.Visible = false;
            // 
            // btnNuevoTutor
            // 
            this.btnNuevoTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnNuevoTutor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoTutor.FlatAppearance.BorderSize = 2;
            this.btnNuevoTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTutor.ForeColor = System.Drawing.Color.White;
            this.btnNuevoTutor.Location = new System.Drawing.Point(222, 45);
            this.btnNuevoTutor.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevoTutor.Name = "btnNuevoTutor";
            this.btnNuevoTutor.Size = new System.Drawing.Size(128, 28);
            this.btnNuevoTutor.TabIndex = 5;
            this.btnNuevoTutor.Text = "Nuevo Tutor";
            this.btnNuevoTutor.UseVisualStyleBackColor = false;
            this.btnNuevoTutor.Click += new System.EventHandler(this.btnNuevoTutor_Click);
            // 
            // btnGuardarTutor
            // 
            this.btnGuardarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnGuardarTutor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarTutor.FlatAppearance.BorderSize = 2;
            this.btnGuardarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTutor.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTutor.Location = new System.Drawing.Point(483, 45);
            this.btnGuardarTutor.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarTutor.Name = "btnGuardarTutor";
            this.btnGuardarTutor.Size = new System.Drawing.Size(128, 28);
            this.btnGuardarTutor.TabIndex = 7;
            this.btnGuardarTutor.Text = "Guardar Tutor";
            this.btnGuardarTutor.UseVisualStyleBackColor = false;
            this.btnGuardarTutor.Click += new System.EventHandler(this.btnGuardarTutor_Click);
            // 
            // btnEditarTutor
            // 
            this.btnEditarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnEditarTutor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarTutor.FlatAppearance.BorderSize = 2;
            this.btnEditarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTutor.ForeColor = System.Drawing.Color.White;
            this.btnEditarTutor.Location = new System.Drawing.Point(352, 45);
            this.btnEditarTutor.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarTutor.Name = "btnEditarTutor";
            this.btnEditarTutor.Size = new System.Drawing.Size(129, 28);
            this.btnEditarTutor.TabIndex = 6;
            this.btnEditarTutor.Text = "Editar Tutor";
            this.btnEditarTutor.UseVisualStyleBackColor = false;
            this.btnEditarTutor.Click += new System.EventHandler(this.btnEditarTutor_Click_1);
            // 
            // txtApellidoTutor
            // 
            this.txtApellidoTutor.Location = new System.Drawing.Point(224, 19);
            this.txtApellidoTutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoTutor.Name = "txtApellidoTutor";
            this.txtApellidoTutor.Size = new System.Drawing.Size(216, 23);
            this.txtApellidoTutor.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(224, 2);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 17);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellidos";
            // 
            // txtTelefonoTutor
            // 
            this.txtTelefonoTutor.Location = new System.Drawing.Point(441, 19);
            this.txtTelefonoTutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoTutor.Name = "txtTelefonoTutor";
            this.txtTelefonoTutor.Size = new System.Drawing.Size(96, 23);
            this.txtTelefonoTutor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono";
            // 
            // txtMovilTutor
            // 
            this.txtMovilTutor.Location = new System.Drawing.Point(538, 19);
            this.txtMovilTutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovilTutor.Name = "txtMovilTutor";
            this.txtMovilTutor.Size = new System.Drawing.Size(96, 23);
            this.txtMovilTutor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Movil";
            // 
            // txtEmailTutor
            // 
            this.txtEmailTutor.Location = new System.Drawing.Point(635, 19);
            this.txtEmailTutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailTutor.Name = "txtEmailTutor";
            this.txtEmailTutor.Size = new System.Drawing.Size(195, 23);
            this.txtEmailTutor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtNombreTutor
            // 
            this.txtNombreTutor.Location = new System.Drawing.Point(6, 19);
            this.txtNombreTutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTutor.Name = "txtNombreTutor";
            this.txtNombreTutor.Size = new System.Drawing.Size(217, 23);
            this.txtNombreTutor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // grdTutor
            // 
            this.grdTutor.AllowUserToAddRows = false;
            this.grdTutor.AllowUserToDeleteRows = false;
            this.grdTutor.AllowUserToResizeRows = false;
            this.grdTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Movil,
            this.Email,
            this.EsPrincipal,
            this.SocioId});
            this.grdTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdTutor.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grdTutor.Location = new System.Drawing.Point(2, 18);
            this.grdTutor.Margin = new System.Windows.Forms.Padding(2);
            this.grdTutor.MultiSelect = false;
            this.grdTutor.Name = "grdTutor";
            this.grdTutor.ReadOnly = true;
            this.grdTutor.RowHeadersVisible = false;
            this.grdTutor.RowTemplate.Height = 28;
            this.grdTutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTutor.Size = new System.Drawing.Size(832, 105);
            this.grdTutor.TabIndex = 0;
            this.grdTutor.SelectionChanged += new System.EventHandler(this.grdTutor_SelectionChanged_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 180;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Télefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Movil
            // 
            this.Movil.DataPropertyName = "Movil";
            this.Movil.HeaderText = "Móvil";
            this.Movil.Name = "Movil";
            this.Movil.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 130;
            // 
            // EsPrincipal
            // 
            this.EsPrincipal.DataPropertyName = "EsPrincipal";
            this.EsPrincipal.HeaderText = "Principal";
            this.EsPrincipal.Name = "EsPrincipal";
            this.EsPrincipal.ReadOnly = true;
            this.EsPrincipal.Width = 80;
            // 
            // SocioId
            // 
            this.SocioId.DataPropertyName = "SocioId";
            this.SocioId.HeaderText = "SocioId";
            this.SocioId.Name = "SocioId";
            this.SocioId.ReadOnly = true;
            this.SocioId.Visible = false;
            // 
            // pnlImportarSocio
            // 
            this.pnlImportarSocio.Controls.Add(this.label1);
            this.pnlImportarSocio.Controls.Add(this.grdImportarSocios);
            this.pnlImportarSocio.Controls.Add(this.textBox2);
            this.pnlImportarSocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImportarSocio.Location = new System.Drawing.Point(0, 31);
            this.pnlImportarSocio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlImportarSocio.Name = "pnlImportarSocio";
            this.pnlImportarSocio.Size = new System.Drawing.Size(836, 131);
            this.pnlImportarSocio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduzca el nombre o el apellido";
            // 
            // grdImportarSocios
            // 
            this.grdImportarSocios.AllowUserToAddRows = false;
            this.grdImportarSocios.AllowUserToDeleteRows = false;
            this.grdImportarSocios.AllowUserToResizeRows = false;
            this.grdImportarSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdImportarSocios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdImportarSocios.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grdImportarSocios.Location = new System.Drawing.Point(0, 36);
            this.grdImportarSocios.Margin = new System.Windows.Forms.Padding(2);
            this.grdImportarSocios.MultiSelect = false;
            this.grdImportarSocios.Name = "grdImportarSocios";
            this.grdImportarSocios.ReadOnly = true;
            this.grdImportarSocios.RowHeadersVisible = false;
            this.grdImportarSocios.RowTemplate.Height = 28;
            this.grdImportarSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdImportarSocios.Size = new System.Drawing.Size(836, 95);
            this.grdImportarSocios.TabIndex = 1;
            this.grdImportarSocios.SelectionChanged += new System.EventHandler(this.grdImportarSocios_SelectionChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 10);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnImprimir);
            this.pnlButton.Controls.Add(this.btnImportarSocio);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(836, 31);
            this.pnlButton.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))));
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(131, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 28);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir Socio";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImportarSocio
            // 
            this.btnImportarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnImportarSocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))));
            this.btnImportarSocio.FlatAppearance.BorderSize = 2;
            this.btnImportarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarSocio.ForeColor = System.Drawing.Color.White;
            this.btnImportarSocio.Location = new System.Drawing.Point(0, 0);
            this.btnImportarSocio.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportarSocio.Name = "btnImportarSocio";
            this.btnImportarSocio.Size = new System.Drawing.Size(128, 28);
            this.btnImportarSocio.TabIndex = 0;
            this.btnImportarSocio.Text = "Importar Socio";
            this.btnImportarSocio.UseVisualStyleBackColor = false;
            this.btnImportarSocio.Click += new System.EventHandler(this.btnImportarSocio_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 749);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // pnlPie
            // 
            this.pnlPie.Controls.Add(this.BtnGuardarSocio);
            this.pnlPie.Controls.Add(this.BtnEditarSocio);
            this.pnlPie.Controls.Add(this.label8);
            this.pnlPie.Controls.Add(this.txtObservaciones);
            this.pnlPie.Controls.Add(this.chkPagaPorBanco);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPie.Location = new System.Drawing.Point(0, 495);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(836, 100);
            this.pnlPie.TabIndex = 14;
            // 
            // BtnGuardarSocio
            // 
            this.BtnGuardarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.BtnGuardarSocio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardarSocio.FlatAppearance.BorderSize = 2;
            this.BtnGuardarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarSocio.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarSocio.Location = new System.Drawing.Point(708, 38);
            this.BtnGuardarSocio.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardarSocio.Name = "BtnGuardarSocio";
            this.BtnGuardarSocio.Size = new System.Drawing.Size(120, 28);
            this.BtnGuardarSocio.TabIndex = 18;
            this.BtnGuardarSocio.Text = "Guardar";
            this.BtnGuardarSocio.UseVisualStyleBackColor = false;
            this.BtnGuardarSocio.Click += new System.EventHandler(this.BtnGuardarSocio_Click);
            // 
            // BtnEditarSocio
            // 
            this.BtnEditarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.BtnEditarSocio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEditarSocio.FlatAppearance.BorderSize = 2;
            this.BtnEditarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarSocio.ForeColor = System.Drawing.Color.White;
            this.BtnEditarSocio.Location = new System.Drawing.Point(708, 5);
            this.BtnEditarSocio.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEditarSocio.Name = "BtnEditarSocio";
            this.BtnEditarSocio.Size = new System.Drawing.Size(120, 28);
            this.BtnEditarSocio.TabIndex = 17;
            this.BtnEditarSocio.Text = "Editar ";
            this.BtnEditarSocio.UseVisualStyleBackColor = false;
            this.BtnEditarSocio.Click += new System.EventHandler(this.BtnEditarSocio_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(162, 5);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(543, 60);
            this.txtObservaciones.TabIndex = 15;
            // 
            // chkPagaPorBanco
            // 
            this.chkPagaPorBanco.AutoSize = true;
            this.chkPagaPorBanco.ForeColor = System.Drawing.Color.White;
            this.chkPagaPorBanco.Location = new System.Drawing.Point(12, 1);
            this.chkPagaPorBanco.Name = "chkPagaPorBanco";
            this.chkPagaPorBanco.Size = new System.Drawing.Size(144, 21);
            this.chkPagaPorBanco.TabIndex = 14;
            this.chkPagaPorBanco.Text = "Pagado por banco";
            this.chkPagaPorBanco.UseVisualStyleBackColor = true;
            // 
            // FrmSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(836, 566);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlAlumnos);
            this.Controls.Add(this.pnlTutores);
            this.Controls.Add(this.pnlImportarSocio);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmSocio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSocio_FormClosed);
            this.Load += new System.EventHandler(this.FrmSocio_Load);
            this.pnlAlumnos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.pnlTutores.ResumeLayout(false);
            this.pnlEditTutor.ResumeLayout(false);
            this.pnlEditTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTutor)).EndInit();
            this.pnlImportarSocio.ResumeLayout(false);
            this.pnlImportarSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdImportarSocios)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlButton;
        private Control.CustomButton btnImportarSocio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlImportarSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdImportarSocios;
        private System.Windows.Forms.GroupBox pnlTutores;
        private System.Windows.Forms.DataGridView grdTutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreTutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailTutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovilTutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoTutor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellidoTutor;
        private Control.CustomButton btnEditarTutor;
        private Control.CustomButton btnGuardarTutor;
        private System.Windows.Forms.Panel pnlEditTutor;
        private System.Windows.Forms.GroupBox pnlAlumnos;
        private System.Windows.Forms.Panel panel1;
        private Control.CustomButton btnGuardarAlumno;
        private Control.CustomButton btnEditarAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private Control.CustomButton btnNuevoTutor;
        private Control.CustomButton btnNuevoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocioIdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.TextBox txtCursoAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocioId;
        private System.Windows.Forms.TextBox txtTutorId;
        private System.Windows.Forms.TextBox TxtAlumnoId;
        private Control.CustomButton btnImprimir;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservaciones;
        private Control.CustomButton BtnGuardarSocio;
        private Control.CustomButton BtnEditarSocio;
        private System.Windows.Forms.CheckBox chkPagaPorBanco;
    }
}
