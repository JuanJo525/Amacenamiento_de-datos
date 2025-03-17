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
    public partial class frm_CSV : Form
    {
        public frm_CSV()
        {
            InitializeComponent();
        }

        string[] filas;
        string Direccion;

        private void btn_Archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "CSV Files|*.csv"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Direccion = openFileDialog.FileName;
                MessageBox.Show("Archivo seleccionado: " + Direccion);

                try
                {
                    using (StreamReader sr = new StreamReader(Direccion))
                    {

                        bool primeraLinea = true;

                        while (!sr.EndOfStream)
                        {
                            filas = sr.ReadLine().Split(';');

                            if (primeraLinea == true)
                            {
                               
                                foreach (string columna in filas)
                                {
                                    dtg_Vista.Columns.Add(columna, columna);
                                }
                                primeraLinea = false;
                            }
                            else
                            {
                                dtg_Vista.Rows.Add(filas);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Direccion))
                {
                    MessageBox.Show("No hay archivo cargado.");
                    return;
                }
               

                using (StreamWriter sw = new StreamWriter(Direccion, false)) 
                {
                    List<string> Texto = new List<string>();
                    foreach (DataGridViewColumn col in dtg_Vista.Columns)
                    { 
                        Texto.Add(col.HeaderText);
                    }                             
                    sw.WriteLine(string.Join(";", Texto));


                    foreach (DataGridViewRow row in dtg_Vista.Rows)
                    {
                        if (!row.IsNewRow) 
                        {
                            List<string> valores = new List<string>();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                valores.Add(cell.Value?.ToString() ?? ""); 
                            }
                            sw.WriteLine(string.Join(";", valores));
                        }
                    }
                }

                MessageBox.Show("Archivo guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_principal frm_Principal = new frm_principal();
            frm_Principal.Show();
            this.Hide();
        }

        private void dtg_Vista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
