namespace GuiaCuatro
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
            this.textcod1 = new System.Windows.Forms.TextBox();
            this.textnom1 = new System.Windows.Forms.TextBox();
            this.textapel1 = new System.Windows.Forms.TextBox();
            this.textedad1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modificar1 = new System.Windows.Forms.Button();
            this.buscar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textcod1
            // 
            this.textcod1.Location = new System.Drawing.Point(102, 35);
            this.textcod1.Name = "textcod1";
            this.textcod1.Size = new System.Drawing.Size(100, 20);
            this.textcod1.TabIndex = 0;
            // 
            // textnom1
            // 
            this.textnom1.Location = new System.Drawing.Point(102, 77);
            this.textnom1.Name = "textnom1";
            this.textnom1.Size = new System.Drawing.Size(100, 20);
            this.textnom1.TabIndex = 1;
            this.textnom1.Visible = false;
            // 
            // textapel1
            // 
            this.textapel1.Location = new System.Drawing.Point(102, 126);
            this.textapel1.Name = "textapel1";
            this.textapel1.Size = new System.Drawing.Size(100, 20);
            this.textapel1.TabIndex = 2;
            this.textapel1.Visible = false;
            // 
            // textedad1
            // 
            this.textedad1.Location = new System.Drawing.Point(102, 171);
            this.textedad1.Name = "textedad1";
            this.textedad1.Size = new System.Drawing.Size(100, 20);
            this.textedad1.TabIndex = 3;
            this.textedad1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // modificar1
            // 
            this.modificar1.Location = new System.Drawing.Point(45, 224);
            this.modificar1.Name = "modificar1";
            this.modificar1.Size = new System.Drawing.Size(75, 23);
            this.modificar1.TabIndex = 8;
            this.modificar1.Text = "Modificar";
            this.modificar1.UseVisualStyleBackColor = true;
            this.modificar1.Click += new System.EventHandler(this.modificar1_Click);
            // 
            // buscar1
            // 
            this.buscar1.Location = new System.Drawing.Point(248, 32);
            this.buscar1.Name = "buscar1";
            this.buscar1.Size = new System.Drawing.Size(75, 23);
            this.buscar1.TabIndex = 9;
            this.buscar1.Text = "Buscar";
            this.buscar1.UseVisualStyleBackColor = true;
            this.buscar1.Click += new System.EventHandler(this.buscar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 277);
            this.Controls.Add(this.buscar1);
            this.Controls.Add(this.modificar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textedad1);
            this.Controls.Add(this.textapel1);
            this.Controls.Add(this.textnom1);
            this.Controls.Add(this.textcod1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcod1;
        private System.Windows.Forms.TextBox textnom1;
        private System.Windows.Forms.TextBox textapel1;
        private System.Windows.Forms.TextBox textedad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modificar1;
        private System.Windows.Forms.Button buscar1;
    }
}

