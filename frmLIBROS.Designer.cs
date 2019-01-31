namespace Manipulación_de_Datos
{
    partial class frmLIBROS
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
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNomProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnVerTodos = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(771, 12);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(75, 20);
            this.TxtCosto.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Año:";
            // 
            // TxtNomProducto
            // 
            this.TxtNomProducto.Location = new System.Drawing.Point(413, 12);
            this.TxtNomProducto.Name = "TxtNomProducto";
            this.TxtNomProducto.Size = new System.Drawing.Size(155, 20);
            this.TxtNomProducto.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre del libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Autor:";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(633, 12);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(89, 20);
            this.TxtMarca.TabIndex = 20;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Enabled = false;
            this.TxtIdProducto.Location = new System.Drawing.Point(227, 12);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(36, 20);
            this.TxtIdProducto.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id del libro:";
            // 
            // DgvProductos
            // 
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductos.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(11, 92);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(931, 304);
            this.DgvProductos.TabIndex = 35;
            this.DgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellContentClick);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Image = global::Manipulación_de_Datos.Properties.Resources.brush;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(599, 38);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(119, 48);
            this.BtnLimpiar.TabIndex = 33;
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
            this.BtnVerTodos.Location = new System.Drawing.Point(249, 38);
            this.BtnVerTodos.Name = "BtnVerTodos";
            this.BtnVerTodos.Size = new System.Drawing.Size(158, 48);
            this.BtnVerTodos.TabIndex = 32;
            this.BtnVerTodos.Text = "Ver todos los libros";
            this.BtnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerTodos.UseVisualStyleBackColor = true;
            this.BtnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Image = global::Manipulación_de_Datos.Properties.Resources.search;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(101, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(142, 48);
            this.BtnBuscar.TabIndex = 31;
            this.BtnBuscar.Text = "Buscar por Nombre";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Image = global::Manipulación_de_Datos.Properties.Resources.bin;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(413, 38);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 48);
            this.BtnEliminar.TabIndex = 30;
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
            this.BtnActualizar.Location = new System.Drawing.Point(499, 38);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 48);
            this.BtnActualizar.TabIndex = 29;
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
            this.BtnInsertar.Location = new System.Drawing.Point(724, 38);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(100, 48);
            this.BtnInsertar.TabIndex = 28;
            this.BtnInsertar.Text = "Añadir libro";
            this.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // frmLIBROS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 405);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnVerTodos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNomProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.label1);
            this.Name = "frmLIBROS";
            this.Text = "..........:::::Libros:::::..........";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnVerTodos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNomProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvProductos;
    }
}