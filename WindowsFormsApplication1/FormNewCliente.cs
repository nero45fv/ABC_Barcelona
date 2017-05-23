using System;
using System.Collections;
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
    public partial class FormNewCliente : Form
    {
        public ArrayList dataCliente;
        //public ArrayList dataDescuento;
        private ArrayList listaCategoria;
        public bool Valido;
        public DataTable tablaDescuento;
        //dataProducto dataProduc;


        internal ConecDBmySql DataBase
        { get; set; }


        public FormNewCliente()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Valido = false;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int idDescuento = this.cbTipoCliente.SelectedIndex + 1;
            //INSERT INTO `abc_barcelona`.`tb_cliente`
            //(`id_cedulaClient`, `nomCliente`, `fechaNacimiento`, `CelularCliente`, `fonoCliente`, `cuidad`, `direcCliente`, `emailCliente`, `id_descuento`)
            //VALUES('99', 'das', '0000-00-00', '555', '5555', 'ss', 'asas', 'asa', '1');
            String comando = "INSERT INTO `abc_barcelona`.`tb_cliente`"+
                             " (`id_cedulaClient`, `nomCliente`, `fechaNacimiento`, `CelularCliente`, `fonoCliente`, `cuidad`, `direcCliente`, `emailCliente`, `id_descuento`)" +
                             " VALUES ('" + this.txtRuc.Text + "', '" + this.txtNombre.Text + "', '" + this.dtFechaNacimiento.Text + "', '" + this.txtCelular.Text + "',"
                                        + " '" + this.txtTelefono.Text + "', '" + this.txtCiudad.Text + "', '" + this.txtDireccion.Text + "', '" + this.txtEmail.Text + "', "+idDescuento+");";

            this.DataBase.ejecutaNoConsulta(comando);
            if(this.DataBase.Error == null)
            {

                String consulta = "SELECT * FROM abc_barcelona.tb_cliente where id_cedulaClient ="+ this.txtRuc.Text + ";";
                this.Valido = true;
                this.dataCliente = this.DataBase.getRow(consulta);
                MessageBox.Show("El Nuevo Cliente se Guardo Corretamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show(this.DataBase.Error);
                this.Valido = false;
            }
        }

        private void FormNewCliente_Load(object sender, EventArgs e)
        {
                this.listaCategoria = this.DataBase.getColumn(this.tablaDescuento, "Categoria");
                this.cbTipoCliente.DataSource = this.listaCategoria;
                this.cbTipoCliente.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
