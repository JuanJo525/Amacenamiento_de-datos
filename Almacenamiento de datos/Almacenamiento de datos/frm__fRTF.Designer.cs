namespace Almacenamiento_de_datos
{
    partial class frm__fRTF
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
            this.rtb_Texto = new System.Windows.Forms.RichTextBox();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Archivo = new System.Windows.Forms.Button();
            this.btn_FuenteL = new System.Windows.Forms.Button();
            this.btn_FondoL = new System.Windows.Forms.Button();
            this.btn_colorL = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_Texto
            // 
            this.rtb_Texto.Location = new System.Drawing.Point(12, 52);
            this.rtb_Texto.Name = "rtb_Texto";
            this.rtb_Texto.Size = new System.Drawing.Size(567, 365);
            this.rtb_Texto.TabIndex = 0;
            this.rtb_Texto.Text = "";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Regresar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(643, 352);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(115, 53);
            this.btn_Regresar.TabIndex = 6;
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
            this.btn_Guardar.Location = new System.Drawing.Point(643, 259);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(115, 53);
            this.btn_Guardar.TabIndex = 5;
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
            this.btn_Archivo.Location = new System.Drawing.Point(643, 169);
            this.btn_Archivo.Name = "btn_Archivo";
            this.btn_Archivo.Size = new System.Drawing.Size(115, 53);
            this.btn_Archivo.TabIndex = 4;
            this.btn_Archivo.Text = "Cargar Archivo";
            this.btn_Archivo.UseVisualStyleBackColor = false;
            this.btn_Archivo.Click += new System.EventHandler(this.btn_Archivo_Click);
            // 
            // btn_FuenteL
            // 
            this.btn_FuenteL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FuenteL.Location = new System.Drawing.Point(14, 23);
            this.btn_FuenteL.Name = "btn_FuenteL";
            this.btn_FuenteL.Size = new System.Drawing.Size(185, 23);
            this.btn_FuenteL.TabIndex = 7;
            this.btn_FuenteL.Text = "Cambiar fuente";
            this.btn_FuenteL.UseVisualStyleBackColor = true;
            this.btn_FuenteL.Click += new System.EventHandler(this.btn_FuenteL_Click);
            // 
            // btn_FondoL
            // 
            this.btn_FondoL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FondoL.Location = new System.Drawing.Point(205, 23);
            this.btn_FondoL.Name = "btn_FondoL";
            this.btn_FondoL.Size = new System.Drawing.Size(189, 23);
            this.btn_FondoL.TabIndex = 8;
            this.btn_FondoL.Text = "Cambiar Fondo";
            this.btn_FondoL.UseVisualStyleBackColor = true;
            this.btn_FondoL.Click += new System.EventHandler(this.btn_FondoL_Click);
            // 
            // btn_colorL
            // 
            this.btn_colorL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colorL.Location = new System.Drawing.Point(400, 23);
            this.btn_colorL.Name = "btn_colorL";
            this.btn_colorL.Size = new System.Drawing.Size(181, 23);
            this.btn_colorL.TabIndex = 9;
            this.btn_colorL.Text = "Cambiar Color";
            this.btn_colorL.UseVisualStyleBackColor = true;
            this.btn_colorL.Click += new System.EventHandler(this.btn_colorL_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(614, 71);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(167, 44);
            this.lbl_info.TabIndex = 10;
            this.lbl_info.Text = "Editor de archivos: \r\nRTF\r\n";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm__fRTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_colorL);
            this.Controls.Add(this.btn_FondoL);
            this.Controls.Add(this.btn_FuenteL);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Archivo);
            this.Controls.Add(this.rtb_Texto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm__fRTF";
            this.Text = "frm__fRTF";
            this.Load += new System.EventHandler(this.frm__fRTF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Texto;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Archivo;
        private System.Windows.Forms.Button btn_FuenteL;
        private System.Windows.Forms.Button btn_FondoL;
        private System.Windows.Forms.Button btn_colorL;
        private System.Windows.Forms.Label lbl_info;
    }
}