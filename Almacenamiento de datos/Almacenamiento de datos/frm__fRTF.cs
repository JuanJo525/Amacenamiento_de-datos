using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacenamiento_de_datos
{
    public partial class frm__fRTF : Form
    {
        public frm__fRTF()
        {
            InitializeComponent();
            rtb_Texto.Enabled = false;
        }
        string Direccion;
        bool cargado = false;

        private void btn_Archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Archivos RTF|*.rtf"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Direccion = openFileDialog.FileName;
                rtb_Texto.LoadFile(Direccion);
                rtb_Texto.Enabled = true;   
                cargado = true;

            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_principal frm_Principal = new frm_principal();
            frm_Principal.Show();
            this.Hide();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Direccion))
            {
                MessageBox.Show("No hay archivo cargado.");
                return;
            }

            try
            {
                rtb_Texto.SaveFile(Direccion);
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void frm__fRTF_Load(object sender, EventArgs e)
        {

        }

        private void btn_FuenteL_Click(object sender, EventArgs e)
        {
            if (cargado == false)
            {
                MessageBox.Show("No hay archivo cargado.");
                return;
            }
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = rtb_Texto.SelectionFont;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    rtb_Texto.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void btn_FondoL_Click(object sender, EventArgs e)
        {
            if (cargado == false)
            {
                MessageBox.Show("No hay archivo cargado.");
                return;
            }
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    rtb_Texto.SelectionBackColor = colorDialog.Color;
                }
            }
        }

        private void btn_colorL_Click(object sender, EventArgs e)
        {
            if (cargado == false)
            {
                MessageBox.Show("No hay archivo cargado.");
                return;
            }
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    rtb_Texto.SelectionColor = colorDialog.Color;
                }
            }
        }
    }
}



