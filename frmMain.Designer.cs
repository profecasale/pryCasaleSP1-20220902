namespace pryCasaleSP1
{
    partial class frmMain
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbOficio = new System.Windows.Forms.GroupBox();
            this.rbDesarrollo = new System.Windows.Forms.RadioButton();
            this.rbAdmRed = new System.Windows.Forms.RadioButton();
            this.rbDevOp = new System.Windows.Forms.RadioButton();
            this.rbAdminBD = new System.Windows.Forms.RadioButton();
            this.gbOficio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 31);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 38);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(268, 307);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(189, 48);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gbOficio
            // 
            this.gbOficio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbOficio.Controls.Add(this.rbAdminBD);
            this.gbOficio.Controls.Add(this.rbDevOp);
            this.gbOficio.Controls.Add(this.rbAdmRed);
            this.gbOficio.Controls.Add(this.rbDesarrollo);
            this.gbOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOficio.Location = new System.Drawing.Point(27, 96);
            this.gbOficio.Name = "gbOficio";
            this.gbOficio.Size = new System.Drawing.Size(430, 168);
            this.gbOficio.TabIndex = 3;
            this.gbOficio.TabStop = false;
            this.gbOficio.Text = "Oficio";
            // 
            // rbDesarrollo
            // 
            this.rbDesarrollo.AutoSize = true;
            this.rbDesarrollo.Location = new System.Drawing.Point(35, 50);
            this.rbDesarrollo.Name = "rbDesarrollo";
            this.rbDesarrollo.Size = new System.Drawing.Size(195, 35);
            this.rbDesarrollo.TabIndex = 0;
            this.rbDesarrollo.TabStop = true;
            this.rbDesarrollo.Text = "Desarrollador";
            this.rbDesarrollo.UseVisualStyleBackColor = true;
            // 
            // rbAdmRed
            // 
            this.rbAdmRed.AutoSize = true;
            this.rbAdmRed.Location = new System.Drawing.Point(241, 50);
            this.rbAdmRed.Name = "rbAdmRed";
            this.rbAdmRed.Size = new System.Drawing.Size(165, 35);
            this.rbAdmRed.TabIndex = 1;
            this.rbAdmRed.TabStop = true;
            this.rbAdmRed.Text = "Admin Red";
            this.rbAdmRed.UseVisualStyleBackColor = true;
            this.rbAdmRed.CheckedChanged += new System.EventHandler(this.rbAdmRed_CheckedChanged);
            this.rbAdmRed.Click += new System.EventHandler(this.rbAdmRed_Click);
            // 
            // rbDevOp
            // 
            this.rbDevOp.AutoSize = true;
            this.rbDevOp.Location = new System.Drawing.Point(35, 113);
            this.rbDevOp.Name = "rbDevOp";
            this.rbDevOp.Size = new System.Drawing.Size(170, 35);
            this.rbDevOp.TabIndex = 2;
            this.rbDevOp.TabStop = true;
            this.rbDevOp.Text = "Admin Infra";
            this.rbDevOp.UseVisualStyleBackColor = true;
            // 
            // rbAdminBD
            // 
            this.rbAdminBD.AutoSize = true;
            this.rbAdminBD.Location = new System.Drawing.Point(241, 113);
            this.rbAdminBD.Name = "rbAdminBD";
            this.rbAdminBD.Size = new System.Drawing.Size(191, 35);
            this.rbAdminBD.TabIndex = 3;
            this.rbAdminBD.TabStop = true;
            this.rbAdminBD.Text = "Admin Bases";
            this.rbAdminBD.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 367);
            this.Controls.Add(this.gbOficio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uso de controles en VS";
            this.gbOficio.ResumeLayout(false);
            this.gbOficio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbOficio;
        private System.Windows.Forms.RadioButton rbAdminBD;
        private System.Windows.Forms.RadioButton rbDevOp;
        private System.Windows.Forms.RadioButton rbAdmRed;
        private System.Windows.Forms.RadioButton rbDesarrollo;
    }
}

