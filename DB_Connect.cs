using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

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
        public bool OpenConnection()
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
                        Console.Out.WriteLine("No se puede conectar a la base de datos.  Contacte al administrator.");
                        break;

                    case 1045:
                        Console.Out.WriteLine("El usuario o contraseña no son validos, por favor intentelo de nuevo.");
                        break;
                    default:
                        Console.WriteLine(ex);
                        break;
                }
                return false;
            }
        }


    //Close connection
    public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
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
                Console.Out.WriteLine("Error a la hora de ingresar el dato. Intentelo de nuevo.", "ERROR!");
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

            Console.Out.WriteLine("Query = " + query);
            // Open connection
            if (this.OpenConnection())
            {
                try
                {
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Execute command
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                }

                // Close connection
                this.CloseConnection();
            }

        }

        //Update statement
        public bool Update(string tableName, string[] columnlist, string[] valuelist, string condition)
        {
            int pos = 0;
            string set = columnlist[pos] + "=" + valuelist[pos];
            pos++;
            while (pos < columnlist.Length)
            {
                set += ", " + columnlist[pos] + " = " + valuelist[pos];
                pos++;
            }

            return Update(tableName, set, condition);
        }

        public bool Update(string tableName, string set, string condition) { 
            bool flag = false;
            if (this.OpenConnection())
            {
                string query = "UPDATE " + tableName + " SET " + set + " WHERE " + condition;

                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    flag = true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                    flag = false;
                }

                //close connection
                this.CloseConnection();
            }
            return flag;
        }

        // Delete statement
        public bool Delete(string table, string condition)
        {
            string query = "DELETE FROM " + table + " WHERE " + condition;

            bool flag = false;
            if (this.OpenConnection())
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                    flag = false;
                }

                //close connection
                this.CloseConnection();
            }
            return flag;
        }

        //  Extrae los nombres de las tablas de la base de datos.
        public List<string> getTablesList()
        {
            List<string> tableNames = new List<string>();
            if (this.OpenConnection())
            {
                try
                {
                    string query = "SELECT * FROM information_schema.tables WHERE table_schema = '" + this.database + "'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    //  Este ciclo es donde se lee y guarda en la lista los nombres de las tablas.
                    while (reader.Read())
                    {
                        string tmpName = reader.GetString(2);
                        tableNames.Add(tmpName);
                    }
                    
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }
                this.CloseConnection();
            }
            return tableNames;
        }

        public List<string> getColumnsFromTable(string tableName)
        {
            List<string> columns = new List<string>();

            // Open connection
            if (this.OpenConnection())
            {
                try
                {
                    string query = "SELECT * FROM information_schema.columns WHERE table_name = '" + tableName + "'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    Console.Out.WriteLine(query);
                    //  Este ciclo es donde se lee y guarda en la lista los nombres de los atributos.
                    while (reader.Read())
                    {
                        Console.Out.WriteLine("Reader = "+ reader.GetString(3));
                        string tmpName = reader.GetString(3);
                        columns.Add(tmpName);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                // Close connection
                this.CloseConnection();
            }
            return columns;
        }

        // Select statement from column array
        public DataSet Select(string tableName, string[] columnsList, string condition, string groupBy)
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

            return Select(tableName, columns, condition, groupBy);
        }

        // Select statement
        public DataSet Select(string tableName, string columns, string condition, string groupBy) {

            DataSet datatable = new DataSet();

            // Generate condition string
            if (condition != "") condition = " WHERE " + condition;

            // Generate condition string
            if (groupBy != "") condition = " GROUP BY " + condition;

            // Open connection
            if (this.OpenConnection())
            {
                string query = "SELECT " + columns + " FROM " + tableName + condition;
                Console.Out.WriteLine("QUERY = " + query);
                try
                {
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Execute the command and adapts the information to a DataSet
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                }

                // Close connection
                this.CloseConnection();
            }
            datatable.Tables.Add(new DataTable());
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

        public int execProc_Get_Appointment_Number()
        {
            // Open connection
            if (this.OpenConnection())
            {
                int result = -1;
                try
                {
                    //Se crea el commando 
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Get_Appointment_Number";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("num_cita", MySqlDbType.Int32);
                    cmd.Parameters["num_cita"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    //Se guarda el resultado en una variable
                    Int32.TryParse(cmd.Parameters["num_cita"].Value.ToString(), out result);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                }
                this.CloseConnection();
                return result;
            }
            return -1;
        }
    }
}