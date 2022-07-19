namespace FormClubFutbol
{
    partial class FormEstadisticas
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
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.dgv_estadisticas = new System.Windows.Forms.DataGridView();
            this.bt_cargaSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cerrar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cerrar.Location = new System.Drawing.Point(12, 268);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(185, 45);
            this.bt_cerrar.TabIndex = 36;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // dgv_estadisticas
            // 
            this.dgv_estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadisticas.Location = new System.Drawing.Point(12, 12);
            this.dgv_estadisticas.Name = "dgv_estadisticas";
            this.dgv_estadisticas.RowTemplate.Height = 25;
            this.dgv_estadisticas.Size = new System.Drawing.Size(1123, 230);
            this.dgv_estadisticas.TabIndex = 39;
            // 
            // bt_cargaSQL
            // 
            this.bt_cargaSQL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cargaSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cargaSQL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cargaSQL.Location = new System.Drawing.Point(298, 268);
            this.bt_cargaSQL.Name = "bt_cargaSQL";
            this.bt_cargaSQL.Size = new System.Drawing.Size(185, 45);
            this.bt_cargaSQL.TabIndex = 40;
            this.bt_cargaSQL.Text = "CARGA SQL";
            this.bt_cargaSQL.UseVisualStyleBackColor = false;
            this.bt_cargaSQL.Click += new System.EventHandler(this.bt_cargaSQL_Click);
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1147, 319);
            this.Controls.Add(this.bt_cargaSQL);
            this.Controls.Add(this.dgv_estadisticas);
            this.Controls.Add(this.bt_cerrar);
            this.Name = "FormEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADISTICAS";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.DataGridView dgv_estadisticas;
        private System.Windows.Forms.Button bt_cargaSQL;
    }
}