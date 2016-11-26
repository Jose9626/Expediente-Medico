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
    public partial class V_Login : Form
    {
        /****************************
         * 
         *  ATTRIBUTES
         * 
         ***************************/
        private DB_Connect connection;
        private V_Main main_view;

        /****************************
         * 
         *  BUILDERS
         * 
         ***************************/
        public V_Login()
        {
            //  DATA BASE CONNECTION
            connection = new DB_Connect();
            InitializeComponent();
        }

        /****************************
         * 
         *  METHODS
         * 
         ***************************/

        private void entry()
        {
            // Variables
            string user = textBox_user.Text;
            string pass = textBox_pass.Text;
            string rol = comboBox_rol.SelectedItem.ToString();

            Console.Out.WriteLine("user='" + user + "'");
            Console.Out.WriteLine("pass='" + pass + "'");
            Console.Out.WriteLine("rol='" + rol + "'");

            try
            {
                // 
                DataSet dataset_person = connection.Select("Personas", new string[] { "cedula_persona", "contrasena" }, "cedula_persona = " + user);

                Console.Out.WriteLine(pass + "==" + dataset_person.Tables[0].Rows[0][1]);
                // 
                if (pass.Equals(dataset_person.Tables[0].Rows[0][1]))
                {
                    // 
                    Console.Out.WriteLine(rol + "!=Paciente");
                    if (!rol.Equals("Paciente"))
                    {
                        try
                        {
                            DataSet dataset_functionary = connection.Select("Funcionarios", new string[] { "cedula_persona", "area_labora" }, "cedula_persona=" + user);
                            rol = dataset_functionary.Tables[0].Rows[0][1].ToString();
                            Console.Out.WriteLine("NEW Rol='" + rol + "'");
                        }
                        catch
                        {
                            Console.Out.WriteLine("Error 3");
                            MessageBox.Show("El usuario no es un funcionario, favor cambiar el área a paciente.", "ATENCIÓN!");
                            return;
                        }

                    }

                    main_view = new V_Main(this, this.connection, user, rol);
                    main_view.Show();

                    this.Hide();
                }
                else {
                    Console.Out.WriteLine("Error 2");
                    MessageBox.Show("El usuario o la contraseña no son validos, vuelva a intentarlo con otro usuario o contraseña.", "ERROR!");
                }
            }
            catch
            {
                Console.Out.WriteLine("Error 1");
                MessageBox.Show("Los datos no coinciden con la base de datos.", "ERROR!");
            }
        }



        /****************************
         * 
         *  ACTION METHODS
         * 
         ***************************/

        private void button_enter_Click(object sender, EventArgs e)
        {
            entry();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
