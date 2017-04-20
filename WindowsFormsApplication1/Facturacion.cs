using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Facturacion
    {
        private Panel pantalla;
        private Panel infoFactura;
        private GroupBox groupCliente;
        private Font FuenteLeta;
        private DataGridView dataGVDetallesFact;
        private ContextMenuStrip menuContextual;
        private ToolStripMenuItem agregarProductoTSMenuItem;
        private ToolStripMenuItem eliminarProductoTSMenuItem;

        private FormBuscProducto buscarProducto;

        private ConecDBmySql dataBase;
        //public DataTable data_Descuento;
        private DataTable data_iva;
        private int id_Iva;
        private String id_empleado;
        // private DataGridViewTextBoxColumn colcodigo;

        #region Variables groupCliente
        private Label lbNomCliente;
        private TextBox txtNomCliente;
        private Label lbFonoCliente;
        private TextBox txtFonoCliente;
        private Label lbDirecCliente;
        private TextBox txtDirecCliente;
        private Label lbRucCliente;
        private TextBox txtRucCliente;
        private Button btNewCliente;
        private Button btBuscarNombre;
        private Button btBuscarCI;
        private Label lbNumeroFactura;
        private Label lbFactura;
        private Label lbVerFecha;
        private Label lbfecha;
        #endregion

        #region Variables infoFactura
        private Label lb_nombreEmpreado;
        private Label lb_subTotal;
        private Label lb_valorSubTotal;
        private Label lb_descuento;
        private Label lb_valorDescuento;
        private TextBox txtDescuento;
        private Label lb_iva;
        private Label lb_valorIva;
        private Label lb_total;
        private Label lb_valorTotal;
        private Button bt_imprimir;
        #endregion

        public Facturacion(Panel Pantalla, ConecDBmySql DataBase,Point ubicacion, Size tamaño)
        {

            #region inicializacion de Objetos
            this.dataBase = DataBase;
            //this.data_Descuento = new DataTable();
            this.data_iva = new DataTable();
            this.pantalla = new Panel();
            this.groupCliente = new GroupBox();
            this.FuenteLeta = new Font(groupCliente.Font.Name, groupCliente.Font.Size, groupCliente.Font.Style);
            this.dataGVDetallesFact = new DataGridView();
            this.infoFactura = new Panel();

            this.menuContextual = new ContextMenuStrip();
            this.agregarProductoTSMenuItem = new ToolStripMenuItem();
            this.eliminarProductoTSMenuItem = new ToolStripMenuItem();

            this.buscarProducto = new FormBuscProducto();
            this.buscarProducto.DataBase = this.dataBase;
            #endregion



            Pantalla.Controls.Add(this.pantalla);
            this.pantalla.Location = ubicacion;
            this.pantalla.Size = tamaño;
            this.pantalla.BackColor = Color.White;
            this.pantalla.Hide();

            #region Agregando Objetos a la Pantalla
            this.pantalla.Controls.Add(this.groupCliente);
            this.pantalla.Controls.Add(this.dataGVDetallesFact);
            this.pantalla.Controls.Add(this.infoFactura);
            #endregion

            #region Configurando Objetos groupCliente

            #region Inicializa Objetos
            this.lbNomCliente = new Label();
            this.txtNomCliente = new TextBox();
            this.lbFonoCliente = new Label();
            this.txtFonoCliente = new TextBox();
            this.lbDirecCliente = new Label();
            this.txtDirecCliente = new TextBox();
            this.lbRucCliente = new Label();
            this.txtRucCliente = new TextBox();
            this.btBuscarNombre = new Button();
            this.btBuscarCI = new Button();
            this.btNewCliente = new Button();
            this.lbFactura = new Label();
            this.lbNumeroFactura = new Label();
            this.lbVerFecha = new Label();
            this.lbfecha = new Label();
            #endregion

            #region Agregando Objetos a la groupCliente
            this.groupCliente.Controls.Add(this.lbRucCliente);
            this.groupCliente.Controls.Add(this.txtRucCliente);
            this.groupCliente.Controls.Add(this.lbNomCliente);
            this.groupCliente.Controls.Add(this.txtNomCliente);
            this.groupCliente.Controls.Add(this.lbFonoCliente);
            this.groupCliente.Controls.Add(this.txtFonoCliente);
            this.groupCliente.Controls.Add(this.lbDirecCliente);
            this.groupCliente.Controls.Add(this.txtDirecCliente);
            this.groupCliente.Controls.Add(this.btNewCliente);
            this.groupCliente.Controls.Add(this.btBuscarNombre);
            this.groupCliente.Controls.Add(this.btBuscarCI);
            this.groupCliente.Controls.Add(this.lbfecha);
            this.groupCliente.Controls.Add(this.lbVerFecha);
            this.groupCliente.Controls.Add(this.lbNumeroFactura);
            this.groupCliente.Controls.Add(this.lbFactura);
            #endregion

            #region Comfiguracion Asset Cliente
            int marge = 20;
            int separacion = 10;
            int ancho = this.pantalla.Size.Width - (marge * 2);
            int altoObjetos = this.txtRucCliente.Size.Height;
            int anchoBotones = 60 * 2;
            int anchoLabel = 75;
            // objetos Label
            this.lbRucCliente.Name = "lbRucCliente";
            this.lbRucCliente.Text = "Cedula o Ruc:";
            this.lbRucCliente.Location = new Point(marge, marge);
            this.lbRucCliente.Size = new Size(anchoLabel, altoObjetos);
            this.txtRucCliente.Name = "txtRucCliente";
            this.txtRucCliente.Location = new Point(this.lbRucCliente.Location.X + this.lbRucCliente.Size.Width + separacion, this.lbRucCliente.Location.Y - 4);
            this.txtRucCliente.Size = new Size((ancho / 3) - this.lbRucCliente.Size.Width, altoObjetos);
            this.txtRucCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            this.txtRucCliente.MaxLength = 13;

            this.btBuscarCI.Name = "btBuscarCI";
            this.btBuscarCI.Text = "Buscar por Ruc o CI";
            this.btBuscarCI.Location = new Point(this.txtRucCliente.Location.X + this.txtRucCliente.Size.Width + separacion, this.txtRucCliente.Location.Y);
            this.btBuscarCI.Size = new Size(anchoBotones, altoObjetos);
            this.btBuscarCI.BackColor = Color.White;

            this.lbNomCliente.Name = "lbNomCliente";
            this.lbNomCliente.Text = "Nombre:";
            this.lbNomCliente.Location = new Point(marge, this.lbRucCliente.Location.Y + this.lbRucCliente.Size.Height + separacion);
            this.lbNomCliente.Size = new Size(anchoLabel, altoObjetos);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Location = new Point(this.lbNomCliente.Location.X + this.lbNomCliente.Size.Width + separacion, this.lbNomCliente.Location.Y - 4);
            this.txtNomCliente.Size = new Size((ancho / 3) - this.lbNomCliente.Size.Width, altoObjetos);
            this.txtNomCliente.Enabled = false;

            this.btBuscarNombre.Name = "btBuscarNombre";
            this.btBuscarNombre.Text = "Buscar por Nombre";
            this.btBuscarNombre.Location = new Point(this.txtNomCliente.Location.X + this.txtNomCliente.Size.Width + separacion, this.txtNomCliente.Location.Y);
            this.btBuscarNombre.Size = new Size(anchoBotones, altoObjetos);
            this.btBuscarNombre.BackColor = Color.White;

            this.lbFonoCliente.Name = "lbRucCliente";
            this.lbFonoCliente.Text = "Telefono:";
            this.lbFonoCliente.Location = new Point(marge, this.lbNomCliente.Location.Y + this.lbNomCliente.Size.Height + separacion);
            this.lbFonoCliente.Size = new Size(anchoLabel, altoObjetos);
            this.txtFonoCliente.Name = "txtFonoCliente";
            this.txtFonoCliente.Location = new Point(this.lbFonoCliente.Location.X + this.lbFonoCliente.Size.Width + separacion, this.lbFonoCliente.Location.Y - 4);
            this.txtFonoCliente.Size = new Size((ancho / 3) - this.lbFonoCliente.Size.Width, altoObjetos);
            this.txtFonoCliente.Enabled = false;

            this.btNewCliente.Name = "btNewCliente";
            this.btNewCliente.Text = "Nuevo Cliente";
            this.btNewCliente.Location = new Point(this.txtFonoCliente.Location.X + this.txtFonoCliente.Size.Width + separacion, this.txtFonoCliente.Location.Y);
            this.btNewCliente.Size = new Size(anchoBotones, altoObjetos);
            this.btNewCliente.BackColor = Color.White;

            this.lbDirecCliente.Name = "lbDirecCliente";
            this.lbDirecCliente.Text = "Direccion:";
            this.lbDirecCliente.Location = new Point(this.btBuscarCI.Location.X + this.btBuscarCI.Size.Width + separacion, marge);
            this.lbDirecCliente.Size = new Size(anchoLabel, altoObjetos);
            this.txtDirecCliente.Name = "txtDirecCliente";
            this.txtDirecCliente.Location = new Point(this.lbDirecCliente.Location.X + this.lbDirecCliente.Size.Width + separacion, this.lbDirecCliente.Location.Y - 4);
            this.txtDirecCliente.Size = new Size(ancho - this.txtDirecCliente.Location.X - marge, altoObjetos);
            this.txtDirecCliente.Enabled = false;
            #endregion

            this.groupCliente.Name = "groupCliente";
            this.groupCliente.Text = "Datos del Cliente";
            this.groupCliente.Location = new Point(marge, marge - 4);
            this.groupCliente.Size = new Size(this.txtDirecCliente.Location.X + this.txtDirecCliente.Size.Width + marge, this.btNewCliente.Location.Y + this.btNewCliente.Size.Height + marge - 6);
            this.groupCliente.TabStop = false;
            this.groupCliente.BackColor = Color.LightGray;
            
            #region Configuracion Asset Informacion de Factura
            float tamañoFontSize = this.FuenteLeta.Size + 10.0f;
            int y = this.lbfecha.Size.Height + 3;
            int poinYfecha = ((this.groupCliente.Size.Height - this.txtDirecCliente.Location.Y + this.txtDirecCliente.Size.Height) / 2);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Text = "Fecha:";
            this.lbfecha.Font = new Font(this.FuenteLeta.Name, tamañoFontSize, FontStyle.Bold);
            this.lbfecha.Location = new Point(this.btBuscarNombre.Location.X + this.btBuscarNombre.Size.Width + separacion, poinYfecha);
            this.lbfecha.Size = new Size(100, this.lbfecha.Size.Height + 3);

            this.lbVerFecha.Name = "lbVerFecha";
            this.lbVerFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.lbVerFecha.Font = new Font(this.FuenteLeta.Name, tamañoFontSize, FontStyle.Regular);
            this.lbVerFecha.Location = new Point(this.lbfecha.Location.X + this.lbfecha.Size.Width, poinYfecha);
            this.lbVerFecha.Size = new Size(200, this.lbfecha.Size.Height);
            this.lbVerFecha.ForeColor = Color.Blue;

            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Text = "N° Factura:";
            this.lbFactura.Font = new Font(this.FuenteLeta.Name, tamañoFontSize, FontStyle.Bold);
            this.lbFactura.Location = new Point(this.lbVerFecha.Location.X + this.lbVerFecha.Size.Width + separacion, poinYfecha);
            this.lbFactura.Size = new Size(160, this.lbfecha.Size.Height + 3);

            this.lbNumeroFactura.Name = "lbNumFactua";
            this.lbNumeroFactura.Text = "000-000-000";
            this.lbNumeroFactura.Font = new Font(this.FuenteLeta.Name, tamañoFontSize, FontStyle.Regular);
            this.lbNumeroFactura.Location = new Point(this.lbFactura.Location.X + this.lbFactura.Size.Width, poinYfecha);
            this.lbNumeroFactura.Size = new Size(200, this.lbfecha.Size.Height);
            this.lbNumeroFactura.ForeColor = Color.Red;
            #endregion

            #endregion

            #region configuracion Asset Detalle de factura

            this.dataGVDetallesFact.Name = "dataGVDetallesFact";
            this.dataGVDetallesFact.Location = new Point(this.groupCliente.Location.X, this.groupCliente.Location.Y + this.groupCliente.Size.Height + 10);
            this.dataGVDetallesFact.Size = new Size(this.groupCliente.Size.Width, (this.pantalla.Size.Height - this.dataGVDetallesFact.Location.Y) - this.groupCliente.Size.Height);
            //this.dataGVDetallesFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            this.dataGVDetallesFact.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGVDetallesFact.ContextMenuStrip = this.menuContextual;

            #region add Columnas al dataGVDetallesFact
            if (dataGVDetallesFact.Columns.Count.Equals(0))

            {
                DataGridViewTextBoxColumn idProdu = new DataGridViewTextBoxColumn();
                idProdu.HeaderText = "Codigo";
                idProdu.Name = "id_bodegaProdutos";
                idProdu.Width = 75;
                idProdu.MaxInputLength = 5;
                


                DataGridViewTextBoxColumn CantidaProdu = new DataGridViewTextBoxColumn();
                CantidaProdu.HeaderText = "Cantidad";
                CantidaProdu.Name = "cantidad";
                CantidaProdu.Width = 75;
                CantidaProdu.MaxInputLength = 5;

                DataGridViewTextBoxColumn PrecioUProdu = new DataGridViewTextBoxColumn();
                PrecioUProdu.HeaderText = "Precio Unitario";
                PrecioUProdu.Name = "precioUnitario";
                PrecioUProdu.Width = 175;
                PrecioUProdu.ReadOnly = true;

                DataGridViewTextBoxColumn PrecioTProdu = new DataGridViewTextBoxColumn();
                PrecioTProdu.HeaderText = "Precio Final";
                PrecioTProdu.Name = "precioTotal";
                PrecioTProdu.Width = 175;
                PrecioTProdu.ReadOnly = true;

                DataGridViewTextBoxColumn nombreProdu = new DataGridViewTextBoxColumn();
                nombreProdu.HeaderText = "Producto";
                nombreProdu.Name = "nombre";
                nombreProdu.Width = dataGVDetallesFact.Size.Width - idProdu.Width - CantidaProdu.Width - PrecioUProdu.Width - PrecioTProdu.Width;
                nombreProdu.ReadOnly = true;

                dataGVDetallesFact.Columns.Add(idProdu);
                dataGVDetallesFact.Columns.Add(nombreProdu);
                dataGVDetallesFact.Columns.Add(CantidaProdu);
                dataGVDetallesFact.Columns.Add(PrecioUProdu);
                dataGVDetallesFact.Columns.Add(PrecioTProdu);
            }
            #endregion

            this.menuContextual.Name = "menuContextual";
            this.menuContextual.Size = new System.Drawing.Size(169, 48);


            this.menuContextual.Items.Add(agregarProductoTSMenuItem);
            this.menuContextual.Items.Add(eliminarProductoTSMenuItem);


            this.agregarProductoTSMenuItem.Name = "agregarProductoTSMenuItem";
            this.agregarProductoTSMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarProductoTSMenuItem.Text = "Agregar Producto";
            this.agregarProductoTSMenuItem.Click += new System.EventHandler(this.agregarProductoTSMenuItem_Click);

            this.eliminarProductoTSMenuItem.Name = "agregarProductoTSMenuItem";
            this.eliminarProductoTSMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eliminarProductoTSMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoTSMenuItem.Click += new System.EventHandler(this.eliminarProductoTSMenuItem_Click);

            #endregion

            #region Informacion de Factura 

            #region Inicializa Objetos
            this.lb_nombreEmpreado = new Label();
            this.lb_subTotal = new Label();
            this.lb_valorSubTotal = new Label();
            this.lb_descuento = new Label();
            this.lb_valorDescuento = new Label();
            this.txtDescuento = new TextBox();
            this.lb_iva = new Label();
            this.lb_valorIva = new Label();
            this.lb_total = new Label();
            this.lb_valorTotal = new Label();
            this.bt_imprimir = new Button();
            #endregion

            this.infoFactura.Name = "infoFactura";
            this.infoFactura.Location = new Point(this.dataGVDetallesFact.Location.X, this.dataGVDetallesFact.Location.Y + this.dataGVDetallesFact.Size.Height + 10);
            this.infoFactura.Size = new Size(this.dataGVDetallesFact.Size.Width, ((this.pantalla.Size.Height - this.dataGVDetallesFact.Size.Height) - this.groupCliente.Size.Height) - 50);
            this.infoFactura.BackColor = Color.LightGray;

            #region Agregar Objetos al Panel infoFactura
            this.infoFactura.Controls.Add(this.lb_subTotal);
            this.infoFactura.Controls.Add(this.lb_valorSubTotal);
            this.infoFactura.Controls.Add(this.lb_descuento);
            this.infoFactura.Controls.Add(this.lb_valorDescuento);
            this.infoFactura.Controls.Add(this.txtDescuento);
            this.infoFactura.Controls.Add(this.lb_iva);
            this.infoFactura.Controls.Add(this.lb_valorIva);
            this.infoFactura.Controls.Add(this.lb_total);
            this.infoFactura.Controls.Add(this.lb_valorTotal);
            this.infoFactura.Controls.Add(this.lb_nombreEmpreado);
            this.infoFactura.Controls.Add(this.bt_imprimir);
            #endregion

            #region Configuracion Objetos

            int margenIF = 10;
            float tamañoLetraIF= this.FuenteLeta.Size + 4.0f;
            int separacionIF = 10;

            this.lb_subTotal.Name = "lbRucCliente";
            this.lb_subTotal.Text = "SubTotal: $";
            this.lb_subTotal.Location = new Point(margenIF, margenIF);
            this.lb_subTotal.AutoSize = true;
            this.lb_subTotal.Font = new Font(this.FuenteLeta.Name, tamañoLetraIF, FontStyle.Regular);

            this.lb_valorSubTotal.Name = "lb_valorSubTotal";
            this.lb_valorSubTotal.Text = "0.00";
            this.lb_valorSubTotal.Location = new Point(this.lb_subTotal.Location.X + this.lb_subTotal.Size.Width, margenIF);
            this.lb_valorSubTotal.AutoSize = true;
            this.lb_valorSubTotal.ForeColor = Color.DarkBlue;
            this.lb_valorSubTotal.Font = this.lb_subTotal.Font;

            this.lb_descuento.Name = "lb_descuento";
            this.lb_descuento.Text = "Descuento: $";
            this.lb_descuento.Location = new Point(this.lb_valorSubTotal.Location.X + this.lb_valorSubTotal.Size.Width + separacionIF, margenIF);
            this.lb_descuento.AutoSize = true;
            this.lb_descuento.Font = this.lb_subTotal.Font;

            this.lb_valorDescuento.Name = "lb_valorDescuento";
            this.lb_valorDescuento.Text = "0.00";
            this.lb_valorDescuento.Location = new Point(this.lb_descuento.Location.X + this.lb_descuento.Size.Width, margenIF);
            this.lb_valorDescuento.AutoSize = true;
            this.lb_valorDescuento.ForeColor = Color.DarkBlue;
            this.lb_valorDescuento.Font = this.lb_subTotal.Font;

            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Text = "0%";
            this.txtDescuento.Location = new Point(this.lb_valorDescuento.Location.X + this.lb_valorDescuento.Size.Width + separacionIF, margenIF - 4);
            this.txtDescuento.AutoSize = true;
            this.txtDescuento.ForeColor = Color.DarkBlue;
            this.txtDescuento.Font = this.lb_subTotal.Font;
            this.txtDescuento.ReadOnly = true;


            this.lb_iva.Name = "lb_iva";
            this.lb_iva.Text = "Iva ";
            this.lb_iva.Location = new Point(this.txtDescuento.Location.X + this.txtDescuento.Size.Width + separacionIF, margenIF);
            this.lb_iva.AutoSize = true;
            this.lb_iva.Font = this.lb_subTotal.Font;

            this.lb_valorIva.Name = "lb_valorIva";
            this.lb_valorIva.Text = "0.00";
            this.lb_valorIva.Location = new Point(this.lb_iva.Location.X + this.lb_iva.Size.Width, margenIF);
            this.lb_valorIva.AutoSize = true;
            this.lb_valorIva.ForeColor = Color.DarkBlue;
            this.lb_valorIva.Font = this.lb_subTotal.Font;
            

            this.lb_total.Name = "lb_total";
            this.lb_total.Text = "Total";
            this.lb_total.Location = new Point(this.lb_subTotal.Location.X + this.lb_subTotal.Size.Width + separacionIF, this.lb_subTotal.Location.Y + this.lb_subTotal.Size.Height + separacionIF);
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new Font (this.FuenteLeta.FontFamily,this.FuenteLeta.Size+20f,FontStyle.Bold,this.FuenteLeta.Unit);

            this.lb_valorTotal.Name = "lb_valorTotal";
            this.lb_valorTotal.Text = "0.00";
            this.lb_valorTotal.Location = new Point(this.lb_total.Location.X + this.lb_total.Size.Width, this.lb_total.Location.Y);
            this.lb_valorTotal.AutoSize = true;
            this.lb_valorTotal.ForeColor = Color.DarkBlue;
            this.lb_valorTotal.Font = this.lb_total.Font;

            this.lb_nombreEmpreado.Name = "lb_nombreEmpreado";
            this.lb_nombreEmpreado.Text = "";
            this.lb_nombreEmpreado.AutoSize = true;
            this.lb_nombreEmpreado.ForeColor = Color.DarkSlateBlue;
            this.lb_nombreEmpreado.Font = new Font(this.FuenteLeta.Name, tamañoLetraIF+20f, FontStyle.Bold);
            this.lb_nombreEmpreado.Location = new Point(this.lb_valorIva.Location.X + this.lb_valorIva.Size.Width + separacionIF, this.infoFactura.Size.Height/2);

            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.Size = new Size(150, (this.infoFactura.Size.Height - separacionIF) - separacionIF);
            this.bt_imprimir.Font = new Font(this.FuenteLeta.Name, tamañoLetraIF + 10f, FontStyle.Bold);
            this.bt_imprimir.Location = new Point((this.infoFactura.Size.Width - this.bt_imprimir.Size.Width) - separacionIF, separacionIF);
            this.bt_imprimir.BackColor = Color.White;
            #endregion


            #endregion
            //---------------------------------


        }

        private void agregarProductoTSMenuItem_Click(object sender, EventArgs e)
        {
            this.buscarProducto.ShowDialog();
        }

        private void eliminarProductoTSMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (Char.IsNumber(e.KeyChar))//Al pulsar una numero
            {
                e.Handled = false;//Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false;//Se acepta (todo OK)
            }
            //else if (Char.IsSeparator(e.KeyChar))//Al pulsar teclas como Espaarador y Espacio
            //{
            //    e.Handled = false;//Se acepta (todo OK)
            //}
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void TxtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))//Al pulsar una letra
            {
                e.Handled = false;//Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false;//Se acepta (todo OK)
            }
            else if (Char.IsSeparator(e.KeyChar))//Al pulsar teclas como Espaarador y Espacio
            {
                e.Handled = false;//Se acepta (todo OK)
            }
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)

        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {
                //para poner todos las Filas(rows) en Falso para evitar una una fila no selecionada 
                foreach (DataGridViewRow dr in this.dataGVDetallesFact.SelectedRows)
                { dr.Selected = false; }

                // Para seleccionar

                dataGVDetallesFact.Rows[e.RowIndex].Selected = true;

                // Para mostrar el menú

                this.menuContextual.Show(this.pantalla.Left + this.dataGVDetallesFact.Left + e.X, this.pantalla.Top + this.dataGVDetallesFact.Top + e.Y);

            }

        }

        public void VerPantallaFacturacion(DataTable Empleado)
        {
            
            //String consulta = "SELECT id_descuento,`descuento%` as Descuento,descuentoDecimal FROM abc_barcelona.tb_descuento;";
            //this.cb_listDescuento.DataSource = this.dataBase.getColumnString(consulta, this.data_Descuento, "Descuento");

            String consulta1 = "SELECT id_iva,`iva%` as Iva,ivaDecimal FROM abc_barcelona.tb_iva where valido = true;";
            this.dataBase.GetDataTabla(consulta1, this.data_iva);

            int i = 1;
            foreach (DataRow row in data_iva.Rows)
            {
                    if (i == data_iva.Rows.Count)
                    {
                        this.id_Iva = (int)row["id_iva"];
                        this.lb_iva.Text = this.lb_iva.Text + row["Iva"].ToString() + ": $";
                        break;
                    }
                i = i + 1;
            }

            this.lb_valorIva.Location = new Point(this.lb_iva.Location.X + this.lb_iva.Size.Width, this.lb_valorIva.Location.Y);

            foreach (DataRow row in Empleado.Rows)
            {
                foreach (DataColumn column in Empleado.Columns)
                {
                    this.id_empleado = row["id_cedulaEmpleado"].ToString();
                    this.lb_nombreEmpreado.Text = row["nombre"].ToString() +" "+ row["apellido"].ToString();
                }
            }
            this.lb_nombreEmpreado.Location = new Point(this.lb_valorIva.Location.X + this.lb_valorIva.Size.Width + 20, this.lb_nombreEmpreado.Location.Y - (this.lb_nombreEmpreado.Size.Height/2));

            pantalla.Show();
        }

        public void OcultarPantallaFacturacion()
        {
            pantalla.Hide();
        }
    }
}
