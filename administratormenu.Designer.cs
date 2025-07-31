
namespace coal_managment_application
{
    partial class administratormenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administratormenu));
            this.label4 = new System.Windows.Forms.Label();
            this.ReportTimeradmin = new System.Windows.Forms.Timer(this.components);
            this.sliderbartimeradmin = new System.Windows.Forms.Timer(this.components);
            this.panelcontaineradmin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.slidebaradmin = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Reportpaneladmin = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.logout = new System.Windows.Forms.Button();
            this.menubuttononbar = new System.Windows.Forms.PictureBox();
            this.reportbutton = new System.Windows.Forms.Button();
            this.expensereportbtn = new System.Windows.Forms.Button();
            this.stockreportbutton = new System.Windows.Forms.Button();
            this.salesreportbtn = new System.Windows.Forms.Button();
            this.alert = new System.Windows.Forms.Button();
            this.transactionandcashbtn = new System.Windows.Forms.Button();
            this.Notification = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.createbackup = new System.Windows.Forms.Button();
            this.graphbtn = new System.Windows.Forms.Button();
            this.panelcontaineradmin.SuspendLayout();
            this.slidebaradmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Reportpaneladmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubuttononbar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(416, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "Iqbal Smart Coal Managment";
            // 
            // ReportTimeradmin
            // 
            this.ReportTimeradmin.Interval = 15;
            // 
            // sliderbartimeradmin
            // 
            this.sliderbartimeradmin.Interval = 10;
            // 
            // panelcontaineradmin
            // 
            this.panelcontaineradmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelcontaineradmin.Controls.Add(this.label2);
            this.panelcontaineradmin.Location = new System.Drawing.Point(239, 44);
            this.panelcontaineradmin.Name = "panelcontaineradmin";
            this.panelcontaineradmin.Size = new System.Drawing.Size(798, 655);
            this.panelcontaineradmin.TabIndex = 15;
            this.panelcontaineradmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontaineradmin_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(386, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Welcome Sir";
            // 
            // slidebaradmin
            // 
            this.slidebaradmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slidebaradmin.Controls.Add(this.panel1);
            this.slidebaradmin.Controls.Add(this.Reportpaneladmin);
            this.slidebaradmin.Controls.Add(this.alert);
            this.slidebaradmin.Controls.Add(this.transactionandcashbtn);
            this.slidebaradmin.Controls.Add(this.Notification);
            this.slidebaradmin.Controls.Add(this.printbtn);
            this.slidebaradmin.Controls.Add(this.createbackup);
            this.slidebaradmin.Controls.Add(this.graphbtn);
            this.slidebaradmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebaradmin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.slidebaradmin.Location = new System.Drawing.Point(0, 0);
            this.slidebaradmin.MaximumSize = new System.Drawing.Size(214, 0);
            this.slidebaradmin.MinimumSize = new System.Drawing.Size(77, 0);
            this.slidebaradmin.Name = "slidebaradmin";
            this.slidebaradmin.Size = new System.Drawing.Size(214, 702);
            this.slidebaradmin.TabIndex = 0;
            this.slidebaradmin.Paint += new System.Windows.Forms.PaintEventHandler(this.slidebaradmin_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menubuttononbar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 114);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // Reportpaneladmin
            // 
            this.Reportpaneladmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Reportpaneladmin.Controls.Add(this.reportbutton);
            this.Reportpaneladmin.Controls.Add(this.expensereportbtn);
            this.Reportpaneladmin.Controls.Add(this.stockreportbutton);
            this.Reportpaneladmin.Controls.Add(this.salesreportbtn);
            this.Reportpaneladmin.Location = new System.Drawing.Point(3, 123);
            this.Reportpaneladmin.MaximumSize = new System.Drawing.Size(211, 229);
            this.Reportpaneladmin.MinimumSize = new System.Drawing.Size(211, 57);
            this.Reportpaneladmin.Name = "Reportpaneladmin";
            this.Reportpaneladmin.Size = new System.Drawing.Size(211, 186);
            this.Reportpaneladmin.TabIndex = 21;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Image = global::coal_managment_application.Properties.Resources.power_off;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(959, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(108, 35);
            this.logout.TabIndex = 21;
            this.logout.Text = "        LogOut";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menubuttononbar
            // 
            this.menubuttononbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubuttononbar.Image = global::coal_managment_application.Properties.Resources.icons8_circled_menu_48;
            this.menubuttononbar.Location = new System.Drawing.Point(16, 25);
            this.menubuttononbar.Name = "menubuttononbar";
            this.menubuttononbar.Size = new System.Drawing.Size(77, 50);
            this.menubuttononbar.TabIndex = 1;
            this.menubuttononbar.TabStop = false;
            // 
            // reportbutton
            // 
            this.reportbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportbutton.FlatAppearance.BorderSize = 0;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbutton.ForeColor = System.Drawing.Color.Silver;
            this.reportbutton.Image = global::coal_managment_application.Properties.Resources.report;
            this.reportbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportbutton.Location = new System.Drawing.Point(0, 3);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(212, 52);
            this.reportbutton.TabIndex = 3;
            this.reportbutton.Text = "                     Report";
            this.reportbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportbutton.UseVisualStyleBackColor = false;
            // 
            // expensereportbtn
            // 
            this.expensereportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.expensereportbtn.FlatAppearance.BorderSize = 0;
            this.expensereportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensereportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensereportbtn.ForeColor = System.Drawing.Color.Silver;
            this.expensereportbtn.Image = global::coal_managment_application.Properties.Resources.expense;
            this.expensereportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensereportbtn.Location = new System.Drawing.Point(3, 142);
            this.expensereportbtn.Name = "expensereportbtn";
            this.expensereportbtn.Size = new System.Drawing.Size(206, 40);
            this.expensereportbtn.TabIndex = 6;
            this.expensereportbtn.Text = "                     Expense Report";
            this.expensereportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensereportbtn.UseVisualStyleBackColor = false;
            this.expensereportbtn.Click += new System.EventHandler(this.expensereportbtn_Click);
            // 
            // stockreportbutton
            // 
            this.stockreportbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.stockreportbutton.FlatAppearance.BorderSize = 0;
            this.stockreportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockreportbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockreportbutton.ForeColor = System.Drawing.Color.Silver;
            this.stockreportbutton.Image = global::coal_managment_application.Properties.Resources.stocks;
            this.stockreportbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockreportbutton.Location = new System.Drawing.Point(3, 99);
            this.stockreportbutton.Name = "stockreportbutton";
            this.stockreportbutton.Size = new System.Drawing.Size(206, 40);
            this.stockreportbutton.TabIndex = 5;
            this.stockreportbutton.Text = "                    Stock  Report";
            this.stockreportbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockreportbutton.UseVisualStyleBackColor = false;
            this.stockreportbutton.Click += new System.EventHandler(this.stockreportbutton_Click);
            // 
            // salesreportbtn
            // 
            this.salesreportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.salesreportbtn.FlatAppearance.BorderSize = 0;
            this.salesreportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesreportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesreportbtn.ForeColor = System.Drawing.Color.Silver;
            this.salesreportbtn.Image = global::coal_managment_application.Properties.Resources.sales;
            this.salesreportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesreportbtn.Location = new System.Drawing.Point(0, 61);
            this.salesreportbtn.Name = "salesreportbtn";
            this.salesreportbtn.Size = new System.Drawing.Size(206, 34);
            this.salesreportbtn.TabIndex = 4;
            this.salesreportbtn.Text = "                     Sales Report";
            this.salesreportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesreportbtn.UseVisualStyleBackColor = false;
            this.salesreportbtn.Click += new System.EventHandler(this.salesreportbtn_Click);
            // 
            // alert
            // 
            this.alert.FlatAppearance.BorderSize = 0;
            this.alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert.ForeColor = System.Drawing.Color.Silver;
            this.alert.Image = global::coal_managment_application.Properties.Resources.alert;
            this.alert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alert.Location = new System.Drawing.Point(3, 315);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(205, 56);
            this.alert.TabIndex = 20;
            this.alert.Text = "                     Alert";
            this.alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alert.UseVisualStyleBackColor = true;
            this.alert.Visible = false;
            this.alert.Click += new System.EventHandler(this.button4_Click);
            // 
            // transactionandcashbtn
            // 
            this.transactionandcashbtn.FlatAppearance.BorderSize = 0;
            this.transactionandcashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionandcashbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionandcashbtn.ForeColor = System.Drawing.Color.Silver;
            this.transactionandcashbtn.Image = global::coal_managment_application.Properties.Resources.transaction;
            this.transactionandcashbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionandcashbtn.Location = new System.Drawing.Point(3, 377);
            this.transactionandcashbtn.Name = "transactionandcashbtn";
            this.transactionandcashbtn.Size = new System.Drawing.Size(205, 56);
            this.transactionandcashbtn.TabIndex = 19;
            this.transactionandcashbtn.Text = "                        Transaction/cash";
            this.transactionandcashbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionandcashbtn.UseVisualStyleBackColor = true;
            this.transactionandcashbtn.Click += new System.EventHandler(this.transactionandcashbtn_Click);
            // 
            // Notification
            // 
            this.Notification.FlatAppearance.BorderSize = 0;
            this.Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.ForeColor = System.Drawing.Color.Silver;
            this.Notification.Image = global::coal_managment_application.Properties.Resources.notification;
            this.Notification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notification.Location = new System.Drawing.Point(3, 439);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(205, 56);
            this.Notification.TabIndex = 17;
            this.Notification.Text = "                     Notification";
            this.Notification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notification.UseVisualStyleBackColor = true;
            this.Notification.Click += new System.EventHandler(this.Notification_Click);
            // 
            // printbtn
            // 
            this.printbtn.FlatAppearance.BorderSize = 0;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.Silver;
            this.printbtn.Image = global::coal_managment_application.Properties.Resources.printer;
            this.printbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printbtn.Location = new System.Drawing.Point(3, 501);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(205, 56);
            this.printbtn.TabIndex = 22;
            this.printbtn.Text = "                        Print";
            this.printbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // createbackup
            // 
            this.createbackup.FlatAppearance.BorderSize = 0;
            this.createbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbackup.ForeColor = System.Drawing.Color.Silver;
            this.createbackup.Image = global::coal_managment_application.Properties.Resources.synchronize;
            this.createbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createbackup.Location = new System.Drawing.Point(3, 563);
            this.createbackup.Name = "createbackup";
            this.createbackup.Size = new System.Drawing.Size(205, 56);
            this.createbackup.TabIndex = 23;
            this.createbackup.Text = "                        Backup";
            this.createbackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createbackup.UseVisualStyleBackColor = true;
            this.createbackup.Click += new System.EventHandler(this.createbackup_Click);
            // 
            // graphbtn
            // 
            this.graphbtn.FlatAppearance.BorderSize = 0;
            this.graphbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphbtn.ForeColor = System.Drawing.Color.Silver;
            this.graphbtn.Image = global::coal_managment_application.Properties.Resources.analysis;
            this.graphbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphbtn.Location = new System.Drawing.Point(3, 625);
            this.graphbtn.Name = "graphbtn";
            this.graphbtn.Size = new System.Drawing.Size(205, 56);
            this.graphbtn.TabIndex = 24;
            this.graphbtn.Text = "                  Visulise Data";
            this.graphbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphbtn.UseVisualStyleBackColor = true;
            this.graphbtn.Click += new System.EventHandler(this.graphbtn_Click);
            // 
            // administratormenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 702);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.slidebaradmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelcontaineradmin);
            this.Name = "administratormenu";
            this.Text = "administratormenu";
            this.Load += new System.EventHandler(this.administratormenu_Load);
            this.panelcontaineradmin.ResumeLayout(false);
            this.panelcontaineradmin.PerformLayout();
            this.slidebaradmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Reportpaneladmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menubuttononbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ReportTimeradmin;
        private System.Windows.Forms.Timer sliderbartimeradmin;
        private System.Windows.Forms.Panel panelcontaineradmin;
        private System.Windows.Forms.FlowLayoutPanel slidebaradmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menubuttononbar;
        private System.Windows.Forms.Button transactionandcashbtn;
        private System.Windows.Forms.Button alert;
        private System.Windows.Forms.Button Notification;
        private System.Windows.Forms.Panel Reportpaneladmin;
        private System.Windows.Forms.Button reportbutton;
        private System.Windows.Forms.Button expensereportbtn;
        private System.Windows.Forms.Button stockreportbutton;
        private System.Windows.Forms.Button salesreportbtn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button createbackup;
        private System.Windows.Forms.Button graphbtn;
    }
}