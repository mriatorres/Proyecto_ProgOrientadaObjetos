namespace VisualComercioOnline
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            cmbRole = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(105, 37);
            label1.TabIndex = 0;
            label1.Text = "Correo";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(57, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese su correo";
            txtEmail.Size = new Size(474, 33);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 135);
            label2.Name = "label2";
            label2.Size = new Size(162, 37);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(57, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Ingrese su contraseña";
            txtPassword.Size = new Size(474, 33);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateBlue;
            label3.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 237);
            label3.Name = "label3";
            label3.Size = new Size(60, 37);
            label3.TabIndex = 4;
            label3.Text = "Rol";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Administrador", "Cajero" });
            cmbRole.Location = new Point(57, 277);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(57, 329);
            button1.Name = "button1";
            button1.Size = new Size(262, 43);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(cmbRole);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            //FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private ComboBox cmbRole;
        private Button button1;
    }
}