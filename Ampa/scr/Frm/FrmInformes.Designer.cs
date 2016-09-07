namespace Ampa.Frm
{
    partial class FrmInformes
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
            this.btnImprimir = new Ampa.Control.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.txtSocioPorClase = new System.Windows.Forms.TextBox();
            this.pnlGrupo = new System.Windows.Forms.Panel();
            this.rdbSecundaria = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rdbInfantil = new System.Windows.Forms.RadioButton();
            this.txtAlumnoPorClase = new System.Windows.Forms.TextBox();
            this.rdbTodosAlumnos = new System.Windows.Forms.RadioButton();
            this.rdbAlumnoPorClase = new System.Windows.Forms.RadioButton();
            this.rdbAlumnoPorGrupo = new System.Windows.Forms.RadioButton();
            this.rdbSociosPorClase = new System.Windows.Forms.RadioButton();
            this.rdbSocioPorGrupo = new System.Windows.Forms.RadioButton();
            this.rdbSociosBanco = new System.Windows.Forms.RadioButton();
            this.rdbSociosObservaciones = new System.Windows.Forms.RadioButton();
            this.rdbCorreos = new System.Windows.Forms.RadioButton();
            this.rdbTodosSocios = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(174, 271);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(117, 39);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtSocioPorClase);
            this.panel2.Controls.Add(this.pnlGrupo);
            this.panel2.Controls.Add(this.txtAlumnoPorClase);
            this.panel2.Controls.Add(this.rdbTodosAlumnos);
            this.panel2.Controls.Add(this.rdbAlumnoPorClase);
            this.panel2.Controls.Add(this.rdbAlumnoPorGrupo);
            this.panel2.Controls.Add(this.rdbSociosPorClase);
            this.panel2.Controls.Add(this.rdbSocioPorGrupo);
            this.panel2.Controls.Add(this.rdbSociosBanco);
            this.panel2.Controls.Add(this.rdbSociosObservaciones);
            this.panel2.Controls.Add(this.rdbCorreos);
            this.panel2.Controls.Add(this.rdbTodosSocios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 265);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Location = new System.Drawing.Point(181, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 30);
            this.panel1.TabIndex = 25;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(175, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "3";
            this.radioButton1.Text = "Secundaria";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(91, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 21);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "2";
            this.radioButton5.Text = "Primaria";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(8, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 21);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "1";
            this.radioButton6.Text = "Infantil";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // txtSocioPorClase
            // 
            this.txtSocioPorClase.Location = new System.Drawing.Point(188, 123);
            this.txtSocioPorClase.Name = "txtSocioPorClase";
            this.txtSocioPorClase.Size = new System.Drawing.Size(113, 23);
            this.txtSocioPorClase.TabIndex = 24;
            // 
            // pnlGrupo
            // 
            this.pnlGrupo.Controls.Add(this.rdbSecundaria);
            this.pnlGrupo.Controls.Add(this.radioButton7);
            this.pnlGrupo.Controls.Add(this.rdbInfantil);
            this.pnlGrupo.Location = new System.Drawing.Point(180, 91);
            this.pnlGrupo.Name = "pnlGrupo";
            this.pnlGrupo.Size = new System.Drawing.Size(282, 30);
            this.pnlGrupo.TabIndex = 23;
            // 
            // rdbSecundaria
            // 
            this.rdbSecundaria.AutoSize = true;
            this.rdbSecundaria.Location = new System.Drawing.Point(175, 5);
            this.rdbSecundaria.Name = "rdbSecundaria";
            this.rdbSecundaria.Size = new System.Drawing.Size(98, 21);
            this.rdbSecundaria.TabIndex = 9;
            this.rdbSecundaria.TabStop = true;
            this.rdbSecundaria.Tag = "3";
            this.rdbSecundaria.Text = "Secundaria";
            this.rdbSecundaria.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(91, 4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(78, 21);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "2";
            this.radioButton7.Text = "Primaria";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rdbInfantil
            // 
            this.rdbInfantil.AutoSize = true;
            this.rdbInfantil.Location = new System.Drawing.Point(8, 2);
            this.rdbInfantil.Name = "rdbInfantil";
            this.rdbInfantil.Size = new System.Drawing.Size(67, 21);
            this.rdbInfantil.TabIndex = 6;
            this.rdbInfantil.TabStop = true;
            this.rdbInfantil.Tag = "1";
            this.rdbInfantil.Text = "Infantil";
            this.rdbInfantil.UseVisualStyleBackColor = true;
            // 
            // txtAlumnoPorClase
            // 
            this.txtAlumnoPorClase.Location = new System.Drawing.Point(188, 65);
            this.txtAlumnoPorClase.Name = "txtAlumnoPorClase";
            this.txtAlumnoPorClase.Size = new System.Drawing.Size(113, 23);
            this.txtAlumnoPorClase.TabIndex = 22;
            // 
            // rdbTodosAlumnos
            // 
            this.rdbTodosAlumnos.AutoSize = true;
            this.rdbTodosAlumnos.Location = new System.Drawing.Point(28, 38);
            this.rdbTodosAlumnos.Name = "rdbTodosAlumnos";
            this.rdbTodosAlumnos.Size = new System.Drawing.Size(145, 21);
            this.rdbTodosAlumnos.TabIndex = 21;
            this.rdbTodosAlumnos.TabStop = true;
            this.rdbTodosAlumnos.Text = "Todos los alumnos";
            this.rdbTodosAlumnos.UseVisualStyleBackColor = true;
            // 
            // rdbAlumnoPorClase
            // 
            this.rdbAlumnoPorClase.AutoSize = true;
            this.rdbAlumnoPorClase.Location = new System.Drawing.Point(28, 65);
            this.rdbAlumnoPorClase.Name = "rdbAlumnoPorClase";
            this.rdbAlumnoPorClase.Size = new System.Drawing.Size(142, 21);
            this.rdbAlumnoPorClase.TabIndex = 20;
            this.rdbAlumnoPorClase.TabStop = true;
            this.rdbAlumnoPorClase.Text = "Alumnos por clase";
            this.rdbAlumnoPorClase.UseVisualStyleBackColor = true;
            // 
            // rdbAlumnoPorGrupo
            // 
            this.rdbAlumnoPorGrupo.AutoSize = true;
            this.rdbAlumnoPorGrupo.Location = new System.Drawing.Point(28, 92);
            this.rdbAlumnoPorGrupo.Name = "rdbAlumnoPorGrupo";
            this.rdbAlumnoPorGrupo.Size = new System.Drawing.Size(146, 21);
            this.rdbAlumnoPorGrupo.TabIndex = 19;
            this.rdbAlumnoPorGrupo.TabStop = true;
            this.rdbAlumnoPorGrupo.Text = "Alumnos por grupo";
            this.rdbAlumnoPorGrupo.UseVisualStyleBackColor = true;
            // 
            // rdbSociosPorClase
            // 
            this.rdbSociosPorClase.AutoSize = true;
            this.rdbSociosPorClase.Location = new System.Drawing.Point(28, 124);
            this.rdbSociosPorClase.Name = "rdbSociosPorClase";
            this.rdbSociosPorClase.Size = new System.Drawing.Size(130, 21);
            this.rdbSociosPorClase.TabIndex = 18;
            this.rdbSociosPorClase.TabStop = true;
            this.rdbSociosPorClase.Text = "Socios por clase";
            this.rdbSociosPorClase.UseVisualStyleBackColor = true;
            // 
            // rdbSocioPorGrupo
            // 
            this.rdbSocioPorGrupo.AutoSize = true;
            this.rdbSocioPorGrupo.Location = new System.Drawing.Point(28, 151);
            this.rdbSocioPorGrupo.Name = "rdbSocioPorGrupo";
            this.rdbSocioPorGrupo.Size = new System.Drawing.Size(141, 21);
            this.rdbSocioPorGrupo.TabIndex = 17;
            this.rdbSocioPorGrupo.TabStop = true;
            this.rdbSocioPorGrupo.Text = "Socios por grupos";
            this.rdbSocioPorGrupo.UseVisualStyleBackColor = true;
            // 
            // rdbSociosBanco
            // 
            this.rdbSociosBanco.AutoSize = true;
            this.rdbSociosBanco.Location = new System.Drawing.Point(28, 178);
            this.rdbSociosBanco.Name = "rdbSociosBanco";
            this.rdbSociosBanco.Size = new System.Drawing.Size(208, 21);
            this.rdbSociosBanco.TabIndex = 16;
            this.rdbSociosBanco.TabStop = true;
            this.rdbSociosBanco.Text = "Socios que pagan por banco";
            this.rdbSociosBanco.UseVisualStyleBackColor = true;
            // 
            // rdbSociosObservaciones
            // 
            this.rdbSociosObservaciones.AutoSize = true;
            this.rdbSociosObservaciones.Location = new System.Drawing.Point(28, 205);
            this.rdbSociosObservaciones.Name = "rdbSociosObservaciones";
            this.rdbSociosObservaciones.Size = new System.Drawing.Size(191, 21);
            this.rdbSociosObservaciones.TabIndex = 15;
            this.rdbSociosObservaciones.TabStop = true;
            this.rdbSociosObservaciones.Text = "Socios con observaciones";
            this.rdbSociosObservaciones.UseVisualStyleBackColor = true;
            // 
            // rdbCorreos
            // 
            this.rdbCorreos.AutoSize = true;
            this.rdbCorreos.Location = new System.Drawing.Point(28, 232);
            this.rdbCorreos.Name = "rdbCorreos";
            this.rdbCorreos.Size = new System.Drawing.Size(212, 21);
            this.rdbCorreos.TabIndex = 14;
            this.rdbCorreos.TabStop = true;
            this.rdbCorreos.Text = "Listados de todos los correos";
            this.rdbCorreos.UseVisualStyleBackColor = true;
            // 
            // rdbTodosSocios
            // 
            this.rdbTodosSocios.AutoSize = true;
            this.rdbTodosSocios.Location = new System.Drawing.Point(28, 11);
            this.rdbTodosSocios.Name = "rdbTodosSocios";
            this.rdbTodosSocios.Size = new System.Drawing.Size(132, 21);
            this.rdbTodosSocios.TabIndex = 13;
            this.rdbTodosSocios.TabStop = true;
            this.rdbTodosSocios.Text = "Todos los socios";
            this.rdbTodosSocios.UseVisualStyleBackColor = true;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnImprimir);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGrupo.ResumeLayout(false);
            this.pnlGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.CustomButton btnImprimir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox txtSocioPorClase;
        private System.Windows.Forms.Panel pnlGrupo;
        private System.Windows.Forms.RadioButton rdbSecundaria;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rdbInfantil;
        private System.Windows.Forms.TextBox txtAlumnoPorClase;
        private System.Windows.Forms.RadioButton rdbTodosAlumnos;
        private System.Windows.Forms.RadioButton rdbAlumnoPorClase;
        private System.Windows.Forms.RadioButton rdbAlumnoPorGrupo;
        private System.Windows.Forms.RadioButton rdbSociosPorClase;
        private System.Windows.Forms.RadioButton rdbSocioPorGrupo;
        private System.Windows.Forms.RadioButton rdbSociosBanco;
        private System.Windows.Forms.RadioButton rdbSociosObservaciones;
        private System.Windows.Forms.RadioButton rdbCorreos;
        private System.Windows.Forms.RadioButton rdbTodosSocios;
    }
}