namespace VisualComercioOnline.Administrador_forms.Gestion_rutas
{
    partial class AgregarRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRuta));
            label1 = new Label();
            label2 = new Label();
            txtIdruta = new TextBox();
            label3 = new Label();
            txtOrigen = new TextBox();
            label4 = new Label();
            txtDestino = new TextBox();
            label5 = new Label();
            txtHora = new TextBox();
            label6 = new Label();
            txtPrecioTiquete = new TextBox();
            buttonAgregarRuta = new Button();
            label7 = new Label();
            txtTiquetesDispo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 20);
            label1.Name = "label1";
            label1.Size = new Size(194, 40);
            label1.TabIndex = 3;
            label1.Text = "Agregar ruta";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 73);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 4;
            label2.Text = "ID ruta";
            // 
            // txtIdruta
            // 
            txtIdruta.BorderStyle = BorderStyle.FixedSingle;
            txtIdruta.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtIdruta.ForeColor = SystemColors.WindowText;
            txtIdruta.Location = new Point(107, 125);
            txtIdruta.Name = "txtIdruta";
            txtIdruta.PlaceholderText = "Ingrese el ID de la ruta";
            txtIdruta.Size = new Size(474, 33);
            txtIdruta.TabIndex = 5;
            txtIdruta.TextChanged += txtNomComp_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateBlue;
            label3.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(107, 181);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 6;
            label3.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.BorderStyle = BorderStyle.FixedSingle;
            txtOrigen.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtOrigen.ForeColor = SystemColors.WindowText;
            txtOrigen.Location = new Point(107, 229);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.PlaceholderText = "Ingrese el origen de la ruta";
            txtOrigen.Size = new Size(474, 33);
            txtOrigen.TabIndex = 7;
            txtOrigen.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateBlue;
            label4.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(107, 289);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 8;
            label4.Text = "Destino";
            // 
            // txtDestino
            // 
            txtDestino.BorderStyle = BorderStyle.FixedSingle;
            txtDestino.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDestino.ForeColor = SystemColors.WindowText;
            txtDestino.Location = new Point(107, 341);
            txtDestino.Name = "txtDestino";
            txtDestino.PlaceholderText = "Ingrese el destino de la ruta";
            txtDestino.Size = new Size(474, 33);
            txtDestino.TabIndex = 9;
            txtDestino.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSlateBlue;
            label5.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(107, 395);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 10;
            label5.Text = "Horario";
            // 
            // txtHora
            // 
            txtHora.BorderStyle = BorderStyle.FixedSingle;
            txtHora.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtHora.ForeColor = SystemColors.WindowText;
            txtHora.Location = new Point(107, 450);
            txtHora.Name = "txtHora";
            txtHora.PlaceholderText = "Ingrese el horario de la ruta ex: 12:00AM/12:00PM";
            txtHora.Size = new Size(474, 33);
            txtHora.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkSlateBlue;
            label6.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(107, 509);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 12;
            label6.Text = "Precio tiquete";
            // 
            // txtPrecioTiquete
            // 
            txtPrecioTiquete.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioTiquete.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrecioTiquete.ForeColor = SystemColors.WindowText;
            txtPrecioTiquete.Location = new Point(107, 560);
            txtPrecioTiquete.Name = "txtPrecioTiquete";
            txtPrecioTiquete.PlaceholderText = "Ingrese el precio del tiquete de la ruta";
            txtPrecioTiquete.Size = new Size(474, 33);
            txtPrecioTiquete.TabIndex = 13;
            txtPrecioTiquete.TextChanged += textBox4_TextChanged;
            // 
            // buttonAgregarRuta
            // 
            buttonAgregarRuta.BackColor = Color.FromArgb(192, 192, 255);
            buttonAgregarRuta.FlatStyle = FlatStyle.Popup;
            buttonAgregarRuta.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregarRuta.ForeColor = Color.BlueViolet;
            buttonAgregarRuta.Location = new Point(248, 740);
            buttonAgregarRuta.Name = "buttonAgregarRuta";
            buttonAgregarRuta.Size = new Size(262, 43);
            buttonAgregarRuta.TabIndex = 14;
            buttonAgregarRuta.Text = "Actualizar";
            buttonAgregarRuta.UseVisualStyleBackColor = false;
            buttonAgregarRuta.Click += buttonAgregarRuta_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkSlateBlue;
            label7.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(107, 616);
            label7.Name = "label7";
            label7.Size = new Size(249, 32);
            label7.TabIndex = 15;
            label7.Text = "Tiquetes disponibles";
            // 
            // txtTiquetesDispo
            // 
            txtTiquetesDispo.BorderStyle = BorderStyle.FixedSingle;
            txtTiquetesDispo.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTiquetesDispo.ForeColor = SystemColors.WindowText;
            txtTiquetesDispo.Location = new Point(107, 668);
            txtTiquetesDispo.Name = "txtTiquetesDispo";
            txtTiquetesDispo.PlaceholderText = "Ingrese el numero de tiquetes disponibles de la ruta";
            txtTiquetesDispo.Size = new Size(474, 33);
            txtTiquetesDispo.TabIndex = 16;
            // 
            // AgregarRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(712, 833);
            Controls.Add(txtTiquetesDispo);
            Controls.Add(label7);
            Controls.Add(buttonAgregarRuta);
            Controls.Add(txtPrecioTiquete);
            Controls.Add(label6);
            Controls.Add(txtHora);
            Controls.Add(label5);
            Controls.Add(txtDestino);
            Controls.Add(label4);
            Controls.Add(txtOrigen);
            Controls.Add(label3);
            Controls.Add(txtIdruta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarRuta";
            Text = "AgregarRuta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdruta;
        private Label label3;
        private TextBox txtOrigen;
        private Label label4;
        private TextBox txtDestino;
        private Label label5;
        private TextBox txtHora;
        private Label label6;
        private TextBox txtPrecioTiquete;
        private Button buttonAgregarRuta;
        private Label label7;
        private TextBox txtTiquetesDispo;
    }
}