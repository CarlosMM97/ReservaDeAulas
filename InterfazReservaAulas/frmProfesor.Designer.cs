namespace ReservaDeAulasInterfaz
{
    partial class frmProfesor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProfesor_ID = new System.Windows.Forms.Label();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtProfesor_ID = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.Profesor_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesor_ID
            // 
            this.lblProfesor_ID.AutoSize = true;
            this.lblProfesor_ID.Location = new System.Drawing.Point(31, 31);
            this.lblProfesor_ID.Name = "lblProfesor_ID";
            this.lblProfesor_ID.Size = new System.Drawing.Size(68, 13);
            this.lblProfesor_ID.TabIndex = 0;
            this.lblProfesor_ID.Text = "Cod Profesor";
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Location = new System.Drawing.Point(31, 73);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroDoc.TabIndex = 1;
            this.lblNumeroDoc.Text = "Nº de documento";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(31, 167);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(92, 13);
            this.lblNombreApellido.TabIndex = 2;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(31, 206);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNac.TabIndex = 3;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 242);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(31, 117);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(99, 13);
            this.lblTipoDoc.TabIndex = 5;
            this.lblTipoDoc.Text = "Tipo de documento";
            // 
            // txtProfesor_ID
            // 
            this.txtProfesor_ID.Enabled = false;
            this.txtProfesor_ID.Location = new System.Drawing.Point(169, 31);
            this.txtProfesor_ID.Name = "txtProfesor_ID";
            this.txtProfesor_ID.Size = new System.Drawing.Size(36, 20);
            this.txtProfesor_ID.TabIndex = 6;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(169, 73);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(121, 20);
            this.txtNroDoc.TabIndex = 7;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(169, 167);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(121, 20);
            this.txtNombreApellido.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(169, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(169, 206);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaNac.TabIndex = 10;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(169, 117);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoDocumento.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 283);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(255, 283);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(155, 283);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(361, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profesor_ID,
            this.NroDoc,
            this.TipoDoc,
            this.NombreApellido,
            this.FechaNac,
            this.Email});
            this.dgvProfesores.Location = new System.Drawing.Point(3, 312);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(643, 191);
            this.dgvProfesores.TabIndex = 16;
            // 
            // Profesor_ID
            // 
            this.Profesor_ID.HeaderText = "Cod Profesor";
            this.Profesor_ID.Name = "Profesor_ID";
            // 
            // NroDoc
            // 
            this.NroDoc.HeaderText = "Numero Documento";
            this.NroDoc.Name = "NroDoc";
            // 
            // TipoDoc
            // 
            this.TipoDoc.HeaderText = "Tipo de documento";
            this.TipoDoc.Name = "TipoDoc";
            // 
            // NombreApellido
            // 
            this.NombreApellido.HeaderText = "Nombre y Apellido";
            this.NombreApellido.Name = "NombreApellido";
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha de Nacimiento";
            this.FechaNac.Name = "FechaNac";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 502);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxTipoDocumento);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtProfesor_ID);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.lblNumeroDoc);
            this.Controls.Add(this.lblProfesor_ID);
            this.Name = "frmProfesor";
            this.Text = "Mantenimiento de Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesor_ID;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtProfesor_ID;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

