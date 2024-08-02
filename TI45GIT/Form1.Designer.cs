namespace TI45GIT
{
    partial class Form1
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
            this.tbValor1 = new System.Windows.Forms.TextBox();
            this.tbValor2 = new System.Windows.Forms.TextBox();
            this.lbValor1 = new System.Windows.Forms.Label();
            this.lbValor2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbResoltado = new System.Windows.Forms.Label();
            this.btnsoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbValor1
            // 
            this.tbValor1.Location = new System.Drawing.Point(79, 39);
            this.tbValor1.Name = "tbValor1";
            this.tbValor1.Size = new System.Drawing.Size(100, 20);
            this.tbValor1.TabIndex = 0;
            // 
            // tbValor2
            // 
            this.tbValor2.Location = new System.Drawing.Point(79, 76);
            this.tbValor2.Name = "tbValor2";
            this.tbValor2.Size = new System.Drawing.Size(100, 20);
            this.tbValor2.TabIndex = 1;
            // 
            // lbValor1
            // 
            this.lbValor1.AutoSize = true;
            this.lbValor1.Location = new System.Drawing.Point(33, 39);
            this.lbValor1.Name = "lbValor1";
            this.lbValor1.Size = new System.Drawing.Size(40, 13);
            this.lbValor1.TabIndex = 2;
            this.lbValor1.Text = "Valor 1";
            this.lbValor1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbValor2
            // 
            this.lbValor2.AutoSize = true;
            this.lbValor2.Location = new System.Drawing.Point(33, 76);
            this.lbValor2.Name = "lbValor2";
            this.lbValor2.Size = new System.Drawing.Size(40, 13);
            this.lbValor2.TabIndex = 3;
            this.lbValor2.Text = "Valor 2";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(33, 120);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total";
            this.lbTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbResoltado
            // 
            this.lbResoltado.AutoSize = true;
            this.lbResoltado.Location = new System.Drawing.Point(88, 120);
            this.lbResoltado.Name = "lbResoltado";
            this.lbResoltado.Size = new System.Drawing.Size(16, 13);
            this.lbResoltado.TabIndex = 5;
            this.lbResoltado.Text = "...";
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(36, 160);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(75, 23);
            this.btnsoma.TabIndex = 6;
            this.btnsoma.Text = "Soma";
            this.btnsoma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.lbResoltado);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbValor2);
            this.Controls.Add(this.lbValor1);
            this.Controls.Add(this.tbValor2);
            this.Controls.Add(this.tbValor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValor1;
        private System.Windows.Forms.TextBox tbValor2;
        private System.Windows.Forms.Label lbValor1;
        private System.Windows.Forms.Label lbValor2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbResoltado;
        private System.Windows.Forms.Button btnsoma;
    }
}

