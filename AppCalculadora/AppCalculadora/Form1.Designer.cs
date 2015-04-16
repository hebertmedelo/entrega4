namespace AppCalculadora
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
            this.lbnum1 = new System.Windows.Forms.Label();
            this.lbnum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnun2 = new System.Windows.Forms.TextBox();
            this.rbsuma = new System.Windows.Forms.RadioButton();
            this.rbmultiplicar = new System.Windows.Forms.RadioButton();
            this.rbrestar = new System.Windows.Forms.RadioButton();
            this.rbdividir = new System.Windows.Forms.RadioButton();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnum1
            // 
            this.lbnum1.AutoSize = true;
            this.lbnum1.Location = new System.Drawing.Point(26, 28);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(51, 13);
            this.lbnum1.TabIndex = 0;
            this.lbnum1.Text = "numero 1";
            this.lbnum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbnum2
            // 
            this.lbnum2.AutoSize = true;
            this.lbnum2.Location = new System.Drawing.Point(29, 62);
            this.lbnum2.Name = "lbnum2";
            this.lbnum2.Size = new System.Drawing.Size(51, 13);
            this.lbnum2.TabIndex = 1;
            this.lbnum2.Text = "numero 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(130, 28);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnun2
            // 
            this.txtnun2.Location = new System.Drawing.Point(130, 62);
            this.txtnun2.Name = "txtnun2";
            this.txtnun2.Size = new System.Drawing.Size(100, 20);
            this.txtnun2.TabIndex = 3;
            // 
            // rbsuma
            // 
            this.rbsuma.AutoSize = true;
            this.rbsuma.Location = new System.Drawing.Point(32, 135);
            this.rbsuma.Name = "rbsuma";
            this.rbsuma.Size = new System.Drawing.Size(53, 17);
            this.rbsuma.TabIndex = 4;
            this.rbsuma.TabStop = true;
            this.rbsuma.Text = "sumar";
            this.rbsuma.UseVisualStyleBackColor = true;
            // 
            // rbmultiplicar
            // 
            this.rbmultiplicar.AutoSize = true;
            this.rbmultiplicar.Location = new System.Drawing.Point(32, 178);
            this.rbmultiplicar.Name = "rbmultiplicar";
            this.rbmultiplicar.Size = new System.Drawing.Size(71, 17);
            this.rbmultiplicar.TabIndex = 5;
            this.rbmultiplicar.TabStop = true;
            this.rbmultiplicar.Text = "multiplicar";
            this.rbmultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbrestar
            // 
            this.rbrestar.AutoSize = true;
            this.rbrestar.Location = new System.Drawing.Point(154, 135);
            this.rbrestar.Name = "rbrestar";
            this.rbrestar.Size = new System.Drawing.Size(51, 17);
            this.rbrestar.TabIndex = 6;
            this.rbrestar.TabStop = true;
            this.rbrestar.Text = "restar";
            this.rbrestar.UseVisualStyleBackColor = true;
            // 
            // rbdividir
            // 
            this.rbdividir.AutoSize = true;
            this.rbdividir.Location = new System.Drawing.Point(154, 178);
            this.rbdividir.Name = "rbdividir";
            this.rbdividir.Size = new System.Drawing.Size(52, 17);
            this.rbdividir.TabIndex = 7;
            this.rbdividir.TabStop = true;
            this.rbdividir.Text = "dividir";
            this.rbdividir.UseVisualStyleBackColor = true;
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(130, 98);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 8;
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(29, 104);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(50, 13);
            this.lbresultado.TabIndex = 9;
            this.lbresultado.Text = "resultado";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(119, 217);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.rbdividir);
            this.Controls.Add(this.rbrestar);
            this.Controls.Add(this.rbmultiplicar);
            this.Controls.Add(this.rbsuma);
            this.Controls.Add(this.txtnun2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lbnum2);
            this.Controls.Add(this.lbnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.Label lbnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnun2;
        private System.Windows.Forms.RadioButton rbsuma;
        private System.Windows.Forms.RadioButton rbmultiplicar;
        private System.Windows.Forms.RadioButton rbrestar;
        private System.Windows.Forms.RadioButton rbdividir;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btncalcular;
    }
}

