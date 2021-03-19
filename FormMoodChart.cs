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
    public partial class FormMoodChart : Form
    {
        public FormMoodChart()
        {
            InitializeComponent();
        }
        public void UpdateColor() // This is not working either why!!!
        {

        }
        public FormMoodChart(Action onSettingsChanged)
        {
            this.InitializeComponent();
        }
    }
}
