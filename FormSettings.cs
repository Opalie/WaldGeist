using System;
using System.Drawing;
using System.Windows.Forms;
using static Journaling.ColorThemePicker;

namespace Journaling
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        /// <summary>The method to call when the settings change.</summary>
        private readonly Action OnSettingsChanged;

        /// <summary>Construct an instance.</summary>
        /// <param name="onSettingsChanged">The method to call when the settings change.</param>
        public FormSettings(Action onSettingsChanged)
        {
            this.OnSettingsChanged = onSettingsChanged;
            this.InitializeComponent();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            buttonRGB1.BackColor = Color.FromArgb(trackBarR1.Value, trackBarG1.Value, trackBarB1.Value);
        }
        private void trackBarR2_Scroll(object sender, EventArgs e)
        {
            buttonRGB2.BackColor = Color.FromArgb(trackBarR2.Value, trackBarG2.Value, trackBarB2.Value);
        }
        private void trackBarR3_Scroll(object sender, EventArgs e)
        {
            buttonRGB3.BackColor = Color.FromArgb(trackBarR3.Value, trackBarG3.Value, trackBarB3.Value);
        }

        private void buttonRGB1_Click(object sender, EventArgs e)
        {
            RGBColors.color1 = buttonRGB1.BackColor;
            this.OnSettingsChanged();
        }

        private void buttonRGB2_Click(object sender, EventArgs e)
        {
            RGBColors.color4 = buttonRGB2.BackColor;
            this.OnSettingsChanged();
        }
        private void buttonRGB3_Click(object sender, EventArgs e)
        {
            RGBColors.color3 = buttonRGB3.BackColor;
            this.OnSettingsChanged();
        }
    }
}
