using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_3
{
    public class DB_CRUD
    {
        /****************************
         * 
         *  ATTRIBUTES
         * 
         ***************************/
        private String dataSource;

        /****************************
         * 
         *  BUILDERS
         * 
         ***************************/
        public DB_CRUD(String dbSource)
        {
            this.dataSource = dbSource;
        }

        /****************************
         * 
         *  METHODS
         * 
         ***************************/
         
        //  Esta funcion crea y retorna la conexion a la base de datos 
        private SqlConnection openConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.dataSource);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /*******************
         *  CREATE
         *******************/

        //  Agrega a una tabla de la base de datos la tupla ingresada.
        public void insertIntoTable(string tableName, List<string> data)
        {
            //Verifica que la cantidad de datos introducidos sean las mismas que las que ocupa el SQL
            if (data.Count() == this.getColumns(tableName).Count)
            {
                //En caso de que ocurra una excepcion de tipo SQL es atrapado
                try
                {
                    //List<string> columns = this.getColumns(table);
                    SqlConnection connection = openConnection();
                    int pos = 0;
                    string values = " VALUES(";
                    while (data.Count != pos)
                    {
                        if (pos + 1 != data.Count)
                        {
                            values += data.ElementAt(pos) + ",";
                        }
                        else
                        {
                            values += data.ElementAt(pos) + ")";
                        }
                        pos++;
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO " + tableName + values, connection);
                    Console.WriteLine("INSERT INTO " + tableName + values);
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
                }
            }
            //Aqui iria un messagebox 
            else
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
        }

        /*******************
         *  READ
         *******************/

        //  Extrae los nombres de las tablas de la base de datos.
        public List<string> getTablesList()
        {
            List<string> tableNames = new List<string>();
            try
            {
                SqlConnection connection = openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Information_Schema.Tables", connection);
                SqlDataReader reader = command.ExecuteReader();
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
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
            return tableNames;
        }

        // Esta funcion se encarga de obtener el nombre de las columnas de una tabla.
        // Ocupa el nombre de la tabla que se desea procesar.
        public List<string> getColumns(string tableName)
        {
            List<string> columns = new List<string>();
            try
            {
                SqlConnection connection = openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM " + tableName, connection);
                SqlDataReader reader = command.ExecuteReader();

                int cont = 0;
                while (reader.VisibleFieldCount > cont)
                {
                    string tmpName = reader.GetName(cont);
                    columns.Add(tmpName);
                    cont++;
                }

                connection.Close();
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
            return columns;
        }

        //  Retorna una tabla con los datos de la tabla de la base de datos.
        public DataTable getTableData(string tableName, string select)
        {
            DataSet datatable = new DataSet();
            try
            {
                SqlConnection connection = openConnection();
                SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + tableName, connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(datatable);

                return datatable.Tables[0];
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
            return null;
        }



        //  Extrae los datos de un atributo de una tabla en especifico.
        public List<string> getColumnDataList(string tableName, string columnName)
        {
            List<string> data = new List<string>();
            try
            {
                SqlConnection connection = openConnection();
                SqlCommand command = new SqlCommand("SELECT " + columnName + " FROM " + tableName, connection);
                SqlDataReader reader = command.ExecuteReader();

                //  Este ciclo es donde se lee y guarda en la lista los elementos de la columna.
                while (reader.Read())
                {
                    string tmpData = reader.GetString(0);
                    data.Add(tmpData);
                    reader.GetString(0);
                }

                connection.Close();
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
            return data;
        }

        //  Retorna una o varias tuplas que cumplan la condicion introducida
        public DataTable getConditionalTableData(string tableName, string select, string columnName, string condition)
        {
            DataSet datatable = new DataSet();
            try
            {
                SqlConnection connection = openConnection();
                SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + tableName + " WHERE " + columnName + "=" + condition, connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(datatable);

                return datatable.Tables[0];
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
            return null;
        }

        //  
        public List<string> getConditionalTableList(string tableName, string select, string columnName, string condition)
        {
            List<string> data = new List<string>();
            try
            {
                SqlConnection connection = openConnection();
                SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + tableName + " WHERE " + columnName + "=" + condition, connection);

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                while (reader.Read())   //  REVISAR *****************************************************************************************************************************
                {
                    int pos = 0;
                    while (pos < reader.FieldCount) {
                        data.Add((reader.GetValue(pos).ToString()));
                        pos++;
                    }
                }

                connection.Close();
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
            return data;
        }

        //  Retorna una lista con las llaves foraneas de la base de datos
        public List<Object> getForeignKeys()
        {
            return new List<object>();
        }

        //  Retorna un string con el Join entre las tablas.
        public string join(string table1, string table2)
        {
            return "";
        }

        /*******************
         *  UPDATE
         *******************/

        // Recibe el nombre de la tabla(table), dos strings que forman la condicion del where(where y condition)
        // Una lista de las columnas que se van a modificar(columns) y una lista con los datos a actualizar(data)
        public void updateRowData(string table, string column, string condition, List<string> columns, List<string> data)
        {
            try
            {
                SqlConnection connection = openConnection();
                int pos = 0;
                string values = "";
                //Este while construye la seccion del sqlcommand del set
                while (data.Count != pos)
                {
                    if (pos + 1 != data.Count)
                    {
                        values += data.ElementAt(pos) + "=" + columns.ElementAt(pos) + ",";
                    }
                    else
                    {
                        values += data.ElementAt(pos) + "=" + columns.ElementAt(pos);
                    }
                    pos++;
                }
                SqlCommand command = new SqlCommand("UPDATE " + table + " SET " + values + " WHERE " + column + "=" + condition, connection);
                Console.WriteLine("UPDATE " + table + " SET " + values + " WHERE " + column + "=" + condition);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
        }

        /*******************
         *  DELETE
         *******************/

        // Esta funcion borra una tupla de la base de datos
        // Recibe el nombre de la tabla y el condicional dividido en dos strings con where siendo la columna
        // y key el valor del dato
        public void deleteRow(string tableName, string columnName, string condition)
        {
            try
            {
                SqlConnection connection = openConnection();
                SqlCommand command = new SqlCommand("DELETE FROM " + tableName + " WHERE " + columnName + "=" + condition, connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error y no se pudo desarrollar la accion");
            }
        }
    }
}
