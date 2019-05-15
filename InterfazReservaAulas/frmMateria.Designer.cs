namespace InterfazReservaAulas
{
    partial class frmMateria
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
            this.lblMateria_ID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMateria_ID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTituloMenuMateria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMateria_ID
            // 
            this.lblMateria_ID.AutoSize = true;
            this.lblMateria_ID.Location = new System.Drawing.Point(43, 68);
            this.lblMateria_ID.Name = "lblMateria_ID";
            this.lblMateria_ID.Size = new System.Drawing.Size(77, 13);
            this.lblMateria_ID.TabIndex = 0;
            this.lblMateria_ID.Text = "Código materia";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 116);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(81, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Nombre materia";
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(12, 154);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.Size = new System.Drawing.Size(420, 164);
            this.dgvMateria.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(357, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtMateria_ID
            // 
            this.txtMateria_ID.Enabled = false;
            this.txtMateria_ID.Location = new System.Drawing.Point(151, 65);
            this.txtMateria_ID.Name = "txtMateria_ID";
            this.txtMateria_ID.Size = new System.Drawing.Size(100, 20);
            this.txtMateria_ID.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 116);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(266, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(266, 116);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(357, 116);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTituloMenuMateria
            // 
            this.lblTituloMenuMateria.AutoSize = true;
            this.lblTituloMenuMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenuMateria.Location = new System.Drawing.Point(105, 9);
            this.lblTituloMenuMateria.Name = "lblTituloMenuMateria";
            this.lblTituloMenuMateria.Size = new System.Drawing.Size(236, 24);
            this.lblTituloMenuMateria.TabIndex = 9;
            this.lblTituloMenuMateria.Text = "Mantenimiento de Materias";
            this.lblTituloMenuMateria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 372);
            this.Controls.Add(this.lblTituloMenuMateria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMateria_ID);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMateria_ID);
            this.Name = "frmMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materia";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateria_ID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMateria_ID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTituloMenuMateria;
    }
}