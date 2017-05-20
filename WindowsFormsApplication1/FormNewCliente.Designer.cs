namespace WindowsFormsApplication1
{
    partial class FormNewCliente
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
            this.lbRuc = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbDirrecion = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbNewCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuc.Location = new System.Drawing.Point(12, 58);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(88, 13);
            this.lbRuc.TabIndex = 0;
            this.lbRuc.Text = "Cedula o Ruc:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(106, 55);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(398, 20);
            this.txtRuc.TabIndex = 1;
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(15, 224);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(98, 38);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(398, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(12, 84);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(106, 107);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(106, 133);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(398, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // lbDirrecion
            // 
            this.lbDirrecion.AutoSize = true;
            this.lbDirrecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirrecion.Location = new System.Drawing.Point(12, 136);
            this.lbDirrecion.Name = "lbDirrecion";
            this.lbDirrecion.Size = new System.Drawing.Size(65, 13);
            this.lbDirrecion.TabIndex = 7;
            this.lbDirrecion.Text = "Direccion:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(342, 107);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(162, 20);
            this.txtCelular.TabIndex = 10;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(280, 110);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(50, 13);
            this.lbCelular.TabIndex = 9;
            this.lbCelular.Text = "Celular:";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(406, 224);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(98, 38);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbNewCliente
            // 
            this.lbNewCliente.AutoSize = true;
            this.lbNewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbNewCliente.Location = new System.Drawing.Point(173, 11);
            this.lbNewCliente.Name = "lbNewCliente";
            this.lbNewCliente.Size = new System.Drawing.Size(178, 29);
            this.lbNewCliente.TabIndex = 12;
            this.lbNewCliente.Text = "Nuevo Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo Cliente:";
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Location = new System.Drawing.Point(106, 186);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(155, 21);
            this.cbTipoCliente.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(398, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email:";
            // 
            // FormNewCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(519, 274);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNewCliente);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbDirrecion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.lbRuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewCliente";
            this.Text = "FormNewCliente";
            this.Load += new System.EventHandler(this.FormNewCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbDirrecion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbNewCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
    }
}