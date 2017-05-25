using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        public string BaseDatos { get; private set; }



        public ConecDBmySql(String Server, String UserID, String Password, String BaseDatos)
        {
            MySqlConnectionStringBuilder datosDelServidor = new MySqlConnectionStringBuilder();
            datosDelServidor.Server = this.Server = Server;
            datosDelServidor.UserID = this.UserID = UserID;
            datosDelServidor.Password = this.Password = Password;
            datosDelServidor.Database = this.BaseDatos = BaseDatos;
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

        public void ejecutaNoConsulta(string selectCommand)
        {
            try
            {
                this.Error = null;
                // Se abre la conexion
                this.dbConn.Open();

                MySqlCommand mycomand = new MySqlCommand(selectCommand, dbConn);

                mycomand.ExecuteNonQuery();

                this.dbConn.Close();

            }
            catch (MySqlException e) { this.Error = e.ToString(); }
        }

        public ArrayList getColumn(string selectCommand, DataTable DataTable,String nameColumn)
        {
            ArrayList columna = new ArrayList();

            GetDataTabla(selectCommand, DataTable);

            foreach (DataRow row in DataTable.Rows)
            { columna.Add(row[nameColumn]); }

            return columna;
        }

        public ArrayList getColumn( DataTable DataTable, String nameColumn)
        {
            ArrayList columna = new ArrayList();
            
            foreach (DataRow row in DataTable.Rows)
            { columna.Add(row[nameColumn]); }
            return columna;
        }

        public ArrayList getColumn(string selectCommand, String nameColumn)
        {
            ArrayList columna = new ArrayList();
            DataTable dataTable = new DataTable();

            GetDataTabla(selectCommand, dataTable);

            foreach (DataRow row in dataTable.Rows)
            { columna.Add(row[nameColumn]); }
            return columna;
        }

        public ArrayList getRow(string selectCommand, DataTable DataTable, int numFila)
        {
            ArrayList Fila = new ArrayList();

            GetDataTabla(selectCommand, DataTable);

            foreach (DataRow row in DataTable.Rows)
            {
                if (DataTable.Rows.Count == numFila)
                {
                    foreach (DataColumn column in DataTable.Columns)
                    {Fila.Add(row[column]); }
                    if (Fila.Count >= 0) { break; }
                }
            }
            return Fila;
        }

        public ArrayList getRow( DataTable DataTable, int numFila)
        {
            ArrayList Fila = new ArrayList();

            foreach (DataRow row in DataTable.Rows)
            {
                if (DataTable.Rows.Count == numFila)
                {
                    foreach (DataColumn column in DataTable.Columns)
                    { Fila.Add(row[column]); }
                    if (Fila.Count >= 0) { break; }
                }
            }

            return Fila;
        }

        public ArrayList getRow(string selectCommand)
        {
            DataTable dataTable = new DataTable();

            ArrayList Fila = new ArrayList();
            
            GetDataTabla(selectCommand, dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Fila.Add(row[column]);
                }
                if (Fila.Count >= 0) { break; }
            }

            return Fila;
        }


        //foreach (DataRow row in table.Rows)
        //{
        //    foreach (DataColumn column in table.Columns)
        //    {
        //        Console.WriteLine(row[column]);
        //    }
        //}

        
    }

}
