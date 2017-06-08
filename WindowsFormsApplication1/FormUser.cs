using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormUser : Form
    {
        private FormMain Main;
        private ConecDBmySql DataBase;
        private User user;
        private String Rol;
        private String AccederA;

        public FormUser()
        {
            InitializeComponent();
            
        }

        public FormUser(FormMain main)
        {
            InitializeComponent();
            this.Main = main;

            this.DataBase = new ConecDBmySql("127.0.0.1", "root", "Fred9845", "abc_barcelona");

            if (this.DataBase.Error != null)
            {
                MessageBox.Show(this.DataBase.Error);
                this.Main.Close();
            }
            else
            {
                this.Main.DataBase = this.DataBase;
                this.user = new User(this.DataBase, this);
            }

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            //this.txtUser.Focused = true;
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Main.Enabled = true;
        }

        public void entrarA(String Acceder,string rol)
        {
            this.Rol = rol;
            this.AccederA = Acceder;

            if (this.Rol == "facturacion")
            {
               if (this.Main.Factu.Activo)
                { this.Main.Factu.OcultarPantallaFacturacion(); }
                if (this.Main.Proform.Activo)
                { this.Main.Proform.OcultarPantallaProforma(); }
            }

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if(this.user.validarUser(this.txtUser.Text, this.txtPassword.Text))
            {
                this.txtPassword.Text = "";
                this.txtUser.Text = "";
                if (this.user.validarAcceso(this.Rol))
                {
                    switch (this.Rol)
                    {
                        case "master":
                            this.Main.AccesoTotal = true;
                            break;
                        case "facturacion":
                            switch (this.AccederA)
                            {
                                case "factura":
                                    this.Main.Factu.VerPantallaFacturacion(this.user.dataEmpleado);
                                    break;
                                case "proforma":
                                    this.Main.Proform.VerPantallaProforma(this.user.dataEmpleado);
                                    break;
                                case "faturarProforma":
                                    //this.Main.Factu.VerPantallaFacturacion(this.user.dataEmpleado);
                                    break;
                            }
                            break;
                        case "bodega":
                            switch (this.AccederA)
                            {
                                //case "factura":
                                //    this.Main.Factu.VerPantallaFacturacion(this.user.dataEmpleado);
                                //    break;
                            }
                            break;
                        case "contabilidad":
                            switch (this.AccederA)
                            {
                                //case "factura":
                                //    this.Main.Factu.VerPantallaFacturacion(this.user.dataEmpleado);
                                //    break;
                            }
                            break;
                        case "configuracion":
                            switch (this.AccederA)
                            {
                                //case "factura":
                                //    this.Main.Factu.VerPantallaFacturacion(this.user.dataEmpleado);
                                //    break;
                            }
                            break;
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Acceso Denegado, Usuario sin permisos");
                }
                
            }
            else
            {
                MessageBox.Show("Error: Acceso Denegado, Ingrese Usuario y Clave Correctos");
                this.txtPassword.Text = "";
                this.txtUser.Text = "";
            }
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
