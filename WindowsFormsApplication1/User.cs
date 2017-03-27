using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class User
    {
        private ConecDBmySql DataBase;
        //private BindingSource dataTabla;
        private DataTable dataTablaUser;
        private FormUser pantala;
        public DataTable dataEmpleado;
        public DataTable dataPermisos;
        

        public User(ConecDBmySql dataBase,FormUser Pantala)
        {
            this.pantala = Pantala;
            this.DataBase = dataBase;
            this.dataTablaUser = new DataTable();
            
            
            String consulta = "select id_user,nomUser as User,claveUser as Clave,titulo as Titulo,id_privilegios " +
                              "from tb_user, tb_previlegios where tb_user.id_privilegios = tb_previlegios.id_previlegios;";
            this.DataBase.GetDataTabla(consulta, this.dataTablaUser);
            if(this.DataBase.Error != null) {
                MessageBox.Show(this.DataBase.Error);
                this.pantala.Close();
            }
        }

        public Boolean validarUser(TextBox user, TextBox password)
        {
            Boolean valido = false;
            this.dataPermisos = new DataTable();
            this.dataEmpleado = new DataTable();
            try
            {
                foreach (DataRow row in this.dataTablaUser.Rows)
                {
                    //foreach (DataColumn column in this.dataTabla.Columns)
                    //{
                        String User = row["User"].ToString();
                        String Clave = row["Clave"].ToString();
                        if (Clave == password.Text && User == user.Text)
                        {
                        String consulta = "select titulo as Titulo,bodega,facturacion,contabilidad,master,configuracion " +
                         "from tb_previlegios where "+ row["id_privilegios"].ToString() + " = tb_previlegios.id_previlegios;";
                        this.DataBase.GetDataTabla(consulta, this.dataPermisos);

                        String consulta1 = "SELECT id_empleado,nom1Emple as nombre,apel1Emple as apellido,id_user " +
                                            "FROM abc_barcelona.tb_empleado where id_user = "+ row["id_user"].ToString() + ";" ;
                             this.DataBase.GetDataTabla(consulta1, this.dataEmpleado);
                             valido = true;
                             break;
                        }
                        else { valido = false; }
                    //}
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
                this.pantala.Close();
            }
            return valido;
        }
        public Boolean validarAcceso(String AccederA)
        {
            Boolean valido = false;
            foreach (DataRow row in this.dataPermisos.Rows)
            {
                foreach (DataColumn column in this.dataPermisos.Columns)
                {
                    if (column.ToString() == AccederA)
                    {
                        valido =(Boolean) row[column];
                        break;
                    }
                }
            }
            return valido;
        }

        //public empleado getEmpleado(string selectCommand, DataTable DataTable, int numFila)
        //{
        //    empleado Emple= new  empleado();

        //    this.DataBase.GetDataTabla(selectCommand, DataTable);
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

        //    return Emple;
        //}
    }
}
