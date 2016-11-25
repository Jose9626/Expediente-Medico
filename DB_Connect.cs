using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ConnectionTest
{
    internal class DB_Connect
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DB_Connect()
        {
            server = "localhost";
            database = "expediente_medico";
            uid = "root";
            password = "DataBase2016";
            Initialize();
        }

        public DB_Connect(string server, string database, string uid, string password)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement string tableName, string[] columns, string[] values
        public void Insert(string tableName, string[] columnsList, string[] valuesList)
        {
            string columns;
            if (columnsList.Length == 0) columns = "";
            else
            {
                columns = "(" + columnsList[0];
                for (int i = 1; i < columnsList.Length; i++)
                    columns += ", " + columnsList[i];
                columns += ")";
            }

            string values;
            if (valuesList.Length == 0)
            {
                MessageBox.Show("Error a la hora de ingresar el dato. Intentelo de nuevo.", "ATENCION!");
                return;
            }
            else
            {
                values = "(" + valuesList[0];
                for (int i = 1; i < valuesList.Length; i++)
                    values += ", " + valuesList[i];
                values += ")";
            }

            string query = "INSERT INTO " + tableName + " " + columns + "VALUES" + values;

            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Error a la hora de ingresar el dato. Intentelo de nuevo.", "ATENCION!");
                }

                //close connection
                this.CloseConnection();
            }

        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public DataSet Select()
        {
            DataSet datatable = new DataSet();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM " + "Telefonos", connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(datatable);

                return datatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}