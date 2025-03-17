namespace Almacenamiento_de_datos
{
    partial class frm_TXT
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
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Archivo = new System.Windows.Forms.Button();
            this.rtb_Texto = new System.Windows.Forms.RichTextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Regresar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(636, 346);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(115, 53);
            this.btn_Regresar.TabIndex = 13;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(636, 253);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(115, 53);
            this.btn_Guardar.TabIndex = 12;
            this.btn_Guardar.Text = "Guardar cambios";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Archivo
            // 
            this.btn_Archivo.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Archivo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archivo.ForeColor = System.Drawing.Color.White;
            this.btn_Archivo.Location = new System.Drawing.Point(636, 163);
            this.btn_Archivo.Name = "btn_Archivo";
            this.btn_Archivo.Size = new System.Drawing.Size(115, 53);
            this.btn_Archivo.TabIndex = 11;
            this.btn_Archivo.Text = "Cargar Archivo";
            this.btn_Archivo.UseVisualStyleBackColor = false;
            this.btn_Archivo.Click += new System.EventHandler(this.btn_Archivo_Click);
            // 
            // rtb_Texto
            // 
            this.rtb_Texto.Location = new System.Drawing.Point(12, 32);
            this.rtb_Texto.Name = "rtb_Texto";
            this.rtb_Texto.Size = new System.Drawing.Size(567, 390);
            this.rtb_Texto.TabIndex = 10;
            this.rtb_Texto.Text = "";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(608, 64);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(167, 66);
            this.lbl_info.TabIndex = 14;
            this.lbl_info.Text = "Editor de archivos: \r\nTXT\r\n\r\n";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_TXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Archivo);
            this.Controls.Add(this.rtb_Texto);
            this.Name = "frm_TXT";
            this.Text = "frm_TXT";
            this.Load += new System.EventHandler(this.frm_TXT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Archivo;
        private System.Windows.Forms.RichTextBox rtb_Texto;
        private System.Windows.Forms.Label lbl_info;
    }
}