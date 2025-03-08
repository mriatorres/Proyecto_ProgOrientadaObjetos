namespace VisualComercioOnline.Administrador_forms
{
    partial class ManageRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRutas));
            label1 = new Label();
            buttonAgregarRuta = new Button();
            buttonEliminarRuta = new Button();
            buttonRegresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 59);
            label1.Name = "label1";
            label1.Size = new Size(228, 40);
            label1.TabIndex = 2;
            label1.Text = "Gestionar rutas";
            label1.Click += label1_Click;
            // 
            // buttonAgregarRuta
            // 
            buttonAgregarRuta.BackColor = Color.FromArgb(192, 192, 255);
            buttonAgregarRuta.FlatStyle = FlatStyle.Popup;
            buttonAgregarRuta.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregarRuta.ForeColor = Color.BlueViolet;
            buttonAgregarRuta.Location = new Point(218, 138);
            buttonAgregarRuta.Name = "buttonAgregarRuta";
            buttonAgregarRuta.Size = new Size(262, 43);
            buttonAgregarRuta.TabIndex = 3;
            buttonAgregarRuta.Text = "Agregar ruta";
            buttonAgregarRuta.UseVisualStyleBackColor = false;
            buttonAgregarRuta.Click += this.button1_Click;
            // 
            // buttonEliminarRuta
            // 
            buttonEliminarRuta.BackColor = Color.FromArgb(192, 192, 255);
            buttonEliminarRuta.FlatStyle = FlatStyle.Popup;
            buttonEliminarRuta.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminarRuta.ForeColor = Color.BlueViolet;
            buttonEliminarRuta.Location = new Point(218, 204);
            buttonEliminarRuta.Name = "buttonEliminarRuta";
            buttonEliminarRuta.Size = new Size(262, 43);
            buttonEliminarRuta.TabIndex = 4;
            buttonEliminarRuta.Text = "Eliminar ruta";
            buttonEliminarRuta.UseVisualStyleBackColor = false;
            buttonEliminarRuta.Click += this.button2_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.FromArgb(192, 192, 255);
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.ForeColor = Color.BlueViolet;
            buttonRegresar.Location = new Point(218, 273);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(262, 43);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += this.button3_Click;
            // 
            // ManageRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(698, 450);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonEliminarRuta);
            Controls.Add(buttonAgregarRuta);
            Controls.Add(label1);
            Name = "ManageRutas";
            Text = "ManageRutas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAgregarRuta;
        private Button buttonEliminarRuta;
        private Button buttonRegresar;
    }
}