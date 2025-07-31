
namespace coal_managment_application
{
    partial class adminexpensereport
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
            this.getid = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.searchid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gettravel_exp = new System.Windows.Forms.TextBox();
            this.getinsur_exp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.getempl_exp = new System.Windows.Forms.TextBox();
            this.getmaint_exp = new System.Windows.Forms.TextBox();
            this.getequip_exp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteradioButton = new System.Windows.Forms.RadioButton();
            this.updateradioButton = new System.Windows.Forms.RadioButton();
            this.insertradioButton = new System.Windows.Forms.RadioButton();
            this.searchpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense report Status";
            // 
            // getid
            // 
            this.getid.BackColor = System.Drawing.Color.Beige;
            this.getid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getid.Location = new System.Drawing.Point(198, 97);
            this.getid.Multiline = true;
            this.getid.Name = "getid";
            this.getid.Size = new System.Drawing.Size(274, 32);
            this.getid.TabIndex = 58;
            this.getid.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.Black;
            this.labelid.Location = new System.Drawing.Point(10, 97);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(92, 20);
            this.labelid.TabIndex = 57;
            this.labelid.Text = "Assign ID:";
            this.labelid.Visible = false;
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Black;
            this.deletebutton.Location = new System.Drawing.Point(475, 458);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(193, 37);
            this.deletebutton.TabIndex = 56;
            this.deletebutton.Text = "delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Visible = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.Black;
            this.updatebutton.Location = new System.Drawing.Point(77, 458);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(193, 37);
            this.updatebutton.TabIndex = 55;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Visible = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.ForeColor = System.Drawing.Color.Black;
            this.insertbutton.Location = new System.Drawing.Point(276, 458);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(193, 37);
            this.insertbutton.TabIndex = 54;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // searchpanel
            // 
            this.searchpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchpanel.Controls.Add(this.searchbtn);
            this.searchpanel.Controls.Add(this.label9);
            this.searchpanel.Controls.Add(this.searchid);
            this.searchpanel.Controls.Add(this.label8);
            this.searchpanel.Location = new System.Drawing.Point(481, 110);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(291, 308);
            this.searchpanel.TabIndex = 53;
            this.searchpanel.Visible = false;
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.Black;
            this.searchbtn.Location = new System.Drawing.Point(47, 199);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(193, 37);
            this.searchbtn.TabIndex = 18;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(95, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Enter id: ";
            // 
            // searchid
            // 
            this.searchid.BackColor = System.Drawing.Color.Beige;
            this.searchid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchid.ForeColor = System.Drawing.Color.Black;
            this.searchid.Location = new System.Drawing.Point(9, 119);
            this.searchid.Multiline = true;
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(274, 32);
            this.searchid.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "please search customer name or id first\r\n           for update and delete";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 415);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Date /Time: ";
            // 
            // gettravel_exp
            // 
            this.gettravel_exp.BackColor = System.Drawing.Color.Beige;
            this.gettravel_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gettravel_exp.Location = new System.Drawing.Point(198, 358);
            this.gettravel_exp.Multiline = true;
            this.gettravel_exp.Name = "gettravel_exp";
            this.gettravel_exp.Size = new System.Drawing.Size(274, 32);
            this.gettravel_exp.TabIndex = 50;
            // 
            // getinsur_exp
            // 
            this.getinsur_exp.BackColor = System.Drawing.Color.Beige;
            this.getinsur_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getinsur_exp.Location = new System.Drawing.Point(195, 306);
            this.getinsur_exp.Multiline = true;
            this.getinsur_exp.Name = "getinsur_exp";
            this.getinsur_exp.Size = new System.Drawing.Size(274, 32);
            this.getinsur_exp.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Travel Expense:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Insurance Expense: ";
            // 
            // getempl_exp
            // 
            this.getempl_exp.BackColor = System.Drawing.Color.Beige;
            this.getempl_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getempl_exp.Location = new System.Drawing.Point(198, 254);
            this.getempl_exp.Multiline = true;
            this.getempl_exp.Name = "getempl_exp";
            this.getempl_exp.Size = new System.Drawing.Size(274, 32);
            this.getempl_exp.TabIndex = 46;
            // 
            // getmaint_exp
            // 
            this.getmaint_exp.BackColor = System.Drawing.Color.Beige;
            this.getmaint_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getmaint_exp.Location = new System.Drawing.Point(195, 202);
            this.getmaint_exp.Multiline = true;
            this.getmaint_exp.Name = "getmaint_exp";
            this.getmaint_exp.Size = new System.Drawing.Size(274, 32);
            this.getmaint_exp.TabIndex = 45;
            // 
            // getequip_exp
            // 
            this.getequip_exp.BackColor = System.Drawing.Color.Beige;
            this.getequip_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getequip_exp.Location = new System.Drawing.Point(198, 147);
            this.getequip_exp.Multiline = true;
            this.getequip_exp.Name = "getequip_exp";
            this.getequip_exp.Size = new System.Drawing.Size(274, 32);
            this.getequip_exp.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Employee Expense:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Maintainance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Equipment Expense:";
            // 
            // deleteradioButton
            // 
            this.deleteradioButton.AutoSize = true;
            this.deleteradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteradioButton.ForeColor = System.Drawing.Color.Black;
            this.deleteradioButton.Location = new System.Drawing.Point(606, 35);
            this.deleteradioButton.Name = "deleteradioButton";
            this.deleteradioButton.Size = new System.Drawing.Size(80, 24);
            this.deleteradioButton.TabIndex = 40;
            this.deleteradioButton.TabStop = true;
            this.deleteradioButton.Text = "Delete";
            this.deleteradioButton.UseVisualStyleBackColor = true;
            this.deleteradioButton.CheckedChanged += new System.EventHandler(this.deleteradioButton_CheckedChanged);
            // 
            // updateradioButton
            // 
            this.updateradioButton.AutoSize = true;
            this.updateradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateradioButton.ForeColor = System.Drawing.Color.Black;
            this.updateradioButton.Location = new System.Drawing.Point(326, 35);
            this.updateradioButton.Name = "updateradioButton";
            this.updateradioButton.Size = new System.Drawing.Size(86, 24);
            this.updateradioButton.TabIndex = 39;
            this.updateradioButton.TabStop = true;
            this.updateradioButton.Text = "Update";
            this.updateradioButton.UseVisualStyleBackColor = true;
            this.updateradioButton.CheckedChanged += new System.EventHandler(this.updateradioButton_CheckedChanged);
            // 
            // insertradioButton
            // 
            this.insertradioButton.AutoSize = true;
            this.insertradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertradioButton.ForeColor = System.Drawing.Color.Black;
            this.insertradioButton.Location = new System.Drawing.Point(72, 35);
            this.insertradioButton.Name = "insertradioButton";
            this.insertradioButton.Size = new System.Drawing.Size(98, 24);
            this.insertradioButton.TabIndex = 38;
            this.insertradioButton.TabStop = true;
            this.insertradioButton.Text = "Insertion";
            this.insertradioButton.UseVisualStyleBackColor = true;
            this.insertradioButton.CheckedChanged += new System.EventHandler(this.insertradioButton_CheckedChanged);
            // 
            // adminexpensereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 531);
            this.Controls.Add(this.getid);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.searchpanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gettravel_exp);
            this.Controls.Add(this.getinsur_exp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getempl_exp);
            this.Controls.Add(this.getmaint_exp);
            this.Controls.Add(this.getequip_exp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteradioButton);
            this.Controls.Add(this.updateradioButton);
            this.Controls.Add(this.insertradioButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminexpensereport";
            this.Text = "adminexpensereport";
            this.Load += new System.EventHandler(this.adminexpensereport_Load);
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gettravel_exp;
        private System.Windows.Forms.TextBox getinsur_exp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox getempl_exp;
        private System.Windows.Forms.TextBox getmaint_exp;
        private System.Windows.Forms.TextBox getequip_exp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton deleteradioButton;
        private System.Windows.Forms.RadioButton updateradioButton;
        private System.Windows.Forms.RadioButton insertradioButton;
    }
}