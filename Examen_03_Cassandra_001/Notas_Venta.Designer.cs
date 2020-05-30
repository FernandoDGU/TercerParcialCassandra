namespace Examen_03_Cassandra_001
{
    partial class Notas_Venta
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
            this.VerDatosGrid = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Nom_client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nom_emp = new System.Windows.Forms.TextBox();
            this.Fecha_proc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.AgregarProducto = new System.Windows.Forms.Button();
            this.RetirarProducto = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Nom_proc = new System.Windows.Forms.TextBox();
            this.Nom_empleado = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VerDatosGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // VerDatosGrid
            // 
            this.VerDatosGrid.BackgroundColor = System.Drawing.Color.White;
            this.VerDatosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerDatosGrid.GridColor = System.Drawing.Color.Teal;
            this.VerDatosGrid.Location = new System.Drawing.Point(371, 38);
            this.VerDatosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.VerDatosGrid.MultiSelect = false;
            this.VerDatosGrid.Name = "VerDatosGrid";
            this.VerDatosGrid.ReadOnly = true;
            this.VerDatosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VerDatosGrid.Size = new System.Drawing.Size(386, 473);
            this.VerDatosGrid.TabIndex = 10;
            this.VerDatosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerDatosGrid_CellClick);
            this.VerDatosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerDatosGrid_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.Teal;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.ForeColor = System.Drawing.Color.White;
            this.Agregar.Location = new System.Drawing.Point(249, 460);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(88, 26);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar Nota";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Nom_client
            // 
            this.Nom_client.Location = new System.Drawing.Point(161, 26);
            this.Nom_client.Margin = new System.Windows.Forms.Padding(4);
            this.Nom_client.MaxLength = 30;
            this.Nom_client.Name = "Nom_client";
            this.Nom_client.Size = new System.Drawing.Size(177, 23);
            this.Nom_client.TabIndex = 1;
            this.Nom_client.TextChanged += new System.EventHandler(this.Nom_client_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del cliente: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de la empresa: ";
            // 
            // Nom_emp
            // 
            this.Nom_emp.Location = new System.Drawing.Point(161, 58);
            this.Nom_emp.Margin = new System.Windows.Forms.Padding(4);
            this.Nom_emp.MaxLength = 30;
            this.Nom_emp.Name = "Nom_emp";
            this.Nom_emp.Size = new System.Drawing.Size(177, 23);
            this.Nom_emp.TabIndex = 2;
            // 
            // Fecha_proc
            // 
            this.Fecha_proc.Location = new System.Drawing.Point(160, 120);
            this.Fecha_proc.Margin = new System.Windows.Forms.Padding(4);
            this.Fecha_proc.Name = "Fecha_proc";
            this.Fecha_proc.Size = new System.Drawing.Size(177, 23);
            this.Fecha_proc.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha: ";
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Teal;
            this.Eliminar.Enabled = false;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.Location = new System.Drawing.Point(59, 460);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(88, 26);
            this.Eliminar.TabIndex = 13;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Nom_empleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.Nom_client);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Fecha_proc);
            this.groupBox1.Controls.Add(this.Nom_emp);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(345, 497);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Precio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cantidad);
            this.groupBox2.Controls.Add(this.AgregarProducto);
            this.groupBox2.Controls.Add(this.RetirarProducto);
            this.groupBox2.Controls.Add(this.Productos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Nom_proc);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(11, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(326, 290);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(5, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Precio:";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(8, 92);
            this.Precio.Margin = new System.Windows.Forms.Padding(4);
            this.Precio.MaxLength = 30;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(177, 23);
            this.Precio.TabIndex = 7;
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_n);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(190, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cantidad:";
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(193, 46);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Cantidad.MaxLength = 30;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(125, 23);
            this.Cantidad.TabIndex = 6;
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_n);
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.BackColor = System.Drawing.Color.Teal;
            this.AgregarProducto.FlatAppearance.BorderSize = 0;
            this.AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarProducto.ForeColor = System.Drawing.Color.White;
            this.AgregarProducto.Location = new System.Drawing.Point(193, 89);
            this.AgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(125, 26);
            this.AgregarProducto.TabIndex = 8;
            this.AgregarProducto.Text = "Agregar Producto";
            this.AgregarProducto.UseVisualStyleBackColor = false;
            this.AgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // RetirarProducto
            // 
            this.RetirarProducto.BackColor = System.Drawing.Color.Teal;
            this.RetirarProducto.Enabled = false;
            this.RetirarProducto.FlatAppearance.BorderSize = 0;
            this.RetirarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetirarProducto.ForeColor = System.Drawing.Color.White;
            this.RetirarProducto.Location = new System.Drawing.Point(230, 256);
            this.RetirarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.RetirarProducto.Name = "RetirarProducto";
            this.RetirarProducto.Size = new System.Drawing.Size(88, 26);
            this.RetirarProducto.TabIndex = 9;
            this.RetirarProducto.Text = "Retirar";
            this.RetirarProducto.UseVisualStyleBackColor = false;
            this.RetirarProducto.Click += new System.EventHandler(this.RetirarProducto_Click);
            // 
            // Productos
            // 
            this.Productos.BackgroundColor = System.Drawing.Color.White;
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.GridColor = System.Drawing.Color.Teal;
            this.Productos.Location = new System.Drawing.Point(8, 128);
            this.Productos.Margin = new System.Windows.Forms.Padding(4);
            this.Productos.MultiSelect = false;
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productos.Size = new System.Drawing.Size(310, 120);
            this.Productos.TabIndex = 33;
            this.Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Producto: ";
            // 
            // Nom_proc
            // 
            this.Nom_proc.Location = new System.Drawing.Point(8, 46);
            this.Nom_proc.Margin = new System.Windows.Forms.Padding(4);
            this.Nom_proc.MaxLength = 30;
            this.Nom_proc.Name = "Nom_proc";
            this.Nom_proc.Size = new System.Drawing.Size(177, 23);
            this.Nom_proc.TabIndex = 5;
            // 
            // Nom_empleado
            // 
            this.Nom_empleado.Location = new System.Drawing.Point(160, 89);
            this.Nom_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.Nom_empleado.MaxLength = 30;
            this.Nom_empleado.Name = "Nom_empleado";
            this.Nom_empleado.Size = new System.Drawing.Size(177, 23);
            this.Nom_empleado.TabIndex = 3;
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Teal;
            this.Limpiar.FlatAppearance.BorderSize = 0;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.ForeColor = System.Drawing.Color.White;
            this.Limpiar.Location = new System.Drawing.Point(155, 460);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(88, 26);
            this.Limpiar.TabIndex = 12;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Notas de ventas:";
            // 
            // Notas_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VerDatosGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notas_Venta";
            this.Text = "Notas de Ventas";
            this.Load += new System.EventHandler(this.Notas_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VerDatosGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VerDatosGrid;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox Nom_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nom_emp;
        private System.Windows.Forms.DateTimePicker Fecha_proc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.TextBox Nom_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button AgregarProducto;
        private System.Windows.Forms.Button RetirarProducto;
        private System.Windows.Forms.DataGridView Productos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nom_proc;
    }
}