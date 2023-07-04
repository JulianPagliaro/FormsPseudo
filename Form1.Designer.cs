namespace FormsPseudo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRadio = new System.Windows.Forms.TextBox();
            this.TxtGeneratriz = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.TxtVolumen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generatriz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // TxtRadio
            // 
            this.TxtRadio.Location = new System.Drawing.Point(139, 35);
            this.TxtRadio.Name = "TxtRadio";
            this.TxtRadio.Size = new System.Drawing.Size(100, 20);
            this.TxtRadio.TabIndex = 3;
            this.TxtRadio.TextChanged += new System.EventHandler(this.TxtRadio_TextChanged);
            // 
            // TxtGeneratriz
            // 
            this.TxtGeneratriz.Location = new System.Drawing.Point(139, 96);
            this.TxtGeneratriz.Name = "TxtGeneratriz";
            this.TxtGeneratriz.Size = new System.Drawing.Size(100, 20);
            this.TxtGeneratriz.TabIndex = 4;
            this.TxtGeneratriz.TextChanged += new System.EventHandler(this.TxtGeneratriz_TextChanged);
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(139, 159);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 20);
            this.TxtAltura.TabIndex = 5;
            this.TxtAltura.TextChanged += new System.EventHandler(this.TxtAltura_TextChanged);
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(83, 260);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.ReadOnly = true;
            this.TxtArea.Size = new System.Drawing.Size(100, 20);
            this.TxtArea.TabIndex = 6;
            // 
            // TxtVolumen
            // 
            this.TxtVolumen.Location = new System.Drawing.Point(324, 260);
            this.TxtVolumen.Name = "TxtVolumen";
            this.TxtVolumen.ReadOnly = true;
            this.TxtVolumen.Size = new System.Drawing.Size(100, 20);
            this.TxtVolumen.TabIndex = 7;
            this.TxtVolumen.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Volumen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Area";
            // 
            // BtnSumar
            // 
            this.BtnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSumar.Location = new System.Drawing.Point(283, 52);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(75, 64);
            this.BtnSumar.TabIndex = 10;
            this.BtnSumar.Text = "Calcular";
            this.BtnSumar.UseVisualStyleBackColor = true;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Location = new System.Drawing.Point(405, 52);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(76, 64);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(514, 378);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtVolumen);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtGeneratriz);
            this.Controls.Add(this.TxtRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRadio;
        private System.Windows.Forms.TextBox TxtGeneratriz;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.TextBox TxtVolumen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

