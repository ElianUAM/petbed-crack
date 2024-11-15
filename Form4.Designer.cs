namespace petbedcrack
{
    partial class Form4
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
            this.dtphospedaje = new System.Windows.Forms.DateTimePicker();
            this.dtpsalida = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbttcredito = new System.Windows.Forms.RadioButton();
            this.rbttdebito = new System.Windows.Forms.RadioButton();
            this.rbttefectivo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles de la habitación:";
            // 
            // dtphospedaje
            // 
            this.dtphospedaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphospedaje.Location = new System.Drawing.Point(279, 107);
            this.dtphospedaje.Name = "dtphospedaje";
            this.dtphospedaje.Size = new System.Drawing.Size(303, 27);
            this.dtphospedaje.TabIndex = 1;
            // 
            // dtpsalida
            // 
            this.dtpsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsalida.Location = new System.Drawing.Point(229, 172);
            this.dtpsalida.Name = "dtpsalida";
            this.dtpsalida.Size = new System.Drawing.Size(299, 27);
            this.dtpsalida.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de hospedaje: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de salida: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Método de Pago:";
            // 
            // rbttcredito
            // 
            this.rbttcredito.AutoSize = true;
            this.rbttcredito.Location = new System.Drawing.Point(21, 312);
            this.rbttcredito.Name = "rbttcredito";
            this.rbttcredito.Size = new System.Drawing.Size(117, 20);
            this.rbttcredito.TabIndex = 6;
            this.rbttcredito.TabStop = true;
            this.rbttcredito.Text = "Tarjeta Crédito";
            this.rbttcredito.UseVisualStyleBackColor = true;
            // 
            // rbttdebito
            // 
            this.rbttdebito.AutoSize = true;
            this.rbttdebito.Location = new System.Drawing.Point(21, 352);
            this.rbttdebito.Name = "rbttdebito";
            this.rbttdebito.Size = new System.Drawing.Size(114, 20);
            this.rbttdebito.TabIndex = 7;
            this.rbttdebito.TabStop = true;
            this.rbttdebito.Text = "Tarjeta Débito";
            this.rbttdebito.UseVisualStyleBackColor = true;
            // 
            // rbttefectivo
            // 
            this.rbttefectivo.AutoSize = true;
            this.rbttefectivo.Location = new System.Drawing.Point(21, 388);
            this.rbttefectivo.Name = "rbttefectivo";
            this.rbttefectivo.Size = new System.Drawing.Size(76, 20);
            this.rbttefectivo.TabIndex = 8;
            this.rbttefectivo.TabStop = true;
            this.rbttefectivo.Text = "Efectivo";
            this.rbttefectivo.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbttefectivo);
            this.Controls.Add(this.rbttdebito);
            this.Controls.Add(this.rbttcredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpsalida);
            this.Controls.Add(this.dtphospedaje);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Sistema de Reserva \"PetBed\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtphospedaje;
        private System.Windows.Forms.DateTimePicker dtpsalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbttcredito;
        private System.Windows.Forms.RadioButton rbttdebito;
        private System.Windows.Forms.RadioButton rbttefectivo;
    }
}