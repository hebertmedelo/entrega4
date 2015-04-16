namespace AppTexBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnsumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(66, 39);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(64, 13);
            this.lblnumero1.TabIndex = 0;
            this.lblnumero1.Text = "NUMERO 1";
            this.lblnumero1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(66, 77);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(64, 13);
            this.lblnumero2.TabIndex = 1;
            this.lblnumero2.Text = "NUMERO 2";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(198, 32);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 2;
            this.txtnumero1.Text = "2";
            this.txtnumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(198, 69);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 3;
            this.txtnumero2.Text = "2";
            this.txtnumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(144, 140);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(73, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "RESULTADO";
            this.lblresultado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(142, 174);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(75, 23);
            this.btnsumar.TabIndex = 5;
            this.btnsumar.Text = "SUMAR";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 332);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Name = "Form1";
            this.Text = "Suma Reales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnsumar;
    }
}

