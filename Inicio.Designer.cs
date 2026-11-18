namespace Water_business
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            Menutitulo = new MenuStrip();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2, MenuCompras, MenuReportes });
            menuStrip1.Location = new Point(0, 74);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1218, 73);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(96, 69);
            iconMenuItem1.Text = "Usuarios";
            iconMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(80, 69);
            iconMenuItem2.Text = "Ventas";
            iconMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuCompras
            // 
            MenuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            MenuCompras.IconColor = Color.Black;
            MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCompras.ImageScaling = ToolStripItemImageScaling.None;
            MenuCompras.Name = "MenuCompras";
            MenuCompras.Size = new Size(100, 69);
            MenuCompras.Text = "Compras";
            MenuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuReportes
            // 
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.FileText;
            MenuReportes.IconColor = Color.Black;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(98, 69);
            MenuReportes.Text = "Reportes";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Menutitulo
            // 
            Menutitulo.AutoSize = false;
            Menutitulo.BackColor = Color.LightSlateGray;
            Menutitulo.ImageScalingSize = new Size(24, 24);
            Menutitulo.Location = new Point(0, 0);
            Menutitulo.Name = "Menutitulo";
            Menutitulo.RightToLeft = RightToLeft.Yes;
            Menutitulo.Size = new Size(1218, 74);
            Menutitulo.TabIndex = 1;
            Menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 8);
            label1.Name = "label1";
            label1.Size = new Size(380, 54);
            label1.TabIndex = 2;
            label1.Text = "Gestion Purificadora";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 548);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(Menutitulo);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private MenuStrip Menutitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private Label label1;
    }
}