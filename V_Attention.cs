using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra_3
{
    public partial class V_Attention : Form
    {
        private V_Main v_Main;
        private DB_Connect crud;
        private string cod;

        public V_Attention(V_Main v_Main, DB_Connect crud, string cod)
        {
            this.v_Main = v_Main;
            this.crud = crud;
            this.cod = cod;

            InitializeComponent();
        }

        private void saveConsult()
        {
            MessageBox.Show("La función 'Guardar consulta' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void V_Attention_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "¿Desea guardar la consulta antes de salir?";
            string caption = "ATENCIÓN!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                saveConsult();
                this.Dispose();
            }
            else this.Dispose();
        }

        private void button_diagnosis_filter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La función 'Filtrar diagnosticos' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void button_treatment_filter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La función 'Filtrar tratamientos' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void button_addDiagnosis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La función 'Agregar diagnostico' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void button_addTreatment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La función 'Agregar tratamiento' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void button_deleteDiagnosis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La función 'Quitar diagnostico' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void button_deleteTreatment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La función 'Quitar tratamiento' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void listBox_addedDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("La función 'Cambio de diagnostico seleccionado' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveConsult();
        }
    }
}
