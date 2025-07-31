
namespace coal_managment_application
{
    partial class backupform
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.browsebtnbup = new System.Windows.Forms.Button();
            this.backupbtn = new System.Windows.Forms.Button();
            this.browsebthnres = new System.Windows.Forms.Button();
            this.restorebthn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup And Restore";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.backupbtn);
            this.groupBox1.Controls.Add(this.browsebtnbup);
            this.groupBox1.Location = new System.Drawing.Point(86, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup DataBase";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.restorebthn);
            this.groupBox2.Controls.Add(this.browsebthnres);
            this.groupBox2.Location = new System.Drawing.Point(86, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore DataBase";
            // 
            // browsebtnbup
            // 
            this.browsebtnbup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebtnbup.Location = new System.Drawing.Point(428, 19);
            this.browsebtnbup.Name = "browsebtnbup";
            this.browsebtnbup.Size = new System.Drawing.Size(75, 38);
            this.browsebtnbup.TabIndex = 0;
            this.browsebtnbup.Text = "Browse";
            this.browsebtnbup.UseVisualStyleBackColor = true;
            this.browsebtnbup.Click += new System.EventHandler(this.browsebtnbup_Click);
            // 
            // backupbtn
            // 
            this.backupbtn.Enabled = false;
            this.backupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupbtn.Location = new System.Drawing.Point(428, 63);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(75, 38);
            this.backupbtn.TabIndex = 1;
            this.backupbtn.Text = "Backup";
            this.backupbtn.UseVisualStyleBackColor = true;
            this.backupbtn.Click += new System.EventHandler(this.backupbtn_Click);
            // 
            // browsebthnres
            // 
            this.browsebthnres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebthnres.Location = new System.Drawing.Point(428, 9);
            this.browsebthnres.Name = "browsebthnres";
            this.browsebthnres.Size = new System.Drawing.Size(75, 38);
            this.browsebthnres.TabIndex = 2;
            this.browsebthnres.Text = "Browse";
            this.browsebthnres.UseVisualStyleBackColor = true;
            this.browsebthnres.Click += new System.EventHandler(this.browsebthnres_Click);
            // 
            // restorebthn
            // 
            this.restorebthn.Enabled = false;
            this.restorebthn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restorebthn.Location = new System.Drawing.Point(428, 53);
            this.restorebthn.Name = "restorebthn";
            this.restorebthn.Size = new System.Drawing.Size(75, 38);
            this.restorebthn.TabIndex = 3;
            this.restorebthn.Text = "Restore";
            this.restorebthn.UseVisualStyleBackColor = true;
            this.restorebthn.Click += new System.EventHandler(this.restorebthn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(65, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 33);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(65, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 33);
            this.textBox2.TabIndex = 4;
            // 
            // backupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "backupform";
            this.Text = "backupform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backupbtn;
        private System.Windows.Forms.Button browsebtnbup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button restorebthn;
        private System.Windows.Forms.Button browsebthnres;
    }
}