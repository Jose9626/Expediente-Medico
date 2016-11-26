using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Progra_3
{
    public class DB_Connect
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
                        MessageBox.Show("No se puede conectar a la base de datos.  Contacte al administrator.");
                        break;

                    case 1045:
                        MessageBox.Show("El usuario o contraseña no son validos, por favor intentelo de nuevo.");
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
                MessageBox.Show("Error a la hora de ingresar el dato. Intentelo de nuevo.", "ERROR!");
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

            // Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Execute command
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Error a la hora de ingresar el dato. Intentelo de nuevo.", "ERROR!");
                }

                // Close connection
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

        //  Extrae los nombres de las tablas de la base de datos.
        public List<string> getTablesList()
        {
            List<string> tableNames = new List<string>();
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "SELECT * FROM information_schema.tables WHERE table_schema = '" + this.database + "'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    //  Este ciclo es donde se lee y guarda en la lista los nombres de las tablas.
                    while (reader.Read())
                    {
                        string tmpName = reader.GetString(2);
                        tableNames.Add(tmpName);
                    }
                    connection.Close();
                }
                catch
                {
                    //Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
                }
            }
            return tableNames;
        }
        
        // Select statement from column array
        public DataSet Select(string tableName, string[] columnsList, string condition)
        {
            // Generate column string list
            string columns;
            if (columnsList.Length == 0) columns = "*";
            else
            {
                columns = columnsList[0];
                for (int i = 1; i < columnsList.Length; i++)
                    columns += ", " + columnsList[i];
            }

            return Select(tableName, columns, condition);
        }

        // Select statement
        public DataSet Select(string tableName, string columns, string condition) {

            DataSet datatable = new DataSet();

            // Generate condition string
            if (condition != "") condition = " WHERE " + condition;

            // Open connection
            if (this.OpenConnection() == true)
            {

                string query = "SELECT " + columns + " FROM " + tableName + condition;

                try
                {
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Execute the command and adapts the information to a DataSet
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);

                }
                catch 
                {
                    MessageBox.Show("Los valores seleccionados NO coinciden.","ERROR!");
                }

                // Close connection
                this.CloseConnection();
            }
            return datatable;
        }

        // Count statement
        public int Count(string tableName)
        {
            string query = "SELECT Count(*) FROM " + tableName;
            int Count = -1;

            // Open Connection
            if (this.OpenConnection() == true)
            {
                // Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                // Close Connection
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