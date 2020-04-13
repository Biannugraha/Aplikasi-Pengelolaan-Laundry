namespace WindowsFormsApplication4
{
    partial class Data_login
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
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.user;
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(208, 73);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(124, 122);
            this.gunaImageButton1.TabIndex = 0;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 28);
            this.textBox1.TabIndex = 1;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton2.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.login__2_;
            this.gunaImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton2.Image = null;
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.Location = new System.Drawing.Point(114, 210);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(29, 28);
            this.gunaImageButton2.TabIndex = 3;
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton3.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._lock;
            this.gunaImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton3.Image = null;
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton3.Location = new System.Drawing.Point(109, 257);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = null;
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(34, 28);
            this.gunaImageButton3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 257);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(204, 28);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "LAUNDRY SHOW";
            // 
            // Data_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.images__3_;
            this.ClientSize = new System.Drawing.Size(499, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunaImageButton3);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gunaImageButton1);
            this.Name = "Data_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data_login";
            this.Load += new System.EventHandler(this.Data_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}