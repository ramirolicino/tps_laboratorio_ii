namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.bt_operar = new System.Windows.Forms.Button();
            this.cb_operadores = new System.Windows.Forms.ComboBox();
            this.lst_resultados = new System.Windows.Forms.ListBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.bt_binario = new System.Windows.Forms.Button();
            this.bt_decimal = new System.Windows.Forms.Button();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num1.Location = new System.Drawing.Point(10, 49);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 34);
            this.txt_num1.TabIndex = 1;
            // 
            // bt_operar
            // 
            this.bt_operar.Location = new System.Drawing.Point(10, 144);
            this.bt_operar.Name = "bt_operar";
            this.bt_operar.Size = new System.Drawing.Size(100, 46);
            this.bt_operar.TabIndex = 4;
            this.bt_operar.Text = "OPERAR";
            this.bt_operar.UseVisualStyleBackColor = true;
            this.bt_operar.Click += new System.EventHandler(this.bt_operar_Click);
            // 
            // cb_operadores
            // 
            this.cb_operadores.AllowDrop = true;
            this.cb_operadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operadores.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_operadores.FormattingEnabled = true;
            this.cb_operadores.Items.AddRange(new object[] {
            " ",
            "+",
            "-",
            "/",
            "*"});
            this.cb_operadores.Location = new System.Drawing.Point(161, 47);
            this.cb_operadores.Name = "cb_operadores";
            this.cb_operadores.Size = new System.Drawing.Size(100, 36);
            this.cb_operadores.TabIndex = 2;
            // 
            // lst_resultados
            // 
            this.lst_resultados.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_resultados.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_resultados.FormattingEnabled = true;
            this.lst_resultados.ItemHeight = 17;
            this.lst_resultados.Location = new System.Drawing.Point(437, 47);
            this.lst_resultados.Name = "lst_resultados";
            this.lst_resultados.Size = new System.Drawing.Size(165, 293);
            this.lst_resultados.TabIndex = 9;
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num2.Location = new System.Drawing.Point(314, 49);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 34);
            this.txt_num2.TabIndex = 3;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.Location = new System.Drawing.Point(314, 144);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(100, 46);
            this.bt_cerrar.TabIndex = 6;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // bt_binario
            // 
            this.bt_binario.Location = new System.Drawing.Point(10, 219);
            this.bt_binario.Name = "bt_binario";
            this.bt_binario.Size = new System.Drawing.Size(193, 46);
            this.bt_binario.TabIndex = 7;
            this.bt_binario.Text = "Convertir a BINARIO";
            this.bt_binario.UseVisualStyleBackColor = true;
            this.bt_binario.Click += new System.EventHandler(this.bt_binario_Click);
            // 
            // bt_decimal
            // 
            this.bt_decimal.Location = new System.Drawing.Point(221, 219);
            this.bt_decimal.Name = "bt_decimal";
            this.bt_decimal.Size = new System.Drawing.Size(193, 46);
            this.bt_decimal.TabIndex = 8;
            this.bt_decimal.Text = "Convertir a DECIMAL";
            this.bt_decimal.UseVisualStyleBackColor = true;
            this.bt_decimal.Click += new System.EventHandler(this.bt_decimal_Click);
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.Location = new System.Drawing.Point(161, 144);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(100, 46);
            this.bt_limpiar.TabIndex = 5;
            this.bt_limpiar.Text = "LIMPIAR";
            this.bt_limpiar.UseVisualStyleBackColor = true;
            this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.Location = new System.Drawing.Point(369, 9);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(45, 28);
            this.lbl_resultado.TabIndex = 10;
            this.lbl_resultado.Text = "RTA";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(614, 364);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.bt_decimal);
            this.Controls.Add(this.bt_binario);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.lst_resultados);
            this.Controls.Add(this.cb_operadores);
            this.Controls.Add(this.bt_operar);
            this.Controls.Add(this.txt_num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Calculadora de Ramiro Olicino del curso 2D\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Button bt_operar;
        private System.Windows.Forms.ComboBox cb_operadores;
        private System.Windows.Forms.ListBox lst_resultados;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Button bt_binario;
        private System.Windows.Forms.Button bt_decimal;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.Label lbl_resultado;
    }
}
