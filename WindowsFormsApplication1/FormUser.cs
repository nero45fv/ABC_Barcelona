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
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Main.Enabled = true;
        }

        public void entrarA(String Acceder)
        {
            this.AccederA = Acceder;

            if (this.AccederA == "facturacion")
            {
                this.Main.Factu.OcultarPantallaFacturacion();
            }
            
            
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if(this.user.validarUser(this.txtUser, this.txtPassword))
            {
                this.txtPassword.Text = "";
                this.txtUser.Text = "";
                if (this.user.validarAcceso(this.AccederA))
                {
                    if (this.AccederA == "facturacion")
                    {
                        this.Main.Factu.VerPantallaFacturacion(this.user.dataEmpleado);
                    }
                    else if(this.AccederA == "bodega")
                    {
                        //this.Main.Factu.VerPantallaFacturacion();
                    }
                    else if (this.AccederA == "contabilidad")
                    {
                        //this.Main.Factu.VerPantallaFacturacion();
                    }
                    else if (this.AccederA == "master")
                    {
                        this.Main.AccesoTotal = true;
                    }
                    else if (this.AccederA == "configuracion")
                    {
                        //this.Main.Factu.VerPantallaFacturacion();
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
