namespace WindowsFormsApp1
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
            this.btnsum = new System.Windows.Forms.Button();
            this.btnres = new System.Windows.Forms.Button();
            this.btnlim = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsum.Location = new System.Drawing.Point(41, 267);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(103, 54);
            this.btnsum.TabIndex = 0;
            this.btnsum.Text = "Sumar";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnres
            // 
            this.btnres.BackColor = System.Drawing.Color.IndianRed;
            this.btnres.Location = new System.Drawing.Point(150, 267);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(106, 54);
            this.btnres.TabIndex = 2;
            this.btnres.Text = "Restar";
            this.btnres.UseVisualStyleBackColor = false;
            this.btnres.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlim
            // 
            this.btnlim.BackColor = System.Drawing.Color.Turquoise;
            this.btnlim.Location = new System.Drawing.Point(41, 327);
            this.btnlim.Name = "btnlim";
            this.btnlim.Size = new System.Drawing.Size(215, 54);
            this.btnlim.TabIndex = 3;
            this.btnlim.Text = "Limpiar";
            this.btnlim.UseVisualStyleBackColor = false;
            this.btnlim.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.AccessibleDescription = "Numero";
            this.txtNumero1.Location = new System.Drawing.Point(41, 227);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(103, 34);
            this.txtNumero1.TabIndex = 4;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(150, 227);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(106, 34);
            this.txtNumero2.TabIndex = 5;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero2_TextChanged);
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.Location = new System.Drawing.Point(41, 103);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(215, 95);
            this.listBoxResultados.TabIndex = 6;
            this.listBoxResultados.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnlim);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.btnsum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Button btnlim;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ListBox listBoxResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

