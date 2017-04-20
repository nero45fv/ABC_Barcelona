namespace WindowsFormsApplication1
{
    partial class FormBuscProducto
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
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.rb_BuscarCodigo = new System.Windows.Forms.RadioButton();
            this.rb_BuscarNombre = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancelar.Location = new System.Drawing.Point(646, 389);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(98, 32);
            this.bt_Cancelar.TabIndex = 0;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(12, 50);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(732, 319);
            this.dgv_productos.TabIndex = 1;
            this.dgv_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellDoubleClick);
            this.dgv_productos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_productos_MouseDoubleClick);
            // 
            // rb_BuscarCodigo
            // 
            this.rb_BuscarCodigo.AutoSize = true;
            this.rb_BuscarCodigo.Checked = true;
            this.rb_BuscarCodigo.Location = new System.Drawing.Point(479, 14);
            this.rb_BuscarCodigo.Name = "rb_BuscarCodigo";
            this.rb_BuscarCodigo.Size = new System.Drawing.Size(112, 17);
            this.rb_BuscarCodigo.TabIndex = 3;
            this.rb_BuscarCodigo.TabStop = true;
            this.rb_BuscarCodigo.Text = "Buscar por Codigo";
            this.rb_BuscarCodigo.UseVisualStyleBackColor = true;
            // 
            // rb_BuscarNombre
            // 
            this.rb_BuscarNombre.AutoSize = true;
            this.rb_BuscarNombre.Location = new System.Drawing.Point(611, 14);
            this.rb_BuscarNombre.Name = "rb_BuscarNombre";
            this.rb_BuscarNombre.Size = new System.Drawing.Size(116, 17);
            this.rb_BuscarNombre.TabIndex = 4;
            this.rb_BuscarNombre.Text = "Buscar por Nombre";
            this.rb_BuscarNombre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // FormBuscProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rb_BuscarNombre);
            this.Controls.Add(this.rb_BuscarCodigo);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.bt_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.RadioButton rb_BuscarCodigo;
        private System.Windows.Forms.RadioButton rb_BuscarNombre;
        private System.Windows.Forms.TextBox textBox1;
    }
}