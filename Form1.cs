using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using static Journaling.ColorThemePicker;


namespace Journaling
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateColor()
        {
            btnHome.IconColor = RGBColors.color1;
            btnBook.IconColor = RGBColors.color1;
            btnBookmark.IconColor = RGBColors.color1;
            btnCalendar.IconColor = RGBColors.color1;
            btnSetting.IconColor = RGBColors.color1;
            panelMenu.BackColor = RGBColors.color4;
            panelDesktop.BackColor = RGBColors.color3;
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
            }
        }
        // Disable button highlighting
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = RGBColors.color1;
                currentBtn.IconColor = RGBColors.color1;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnBars_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);

            // If clicked, main menu (Form1)
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormJournal(this.UpdateColor));
        }

        private void btnBookmark_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormFavorites(this.UpdateColor));
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormCalendar(this.UpdateColor));
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormSettings(this.UpdateColor));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}