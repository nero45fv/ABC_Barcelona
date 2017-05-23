﻿using System;
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
    public partial class FormBuscCliente: Form
    {
        public ArrayList dataCliente;
        public bool producEncotrado;
        //dataProducto dataProduc;
        public DataTable tablaDescuento;

        internal ConecDBmySql DataBase
        { get; set; }

        public FormBuscCliente()
        {
            InitializeComponent();
            #region add Columnas al dataGVDetallesFact
            if (this.dgv_productos.Columns.Count.Equals(0))

            {
                DataGridViewTextBoxColumn idProdu = new DataGridViewTextBoxColumn();
                idProdu.HeaderText = "Codigo";
                idProdu.Name = "id_bodegaProdutos";
                idProdu.Width = 50;
                idProdu.ReadOnly = true;

                DataGridViewTextBoxColumn CantidaProdu = new DataGridViewTextBoxColumn();
                CantidaProdu.HeaderText = "Cantidad";
                CantidaProdu.Name = "cantiBodega";
                CantidaProdu.Width = 50;
                CantidaProdu.ReadOnly = true;

                DataGridViewTextBoxColumn PrecioUProdu = new DataGridViewTextBoxColumn();
                PrecioUProdu.HeaderText = "Precio Unitario";
                PrecioUProdu.Name = "precioUnitario";
                PrecioUProdu.Width = 175;
                PrecioUProdu.ReadOnly = true;

                DataGridViewTextBoxColumn nombreProdu = new DataGridViewTextBoxColumn();
                nombreProdu.HeaderText = "Producto";
                nombreProdu.Name = "nombre";
                nombreProdu.Width = dgv_productos.Size.Width - idProdu.Width - CantidaProdu.Width - PrecioUProdu.Width;
                nombreProdu.ReadOnly = true;

                dgv_productos.Columns.Add(idProdu);
                dgv_productos.Columns.Add(CantidaProdu);
                dgv_productos.Columns.Add(nombreProdu);
                dgv_productos.Columns.Add(PrecioUProdu);
            }
            #endregion
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.producEncotrado = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Al pulsar una numero
            {
                String tem = this.textBox1.Text + e.KeyChar;
                e.Handled = false; //Se acepta (todo OK)
                this.textBox1.MaxLength = 50;
                if (tem != "")
                { llenarDGV(tem); }
                
            }
            else if (Char.IsControl(e.KeyChar))//Al pulsar teclas como Borrar y eso.
            {
                String tem = "";
                e.Handled = false; //Se acepta (todo OK)
                Char[] ArrayTemp = this.textBox1.Text.ToCharArray();
                this.textBox1.MaxLength = 50;
                for (int i = 0; i < ArrayTemp.Length - 1; i++)
                {
                    tem = tem + ArrayTemp[i];
                }
                if (tem.Length != 0)
                { llenarDGV(tem); }
            }
            else if (Char.IsSeparator(e.KeyChar))//Al pulsar teclas como Espaarador y Espacio
            {
                String tem = this.textBox1.Text + e.KeyChar;
                e.Handled = false;//Se acepta (todo OK) 
                this.textBox1.MaxLength = 50;
                if (tem != "")
                { llenarDGV(tem); }
            }
            else if (Char.IsLetter(e.KeyChar))//Al pulsar teclas como Espaarador y Espacio
            {
                String tem = this.textBox1.Text + e.KeyChar;
                e.Handled = false;//Se acepta (todo OK)
                this.textBox1.MaxLength = 50;
                if (tem != "")
                { llenarDGV(tem); }
            }
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void llenarDGV(String Buscar)
        {
           String comando = "SELECT * FROM abc_barcelona.tb_cliente WHERE nomCliente like '%" + Buscar + "%';";

            limpiarDGVProductos();

            DataTable dataTable = new DataTable();
            this.DataBase.GetDataTabla(comando, dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                ArrayList newRow = new ArrayList();
                foreach (DataColumn column in dataTable.Columns)
                {
                    newRow.Add( row[column]);
                }
                dgv_productos.Rows.Add(newRow.ToArray());
            }
        }

        private void limpiarDGVProductos()
        {
            if (this.dgv_productos.RowCount > 1)
            {
                int limite = this.dgv_productos.RowCount;
                for (int i = 0; i < limite-1; i++)
                {
                    this.dgv_productos.Rows.RemoveAt(0);
                }
            }
        }


        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.producEncotrado = false;
        }

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1&& !(e.RowIndex==this.dgv_productos.RowCount-1) )
            {
                String comando = "SELECT * FROM abc_barcelona.tb_cliente WHERE nomCliente like '%" + dgv_productos.Rows[e.RowIndex].Cells[0].Value + "%';";
                this.dataCliente = this.DataBase.getRow(comando);

                this.Hide();
                this.producEncotrado = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}