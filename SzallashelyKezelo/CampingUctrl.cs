using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzallashelyKezelo
{
    public partial class CampingUctrl : UserControl
    {
        public CampingUctrl()
        {
            InitializeComponent();
        }
        public bool Vizparti()
        {
            return vizpartiChbx.Checked;
        }
    }
}
