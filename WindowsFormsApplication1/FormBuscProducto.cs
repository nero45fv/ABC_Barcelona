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
    public partial class FormBuscProducto : Form
    {
        public List<string> dataProducto;
        internal ConecDBmySql DataBase
        { get; set; }

        public FormBuscProducto()
        {
            InitializeComponent();
            this.dataProducto = new List<string>();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String comando = "";
            if (Char.IsNumber(e.KeyChar))//Al pulsar una numero
            {
                e.Handled = false; //Se acepta (todo OK)
                if (this.rb_BuscarCodigo.Checked)
                {
                    this.textBox1.MaxLength = 13;
                    comando = "SELECT id_bodegaProdutos as Codigo,cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                                "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos like '%" + this.textBox1.Text + "%';";
                }
                llenarDGV(comando);
            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false;//Se acepta (todo OK)
                if (this.rb_BuscarNombre.Checked)
                {
                    this.textBox1.MaxLength = 50;
                    comando = "SELECT id_bodegaProdutos as Codigo,cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                               "FROM abc_barcelona.tb_bodegaprodutos WHERE nombre like '%" + this.textBox1.Text + "%';";
                }
                else if (this.rb_BuscarCodigo.Checked)
                {
                    this.textBox1.MaxLength = 13;
                    comando = "SELECT id_bodegaProdutos as Codigo,cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                                "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos like '%" + this.textBox1.Text + "%';";
                }
                llenarDGV(comando);
            }
            else if (Char.IsSeparator(e.KeyChar))//Al pulsar teclas como Espaarador y Espacio
            {
                e.Handled = false;//Se acepta (todo OK) 
                if (this.rb_BuscarNombre.Checked)
                {
                    this.textBox1.MaxLength = 50;
                    comando = "SELECT id_bodegaProdutos as Codigo,cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                               "FROM abc_barcelona.tb_bodegaprodutos WHERE nombre like '%" + this.textBox1.Text + "%';";
                }
                else if (this.rb_BuscarCodigo.Checked)
                {
                    this.textBox1.MaxLength = 13;
                    comando = "SELECT id_bodegaProdutos as Codigo,cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                                "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos like '%" + this.textBox1.Text + "%';";
                }
                llenarDGV(comando);
            }
            else if (Char.IsLetter(e.KeyChar))//Al pulsar teclas como Espaarador y Espacio
            {
                e.Handled = false;//Se acepta (todo OK)
                if (this.rb_BuscarNombre.Checked)
                {
                    this.textBox1.MaxLength = 50;
                    comando = "SELECT id_bodegaProdutos as Codigo,cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                               "FROM abc_barcelona.tb_bodegaprodutos WHERE nombre like '%" + this.textBox1.Text + "%';";
                }
                llenarDGV(comando);
            }
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void llenarDGV(String comando)
        {
            DataTable DataTable = new DataTable();
            DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            BindingSource tem = new BindingSource();
            this.dgv_productos.DataSource = tem;
            
            this.DataBase.GetDataTabla(comando, DataTable);

            tem.DataSource = DataTable;
        }


        //private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)

        //{

        //    if (e.Button == MouseButtons.Right && e.RowIndex > -1)
        //    {
        //        //para poner todos las Filas(rows) en Falso para evitar una una fila no selecionada 
        //        foreach (DataGridViewRow dr in this.dgv_productos.SelectedRows)
        //        { dr.Selected = false;}

        //        // Para seleccionar

        //        dgv_productos.Rows[e.RowIndex].Selected = true;

        //        // Para mostrar el menú

        //        this.menuContextual.Show(this.Left + this.dgv_productos.Left + e.X, this.Top + this.dgv_productos.Top + e.Y);

        //    }

        //}



        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //comando = "SELECT id_bodegaProdutos as Codigo,cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
            //                   "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos like '%" + this.textBox1.Text + "%';";

            if ((e.RowIndex > -1))
            {
                //obtienes la fila seleccionada
                this.dataProducto.Add(dgv_productos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                this.dataProducto.Add(dgv_productos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                this.dataProducto.Add(dgv_productos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());
                this.dataProducto.Add(dgv_productos.Rows[e.RowIndex].Cells["PrecioUnitario"].Value.ToString());
                this.bt_Cancelar_Click(sender, e);
            }
        }

        private void dgv_productos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        
    }
}
