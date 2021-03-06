﻿using System;
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
    public partial class FormMain : Form
    {
        public FormUser user;
        int alto;
        int ancho;
        public Boolean AccesoTotal;

        internal ConecDBmySql DataBase
        { get; set; }

        internal Facturacion Factu
        { get;set; }

        public FormMain()
        {
            InitializeComponent();
            this.user = new FormUser(this);
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            alto = this.Size.Height-25;
            ancho = this.Size.Width-5;
            picBoxLOGO.Location = new Point((ancho / 2) - (picBoxLOGO.Width / 2), 0);

            panelBaner.Location = new Point(0, 0);
            panelBaner.Size = new Size(ancho-12,picBoxLOGO.Size.Height);

            panelMain.Location = new Point(0,picBoxLOGO.Size.Height);
            panelMain.Size = new Size(panelBaner.Size.Width, (alto-15 )- picBoxLOGO.Size.Height);

            Factu = new Facturacion(this.panelMain, this.DataBase, new Point(5, 5 + menuMain.Size.Height), new Size(panelMain.Size.Width - 12 , (panelMain.Size.Height - menuMain.Size.Height) - 12));
            
        }


        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.user.entrarA("facturacion");
            this.user.ShowDialog();
        }
    }
}
