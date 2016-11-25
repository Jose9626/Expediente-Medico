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
        private DB_CRUD crud;
        private V_Main main_view;

        /****************************
         * 
         *  BUILDERS
         * 
         ***************************/
        public V_Login()
        {
            //  DATA BASE SOURCES
            //  JOEL: 
            //  JOSE: 
            //  EDWIN: 
            crud = new DB_CRUD("");
            InitializeComponent();
        }

        /****************************
         * 
         *  METHODS
         * 
         ***************************/

        private void entry()
        {
            main_view = new V_Main(this, this.crud, comboBox_rol.SelectedItem.ToString());
            main_view.Show();

            this.Hide();
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
