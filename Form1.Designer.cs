
using static Journaling.ColorThemePicker;

namespace Journaling
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.btnBookmark = new FontAwesome.Sharp.IconButton();
            this.btnBook = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.label_Todayis = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Welcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnChart = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnCalendar);
            this.panelMenu.Controls.Add(this.btnChart);
            this.panelMenu.Controls.Add(this.btnBookmark);
            this.panelMenu.Controls.Add(this.btnBook);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(50, 672);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSetting.IconSize = 40;
            this.btnSetting.Location = new System.Drawing.Point(0, 225);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(50, 45);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnCalendar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.IconSize = 40;
            this.btnCalendar.Location = new System.Drawing.Point(0, 180);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(50, 45);
            this.btnCalendar.TabIndex = 7;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnBookmark
            // 
            this.btnBookmark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookmark.FlatAppearance.BorderSize = 0;
            this.btnBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookmark.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btnBookmark.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnBookmark.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBookmark.IconSize = 40;
            this.btnBookmark.Location = new System.Drawing.Point(0, 90);
            this.btnBookmark.Name = "btnBookmark";
            this.btnBookmark.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnBookmark.Size = new System.Drawing.Size(50, 45);
            this.btnBookmark.TabIndex = 6;
            this.btnBookmark.UseVisualStyleBackColor = true;
            this.btnBookmark.Click += new System.EventHandler(this.btnBookmark_Click);
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBook.IconSize = 40;
            this.btnBook.Location = new System.Drawing.Point(0, 45);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(50, 45);
            this.btnBook.TabIndex = 5;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 40;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(50, 45);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnBars_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.panelDesktop.Controls.Add(this.label_time);
            this.panelDesktop.Controls.Add(this.label_Todayis);
            this.panelDesktop.Controls.Add(this.label_date);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.txt_Welcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(50, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(958, 672);
            this.panelDesktop.TabIndex = 1;
            // 
            // label_time
            // 
            this.label_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_time.Font = new System.Drawing.Font("nintendoP_Humming-E_002pr", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.label_time.Location = new System.Drawing.Point(332, 267);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(284, 44);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "00:00:00";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Todayis
            // 
            this.label_Todayis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Todayis.AutoSize = true;
            this.label_Todayis.Font = new System.Drawing.Font("nintendoP_Humming-E_002pr", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Todayis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.label_Todayis.Location = new System.Drawing.Point(395, 179);
            this.label_Todayis.Name = "label_Todayis";
            this.label_Todayis.Size = new System.Drawing.Size(151, 44);
            this.label_Todayis.TabIndex = 3;
            this.label_Todayis.Text = "Today is";
            this.label_Todayis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_date
            // 
            this.label_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_date.Font = new System.Drawing.Font("nintendoP_Humming-E_002pr", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.label_date.Location = new System.Drawing.Point(6, 223);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(940, 44);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "DATE";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Welcome
            // 
            this.txt_Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Welcome.Font = new System.Drawing.Font("nintendoP_Humming-E_002pr", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.txt_Welcome.Location = new System.Drawing.Point(14, 46);
            this.txt_Welcome.Name = "txt_Welcome";
            this.txt_Welcome.Size = new System.Drawing.Size(932, 44);
            this.txt_Welcome.TabIndex = 0;
            this.txt_Welcome.Text = "WELCOME, User";
            this.txt_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnChart
            // 
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnChart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChart.IconSize = 40;
            this.btnChart.Location = new System.Drawing.Point(0, 135);
            this.btnChart.Name = "btnChart";
            this.btnChart.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnChart.Size = new System.Drawing.Size(50, 45);
            this.btnChart.TabIndex = 11;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaldGeist - My Journaling Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnCalendar;
        private FontAwesome.Sharp.IconButton btnBookmark;
        private FontAwesome.Sharp.IconButton btnBook;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label txt_Welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_Todayis;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnChart;
    }
}

