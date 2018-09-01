namespace Tarea_1
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 22);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "    Afganistán",
            "    Albania",
            "    Alemania",
            "    Andorra",
            "    Angola",
            "    Antigua y Barbuda",
            "    Arabia Saudita",
            "    Argelia",
            "    Argentina",
            "    Armenia",
            "    Australia",
            "    Austria",
            "    Azerbaiyán",
            "    Bahamas",
            "    Bangladés",
            "    Barbados",
            "    Baréin",
            "    Bélgica",
            "    Belice",
            "    Benín",
            "    Bielorrusia",
            "    Birmania",
            "    Bolivia",
            "    Bosnia y Herzegovina",
            "    Botsuana",
            "    Brasil",
            "    Brunéi",
            "    Bulgaria",
            "    Burkina Faso",
            "    Burundi",
            "    Bután",
            "    Cabo Verde",
            "    Camboya",
            "    Camerún",
            "    Canadá",
            "    Catar",
            "    Chad",
            "    Chile",
            "    China",
            "    Chipre",
            "    Ciudad del Vaticano",
            "    Colombia",
            "    Comoras",
            "    Corea del Norte",
            "    Corea del Sur",
            "    Costa de Marfil",
            "    Costa Rica",
            "    Croacia",
            "    Cuba",
            "    Dinamarca",
            "    Dominica",
            "    Ecuador",
            "    Egipto",
            "    El Salvador",
            "    Emiratos Árabes Unidos",
            "    Eritrea",
            "    Eslovaquia",
            "    Eslovenia",
            "    España",
            "    Estados Unidos",
            "    Estonia",
            "    Etiopía",
            "    Filipinas",
            "    Finlandia",
            "    Fiyi",
            "    Francia",
            "    Gabón",
            "    Gambia",
            "    Georgia",
            "    Ghana",
            "    Granada",
            "    Grecia",
            "    Guatemala",
            "    Guyana",
            "    Guinea",
            "    Guinea ecuatorial",
            "    Guinea-Bisáu",
            "    Haití",
            "    Honduras",
            "    Hungría",
            "    India",
            "    Indonesia",
            "    Irak",
            "    Irán",
            "    Irlanda",
            "    Islandia",
            "    Islas Marshall",
            "    Islas Salomón",
            "    Israel",
            "    Italia",
            "    Jamaica",
            "    Japón",
            "    Jordania",
            "    Kazajistán",
            "    Kenia",
            "    Kirguistán",
            "    Kiribati",
            "    Kuwait",
            "    Laos",
            "    Lesoto",
            "    Letonia",
            "    Líbano",
            "    Liberia",
            "    Libia",
            "    Liechtenstein",
            "    Lituania",
            "    Luxemburgo",
            "    Madagascar",
            "    Malasia",
            "    Malaui",
            "    Maldivas",
            "    Malí",
            "    Malta",
            "    Marruecos",
            "    Mauricio",
            "    Mauritania",
            "    México",
            "    Micronesia",
            "    Moldavia",
            "    Mónaco",
            "    Mongolia",
            "    Montenegro",
            "    Mozambique",
            "    Namibia",
            "    Nauru",
            "    Nepal",
            "    Nicaragua",
            "    Níger",
            "    Nigeria",
            "    Noruega",
            "    Nueva Zelanda",
            "    Omán",
            "    Países Bajos",
            "    Pakistán",
            "    Palaos",
            "    Panamá",
            "    Papúa Nueva Guinea",
            "    Paraguay",
            "    Perú",
            "    Polonia",
            "    Portugal",
            "    Reino Unido",
            "    República Centroafricana",
            "    República Checa",
            "    República de Macedonia",
            "    República del Congo",
            "    República Democrática del Congo",
            "    República Dominicana",
            "    República Sudafricana",
            "    Ruanda",
            "    Rumanía",
            "    Rusia",
            "    Samoa",
            "    San Cristóbal y Nieves",
            "    San Marino",
            "    San Vicente y las Granadinas",
            "    Santa Lucía",
            "    Santo Tomé y Príncipe",
            "    Senegal",
            "    Serbia",
            "    Seychelles",
            "    Sierra Leona",
            "    Singapur",
            "    Siria",
            "    Somalia",
            "    Sri Lanka",
            "    Suazilandia",
            "    Sudán",
            "    Sudán del Sur",
            "    Suecia",
            "    Suiza",
            "    Surinam",
            "    Tailandia",
            "    Tanzania",
            "    Tayikistán",
            "    Timor Oriental",
            "    Togo",
            "    Tonga",
            "    Trinidad y Tobago",
            "    Túnez",
            "    Turkmenistán",
            "    Turquía",
            "    Tuvalu",
            "    Ucrania",
            "    Uganda",
            "    Uruguay",
            "    Uzbekistán",
            "    Vanuatu",
            "    Venezuela",
            "    Vietnam",
            "    Yemen",
            "    Yibuti",
            "    Zambia",
            "    Zimbabue"});
            this.comboBox1.Location = new System.Drawing.Point(107, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nacionalidad";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nacimiento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 160);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femenino";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 133);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(512, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 283);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfil";
            
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea_1.Properties.Resources.if_user_309035;
            this.pictureBox1.Location = new System.Drawing.Point(82, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(472, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(141, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cargar Foto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
    }
}