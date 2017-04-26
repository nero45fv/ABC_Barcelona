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
        }

        private void txtCodigio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Al pulsar una numero
            {
                String tem = this.txtCodigio.Text + e.KeyChar;
                e.Handled = false; //Se acepta (todo OK)

                if (tem != "")
                { llenarTxt(tem); }

            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                String tem = "";
                e.Handled = false; //Se acepta (todo OK)
                if(this.txtCodigio.Text.Length != 0)
                {
                    Char[] ArrayTemp = this.txtCodigio.Text.ToCharArray();

                    for (int i = 0; i < ArrayTemp.Length - 1; i++)
                    { tem = tem + ArrayTemp[i]; }

                    if (tem.Length != 0)
                    { llenarTxt(tem); }
                }
                
            }
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        public void limpiarTextbox()
        {
            this.txtCodigio.Enabled = true;
            this.txtCodigio.ReadOnly = false;
            this.txtCodigio.Text = "";
            this.txtCantiB.Text = "";
            this.txtNombre.Text = "";
            this.txtCantidad.Text = "";
            this.lbPrecioU.Text = "$ 0.00";
            this.txtPrecioT.Text = "";
        }

        private void llenarTxt(String Buscar)
        {
            this.rowFila = new ArrayList();
            this.txtCodigio.Enabled = true;
            this.txtCodigio.ReadOnly = false;
            this.aceptado = false;
            String  comando = "SELECT id_bodegaProdutos as Codigo, cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                          "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos = " + Buscar + ";";
            ArrayList row = this.DataBase.getRow(comando);
            if (row.Count > 0)
            {
                llegarTextBox(row,false);
            }
            
        }

        public void llenarTxt(int Codigo)
        {
            this.rowFila = new ArrayList();
            this.aceptado = false;
            String comando = "SELECT id_bodegaProdutos as Codigo, cantidad as Cantidad,nombre as Nombre,precioVentPubli as PrecioUnitario " +
                            "FROM abc_barcelona.tb_bodegaprodutos WHERE id_bodegaProdutos = " + Codigo + ";";
            ArrayList row = this.DataBase.getRow(comando);
            if (row.Count > 0)
            {
                this.txtCodigio.Enabled = false;
                this.txtCodigio.ReadOnly = true;
                llegarTextBox(row,true);
            }
        }

        public void cargarDatos(ArrayList row)
        {
            this.rowFila = new ArrayList();
            this.aceptado = false;
            this.txtCodigio.Enabled = false;
            this.txtCodigio.ReadOnly = true;
            llegarTextBox(row,true);
        }

        private void llegarTextBox(ArrayList row,Boolean codigo)
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
                        if (codigo) { this.txtCodigio.Text = this.rowFila[i].ToString(); }
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
                    Decimal canti = Convert.ToDecimal(tem);
                    Decimal precioU = Convert.ToDecimal(rowFila[4]);
                    Decimal temp = canti * precioU;
                    this.txtPrecioT.Text = temp.ToString();
                }
            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                String tem = "";
                e.Handled = false; //Se acepta (todo OK)
                if (this.txtCantidad.Text.Length != 0)
                {
                    Char[] ArrayTemp = this.txtCantidad.Text.ToCharArray();
                    for (int i = 0; i < ArrayTemp.Length - 1; i++)
                    {
                        tem = tem + ArrayTemp[i];
                    }
                    if (tem.Length != 0)
                    {
                        Decimal canti = Convert.ToDecimal(tem);
                        Decimal precioU = Convert.ToDecimal(rowFila[4]);
                        Decimal temp = canti * precioU;
                        this.txtPrecioT.Text = temp.ToString();
                    }
                    else
                    {
                        this.txtPrecioT.Text = "0";
                    }
                }
            }
            else if (e.KeyChar == '.')//Al pulsar teclas como Borrar y eso.
            {
                String tem = this.txtCantidad.Text + e.KeyChar;
                if(tem.Length <= 1)
                {
                    e.Handled = true;//no acepta (todo OK)
                }else
                {
                    Decimal canti = Convert.ToDecimal(tem);
                    Decimal precioU = Convert.ToDecimal(rowFila[4]);
                    Decimal temp = canti * precioU;
                    this.txtPrecioT.Text = temp.ToString();
                }
                
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
