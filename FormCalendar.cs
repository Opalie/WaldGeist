using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journaling
{
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
        }
        public void UpdateColor()
        {
        }
        public FormCalendar(Action onSettingsChanged)
        {
            this.InitializeComponent();
        }

    }
}
