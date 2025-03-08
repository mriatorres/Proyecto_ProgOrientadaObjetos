namespace VisualComercioOnline
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(216, 47);
            label1.Name = "label1";
            label1.Size = new Size(352, 40);
            label1.TabIndex = 1;
            label1.Text = "   Menú Administrador   ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(260, 108);
            button1.Name = "button1";
            button1.Size = new Size(262, 43);
            button1.TabIndex = 2;
            button1.Text = "Gestionar cajeros";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.BlueViolet;
            button2.Location = new Point(260, 168);
            button2.Name = "button2";
            button2.Size = new Size(262, 43);
            button2.TabIndex = 3;
            button2.Text = "Gestionar Conductores";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.BlueViolet;
            button3.Location = new Point(260, 293);
            button3.Name = "button3";
            button3.Size = new Size(262, 43);
            button3.TabIndex = 4;
            button3.Text = "Cerrar sesión";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.BlueViolet;
            button4.Location = new Point(260, 231);
            button4.Name = "button4";
            button4.Size = new Size(262, 43);
            button4.TabIndex = 5;
            button4.Text = "Gestionar rutas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(786, 376);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AdminMenuForm";
            Text = "AdminMenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}