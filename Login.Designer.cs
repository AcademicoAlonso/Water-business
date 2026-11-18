namespace Water_business
{
    partial class Login
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
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btningresar = new FontAwesome.Sharp.IconButton();
            btncancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightSlateGray;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(500, 117);
            label1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.LightSlateGray;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 117;
            iconPictureBox1.Location = new Point(188, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(118, 117);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(72, 175);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(347, 31);
            txtusuario.TabIndex = 2;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(72, 273);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(347, 31);
            txtcontraseña.TabIndex = 3;
            txtcontraseña.TextChanged += txtcontraseña_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 147);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "N_usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 245);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.DeepSkyBlue;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatAppearance.BorderColor = Color.Black;
            btningresar.ForeColor = Color.White;
            btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btningresar.IconColor = Color.White;
            btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningresar.IconSize = 30;
            btningresar.ImageAlign = ContentAlignment.MiddleRight;
            btningresar.Location = new Point(72, 341);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(165, 44);
            btningresar.TabIndex = 6;
            btningresar.Text = "Ingresar";
            btningresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Brown;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.ForeColor = Color.White;
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btncancelar.IconColor = Color.White;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 30;
            btncancelar.ImageAlign = ContentAlignment.MiddleRight;
            btncancelar.Location = new Point(254, 341);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(165, 44);
            btncancelar.TabIndex = 8;
            btncancelar.Text = "Cancelar";
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 449);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtusuario;
        private TextBox textBox1;
        private TextBox txtcontraseña;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btningresar;
        private FontAwesome.Sharp.IconButton btncancelar;
       
    }
}