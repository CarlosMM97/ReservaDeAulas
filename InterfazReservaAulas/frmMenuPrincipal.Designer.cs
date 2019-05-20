namespace InterfazReservaAulas
{
    partial class frmMenuPrincipal
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
            this.mstMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbmAula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbmProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenuPrincipal
            // 
            this.mstMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.mstMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstMenuPrincipal.Name = "mstMenuPrincipal";
            this.mstMenuPrincipal.Size = new System.Drawing.Size(700, 24);
            this.mstMenuPrincipal.TabIndex = 1;
            this.mstMenuPrincipal.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbmAula,
            this.tsmMateria,
            this.tsmAbmProfesores});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // tsmAbmAula
            // 
            this.tsmAbmAula.Name = "tsmAbmAula";
            this.tsmAbmAula.Size = new System.Drawing.Size(214, 22);
            this.tsmAbmAula.Text = "Mantenimiento de Aulas";
            this.tsmAbmAula.Click += new System.EventHandler(this.tsmAbmAula_Click);
            // 
            // tsmMateria
            // 
            this.tsmMateria.Name = "tsmMateria";
            this.tsmMateria.Size = new System.Drawing.Size(214, 22);
            this.tsmMateria.Text = "Materia";
            this.tsmMateria.Click += new System.EventHandler(this.tsmMateria_Click);
            // 
            // tsmAbmProfesores
            // 
            this.tsmAbmProfesores.Name = "tsmAbmProfesores";
            this.tsmAbmProfesores.Size = new System.Drawing.Size(214, 22);
            this.tsmAbmProfesores.Text = "Mantenimiento Profesores";
            this.tsmAbmProfesores.Click += new System.EventHandler(this.tsmAbmProfesores_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 504);
            this.Controls.Add(this.mstMenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMenuPrincipal;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstMenuPrincipal.ResumeLayout(false);
            this.mstMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAbmAula;
        private System.Windows.Forms.ToolStripMenuItem tsmMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmAbmProfesores;
    }
}