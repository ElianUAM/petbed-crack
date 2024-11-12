namespace petbed
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdire = new System.Windows.Forms.TextBox();
            this.txtctc1 = new System.Windows.Forms.TextBox();
            this.bttregistrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumper = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.continuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registra tus datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono: ";
            // 
            // txtnomb
            // 
            this.txtnomb.Location = new System.Drawing.Point(205, 83);
            this.txtnomb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(132, 20);
            this.txtnomb.TabIndex = 4;
            this.txtnomb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomb_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(113, 124);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(103, 20);
            this.txttelefono.TabIndex = 5;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Correo Electrónico: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contacto de Emergencia: ";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(205, 166);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(120, 20);
            this.txtemail.TabIndex = 9;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // txtdire
            // 
            this.txtdire.Location = new System.Drawing.Point(122, 206);
            this.txtdire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdire.Name = "txtdire";
            this.txtdire.Size = new System.Drawing.Size(179, 20);
            this.txtdire.TabIndex = 10;
            // 
            // txtctc1
            // 
            this.txtctc1.Location = new System.Drawing.Point(271, 244);
            this.txtctc1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctc1.Name = "txtctc1";
            this.txtctc1.Size = new System.Drawing.Size(117, 20);
            this.txtctc1.TabIndex = 11;
            // 
            // bttregistrar
            // 
            this.bttregistrar.Location = new System.Drawing.Point(154, 329);
            this.bttregistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttregistrar.Name = "bttregistrar";
            this.bttregistrar.Size = new System.Drawing.Size(76, 28);
            this.bttregistrar.TabIndex = 12;
            this.bttregistrar.Text = "Registrar";
            this.bttregistrar.UseVisualStyleBackColor = true;
            this.bttregistrar.Click += new System.EventHandler(this.registrar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número de Perros:";
            // 
            // txtnumper
            // 
            this.txtnumper.Location = new System.Drawing.Point(195, 279);
            this.txtnumper.Name = "txtnumper";
            this.txtnumper.Size = new System.Drawing.Size(100, 20);
            this.txtnumper.TabIndex = 14;
            this.txtnumper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumper_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(323, 329);
            this.continuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(76, 28);
            this.continuar.TabIndex = 16;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.bttContinuar);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.txtnumper);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttregistrar);
            this.Controls.Add(this.txtctc1);
            this.Controls.Add(this.txtdire);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnomb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Sistema de Reserva \"PetBed\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomb;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdire;
        private System.Windows.Forms.TextBox txtctc1;
        private System.Windows.Forms.Button bttregistrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnumper;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button continuar;
    }
}