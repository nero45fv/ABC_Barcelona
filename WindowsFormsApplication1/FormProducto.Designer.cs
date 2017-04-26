namespace WindowsFormsApplication1
{
    partial class FormProducto
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
            this.btAcceptar = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCodigio = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtCantiB = new System.Windows.Forms.TextBox();
            this.lbCantiB = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPU = new System.Windows.Forms.Label();
            this.lbPrecioU = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.txtPrecioT = new System.Windows.Forms.TextBox();
            this.lbPT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAcceptar
            // 
            this.btAcceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcceptar.Location = new System.Drawing.Point(12, 354);
            this.btAcceptar.Name = "btAcceptar";
            this.btAcceptar.Size = new System.Drawing.Size(106, 35);
            this.btAcceptar.TabIndex = 1;
            this.btAcceptar.Text = "Aceptar";
            this.btAcceptar.UseVisualStyleBackColor = true;
            this.btAcceptar.Click += new System.EventHandler(this.btAcceptar_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(142, 47);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(86, 25);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "Codigo:";
            // 
            // txtCodigio
            // 
            this.txtCodigio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigio.Location = new System.Drawing.Point(136, 75);
            this.txtCodigio.Name = "txtCodigio";
            this.txtCodigio.Size = new System.Drawing.Size(100, 31);
            this.txtCodigio.TabIndex = 0;
            this.txtCodigio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigio_KeyPress);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(482, 352);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 35);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTitulo.Location = new System.Drawing.Point(165, 8);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(279, 29);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "Cantidad de Productos";
            // 
            // txtCantiB
            // 
            this.txtCantiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantiB.Location = new System.Drawing.Point(330, 75);
            this.txtCantiB.Name = "txtCantiB";
            this.txtCantiB.ReadOnly = true;
            this.txtCantiB.Size = new System.Drawing.Size(98, 31);
            this.txtCantiB.TabIndex = 5;
            // 
            // lbCantiB
            // 
            this.lbCantiB.AutoSize = true;
            this.lbCantiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantiB.Location = new System.Drawing.Point(272, 47);
            this.lbCantiB.Name = "lbCantiB";
            this.lbCantiB.Size = new System.Drawing.Size(214, 25);
            this.lbCantiB.TabIndex = 6;
            this.lbCantiB.Text = "Cantidad en Bodega:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(28, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(549, 31);
            this.txtNombre.TabIndex = 7;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(23, 110);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(93, 25);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbPU
            // 
            this.lbPU.AutoSize = true;
            this.lbPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPU.Location = new System.Drawing.Point(205, 181);
            this.lbPU.Name = "lbPU";
            this.lbPU.Size = new System.Drawing.Size(178, 29);
            this.lbPU.TabIndex = 9;
            this.lbPU.Text = "Precio Unitario:";
            // 
            // lbPrecioU
            // 
            this.lbPrecioU.AutoSize = true;
            this.lbPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioU.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbPrecioU.Location = new System.Drawing.Point(205, 213);
            this.lbPrecioU.Name = "lbPrecioU";
            this.lbPrecioU.Size = new System.Drawing.Size(178, 55);
            this.lbPrecioU.TabIndex = 10;
            this.lbPrecioU.Text = "$00.00";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(49, 297);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(113, 35);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(52, 264);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(109, 29);
            this.lbCantidad.TabIndex = 12;
            this.lbCantidad.Text = "Cantidad";
            // 
            // txtPrecioT
            // 
            this.txtPrecioT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioT.Location = new System.Drawing.Point(424, 297);
            this.txtPrecioT.Name = "txtPrecioT";
            this.txtPrecioT.Size = new System.Drawing.Size(113, 35);
            this.txtPrecioT.TabIndex = 13;
            // 
            // lbPT
            // 
            this.lbPT.AutoSize = true;
            this.lbPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPT.Location = new System.Drawing.Point(409, 264);
            this.lbPT.Name = "lbPT";
            this.lbPT.Size = new System.Drawing.Size(144, 29);
            this.lbPT.TabIndex = 14;
            this.lbPT.Text = "Precio Total";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 401);
            this.Controls.Add(this.txtPrecioT);
            this.Controls.Add(this.lbPT);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbPrecioU);
            this.Controls.Add(this.lbPU);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtCantiB);
            this.Controls.Add(this.lbCantiB);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtCodigio);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btAcceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAcceptar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigio;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtCantiB;
        private System.Windows.Forms.Label lbCantiB;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbPU;
        private System.Windows.Forms.Label lbPrecioU;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox txtPrecioT;
        private System.Windows.Forms.Label lbPT;
    }
}