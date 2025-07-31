
namespace coal_managment_application
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.password_error = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Label();
            this.username_error = new System.Windows.Forms.Label();
            this.password_get = new System.Windows.Forms.TextBox();
            this.username_get = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.password_error);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.username_error);
            this.panel1.Controls.Add(this.password_get);
            this.panel1.Controls.Add(this.username_get);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 339);
            this.panel1.TabIndex = 0;
            // 
            // password_error
            // 
            this.password_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_error.AutoSize = true;
            this.password_error.BackColor = System.Drawing.Color.Transparent;
            this.password_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_error.ForeColor = System.Drawing.Color.Red;
            this.password_error.Location = new System.Drawing.Point(170, 216);
            this.password_error.Name = "password_error";
            this.password_error.Size = new System.Drawing.Size(107, 15);
            this.password_error.TabIndex = 8;
            this.password_error.Text = "password_error";
            this.password_error.Visible = false;
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.Location = new System.Drawing.Point(198, 287);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signup
            // 
            this.signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.signup.Location = new System.Drawing.Point(148, 262);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(190, 15);
            this.signup.TabIndex = 6;
            this.signup.Text = "Don\'t Have Account? SignUp";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // username_error
            // 
            this.username_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_error.AutoSize = true;
            this.username_error.BackColor = System.Drawing.Color.Transparent;
            this.username_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_error.ForeColor = System.Drawing.Color.Red;
            this.username_error.Location = new System.Drawing.Point(170, 147);
            this.username_error.Name = "username_error";
            this.username_error.Size = new System.Drawing.Size(110, 15);
            this.username_error.TabIndex = 5;
            this.username_error.Text = "username_error";
            this.username_error.Visible = false;
            // 
            // password_get
            // 
            this.password_get.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_get.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_get.Location = new System.Drawing.Point(63, 182);
            this.password_get.Multiline = true;
            this.password_get.Name = "password_get";
            this.password_get.PasswordChar = '*';
            this.password_get.Size = new System.Drawing.Size(353, 31);
            this.password_get.TabIndex = 4;
            this.password_get.Enter += new System.EventHandler(this.password_get_Enter);
            // 
            // username_get
            // 
            this.username_get.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_get.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_get.Location = new System.Drawing.Point(63, 113);
            this.username_get.Multiline = true;
            this.username_get.Name = "username_get";
            this.username_get.Size = new System.Drawing.Size(353, 31);
            this.username_get.TabIndex = 3;
            this.username_get.TextChanged += new System.EventHandler(this.username_get_TextChanged);
            this.username_get.Enter += new System.EventHandler(this.username_get_Enter);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(63, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "password:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(215, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(229, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iqbal Smart Coal Manager";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::coal_managment_application.Properties.Resources.pexels_pixabay_48884;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label password_error;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label username_error;
        private System.Windows.Forms.TextBox password_get;
        private System.Windows.Forms.TextBox username_get;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

