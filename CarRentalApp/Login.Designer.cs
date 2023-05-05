namespace CarRentalApp
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            Uname = new Guna.UI2.WinForms.Guna2TextBox();
            psName = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 25);
            label1.Name = "label1";
            label1.Size = new Size(185, 41);
            label1.TabIndex = 1;
            label1.Text = "VIP TRAVELS";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(29, 95);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(346, 228);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(537, 20);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 1;
            label3.Text = "LOGIN";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(455, 302);
            button1.Name = "button1";
            button1.Size = new Size(302, 43);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(455, 367);
            button2.Name = "button2";
            button2.Size = new Size(302, 41);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 120);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 157);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // Uname
            // 
            Uname.CustomizableEdges = customizableEdges9;
            Uname.DefaultText = "";
            Uname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Uname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Uname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Uname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Uname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Uname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Uname.ForeColor = Color.Black;
            Uname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Uname.Location = new Point(507, 111);
            Uname.Name = "Uname";
            Uname.PasswordChar = '\0';
            Uname.PlaceholderText = "";
            Uname.SelectedText = "";
            Uname.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Uname.Size = new Size(250, 29);
            Uname.TabIndex = 6;
            // 
            // psName
            // 
            psName.CustomizableEdges = customizableEdges11;
            psName.DefaultText = "";
            psName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            psName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            psName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            psName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            psName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            psName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            psName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            psName.Location = new Point(507, 157);
            psName.Name = "psName";
            psName.PasswordChar = '\0';
            psName.PlaceholderText = "";
            psName.SelectedText = "";
            psName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            psName.Size = new Size(250, 28);
            psName.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(psName);
            Controls.Add(Uname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Uname;
        private Guna.UI2.WinForms.Guna2TextBox psName;
    }
}