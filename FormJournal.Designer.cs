
using static Journaling.ColorThemePicker;

namespace Journaling
{
    partial class FormJournal
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
            this.panelEditor = new System.Windows.Forms.Panel();
            this.panelTag = new System.Windows.Forms.Panel();
            this.iconTag = new FontAwesome.Sharp.IconButton();
            this.iconBookmark = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDayTitle = new System.Windows.Forms.TextBox();
            this.panelEntries = new System.Windows.Forms.Panel();
            this.splitterLeft = new System.Windows.Forms.Splitter();
            this.splitterRight = new System.Windows.Forms.Splitter();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelPages = new System.Windows.Forms.Panel();
            this.label_pages = new System.Windows.Forms.Label();
            this.icn_next = new FontAwesome.Sharp.IconButton();
            this.icn_previous = new FontAwesome.Sharp.IconButton();
            this.panelTag.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditor
            // 
            this.panelEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEditor.Location = new System.Drawing.Point(740, 0);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(200, 625);
            this.panelEditor.TabIndex = 1;
            // 
            // panelTag
            // 
            this.panelTag.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTag.Controls.Add(this.iconTag);
            this.panelTag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTag.Location = new System.Drawing.Point(0, 590);
            this.panelTag.Name = "panelTag";
            this.panelTag.Size = new System.Drawing.Size(536, 35);
            this.panelTag.TabIndex = 2;
            // 
            // iconTag
            // 
            this.iconTag.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconTag.FlatAppearance.BorderSize = 0;
            this.iconTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTag.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconTag.IconColor = System.Drawing.Color.White;
            this.iconTag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTag.IconSize = 30;
            this.iconTag.Location = new System.Drawing.Point(0, 0);
            this.iconTag.Name = "iconTag";
            this.iconTag.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconTag.Size = new System.Drawing.Size(35, 35);
            this.iconTag.TabIndex = 0;
            this.iconTag.UseVisualStyleBackColor = true;
            // 
            // iconBookmark
            // 
            this.iconBookmark.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBookmark.FlatAppearance.BorderSize = 0;
            this.iconBookmark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconBookmark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBookmark.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.iconBookmark.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.iconBookmark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBookmark.IconSize = 30;
            this.iconBookmark.Location = new System.Drawing.Point(0, 0);
            this.iconBookmark.Name = "iconBookmark";
            this.iconBookmark.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBookmark.Size = new System.Drawing.Size(35, 35);
            this.iconBookmark.TabIndex = 1;
            this.iconBookmark.UseVisualStyleBackColor = true;
            this.iconBookmark.Click += new System.EventHandler(this.iconBookmark_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textDayTitle);
            this.panel1.Controls.Add(this.iconBookmark);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 35);
            this.panel1.TabIndex = 4;
            // 
            // textDayTitle
            // 
            this.textDayTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDayTitle.Font = new System.Drawing.Font("KFhimaji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.textDayTitle.Location = new System.Drawing.Point(41, 8);
            this.textDayTitle.Name = "textDayTitle";
            this.textDayTitle.Size = new System.Drawing.Size(100, 20);
            this.textDayTitle.TabIndex = 2;
            this.textDayTitle.Text = "Untitled";
            this.textDayTitle.TextChanged += new System.EventHandler(this.textDayTitle_TextChanged);
            // 
            // panelEntries
            // 
            this.panelEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.panelEntries.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEntries.Location = new System.Drawing.Point(0, 0);
            this.panelEntries.Name = "panelEntries";
            this.panelEntries.Size = new System.Drawing.Size(200, 625);
            this.panelEntries.TabIndex = 0;
            // 
            // splitterLeft
            // 
            this.splitterLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.splitterLeft.Location = new System.Drawing.Point(200, 0);
            this.splitterLeft.Name = "splitterLeft";
            this.splitterLeft.Size = new System.Drawing.Size(2, 625);
            this.splitterLeft.TabIndex = 0;
            this.splitterLeft.TabStop = false;
            // 
            // splitterRight
            // 
            this.splitterRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.splitterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterRight.Location = new System.Drawing.Point(738, 0);
            this.splitterRight.Name = "splitterRight";
            this.splitterRight.Size = new System.Drawing.Size(2, 625);
            this.splitterRight.TabIndex = 6;
            this.splitterRight.TabStop = false;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.richTextBox1);
            this.panelCenter.Controls.Add(this.panelPages);
            this.panelCenter.Controls.Add(this.panelTag);
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(202, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(536, 625);
            this.panelCenter.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(536, 520);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // panelPages
            // 
            this.panelPages.BackColor = System.Drawing.Color.White;
            this.panelPages.Controls.Add(this.label_pages);
            this.panelPages.Controls.Add(this.icn_next);
            this.panelPages.Controls.Add(this.icn_previous);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 555);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(536, 35);
            this.panelPages.TabIndex = 6;
            // 
            // label_pages
            // 
            this.label_pages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pages.AutoSize = true;
            this.label_pages.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.label_pages.Location = new System.Drawing.Point(240, 2);
            this.label_pages.Name = "label_pages";
            this.label_pages.Size = new System.Drawing.Size(55, 30);
            this.label_pages.TabIndex = 9;
            this.label_pages.Text = "~ 1 ~";
            this.label_pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icn_next
            // 
            this.icn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icn_next.BackColor = System.Drawing.Color.White;
            this.icn_next.FlatAppearance.BorderSize = 0;
            this.icn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.icn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.icn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icn_next.ForeColor = System.Drawing.Color.Silver;
            this.icn_next.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.icn_next.IconColor = System.Drawing.Color.Silver;
            this.icn_next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icn_next.IconSize = 40;
            this.icn_next.Location = new System.Drawing.Point(473, 0);
            this.icn_next.Name = "icn_next";
            this.icn_next.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.icn_next.Size = new System.Drawing.Size(35, 35);
            this.icn_next.TabIndex = 8;
            this.icn_next.UseVisualStyleBackColor = false;
            this.icn_next.MouseEnter += new System.EventHandler(this.icn_next_MouseEnter);
            this.icn_next.MouseLeave += new System.EventHandler(this.icn_next_MouseLeave);
            // 
            // icn_previous
            // 
            this.icn_previous.BackColor = System.Drawing.Color.White;
            this.icn_previous.FlatAppearance.BorderSize = 0;
            this.icn_previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.icn_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.icn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icn_previous.ForeColor = System.Drawing.Color.Silver;
            this.icn_previous.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.icn_previous.IconColor = System.Drawing.Color.Silver;
            this.icn_previous.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icn_previous.IconSize = 40;
            this.icn_previous.Location = new System.Drawing.Point(25, 0);
            this.icn_previous.Name = "icn_previous";
            this.icn_previous.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.icn_previous.Size = new System.Drawing.Size(35, 35);
            this.icn_previous.TabIndex = 7;
            this.icn_previous.UseVisualStyleBackColor = false;
            this.icn_previous.MouseEnter += new System.EventHandler(this.icn_previous_MouseEnter);
            this.icn_previous.MouseLeave += new System.EventHandler(this.icn_previous_MouseLeave);
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 625);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.splitterRight);
            this.Controls.Add(this.splitterLeft);
            this.Controls.Add(this.panelEditor);
            this.Controls.Add(this.panelEntries);
            this.Name = "FormJournal";
            this.Text = "FormJournal";
            this.panelTag.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.Panel panelTag;
        private FontAwesome.Sharp.IconButton iconTag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEntries;
        private System.Windows.Forms.Splitter splitterLeft;
        private System.Windows.Forms.Splitter splitterRight;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelPages;
        private FontAwesome.Sharp.IconButton icn_previous;
        private FontAwesome.Sharp.IconButton icn_next;
        private System.Windows.Forms.Label label_pages;
        private System.Windows.Forms.TextBox textDayTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton iconBookmark;
    }
}