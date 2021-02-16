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
    public partial class FormFavorites : Form
    {
        public FormFavorites()
        {
            InitializeComponent();
        }
        public void UpdateColor()
        {
        }
        public FormFavorites(Action onSettingsChanged)
        {
            this.InitializeComponent();
        }

    }
}
