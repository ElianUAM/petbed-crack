namespace petbedcrack
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtingreso = new System.Windows.Forms.Label();
            this.txtsalida = new System.Windows.Forms.Label();
            this.txtdias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles de Reservación: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtingreso
            // 
            this.txtingreso.AutoSize = true;
            this.txtingreso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtingreso.Location = new System.Drawing.Point(18, 65);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(180, 22);
            this.txtingreso.TabIndex = 1;
            this.txtingreso.Text = "Fecha de Ingreso: ";
            // 
            // txtsalida
            // 
            this.txtsalida.AutoSize = true;
            this.txtsalida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalida.Location = new System.Drawing.Point(18, 108);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(162, 22);
            this.txtsalida.TabIndex = 2;
            this.txtsalida.Text = "Fecha de Salida:";
            // 
            // txtdias
            // 
            this.txtdias.AutoSize = true;
            this.txtdias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdias.Location = new System.Drawing.Point(343, 65);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(124, 22);
            this.txtdias.TabIndex = 5;
            this.txtdias.Text = "Días Totales: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Días Totales: ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtingreso;
        private System.Windows.Forms.Label txtsalida;
        private System.Windows.Forms.Label txtdias;
    }
}