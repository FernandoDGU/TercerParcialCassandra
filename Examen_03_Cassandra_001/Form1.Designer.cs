namespace Examen_03_Cassandra_001
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.N_Ventas = new System.Windows.Forms.Button();
            this.N_Compras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una de las dos opciones: ";
            // 
            // N_Ventas
            // 
            this.N_Ventas.Location = new System.Drawing.Point(89, 95);
            this.N_Ventas.Name = "N_Ventas";
            this.N_Ventas.Size = new System.Drawing.Size(108, 63);
            this.N_Ventas.TabIndex = 3;
            this.N_Ventas.Text = "Notas Ventas";
            this.N_Ventas.UseVisualStyleBackColor = true;
            this.N_Ventas.Click += new System.EventHandler(this.N_Ventas_Click);
            // 
            // N_Compras
            // 
            this.N_Compras.Location = new System.Drawing.Point(269, 95);
            this.N_Compras.Name = "N_Compras";
            this.N_Compras.Size = new System.Drawing.Size(108, 63);
            this.N_Compras.TabIndex = 4;
            this.N_Compras.Text = "Notas Compras";
            this.N_Compras.UseVisualStyleBackColor = true;
            this.N_Compras.Click += new System.EventHandler(this.N_Compras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 236);
            this.Controls.Add(this.N_Compras);
            this.Controls.Add(this.N_Ventas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button N_Ventas;
        private System.Windows.Forms.Button N_Compras;
    }
}

