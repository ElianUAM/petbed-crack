namespace petbed
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxraza = new System.Windows.Forms.ComboBox();
            this.txtraza = new System.Windows.Forms.TextBox();
            this.txtnombreperro = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.rbttmacho = new System.Windows.Forms.RadioButton();
            this.rbtthembra = new System.Windows.Forms.RadioButton();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.imagenperro = new System.Windows.Forms.PictureBox();
            this.bttsubirimg = new System.Windows.Forms.Button();
            this.cbxtamaño = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbttdocil = new System.Windows.Forms.RadioButton();
            this.rbttagresi = new System.Windows.Forms.RadioButton();
            this.bttregistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenperro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registra los datos de tu mascota: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raza: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tamaño Estimado: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Peso Estimado: ";
            // 
            // cbxraza
            // 
            this.cbxraza.FormattingEnabled = true;
            this.cbxraza.Items.AddRange(new object[] {
            "Labrador Retriever",
            "Pastor Alemán",
            "Golden Retriever",
            "Bulldog Francés",
            "Beagle",
            "Bulldog Inglés",
            "Poodle (Caniche)",
            "Chihuahua",
            "Rottweiler",
            "Dachshund (Teckel)",
            "Shih Tzu",
            "Yorkshire Terrier",
            "Pomerania",
            "Schnauzer",
            "Boxer",
            "Border Collie",
            "Bichon Frisé",
            "Cocker Spaniel",
            "Pembroke Welsh Corgi",
            "Akita",
            "Husky",
            "Alaskan Malamute",
            "Otro"});
            this.cbxraza.Location = new System.Drawing.Point(81, 108);
            this.cbxraza.Name = "cbxraza";
            this.cbxraza.Size = new System.Drawing.Size(121, 21);
            this.cbxraza.TabIndex = 9;
            this.cbxraza.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtraza
            // 
            this.txtraza.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtraza.Enabled = false;
            this.txtraza.Location = new System.Drawing.Point(224, 108);
            this.txtraza.Name = "txtraza";
            this.txtraza.Size = new System.Drawing.Size(100, 20);
            this.txtraza.TabIndex = 10;
            // 
            // txtnombreperro
            // 
            this.txtnombreperro.Location = new System.Drawing.Point(103, 70);
            this.txtnombreperro.Name = "txtnombreperro";
            this.txtnombreperro.Size = new System.Drawing.Size(131, 20);
            this.txtnombreperro.TabIndex = 11;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(80, 144);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(61, 20);
            this.txtedad.TabIndex = 12;
            // 
            // rbttmacho
            // 
            this.rbttmacho.AutoSize = true;
            this.rbttmacho.BackColor = System.Drawing.Color.Transparent;
            this.rbttmacho.Location = new System.Drawing.Point(81, 186);
            this.rbttmacho.Name = "rbttmacho";
            this.rbttmacho.Size = new System.Drawing.Size(58, 17);
            this.rbttmacho.TabIndex = 13;
            this.rbttmacho.TabStop = true;
            this.rbttmacho.Text = "Macho";
            this.rbttmacho.UseVisualStyleBackColor = false;
            // 
            // rbtthembra
            // 
            this.rbtthembra.AutoSize = true;
            this.rbtthembra.BackColor = System.Drawing.Color.Transparent;
            this.rbtthembra.Location = new System.Drawing.Point(161, 186);
            this.rbtthembra.Name = "rbtthembra";
            this.rbtthembra.Size = new System.Drawing.Size(62, 17);
            this.rbtthembra.TabIndex = 14;
            this.rbtthembra.TabStop = true;
            this.rbtthembra.Text = "Hembra";
            this.rbtthembra.UseVisualStyleBackColor = false;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(158, 221);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(36, 20);
            this.txtpeso.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(199, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lb";
            // 
            // imagenperro
            // 
            this.imagenperro.BackColor = System.Drawing.Color.Transparent;
            this.imagenperro.Location = new System.Drawing.Point(360, 64);
            this.imagenperro.Name = "imagenperro";
            this.imagenperro.Size = new System.Drawing.Size(200, 220);
            this.imagenperro.TabIndex = 17;
            this.imagenperro.TabStop = false;
            // 
            // bttsubirimg
            // 
            this.bttsubirimg.Location = new System.Drawing.Point(420, 290);
            this.bttsubirimg.Name = "bttsubirimg";
            this.bttsubirimg.Size = new System.Drawing.Size(75, 23);
            this.bttsubirimg.TabIndex = 18;
            this.bttsubirimg.Text = "Subir";
            this.bttsubirimg.UseVisualStyleBackColor = true;
            this.bttsubirimg.Click += new System.EventHandler(this.bttsubirimg_Click);
            // 
            // cbxtamaño
            // 
            this.cbxtamaño.FormattingEnabled = true;
            this.cbxtamaño.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande",
            "Muy Grande"});
            this.cbxtamaño.Location = new System.Drawing.Point(190, 254);
            this.cbxtamaño.Name = "cbxtamaño";
            this.cbxtamaño.Size = new System.Drawing.Size(83, 21);
            this.cbxtamaño.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Comportamiento: ";
            // 
            // rbttdocil
            // 
            this.rbttdocil.AutoSize = true;
            this.rbttdocil.BackColor = System.Drawing.Color.Transparent;
            this.rbttdocil.Location = new System.Drawing.Point(190, 290);
            this.rbttdocil.Name = "rbttdocil";
            this.rbttdocil.Size = new System.Drawing.Size(49, 17);
            this.rbttdocil.TabIndex = 21;
            this.rbttdocil.TabStop = true;
            this.rbttdocil.Text = "Dócil";
            this.rbttdocil.UseVisualStyleBackColor = false;
            // 
            // rbttagresi
            // 
            this.rbttagresi.AutoSize = true;
            this.rbttagresi.BackColor = System.Drawing.Color.Transparent;
            this.rbttagresi.Location = new System.Drawing.Point(245, 290);
            this.rbttagresi.Name = "rbttagresi";
            this.rbttagresi.Size = new System.Drawing.Size(66, 17);
            this.rbttagresi.TabIndex = 22;
            this.rbttagresi.TabStop = true;
            this.rbttagresi.Text = "Agresivo";
            this.rbttagresi.UseVisualStyleBackColor = false;
            // 
            // bttregistrar
            // 
            this.bttregistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttregistrar.Location = new System.Drawing.Point(216, 333);
            this.bttregistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttregistrar.Name = "bttregistrar";
            this.bttregistrar.Size = new System.Drawing.Size(67, 22);
            this.bttregistrar.TabIndex = 23;
            this.bttregistrar.Text = "Continuar";
            this.bttregistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttregistrar.UseVisualStyleBackColor = true;
            this.bttregistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttregistrar);
            this.Controls.Add(this.rbttagresi);
            this.Controls.Add(this.rbttdocil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxtamaño);
            this.Controls.Add(this.bttsubirimg);
            this.Controls.Add(this.imagenperro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.rbtthembra);
            this.Controls.Add(this.rbttmacho);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombreperro);
            this.Controls.Add(this.txtraza);
            this.Controls.Add(this.cbxraza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Sistema de Reserva \"PetBed\"";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenperro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxraza;
        private System.Windows.Forms.TextBox txtraza;
        private System.Windows.Forms.TextBox txtnombreperro;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.RadioButton rbttmacho;
        private System.Windows.Forms.RadioButton rbtthembra;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imagenperro;
        private System.Windows.Forms.Button bttsubirimg;
        private System.Windows.Forms.ComboBox cbxtamaño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbttdocil;
        private System.Windows.Forms.RadioButton rbttagresi;
        private System.Windows.Forms.Button bttregistrar;
        private System.Windows.Forms.Button button1;
    }
}