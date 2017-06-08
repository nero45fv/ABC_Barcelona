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
            this.picBoxLOGO = new System.Windows.Forms.PictureBox();
            this.panelBaner = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarProformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Name = "menuMain";
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem,
            this.proformaToolStripMenuItem,
            this.facturarProformaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            resources.ApplyResources(this.facturacionToolStripMenuItem, "facturacionToolStripMenuItem");
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // proformaToolStripMenuItem
            // 
            this.proformaToolStripMenuItem.Name = "proformaToolStripMenuItem";
            resources.ApplyResources(this.proformaToolStripMenuItem, "proformaToolStripMenuItem");
            this.proformaToolStripMenuItem.Click += new System.EventHandler(this.proformaToolStripMenuItem_Click_1);
            // 
            // facturarProformaToolStripMenuItem
            // 
            this.facturarProformaToolStripMenuItem.Name = "facturarProformaToolStripMenuItem";
            resources.ApplyResources(this.facturarProformaToolStripMenuItem, "facturarProformaToolStripMenuItem");
            this.facturarProformaToolStripMenuItem.Click += new System.EventHandler(this.facturarProformaToolStripMenuItem_Click_1);
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
        private System.Windows.Forms.PictureBox picBoxLOGO;
        private System.Windows.Forms.Panel panelBaner;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proformaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarProformaToolStripMenuItem;
    }
}

