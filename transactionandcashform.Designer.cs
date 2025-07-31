
namespace coal_managment_application
{
    partial class transactionandcashform
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.allrecord = new System.Windows.Forms.RadioButton();
            this.mnthlyrbtn = new System.Windows.Forms.RadioButton();
            this.weeklyreportrb = new System.Windows.Forms.RadioButton();
            this.dailyreportrb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction/Cash Report";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 355);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // allrecord
            // 
            this.allrecord.AutoSize = true;
            this.allrecord.Checked = true;
            this.allrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allrecord.Location = new System.Drawing.Point(38, 55);
            this.allrecord.Name = "allrecord";
            this.allrecord.Size = new System.Drawing.Size(49, 22);
            this.allrecord.TabIndex = 15;
            this.allrecord.TabStop = true;
            this.allrecord.Text = "All ";
            this.allrecord.UseVisualStyleBackColor = true;
            this.allrecord.CheckedChanged += new System.EventHandler(this.allrecord_CheckedChanged);
            // 
            // mnthlyrbtn
            // 
            this.mnthlyrbtn.AutoSize = true;
            this.mnthlyrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnthlyrbtn.Location = new System.Drawing.Point(586, 55);
            this.mnthlyrbtn.Name = "mnthlyrbtn";
            this.mnthlyrbtn.Size = new System.Drawing.Size(141, 22);
            this.mnthlyrbtn.TabIndex = 14;
            this.mnthlyrbtn.Text = "Monthly Report";
            this.mnthlyrbtn.UseVisualStyleBackColor = true;
            this.mnthlyrbtn.CheckedChanged += new System.EventHandler(this.mnthlyrbtn_CheckedChanged);
            // 
            // weeklyreportrb
            // 
            this.weeklyreportrb.AutoSize = true;
            this.weeklyreportrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyreportrb.Location = new System.Drawing.Point(355, 55);
            this.weeklyreportrb.Name = "weeklyreportrb";
            this.weeklyreportrb.Size = new System.Drawing.Size(137, 22);
            this.weeklyreportrb.TabIndex = 13;
            this.weeklyreportrb.Text = "Weekly Report";
            this.weeklyreportrb.UseVisualStyleBackColor = true;
            this.weeklyreportrb.CheckedChanged += new System.EventHandler(this.weeklyreportrb_CheckedChanged);
            // 
            // dailyreportrb
            // 
            this.dailyreportrb.AutoSize = true;
            this.dailyreportrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyreportrb.Location = new System.Drawing.Point(161, 55);
            this.dailyreportrb.Name = "dailyreportrb";
            this.dailyreportrb.Size = new System.Drawing.Size(119, 22);
            this.dailyreportrb.TabIndex = 12;
            this.dailyreportrb.Text = "Daily Report";
            this.dailyreportrb.UseVisualStyleBackColor = true;
            this.dailyreportrb.CheckedChanged += new System.EventHandler(this.dailyreportrb_CheckedChanged);
            // 
            // transactionandcashform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allrecord);
            this.Controls.Add(this.mnthlyrbtn);
            this.Controls.Add(this.weeklyreportrb);
            this.Controls.Add(this.dailyreportrb);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transactionandcashform";
            this.Text = "transactionandcashform";
            this.Load += new System.EventHandler(this.transactionandcashform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton allrecord;
        private System.Windows.Forms.RadioButton mnthlyrbtn;
        private System.Windows.Forms.RadioButton weeklyreportrb;
        private System.Windows.Forms.RadioButton dailyreportrb;
    }
}