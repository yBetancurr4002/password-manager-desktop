namespace password_manager
{
    partial class Form1
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
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtNombreApp = new System.Windows.Forms.TextBox();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.txtContrasenaGenerada = new System.Windows.Forms.TextBox();
            this.btnVerContrasenas = new System.Windows.Forms.Button();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(66, 27);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(402, 31);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "Administrador de contraseñas";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(226, 228);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(111, 32);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtNombreApp
            // 
            this.txtNombreApp.Location = new System.Drawing.Point(329, 109);
            this.txtNombreApp.Name = "txtNombreApp";
            this.txtNombreApp.Size = new System.Drawing.Size(184, 20);
            this.txtNombreApp.TabIndex = 2;
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.Location = new System.Drawing.Point(68, 104);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(178, 24);
            this.lblNombreApp.TabIndex = 3;
            this.lblNombreApp.Text = "Nombre de la app";
            // 
            // txtContrasenaGenerada
            // 
            this.txtContrasenaGenerada.Location = new System.Drawing.Point(191, 291);
            this.txtContrasenaGenerada.Name = "txtContrasenaGenerada";
            this.txtContrasenaGenerada.ReadOnly = true;
            this.txtContrasenaGenerada.Size = new System.Drawing.Size(184, 20);
            this.txtContrasenaGenerada.TabIndex = 4;
            // 
            // btnVerContrasenas
            // 
            this.btnVerContrasenas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVerContrasenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerContrasenas.Location = new System.Drawing.Point(329, 362);
            this.btnVerContrasenas.Name = "btnVerContrasenas";
            this.btnVerContrasenas.Size = new System.Drawing.Size(162, 32);
            this.btnVerContrasenas.TabIndex = 5;
            this.btnVerContrasenas.Text = "Ver contraseñas";
            this.btnVerContrasenas.UseVisualStyleBackColor = false;
            this.btnVerContrasenas.Click += new System.EventHandler(this.btnVerContrasenas_Click);
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.Location = new System.Drawing.Point(68, 166);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(225, 24);
            this.lblLongitud.TabIndex = 7;
            this.lblLongitud.Text = "Cantidad de caracteres";
            this.lblLongitud.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(329, 166);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(184, 20);
            this.txtLongitud.TabIndex = 6;
            this.txtLongitud.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(84, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 32);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(576, 440);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.btnVerContrasenas);
            this.Controls.Add(this.txtContrasenaGenerada);
            this.Controls.Add(this.lblNombreApp);
            this.Controls.Add(this.txtNombreApp);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Name = "Form1";
            this.Text = "Crea tus contraseñas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtNombreApp;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.TextBox txtContrasenaGenerada;
        private System.Windows.Forms.Button btnVerContrasenas;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Button btnGuardar;
    }
}

