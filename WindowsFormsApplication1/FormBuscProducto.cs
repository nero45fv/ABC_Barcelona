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
        internal ConecDBmySql DataBase
        { get; set; }

        public FormBuscProducto()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsNumber(e.KeyChar))//Al pulsar una numero
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
            else if (Char.IsLetter(e.KeyChar))//Al pulsar teclas como Espaarador y Espacio
            {
                e.Handled = false;//Se acepta (todo OK)
            }
            else//Para todo lo demas
            {
                e.Handled = true;//No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }
    }
}
