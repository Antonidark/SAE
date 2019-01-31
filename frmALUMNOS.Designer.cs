namespace Manipulación_de_Datos
{
    partial class Form1
    {
        /// <summary>
        /// requiere designar variables.
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtldCliente = new System.Windows.Forms.TextBox();
            this.TxtApPat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtApMat = new System.Windows.Forms.TextBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnVerTodos = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del Alumno:";
            // 
            // TxtldCliente
            // 
            this.TxtldCliente.Enabled = false;
            this.TxtldCliente.Location = new System.Drawing.Point(117, 12);
            this.TxtldCliente.Name = "TxtldCliente";
            this.TxtldCliente.Size = new System.Drawing.Size(36, 20);
            this.TxtldCliente.TabIndex = 1;
            // 
            // TxtApPat
            // 
            this.TxtApPat.Location = new System.Drawing.Point(468, 12);
            this.TxtApPat.Name = "TxtApPat";
            this.TxtApPat.Size = new System.Drawing.Size(103, 20);
            this.TxtApPat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MATRICULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "GRUPO:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(212, 12);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(155, 20);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(840, 12);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 20);
            this.TxtTel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "GRADO:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtApMat
            // 
            this.TxtApMat.Location = new System.Drawing.Point(674, 12);
            this.TxtApMat.Name = "TxtApMat";
            this.TxtApMat.Size = new System.Drawing.Size(103, 20);
            this.TxtApMat.TabIndex = 9;
            this.TxtApMat.TextChanged += new System.EventHandler(this.TxtApMat_TextChanged);
            // 
            // DgvClientes
            // 
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientes.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(12, 92);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(948, 316);
            this.DgvClientes.TabIndex = 16;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick_1);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Image = global::Manipulación_de_Datos.Properties.Resources.brush;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(396, 38);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(123, 48);
            this.BtnLimpiar.TabIndex = 15;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnVerTodos
            // 
            this.BtnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerTodos.Image = global::Manipulación_de_Datos.Properties.Resources.book_open_bookmark;
            this.BtnVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerTodos.Location = new System.Drawing.Point(91, 38);
            this.BtnVerTodos.Name = "BtnVerTodos";
            this.BtnVerTodos.Size = new System.Drawing.Size(148, 48);
            this.BtnVerTodos.TabIndex = 14;
            this.BtnVerTodos.Text = "Ver todos los Alumnos";
            this.BtnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerTodos.UseVisualStyleBackColor = true;
            this.BtnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Image = global::Manipulación_de_Datos.Properties.Resources.search;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(245, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(145, 48);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar por Nombre";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Image = global::Manipulación_de_Datos.Properties.Resources.EQUIZ;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(525, 38);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(89, 48);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.Image = global::Manipulación_de_Datos.Properties.Resources.button_synchronize;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(620, 38);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 48);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertar.Image = global::Manipulación_de_Datos.Properties.Resources.floppy_disk;
            this.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsertar.Location = new System.Drawing.Point(720, 38);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(126, 48);
            this.BtnInsertar.TabIndex = 10;
            this.BtnInsertar.Text = "Guardar registro";
            this.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 420);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnVerTodos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.TxtApMat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtApPat);
            this.Controls.Add(this.TxtldCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "..........:::::Alumnos:::::..........";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtldCliente;
        private System.Windows.Forms.TextBox TxtApPat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtApMat;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnVerTodos;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView DgvClientes;
    }
}

