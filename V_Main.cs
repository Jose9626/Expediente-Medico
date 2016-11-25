using System;
using System.Windows.Forms;

namespace Progra_3
{
    public partial class V_Main : Form
    {
        /****************************
         * 
         *  ATTRIBUTES
         * 
         ***************************/
        private V_Login v_Login;
        private DB_CRUD crud;

        private string user_type;

        /****************************
         * 
         *  BUILDERS
         * 
         ***************************/
        public V_Main()
        {
            InitializeComponent();
        }

        public V_Main(V_Login v_Login, DB_CRUD crud, string type)
        {
            this.v_Login = v_Login;
            this.crud = crud;
            this.user_type = type;

            InitializeComponent();

            build_according_to_type();
        }



        /****************************
         * 
         *  METHODS
         * 
         ***************************/

        /*  El metodo build_according_to_type no recibe nada, pero toma el atributo user_type para determinar 
        *   qué tipo de usuario es el que ingreso y asi determinar que funciones mostrar en la ventana.
        */
        private void build_according_to_type()
        {
            // Elementos para la gestion de los reportes por usuario
            ToolStripItemCollection collection = toolStripDropDownButton_reports.DropDownItems;
            string[] reportList = new string[] { };

            // Elementos para la gestion del panel de funciones
            string[] functionList = new string[] { };
            Button[] functionButtons = {    button_function_1,
                                            button_function_2,
                                            button_function_3,
                                            button_function_4 };

            switch (this.user_type)
            {
                case "Administrador (Base de Datos)":
                    this.flowLayoutPanel_options.Controls.Add(this.panel_selectTable);

                    functionList = new string[] {   "Agregar tupla",
                                                    "Leer tupla",
                                                    "Modificar tupla",
                                                    "Borrar tupla" };
                    break;

                case "Doctor (a)":
                    reportList = new string[] { "Citas del sistema",
                                                "Diagnosticos asociados a un paciente",
                                                "Tratamientos asociados a un paciente",
                                                "Cantidad de citas",
                                                "Cantidad de diagnosticos",
                                                "Cantidad de tratamientos" };

                    functionList = new string[] {   "Atender Cita",
                                                    "Paciente se ausentó",
                                                    "Programar Cita",
                                                    "Cancelar Cita" };
                    break;
                case "Enfermero (a)":
                    reportList = new string[] { "Citas del sistema",
                                                "Diagnosticos asociados a un paciente",
                                                "Tratamientos asociados a un paciente",
                                                "Cantidad de citas",
                                                "Cantidad de diagnosticos",
                                                "Cantidad de tratamientos" };

                    functionList = new string[] {   "Paciente se ausentó",
                                                    "Programar Cita",
                                                    "Cancelar Cita",
                                                    "" };
                    break;

                case "Secretario (a)":
                    reportList = new string[] { "Citas del sistema" };

                    functionList = new string[] {   "Programar Cita",
                                                    "Cancelar Cita",
                                                    "","" };
                    break;

                default:
                    reportList = new string[] { "Mis Citas",
                                                "Mis Diagnosticos",
                                                "Mis Tratamientos" };

                    functionList = new string[] {   "Programar Cita",
                                                    "Cancelar Cita",
                                                    "","" };
                    break;
            }

            foreach (string report in reportList)
            {
                ToolStripMenuItem reportButton = new ToolStripMenuItem();
                reportButton.Size = new System.Drawing.Size(250, 28);
                reportButton.Text = report;
                reportButton.Click += new System.EventHandler(this.toolStripMenuItem_report_Click);

                collection.Add(reportButton);
            }

            for (int i = 0; i < 4; i++)
            {
                if (functionList[i].Equals(""))
                {
                    functionButtons[i].Enabled = false;
                    functionButtons[i].Visible = false;
                }
                else
                {
                    functionButtons[i].Text = functionList[i];
                    
                }
            }

            this.flowLayoutPanel_options.Controls.Add(this.panel_searchBy);
            this.flowLayoutPanel_options.Controls.Add(this.panel_functions);
        }

        private void showTableMain(string tableName, string select, string where)
        {
            string text = "Se ejecutará el siguiente comando: SELECT " + select + " FROM " + tableName;
            if (!where.Equals(""))
                text += " WHERE " + where;
            MessageBox.Show(text, "ATENCIÓN!");
            MessageBox.Show("La función solicitada aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        /*******************
         *  CRUD
         *******************/
        //  CREATE
        private void crudAdd(string tableName)
        {
            MessageBox.Show("La función de 'Agregar tupla' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }
        //  READ
        private void crudRead(string tableName, string key)
        {
            MessageBox.Show("La función de 'Leer tupla' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }
        //  UPDATE
        private void crudUpdate(string tableName, string key)
        {
            MessageBox.Show("La función de 'Modificar tupla' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }
        //  DELETE
        private void crudDelete(string tableName, string key)
        {
            MessageBox.Show("La función de 'Eleminar tupla' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        /**************************
         *  OTHER BUTTON FUNCTIONS
         *************************/
        private void attend(string cod)
        {
            V_Attention attendView = new V_Attention(this, crud, cod);
            attendView.Show();
        }

        private void changeToAbsent(string cod)
        {
            MessageBox.Show("La función de 'Cambiar a ausente' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void makeAppointment(string cod)
        {
            MessageBox.Show("La función de 'Programar cita' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void cancelAppointment(string cod)
        {
            MessageBox.Show("La función de 'Cancelar cita' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        /****************************
         * 
         *  ACTION METHODS
         * 
         ***************************/
        private void V_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "¿Está seguro que desea salir del programa definitivamente?";
            string caption = "ATENCIÓN!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
                this.v_Login.Dispose();
            else
                this.v_Login.Show();
        }
        private void toolStripButton_logout_Click(object sender, System.EventArgs e)
        {
            this.v_Login.Show();
            this.Dispose();
        }

        private void toolStripMenuItem_manual_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("La función 'Mostrar manual de usuario' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.","ATENCIÓN!");
        }

        private void toolStripMenuItem_about_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("La función 'Mostrar la ventana de acerca de' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
        }

        private void toolStripMenuItem_report_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem reportButton = (ToolStripMenuItem)sender;
            switch (reportButton.Text)
            {
                case "Citas del sistema":
                    MessageBox.Show("La función de 'Generar reporte: Citas del sistema' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Diagnosticos asociados a un paciente":
                    MessageBox.Show("La función de 'Generar reporte: Diagnosticos asociados a un paciente' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Tratamientos asociados a un paciente":
                    MessageBox.Show("La función de 'Generar reporte: Tratamientos asociados a un paciente' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Cantidad de citas":
                    MessageBox.Show("La función de 'Generar reporte: Cantidad de citas' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Cantidad de diagnosticos":
                    MessageBox.Show("La función de 'Generar reporte: Cantidad de diagnosticos' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Cantidad de tratamientos":
                    MessageBox.Show("La función de 'Generar reporte: Cantidad de tratamientos' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Mis Citas":
                    MessageBox.Show("La función de 'Generar reporte: Mis Citas' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Mis Diagnosticos":
                    MessageBox.Show("La función de 'Generar reporte: Mis Diagnosticos' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                case "Mis Tratamientos":
                    MessageBox.Show("La función de 'Generar reporte: Mis Tratamientos' aún no ha sido desarrollada para esta versión de software, pruebe actualizando el programa.", "ATENCIÓN!");
                    break;
                default:
                    MessageBox.Show("La acción " + reportButton.Text + " no existe.", "ATENCIÓN!");
                    break;
            }
        }

        private void button_goToTable_Click(object sender, EventArgs e)
        {
            string tableName = comboBox_selectTable.Text;
            if (tableName.Equals(""))
                MessageBox.Show("No se ha ingresado ninguna tabla.", "ERROR!");
            else
                showTableMain(tableName, "*", "");
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string tableName = comboBox_selectTable.Text;
            string text = textBox_search.Text;
            string columnName = comboBox_columnSearch.Text;

            if (text.Equals("") || columnName.Equals(""))
                MessageBox.Show("No se ha ingresado los datos necesarios, asegurece de ingresar un atributo y un valor en la entrada de texto.", "ERROR!");
            else
                showTableMain(tableName, "*", columnName + "="+ text);
        }

        private void button_function_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string tableName = comboBox_selectTable.Text;
            string key = "";

            switch (button.Text)
            {                                                    
                case "Agregar tupla":
                    crudAdd(tableName);
                    break;
                case "Leer tupla":
                    crudRead(tableName, key);
                    break;
                case "Modificar tupla":
                    crudUpdate(tableName, key);
                    break;
                case "Borrar tupla":
                    crudDelete(tableName, key);
                    break;
                case "Atender Cita":
                    attend(key);
                    break;
                case "Paciente se ausentó":
                    changeToAbsent(key);
                    break;
                case "Programar Cita":
                    makeAppointment(key);
                    break;
                case "Cancelar Cita":
                    cancelAppointment(key);
                    break;
                default:
                    MessageBox.Show("La acción " + button.Text + " no existe.", "ATENCIÓN!");
                    break;
            }
        }
    }
}
