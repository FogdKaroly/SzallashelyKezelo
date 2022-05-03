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
    public partial class SzallodaUctrl : UserControl
    {
        public SzallodaUctrl()
        {
            InitializeComponent();
        }
        public int SzobaAra()
        {
            return (int)szobaAraNud.Value;
        }
        public int Csillagok()
        {
            return (int)csillagokSzamaNud.Value;
        }
        public bool Wellness()
        {
            return wellnessChbx.Checked;
        }
    }
}
