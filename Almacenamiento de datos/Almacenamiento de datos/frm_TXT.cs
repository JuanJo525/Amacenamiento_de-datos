using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Almacenamiento_de_datos
{
    public partial class frm_TXT : Form
    {
        public frm_TXT()
        {
            InitializeComponent();
            rtb_Texto.ReadOnly = true;
        }

        private void frm_TXT_Load(object sender, EventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_principal frm_Principal = new frm_principal();
            frm_Principal.Show();
            this.Hide();
        }
        string direccion;   
        private void btn_Archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos TXT|*.txt"
            };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtb_Texto.ReadOnly = false;
                direccion = openFileDialog.FileName;
                rtb_Texto.Text = File.ReadAllText(direccion);
                rtb_Texto.Text = File.ReadAllText(direccion);

            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("No hay archivo cargado.");
                return;
            }
            try
            {
                File.WriteAllText(direccion, rtb_Texto.Text);
                MessageBox.Show("Guardado");
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex);
            }

        }
    }
    
}
