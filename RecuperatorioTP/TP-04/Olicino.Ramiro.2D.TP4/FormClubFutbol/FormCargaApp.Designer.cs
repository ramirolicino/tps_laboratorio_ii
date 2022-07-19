namespace FormClubFutbol
{
    partial class FormCargaApp
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
            this.lb_carga = new System.Windows.Forms.Label();
            this.picture_carga = new System.Windows.Forms.PictureBox();
            this.pb_cargaApp = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_hola = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_carga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_carga
            // 
            this.lb_carga.AutoSize = true;
            this.lb_carga.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_carga.Location = new System.Drawing.Point(12, 310);
            this.lb_carga.Name = "lb_carga";
            this.lb_carga.Size = new System.Drawing.Size(61, 20);
            this.lb_carga.TabIndex = 0;
            this.lb_carga.Text = "CARGA";
            // 
            // picture_carga
            // 
            this.picture_carga.Image = global::FormClubFutbol.Properties.Resources.loading;
            this.picture_carga.Location = new System.Drawing.Point(155, 12);
            this.picture_carga.Name = "picture_carga";
            this.picture_carga.Size = new System.Drawing.Size(199, 157);
            this.picture_carga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_carga.TabIndex = 1;
            this.picture_carga.TabStop = false;
            // 
            // pb_cargaApp
            // 
            this.pb_cargaApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_cargaApp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pb_cargaApp.ForeColor = System.Drawing.Color.SeaGreen;
            this.pb_cargaApp.Location = new System.Drawing.Point(12, 333);
            this.pb_cargaApp.Name = "pb_cargaApp";
            this.pb_cargaApp.Size = new System.Drawing.Size(486, 23);
            this.pb_cargaApp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_cargaApp.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormClubFutbol.Properties.Resources.puerta;
            this.pictureBox2.Location = new System.Drawing.Point(155, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // lbl_hola
            // 
            this.lbl_hola.AutoSize = true;
            this.lbl_hola.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_hola.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_hola.Location = new System.Drawing.Point(152, 209);
            this.lbl_hola.Name = "lbl_hola";
            this.lbl_hola.Size = new System.Drawing.Size(225, 41);
            this.lbl_hola.TabIndex = 4;
            this.lbl_hola.Text = "BIENVENIDO...";
            this.lbl_hola.Visible = false;
            // 
            // FormCargaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.lbl_hola);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_cargaApp);
            this.Controls.Add(this.picture_carga);
            this.Controls.Add(this.lb_carga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCargaApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_carga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_carga;
        private System.Windows.Forms.PictureBox picture_carga;
        private System.Windows.Forms.ProgressBar pb_cargaApp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_hola;
    }
}