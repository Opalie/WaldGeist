
using static Journaling.ColorThemePicker;

namespace Journaling
{
    partial class FormSettings
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
            this.trackBarR1 = new System.Windows.Forms.TrackBar();
            this.labelR1 = new System.Windows.Forms.Label();
            this.trackBarG1 = new System.Windows.Forms.TrackBar();
            this.trackBarB1 = new System.Windows.Forms.TrackBar();
            this.labelG1 = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.buttonRGB1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRGB2 = new System.Windows.Forms.Button();
            this.trackBarR2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.trackBarB2 = new System.Windows.Forms.TrackBar();
            this.trackBarG2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRGB3 = new System.Windows.Forms.Button();
            this.trackBarR3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarB3 = new System.Windows.Forms.TrackBar();
            this.trackBarG3 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG3)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarR1
            // 
            this.trackBarR1.Location = new System.Drawing.Point(18, 3);
            this.trackBarR1.Maximum = 255;
            this.trackBarR1.Name = "trackBarR1";
            this.trackBarR1.Size = new System.Drawing.Size(196, 56);
            this.trackBarR1.TabIndex = 2;
            this.trackBarR1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarR1.Value = 173;
            this.trackBarR1.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR1.Location = new System.Drawing.Point(-1, 3);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(20, 23);
            this.labelR1.TabIndex = 3;
            this.labelR1.Text = "R";
            // 
            // trackBarG1
            // 
            this.trackBarG1.Location = new System.Drawing.Point(18, 59);
            this.trackBarG1.Maximum = 255;
            this.trackBarG1.Name = "trackBarG1";
            this.trackBarG1.Size = new System.Drawing.Size(196, 56);
            this.trackBarG1.TabIndex = 4;
            this.trackBarG1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarG1.Value = 112;
            this.trackBarG1.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarB1
            // 
            this.trackBarB1.Location = new System.Drawing.Point(18, 115);
            this.trackBarB1.Maximum = 255;
            this.trackBarB1.Name = "trackBarB1";
            this.trackBarB1.Size = new System.Drawing.Size(196, 56);
            this.trackBarB1.TabIndex = 6;
            this.trackBarB1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB1.Value = 133;
            this.trackBarB1.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // labelG1
            // 
            this.labelG1.AutoSize = true;
            this.labelG1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG1.Location = new System.Drawing.Point(-2, 59);
            this.labelG1.Name = "labelG1";
            this.labelG1.Size = new System.Drawing.Size(22, 23);
            this.labelG1.TabIndex = 5;
            this.labelG1.Text = "G";
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB1.Location = new System.Drawing.Point(-1, 115);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(20, 23);
            this.labelB1.TabIndex = 7;
            this.labelB1.Text = "B";
            // 
            // buttonRGB1
            // 
            this.buttonRGB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.buttonRGB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRGB1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRGB1.Location = new System.Drawing.Point(3, 167);
            this.buttonRGB1.Name = "buttonRGB1";
            this.buttonRGB1.Size = new System.Drawing.Size(211, 36);
            this.buttonRGB1.TabIndex = 8;
            this.buttonRGB1.Text = "Set as Color 1";
            this.buttonRGB1.UseVisualStyleBackColor = false;
            this.buttonRGB1.Click += new System.EventHandler(this.buttonRGB1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.buttonRGB1);
            this.panel1.Controls.Add(this.trackBarR1);
            this.panel1.Controls.Add(this.labelB1);
            this.panel1.Controls.Add(this.labelR1);
            this.panel1.Controls.Add(this.trackBarB1);
            this.panel1.Controls.Add(this.trackBarG1);
            this.panel1.Controls.Add(this.labelG1);
            this.panel1.Location = new System.Drawing.Point(126, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 203);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.buttonRGB2);
            this.panel2.Controls.Add(this.trackBarR2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelR2);
            this.panel2.Controls.Add(this.trackBarB2);
            this.panel2.Controls.Add(this.trackBarG2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(347, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 203);
            this.panel2.TabIndex = 10;
            // 
            // buttonRGB2
            // 
            this.buttonRGB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.buttonRGB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRGB2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRGB2.Location = new System.Drawing.Point(3, 167);
            this.buttonRGB2.Name = "buttonRGB2";
            this.buttonRGB2.Size = new System.Drawing.Size(211, 36);
            this.buttonRGB2.TabIndex = 8;
            this.buttonRGB2.Text = "Set as Color 2";
            this.buttonRGB2.UseVisualStyleBackColor = false;
            this.buttonRGB2.Click += new System.EventHandler(this.buttonRGB2_Click);
            // 
            // trackBarR2
            // 
            this.trackBarR2.Location = new System.Drawing.Point(18, 3);
            this.trackBarR2.Maximum = 255;
            this.trackBarR2.Name = "trackBarR2";
            this.trackBarR2.Size = new System.Drawing.Size(196, 56);
            this.trackBarR2.TabIndex = 2;
            this.trackBarR2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarR2.Value = 248;
            this.trackBarR2.Scroll += new System.EventHandler(this.trackBarR2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR2.Location = new System.Drawing.Point(-1, 3);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(20, 23);
            this.labelR2.TabIndex = 3;
            this.labelR2.Text = "R";
            // 
            // trackBarB2
            // 
            this.trackBarB2.Location = new System.Drawing.Point(18, 115);
            this.trackBarB2.Maximum = 255;
            this.trackBarB2.Name = "trackBarB2";
            this.trackBarB2.Size = new System.Drawing.Size(196, 56);
            this.trackBarB2.TabIndex = 6;
            this.trackBarB2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB2.Value = 208;
            this.trackBarB2.Scroll += new System.EventHandler(this.trackBarR2_Scroll);
            // 
            // trackBarG2
            // 
            this.trackBarG2.Location = new System.Drawing.Point(18, 59);
            this.trackBarG2.Maximum = 255;
            this.trackBarG2.Name = "trackBarG2";
            this.trackBarG2.Size = new System.Drawing.Size(196, 56);
            this.trackBarG2.TabIndex = 4;
            this.trackBarG2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarG2.Value = 187;
            this.trackBarG2.Scroll += new System.EventHandler(this.trackBarR2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "G";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.buttonRGB3);
            this.panel3.Controls.Add(this.trackBarR3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.trackBarB3);
            this.panel3.Controls.Add(this.trackBarG3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(568, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 203);
            this.panel3.TabIndex = 11;
            // 
            // buttonRGB3
            // 
            this.buttonRGB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.buttonRGB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRGB3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRGB3.Location = new System.Drawing.Point(3, 167);
            this.buttonRGB3.Name = "buttonRGB3";
            this.buttonRGB3.Size = new System.Drawing.Size(211, 36);
            this.buttonRGB3.TabIndex = 8;
            this.buttonRGB3.Text = "Set as Color 3";
            this.buttonRGB3.UseVisualStyleBackColor = false;
            this.buttonRGB3.Click += new System.EventHandler(this.buttonRGB3_Click);
            // 
            // trackBarR3
            // 
            this.trackBarR3.Location = new System.Drawing.Point(18, 3);
            this.trackBarR3.Maximum = 255;
            this.trackBarR3.Name = "trackBarR3";
            this.trackBarR3.Size = new System.Drawing.Size(196, 56);
            this.trackBarR3.TabIndex = 2;
            this.trackBarR3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarR3.Value = 252;
            this.trackBarR3.Scroll += new System.EventHandler(this.trackBarR3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "R";
            // 
            // trackBarB3
            // 
            this.trackBarB3.Location = new System.Drawing.Point(18, 115);
            this.trackBarB3.Maximum = 255;
            this.trackBarB3.Name = "trackBarB3";
            this.trackBarB3.Size = new System.Drawing.Size(196, 56);
            this.trackBarB3.TabIndex = 6;
            this.trackBarB3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB3.Value = 236;
            this.trackBarB3.Scroll += new System.EventHandler(this.trackBarR3_Scroll);
            // 
            // trackBarG3
            // 
            this.trackBarG3.Location = new System.Drawing.Point(18, 59);
            this.trackBarG3.Maximum = 255;
            this.trackBarG3.Name = "trackBarG3";
            this.trackBarG3.Size = new System.Drawing.Size(196, 56);
            this.trackBarG3.TabIndex = 4;
            this.trackBarG3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarG3.Value = 228;
            this.trackBarG3.Scroll += new System.EventHandler(this.trackBarR3_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "G";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarR1;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.TrackBar trackBarG1;
        private System.Windows.Forms.TrackBar trackBarB1;
        private System.Windows.Forms.Label labelG1;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Button buttonRGB1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRGB2;
        private System.Windows.Forms.TrackBar trackBarR2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.TrackBar trackBarB2;
        private System.Windows.Forms.TrackBar trackBarG2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRGB3;
        private System.Windows.Forms.TrackBar trackBarR3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarB3;
        private System.Windows.Forms.TrackBar trackBarG3;
        private System.Windows.Forms.Label label5;
    }
}