namespace VisualComercioOnline
{
    partial class ComercioOnline_SistemaGestion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComercioOnline_SistemaGestion));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Cursor = Cursors.AppStarting;
            button1.FlatAppearance.BorderColor = Color.DarkViolet;
            button1.FlatAppearance.BorderSize = 4;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(113, 93);
            button1.Name = "button1";
            button1.Size = new Size(330, 43);
            button1.TabIndex = 1;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.AppStarting;
            button2.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.GhostWhite;
            button2.Location = new Point(28, 25);
            button2.Name = "button2";
            button2.Size = new Size(540, 39);
            button2.TabIndex = 4;
            button2.Text = "Comercio Online 101 - Sistema de gestión";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ComercioOnline_SistemaGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 375);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.MediumVioletRed;
            Name = "ComercioOnline_SistemaGestion";
            Text = "ComercioOnline_SistemaGestion";
            FormClosing += ComercioOnline_SistemaGestion_FormClosing;
            Load += ComercioOnline_SistemaGestion_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
    }
}
