namespace FormClubFutbol
{
    partial class FormIngreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_rellenarUsuario = new System.Windows.Forms.Button();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_rellenarUsuario
            // 
            this.bt_rellenarUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_rellenarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_rellenarUsuario.Location = new System.Drawing.Point(156, 111);
            this.bt_rellenarUsuario.Name = "bt_rellenarUsuario";
            this.bt_rellenarUsuario.Size = new System.Drawing.Size(115, 71);
            this.bt_rellenarUsuario.TabIndex = 9;
            this.bt_rellenarUsuario.Text = "AutoCompletar";
            this.bt_rellenarUsuario.UseVisualStyleBackColor = false;
            this.bt_rellenarUsuario.Click += new System.EventHandler(this.bt_rellenarUsuario_Click);
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cerrar.Location = new System.Drawing.Point(85, 222);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(115, 39);
            this.bt_cerrar.TabIndex = 8;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ingresar.Location = new System.Drawing.Point(229, 222);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(115, 39);
            this.bt_ingresar.TabIndex = 7;
            this.bt_ingresar.Text = "INGRESAR";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pass.Location = new System.Drawing.Point(85, 66);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PlaceholderText = "                   CONTRASEÑA";
            this.txt_pass.Size = new System.Drawing.Size(259, 29);
            this.txt_pass.TabIndex = 6;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(85, 12);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "                       USUARIO";
            this.txt_usuario.Size = new System.Drawing.Size(259, 29);
            this.txt_usuario.TabIndex = 5;
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(439, 267);
            this.Controls.Add(this.bt_rellenarUsuario);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Name = "FormIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngreso_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_rellenarUsuario;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_usuario;
    }
}
