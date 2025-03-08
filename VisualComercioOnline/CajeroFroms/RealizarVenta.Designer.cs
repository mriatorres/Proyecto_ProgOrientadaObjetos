namespace VisualComercioOnline
{
    partial class RealizarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarVenta));
            label1 = new Label();
            label2 = new Label();
            txtNomComp = new TextBox();
            label3 = new Label();
            txtNumRuta = new TextBox();
            label4 = new Label();
            txtCantidadTiquetes = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(310, 24);
            label1.Name = "label1";
            label1.Size = new Size(211, 40);
            label1.TabIndex = 1;
            label1.Text = "Realizar venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 93);
            label2.Name = "label2";
            label2.Size = new Size(242, 32);
            label2.TabIndex = 3;
            label2.Text = "Nombre comprador";
            label2.Click += label2_Click;
            // 
            // txtNomComp
            // 
            txtNomComp.BorderStyle = BorderStyle.FixedSingle;
            txtNomComp.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNomComp.ForeColor = SystemColors.WindowText;
            txtNomComp.Location = new Point(47, 141);
            txtNomComp.Name = "txtNomComp";
            txtNomComp.PlaceholderText = "Ingrese el nombre del comprador";
            txtNomComp.Size = new Size(474, 33);
            txtNomComp.TabIndex = 4;
            txtNomComp.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateBlue;
            label3.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 196);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 5;
            label3.Text = "Número de ruta";
            // 
            // txtNumRuta
            // 
            txtNumRuta.BorderStyle = BorderStyle.FixedSingle;
            txtNumRuta.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNumRuta.ForeColor = SystemColors.WindowText;
            txtNumRuta.Location = new Point(47, 245);
            txtNumRuta.Name = "txtNumRuta";
            txtNumRuta.PlaceholderText = "Ingrese el número de la ruta";
            txtNumRuta.Size = new Size(474, 33);
            txtNumRuta.TabIndex = 6;
            txtNumRuta.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateBlue;
            label4.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 300);
            label4.Name = "label4";
            label4.Size = new Size(215, 32);
            label4.TabIndex = 7;
            label4.Text = "Cantidad tiquetes";
            // 
            // txtCantidadTiquetes
            // 
            txtCantidadTiquetes.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadTiquetes.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCantidadTiquetes.ForeColor = SystemColors.WindowText;
            txtCantidadTiquetes.Location = new Point(47, 350);
            txtCantidadTiquetes.Name = "txtCantidadTiquetes";
            txtCantidadTiquetes.PlaceholderText = "Ingrese la cantidad de tiquetes";
            txtCantidadTiquetes.Size = new Size(474, 33);
            txtCantidadTiquetes.TabIndex = 8;
            txtCantidadTiquetes.TextChanged += textBox2_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.BlueViolet;
            button4.Location = new Point(259, 430);
            button4.Name = "button4";
            button4.Size = new Size(262, 43);
            button4.TabIndex = 9;
            button4.Text = "Registrar venta";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(776, 504);
            Controls.Add(button4);
            Controls.Add(txtCantidadTiquetes);
            Controls.Add(label4);
            Controls.Add(txtNumRuta);
            Controls.Add(label3);
            Controls.Add(txtNomComp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RealizarVenta";
            Text = "RealizarVenta";
            Load += RealizarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomComp;
        private Label label3;
        private TextBox txtNumRuta;
        private Label label4;
        private TextBox txtCantidadTiquetes;
        private Button button4;
    }
}