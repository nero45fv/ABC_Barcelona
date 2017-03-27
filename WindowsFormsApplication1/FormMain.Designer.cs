namespace WindowsFormsApplication1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoxLOGO = new System.Windows.Forms.PictureBox();
            this.panelBaner = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLOGO)).BeginInit();
            this.panelBaner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Gray;
            this.panelMain.Controls.Add(this.menuMain);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.contabilidadToolStripMenuItem});
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Name = "menuMain";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.proformaToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            resources.ApplyResources(this.facturacionToolStripMenuItem, "facturacionToolStripMenuItem");
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            resources.ApplyResources(this.facturaToolStripMenuItem, "facturaToolStripMenuItem");
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // proformaToolStripMenuItem
            // 
            this.proformaToolStripMenuItem.Name = "proformaToolStripMenuItem";
            resources.ApplyResources(this.proformaToolStripMenuItem, "proformaToolStripMenuItem");
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.ingresosToolStripMenuItem});
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            resources.ApplyResources(this.bodegaToolStripMenuItem, "bodegaToolStripMenuItem");
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            resources.ApplyResources(this.inventarioToolStripMenuItem, "inventarioToolStripMenuItem");
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProveedorToolStripMenuItem,
            this.facturaCompraToolStripMenuItem,
            this.nuevoProductoToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            resources.ApplyResources(this.ingresosToolStripMenuItem, "ingresosToolStripMenuItem");
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            resources.ApplyResources(this.nuevoProveedorToolStripMenuItem, "nuevoProveedorToolStripMenuItem");
            // 
            // facturaCompraToolStripMenuItem
            // 
            this.facturaCompraToolStripMenuItem.Name = "facturaCompraToolStripMenuItem";
            resources.ApplyResources(this.facturaCompraToolStripMenuItem, "facturaCompraToolStripMenuItem");
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            resources.ApplyResources(this.nuevoProductoToolStripMenuItem, "nuevoProductoToolStripMenuItem");
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            resources.ApplyResources(this.contabilidadToolStripMenuItem, "contabilidadToolStripMenuItem");
            // 
            // picBoxLOGO
            // 
            resources.ApplyResources(this.picBoxLOGO, "picBoxLOGO");
            this.picBoxLOGO.Name = "picBoxLOGO";
            this.picBoxLOGO.TabStop = false;
            // 
            // panelBaner
            // 
            this.panelBaner.BackColor = System.Drawing.Color.Yellow;
            this.panelBaner.Controls.Add(this.picBoxLOGO);
            resources.ApplyResources(this.panelBaner, "panelBaner");
            this.panelBaner.Name = "panelBaner";
            // 
            // FormMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panelBaner);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLOGO)).EndInit();
            this.panelBaner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proformaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxLOGO;
        private System.Windows.Forms.Panel panelBaner;
    }
}

