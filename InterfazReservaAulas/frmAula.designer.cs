namespace ReservaDeAulasInterfaz
{
    partial class frmAula
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.txtNroAula_ID = new System.Windows.Forms.TextBox();
            this.lblTipoAula = new System.Windows.Forms.Label();
            this.lblCantidadAlumnos = new System.Windows.Forms.Label();
            this.lblNroAula_ID = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.cboPiso = new System.Windows.Forms.ComboBox();
            this.gbxProyector = new System.Windows.Forms.GroupBox();
            this.rdbNoPoseeProyector = new System.Windows.Forms.RadioButton();
            this.rdbPoseeProyector = new System.Windows.Forms.RadioButton();
            this.dgvAula = new System.Windows.Forms.DataGridView();
            this.cboTipoAula = new System.Windows.Forms.ComboBox();
            this.gbxProyector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(309, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(103, 236);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(203, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 236);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtCantidadAlumnos
            // 
            this.txtCantidadAlumnos.Location = new System.Drawing.Point(150, 73);
            this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            this.txtCantidadAlumnos.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadAlumnos.TabIndex = 23;
            // 
            // txtNroAula_ID
            // 
            this.txtNroAula_ID.Location = new System.Drawing.Point(150, 31);
            this.txtNroAula_ID.Name = "txtNroAula_ID";
            this.txtNroAula_ID.Size = new System.Drawing.Size(36, 20);
            this.txtNroAula_ID.TabIndex = 22;
            // 
            // lblTipoAula
            // 
            this.lblTipoAula.AutoSize = true;
            this.lblTipoAula.Location = new System.Drawing.Point(12, 114);
            this.lblTipoAula.Name = "lblTipoAula";
            this.lblTipoAula.Size = new System.Drawing.Size(66, 13);
            this.lblTipoAula.TabIndex = 18;
            this.lblTipoAula.Text = "Tipo de aula";
            // 
            // lblCantidadAlumnos
            // 
            this.lblCantidadAlumnos.AutoSize = true;
            this.lblCantidadAlumnos.Location = new System.Drawing.Point(12, 73);
            this.lblCantidadAlumnos.Name = "lblCantidadAlumnos";
            this.lblCantidadAlumnos.Size = new System.Drawing.Size(106, 13);
            this.lblCantidadAlumnos.TabIndex = 17;
            this.lblCantidadAlumnos.Text = "Cantidad de alumnos";
            // 
            // lblNroAula_ID
            // 
            this.lblNroAula_ID.AutoSize = true;
            this.lblNroAula_ID.Location = new System.Drawing.Point(12, 31);
            this.lblNroAula_ID.Name = "lblNroAula_ID";
            this.lblNroAula_ID.Size = new System.Drawing.Size(57, 13);
            this.lblNroAula_ID.TabIndex = 16;
            this.lblNroAula_ID.Text = "Nº de aula";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(12, 148);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 21;
            this.lblPiso.Text = "Piso";
            // 
            // cboPiso
            // 
            this.cboPiso.FormattingEnabled = true;
            this.cboPiso.Location = new System.Drawing.Point(150, 148);
            this.cboPiso.Name = "cboPiso";
            this.cboPiso.Size = new System.Drawing.Size(121, 21);
            this.cboPiso.TabIndex = 27;
            // 
            // gbxProyector
            // 
            this.gbxProyector.Controls.Add(this.rdbNoPoseeProyector);
            this.gbxProyector.Controls.Add(this.rdbPoseeProyector);
            this.gbxProyector.Location = new System.Drawing.Point(12, 175);
            this.gbxProyector.Name = "gbxProyector";
            this.gbxProyector.Size = new System.Drawing.Size(273, 47);
            this.gbxProyector.TabIndex = 32;
            this.gbxProyector.TabStop = false;
            this.gbxProyector.Text = "Proyector";
            // 
            // rdbNoPoseeProyector
            // 
            this.rdbNoPoseeProyector.AutoSize = true;
            this.rdbNoPoseeProyector.Location = new System.Drawing.Point(147, 18);
            this.rdbNoPoseeProyector.Name = "rdbNoPoseeProyector";
            this.rdbNoPoseeProyector.Size = new System.Drawing.Size(118, 17);
            this.rdbNoPoseeProyector.TabIndex = 1;
            this.rdbNoPoseeProyector.TabStop = true;
            this.rdbNoPoseeProyector.Text = "No posee proyector";
            this.rdbNoPoseeProyector.UseVisualStyleBackColor = true;
            // 
            // rdbPoseeProyector
            // 
            this.rdbPoseeProyector.AutoSize = true;
            this.rdbPoseeProyector.Location = new System.Drawing.Point(14, 19);
            this.rdbPoseeProyector.Name = "rdbPoseeProyector";
            this.rdbPoseeProyector.Size = new System.Drawing.Size(103, 17);
            this.rdbPoseeProyector.TabIndex = 0;
            this.rdbPoseeProyector.TabStop = true;
            this.rdbPoseeProyector.Text = "Posee Proyector";
            this.rdbPoseeProyector.UseVisualStyleBackColor = true;
            // 
            // dgvAula
            // 
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(3, 265);
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.Size = new System.Drawing.Size(544, 247);
            this.dgvAula.TabIndex = 33;
            this.dgvAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAula_CellClick);
            // 
            // cboTipoAula
            // 
            this.cboTipoAula.FormattingEnabled = true;
            this.cboTipoAula.Location = new System.Drawing.Point(150, 111);
            this.cboTipoAula.Name = "cboTipoAula";
            this.cboTipoAula.Size = new System.Drawing.Size(121, 21);
            this.cboTipoAula.TabIndex = 34;
            // 
            // frmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 513);
            this.Controls.Add(this.cboTipoAula);
            this.Controls.Add(this.dgvAula);
            this.Controls.Add(this.gbxProyector);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboPiso);
            this.Controls.Add(this.txtCantidadAlumnos);
            this.Controls.Add(this.txtNroAula_ID);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblTipoAula);
            this.Controls.Add(this.lblCantidadAlumnos);
            this.Controls.Add(this.lblNroAula_ID);
            this.Name = "frmAula";
            this.Text = "Mantenimiento de Aulas";
            this.Load += new System.EventHandler(this.frmAula_Load);
            this.gbxProyector.ResumeLayout(false);
            this.gbxProyector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidadAlumnos;
        private System.Windows.Forms.TextBox txtNroAula_ID;
        private System.Windows.Forms.Label lblTipoAula;
        private System.Windows.Forms.Label lblCantidadAlumnos;
        private System.Windows.Forms.Label lblNroAula_ID;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.ComboBox cboPiso;
        private System.Windows.Forms.GroupBox gbxProyector;
        private System.Windows.Forms.RadioButton rdbNoPoseeProyector;
        private System.Windows.Forms.RadioButton rdbPoseeProyector;
        private System.Windows.Forms.DataGridView dgvAula;
        private System.Windows.Forms.ComboBox cboTipoAula;
    }
}