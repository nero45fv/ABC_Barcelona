using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormProducto : Form
    {
        internal ConecDBmySql DataBase
        { get; set; }
        private ArrayList rowFila;
        public Boolean aceptado;

        public FormProducto()
        {
            InitializeComponent();
            this.rowFila = new ArrayList();
        }

        private void txtCodigio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Al pulsar una numero
            {
                e.Handled = false; //Se acepta (todo OK)
                llenarTxt();
            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false;//Se acepta (todo OK)
                llenarTxt();
            }
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void llenarTxt()
        {
          String  comando = "SELECT id_bodegaProdutos as Codigo, cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                          "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos = " + this.txtCodigio.Text + ";";
            ArrayList row = this.DataBase.getRow(comando);
            if (row.Count > 0)
            {
                llegarTextBox(row);
                //this.txtCantiB.Text = this.rowFila.Add(row[1]).ToString();
                //this.txtNombre.Text = this.rowFila.Add(row[2]).ToString();
                //this.txtCantidad.Text = this.rowFila.Add(0).ToString();
                //this.lbPrecioU.Text = this.rowFila.Add(row[3]).ToString();
                //this.txtPrecioT.Text = this.rowFila.Add(0).ToString();
            }
            
        }

        public void llenarTxt(int Codigo)
        {
            String comando = "SELECT id_bodegaProdutos as Codigo, cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                            "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos = " + Codigo + ";";
            ArrayList row = this.DataBase.getRow(comando);
            if (row.Count > 0)
            {
                this.txtCodigio.Enabled = false;
                this.txtCodigio.ReadOnly = true;
                llegarTextBox(row);
                //this.txtCodigio.Text = this.rowFila.Add(row[0]).ToString();
                //this.txtCantiB.Text = this.rowFila.Add(row[1]).ToString();
                //this.txtNombre.Text = this.rowFila.Add(row[2]).ToString();
                //this.txtCantidad.Text = this.rowFila.Add(0).ToString();
                //this.lbPrecioU.Text = this.rowFila.Add(row[3]).ToString();
                //this.txtPrecioT.Text = this.rowFila.Add(0).ToString();
            }
        }

        public void cargarDatos(ArrayList row)
        {
            this.txtCodigio.Enabled = false;
            this.txtCodigio.ReadOnly = true;
            llegarTextBox(row);
        }

        private void llegarTextBox(ArrayList row)
        {
            this.rowFila.Add(row[0]).ToString();
            this.rowFila.Add(row[1]).ToString();
            this.rowFila.Add(row[2]).ToString();
            this.rowFila.Add(0).ToString();
            this.rowFila.Add(row[3]).ToString();
            this.rowFila.Add(0).ToString();

            for (int i = 0; this.rowFila.Count > i; i++)
            {
                switch (i)
                {
                    case 0:
                        this.txtCodigio.Text = this.rowFila[i].ToString();
                        break;
                    case 1:
                        this.txtCantiB.Text = this.rowFila[i].ToString();
                        break;
                    case 2:
                        this.txtNombre.Text = this.rowFila[i].ToString();
                        break;
                    case 3:
                        this.txtCantidad.Text = this.rowFila[i].ToString();
                        break;
                    case 4:
                        this.lbPrecioU.Text = "$"+ Convert.ToDouble(this.rowFila[i], CultureInfo.CreateSpecificCulture("es-ES"));
                        break;
                    case 5:
                        this.txtPrecioT.Text = this.rowFila[i].ToString();
                        break;
                }
            }
        }

        public ArrayList getDatos()
        {
            ArrayList row = new ArrayList();
            row.Add(this.rowFila[0]); // txtCodigio
            row.Add(this.rowFila[2]); // txtNombre
            row.Add(this.rowFila[3]); // txtCantidad
            row.Add(this.rowFila[4]); // lbPrecioU
            row.Add(this.rowFila[5]); // txtPrecioT

            return row;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAcceptar_Click(object sender, EventArgs e)
        {
            Double cantidad = Convert.ToDouble(this.txtCantidad.Text, CultureInfo.CreateSpecificCulture("es-ES"));
            Double cantidadBodega = Convert.ToDouble(this.rowFila[1], CultureInfo.CreateSpecificCulture("es-ES"));
            if (cantidad <= cantidadBodega)
            {
                this.aceptado = true;
                this.rowFila[3] = cantidad;
                this.rowFila[5] = Convert.ToDouble(this.txtCantidad.Text, CultureInfo.CreateSpecificCulture("es-ES")) * Convert.ToDouble(rowFila[4].ToString(), CultureInfo.CreateSpecificCulture("es-ES"));
                this.rowFila = new ArrayList();
                this.Hide();
            }else
            { MessageBox.Show("Error: La Cantidad es mayor a la cantidad q hay en Bodega"); }
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) //object sender, KeyPressEventArgs e
        {
            if (Char.IsNumber(e.KeyChar))//Al pulsar una numero
            {
                String tem = this.txtCantidad.Text + e.KeyChar;
                e.Handled = false; //Se acepta (todo OK)
                if (tem != "")
                {
                    Double canti = Convert.ToDouble(tem, CultureInfo.CreateSpecificCulture("es-ES"));
                    Double precioU = Convert.ToDouble(rowFila[4], CultureInfo.CreateSpecificCulture("es-ES"));
                    Double temp = canti * precioU;
                    this.txtPrecioT.Text = temp.ToString();
                }
            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                String tem = this.txtCantidad.Text + e.KeyChar;
                e.Handled = false; //Se acepta (todo OK)
                //int i = tem
                if (tem != "")
                {
                    Double canti = Convert.ToDouble(tem, CultureInfo.CreateSpecificCulture("es-ES"));
                    Double precioU = Convert.ToDouble(rowFila[4], CultureInfo.CreateSpecificCulture("es-ES"));
                    Double temp = canti * precioU;
                    this.txtPrecioT.Text = temp.ToString();
                }
            }
            else if (e.KeyChar == '.')//Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false;//Se acepta (todo OK)
            }
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
            
        }
        

        private void FormProducto_Load(object sender, EventArgs e)
        {
            
            this.aceptado = false;
            this.txtCodigio.Enabled = true;
            this.txtCantiB.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtCantidad.Enabled = true;
            this.lbPrecioU.Enabled = true;
            this.txtPrecioT.Enabled = false;
        }

        //private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //if (this.txtCantidad.Text != "" && this.txtCantidad.Text != "0")
        //    //{
        //    //    Double canti = Convert.ToDouble(this.txtCantidad.Text, CultureInfo.CreateSpecificCulture("es-ES"));
        //    //    Double precioU = Convert.ToDouble(rowFila[4], CultureInfo.CreateSpecificCulture("es-ES"));
        //    //    Double temp = canti * precioU;
        //    //    this.txtPrecioT.Text = temp.ToString();
        //    //}
        //}

        //private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        //{

        //}
    }
}
