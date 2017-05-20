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
        public ArrayList dataDescuento;
        public ArrayList listaCategoria;
        public bool Valido;
        public DataTable tablaDescuento;
        //dataProducto dataProduc;

        int ultimoIdCliente;

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
            String comando = "INSERT INTO `abc_barcelona`.`tb_cliente`"+
                             " (`id_cedulaClient`, `nomCliente`, `CelularCliente`, `fonoCliente`, `direcCliente`, `emailCliente`, `id_descuento`)"+
                             " VALUES ('" + this.txtRuc.Text + "', '" + this.txtNombre.Text + "', '" + this.txtCelular.Text + "',"
                                        + " '" + this.txtTelefono.Text + "', '" + this.txtDireccion.Text + "', '" + this.txtEmail.Text + "', '1');";

            this.DataBase.ejecutaNoConsulta(comando);
            if(this.DataBase.Error == null)
            {
                String consulta = "SELECT * FROM abc_barcelona.tb_cliente where id_cedulaClient ="+ this.txtRuc.Text + ";";
                this.Valido = true;
                this.dataCliente = this.DataBase.getRow(consulta);

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
            String consulta = "SELECT id_descuento,Categoria,`descuento%`,rangoMinimo,rangoMaximo FROM abc_barcelona.tb_descuento;";

            DataTable tablaDescuento = new DataTable();

            this.DataBase.GetDataTabla(consulta, this.tablaDescuento);

            if (this.DataBase.Error == null)
            {
                this.listaCategoria = this.DataBase.getColumn(this.tablaDescuento, "Categoria");
                this.cbTipoCliente.DataSource = this.listaCategoria;
            }
            else
            { MessageBox.Show(this.DataBase.Error); }
        }
    }
}
