namespace AppChetBox
{
    partial class btnselecionar
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
            this.chkopcion1 = new System.Windows.Forms.CheckBox();
            this.chkopcion2 = new System.Windows.Forms.CheckBox();
            this.chkopcion3 = new System.Windows.Forms.CheckBox();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkopcion1
            // 
            this.chkopcion1.AutoSize = true;
            this.chkopcion1.Location = new System.Drawing.Point(36, 25);
            this.chkopcion1.Name = "chkopcion1";
            this.chkopcion1.Size = new System.Drawing.Size(61, 17);
            this.chkopcion1.TabIndex = 0;
            this.chkopcion1.Text = "amarillo";
            this.chkopcion1.UseVisualStyleBackColor = true;
            this.chkopcion1.CheckedChanged += new System.EventHandler(this.chkopcion1_CheckedChanged);
            // 
            // chkopcion2
            // 
            this.chkopcion2.AutoSize = true;
            this.chkopcion2.Location = new System.Drawing.Point(36, 59);
            this.chkopcion2.Name = "chkopcion2";
            this.chkopcion2.Size = new System.Drawing.Size(45, 17);
            this.chkopcion2.TabIndex = 1;
            this.chkopcion2.Text = "azul";
            this.chkopcion2.UseVisualStyleBackColor = true;
            // 
            // chkopcion3
            // 
            this.chkopcion3.AutoSize = true;
            this.chkopcion3.Location = new System.Drawing.Point(36, 92);
            this.chkopcion3.Name = "chkopcion3";
            this.chkopcion3.Size = new System.Drawing.Size(43, 17);
            this.chkopcion3.TabIndex = 2;
            this.chkopcion3.Text = "rojo";
            this.chkopcion3.UseVisualStyleBackColor = true;
            this.chkopcion3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(36, 144);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnseleccionar.TabIndex = 3;
            this.btnseleccionar.Text = "seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnselecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.chkopcion3);
            this.Controls.Add(this.chkopcion2);
            this.Controls.Add(this.chkopcion1);
            this.Name = "btnselecionar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnselecionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkopcion1;
        private System.Windows.Forms.CheckBox chkopcion2;
        private System.Windows.Forms.CheckBox chkopcion3;
        private System.Windows.Forms.Button btnseleccionar;
    }
}

