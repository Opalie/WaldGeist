using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using static Journaling.ColorThemePicker;

namespace Journaling
{
    public partial class FormJournal : Form
    {
        // Fields
        private bool toggle = false;
        private IconButton currentBtn;
        const int dist = 15;

        public FormJournal()
        {
            // Uses RichTextBoxExtensions.cs see http://stackoverflow.com/q/2914004/107625 why is it not working anymore!!!
            richTextBox1.SetInnerMargins(dist, 5, dist, 5);
            InitializeComponent();
        }
        public void UpdateColor() // This is not working either why!!!
        {
            panelEditor.BackColor = RGBColors.color3;
            panelEntries.BackColor = RGBColors.color3;
            splitterLeft.BackColor = RGBColors.color1;
            splitterRight.BackColor = RGBColors.color1;
            textDayTitle.ForeColor = RGBColors.color1;
            iconBookmark.IconColor = RGBColors.color1;

        }
        public FormJournal(Action onSettingsChanged)
        {
            this.InitializeComponent();
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
                currentBtn.IconFont = IconFont.Auto;
            }
        }

        private void iconBookmark_Click(object sender, EventArgs e)
        {
            // If you click then it sets it to TRUE or FALSE and change the color
            if (toggle == false)
            {
                toggle = true;
                ActivateButton(sender, RGBColors.color1);
                currentBtn.IconFont = IconFont.Solid;
            }
            else
            {
                toggle = false;
                DisableButton();
            }
        }

        private void icn_previous_MouseEnter(object sender, EventArgs e)
        {
            icn_previous.IconColor = RGBColors.color4;
        }

        private void icn_previous_MouseLeave(object sender, EventArgs e)
        {
            icn_previous.IconColor = RGBColors.color2;
        }

        private void icn_next_MouseLeave(object sender, EventArgs e)
        {
            icn_next.IconColor = RGBColors.color2;
        }

        private void icn_next_MouseEnter(object sender, EventArgs e)
        {
            icn_next.IconColor = RGBColors.color4;
        }

        private void textDayTitle_TextChanged(object sender, EventArgs e)
        {
            // sets time
            Entry entry = new Entry(DateTime.Today)
            {
                // sets Title as text
                Title = textDayTitle.Text
            };

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


            //// Write to file (I hope)
            //using (StreamWriter file = File.CreateText(@"d:\documents\WaldGeist\Entry.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, entry);
            //}

    }
}
