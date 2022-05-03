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
    public partial class UjSzallashely : Form
    {
        public UjSzallashely()
        {
            InitializeComponent();
            fajtaCbx.DataSource = Enum.GetValues(typeof(Fajta));
        }

        private void MindentRejt()
        {
            szallodaUctrl1.Visible = false;
            panzioUctrl1.Visible = false;
            campingUctrl1.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    MindentRejt();
                    szallodaUctrl1.Visible = true;
                    break;
                case 1:
                    MindentRejt();
                    panzioUctrl1.Visible = true;
                    break;
                case 2:
                    MindentRejt();
                    campingUctrl1.Visible = true;
                    break;
                default:
                    MindentRejt();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    ABMuveletek.UjSzalloda(new Szalloda(Convert.ToBoolean(szallodaUctrl1.Wellness()), Convert.ToInt32(szallodaUctrl1.SzobaAra()), Convert.ToByte(szallodaUctrl1.Csillagok()), azonositoTxb.Text, (Fajta)fajtaCbx.SelectedItem, new Cim(irszamTxb.Text, varosTxb.Text, utcaTxb.Text, hazszamTxb.Text)));
                    break;
                case 1:
                    ABMuveletek.UjPanzio(new Panzio(Convert.ToBoolean(panzioUctrl1.Reggeli()), Convert.ToInt32(panzioUctrl1.SzobaAr()), Convert.ToByte(panzioUctrl1.Csillagok()), azonositoTxb.Text, (Fajta)fajtaCbx.SelectedItem, new Cim(irszamTxb.Text, varosTxb.Text, utcaTxb.Text, hazszamTxb.Text)));
                    break;
                case 2:
                    ABMuveletek.UjCamping(new Camping(Convert.ToBoolean(campingUctrl1.Vizparti()), azonositoTxb.Text, (Fajta)fajtaCbx.SelectedItem, new Cim(irszamTxb.Text, varosTxb.Text, utcaTxb.Text, hazszamTxb.Text)));
                    break;
                default:
                    MindentRejt();
                    break;
            }
        }
    }
}
