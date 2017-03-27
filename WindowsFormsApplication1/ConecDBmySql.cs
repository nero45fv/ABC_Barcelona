using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ConecDBmySql
    {
        private MySqlConnection dbConn;

        public string Error { get; private set; }
        public string Server { get; private set; }
        public string UserID { get; private set; }
        public string Password { get; private set; }
        public string DataBase { get; private set; }



        public ConecDBmySql(String Server, String UserID, String Password, String DataBase)
        {
            MySqlConnectionStringBuilder datosDelServidor = new MySqlConnectionStringBuilder();
            datosDelServidor.Server = this.Server = Server;
            datosDelServidor.UserID = this.UserID = UserID;
            datosDelServidor.Password = this.Password = Password;
            datosDelServidor.Database = this.DataBase = DataBase;
            try {
                this.Error = null;
                this.dbConn = new MySqlConnection(datosDelServidor.ToString());
            }
            catch (MySqlException e) { Error = e.ToString(); }

        }

        public void GetDataTabla(string selectCommand, DataTable DataTable)
        {
            try
            {
                this.Error = null;
                // Se abre la conexion
                this.dbConn.Open();

                // Se crea un DataSet que almacenará los datos desde donde se cargaran los datos al DataGridView
                //DataSet dtDatos = new DataSet();

                // Se crea un MySqlAdapter para obtener los datos de la base
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(selectCommand, dbConn);

                // Con la información del adaptador se rellena el DataTable
                mdaDatos.Fill(DataTable);

                // Se asigna el DataTable como origen de datos del DataGridView
                //dataGridView1.DataSource = dtDatos;

                // Se cierra la conexión a la base de datos
                this.dbConn.Close();

            }
            catch (MySqlException e) { this.Error = e.ToString(); }
        }

        public  List <String> getColumnString(string selectCommand, DataTable DataTable,String nameColumn)
        {
            List<String> columna = new List<string>();

            GetDataTabla(selectCommand, DataTable);
            foreach (DataRow row in DataTable.Rows)
            {
                String col = row[nameColumn].ToString();
                columna.Add(col);
            }
            return columna;
        }

        public List<String> getColumnString( DataTable DataTable, String nameColumn)
        {
            List<String> columna = new List<string>();
            
            foreach (DataRow row in DataTable.Rows)
            {
                String col = row[nameColumn].ToString();
                columna.Add(col);
            }
            return columna;
        }

        //public List<String> getFilaString(string selectCommand, DataTable DataTable, int numFila)
        //{
        //    List<String> columna = new List<string>();

        //    GetDataTabla(selectCommand, DataTable);
        //    foreach (DataRow row in DataTable.Rows)
        //    {
        //        String col = row[nameColumn].ToString();
        //        columna.Add(col);
        //    }

        //    //foreach (DataRow row in table.Rows)
        //    //{
        //    //    foreach (DataColumn column in table.Columns)
        //    //    {
        //    //        Console.WriteLine(row[column]);
        //    //    }
        //    //}

        //    return columna;
        //}

        //public List<String> getFilaString(DataTable DataTable, String nameColumn)
        //{
        //    List<String> columna = new List<string>();

        //    foreach (DataRow row in DataTable.Rows)
        //    {
        //        String col = row[nameColumn].ToString();
        //        columna.Add(col);
        //    }
        //    return columna;
        //}

        // Create a command builder to generate SQL updatgee, insert, and
        // delete commands based on selectCommand. These are used to
        // update the database.
        //MySqlDataAdapter ademp = new MySqlDataAdapter(selectCommand, dbConn);
        //DataTable tabemp = new DataTable();
        //ademp.Fill(tabemp);
        //DataSet dset = new DataSet();
        //tabemp = dset.Tables["empleado"];
        //agrega_columnas();
        //dataGridView1.DataSource = tabemp;
        /*MessageBox.Show("To run this example, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system.");*/

        /*public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            String query = "SELECT * FROM users";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                String username = reader["username"].ToString();
                String password = reader["password"].ToString();

                User u = new User(id, username, password);

                users.Add(u);
            }

            reader.Close();

            dbConn.Close();

            return users;
        }

        public static User Insert(String u, String p)
        {
            String query = string.Format("INSERT INTO users(username, password) VALUES ('{0}', '{1}')", u, p);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            User user = new User(id, u, p);

            dbConn.Close();

            return user;

        }
        public void Update(string u, string p)
        {
            //String query = string.Format("UPDATE users SET username='{0}', password='{1}' WHERE ID={2}", u, p, Id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();
        }

        public void Delete()
        {
            //String query = string.Format("DELETE FROM users WHERE ID={0}", Id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();
        }*/
    }

}
