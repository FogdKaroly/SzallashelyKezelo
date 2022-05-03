namespace SzallashelyKezelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            ABMuveletek.Kapcsolodas();
            ListaFrissites();
        }

        private void ListaFrissites()
        {
            List<Szallashely> szallashelyek = new();
            szallashelyek.AddRange(ABMuveletek.SzallodaLekeres());
            szallashelyek.AddRange(ABMuveletek.PanzioLekeres());
            szallashelyek.AddRange(ABMuveletek.CampingLekeres());
            
            listBox1.DataSource = null;
            listBox1.DataSource = szallashelyek;
            
        }

        private void szallasFelvitelBtn_Click(object sender, EventArgs e)
        {
            UjSzallashely ujSzallashely = new UjSzallashely();
            if (ujSzallashely.ShowDialog() == DialogResult.OK)
            {
                ListaFrissites();
            }
        }

        private void szallasTorlesBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedItem is Szalloda)
                {
                    if (MessageBox.Show("Biztosan törli a kiválasztott elemet?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        Szalloda szalloda = (Szalloda)listBox1.SelectedItem;
                        ABMuveletek.SzallodaTorles(szalloda);
                        ListaFrissites();
                    }
                    
                }
                else if(listBox1.SelectedItem is Panzio)
                {
                    if (MessageBox.Show("Biztosan törli a kiválasztott elemet?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        Panzio panzio = (Panzio)listBox1.SelectedItem;
                        ABMuveletek.PanzioTorles(panzio);
                        ListaFrissites(); 
                    }
                }
                else if(listBox1.SelectedItem is Camping)
                {
                    if (MessageBox.Show("Biztosan törli a kiválasztott elemet?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        Camping camping = (Camping)listBox1.SelectedItem;
                        ABMuveletek.CampingTorles(camping);
                        ListaFrissites(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy elemet!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //Bezárul
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is EpitettSzallashely)
            {
                EpitettSzallashely epitettszallashely = (EpitettSzallashely)listBox1.SelectedItem;
                if (epitettszallashely is Szalloda)
                {
                    Szalloda szalloda = (Szalloda)epitettszallashely;

                    string Wellness()
                    {
                        if (szalloda.WellnessE)
                        {
                            return "van";
                        }
                        return "nincs";
                    }

                    MessageBox.Show($"Fajta: {szalloda.Fajta}\n" +
                    $"Cím: {szalloda.Cim.Iranyitoszam} {szalloda.Cim.Varos} {szalloda.Cim.Utca} {szalloda.Cim.Hazszam}\n" +
                    $"Csillagok: {szalloda.Csillagok}\n" +
                    $"Szoba ára: {szalloda.Szobaar}\n" +
                    $"Wellness: {Wellness()}\n" +
                    $"Fizetendõ: {szalloda.Arszamitas()} Ft", "Szálláshely adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (epitettszallashely is Panzio)
                {
                    Panzio panzio = (Panzio)epitettszallashely;

                    string Wellness()
                    {
                        if (panzio.ReggeliE)
                        {
                            return "van";
                        }
                        return "nincs";
                    }

                    MessageBox.Show($"Fajta: {panzio.Fajta}\n" +
                    $"Cím: {panzio.Cim.Iranyitoszam} {panzio.Cim.Varos} {panzio.Cim.Utca} {panzio.Cim.Hazszam}\n" +
                    $"Csillagok: {panzio.Csillagok}\n" +
                    $"Szoba ára: {panzio.Szobaar}\n" +
                    $"Reggeli: {Wellness()}\n" +
                    $"Fizetendõ: {panzio.Arszamitas()} Ft", "Szálláshely adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void adatokKimenteseBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                StreamWriter writer = new StreamWriter("adatok.csv");

                if (listBox1.SelectedItem is Szalloda)
                {
                    Szalloda szalloda = (Szalloda)listBox1.SelectedItem;
                    writer.WriteLine($"{szalloda.Fajta};{szalloda.Cim.Iranyitoszam};{szalloda.Cim.Varos};{szalloda.Cim.Utca};{szalloda.Cim.Hazszam};{szalloda.Csillagok};{szalloda.Szobaar};{szalloda.WellnessE}");
                }
                else if (listBox1.SelectedItem is Panzio)
                {
                    Panzio panzio = (Panzio)listBox1.SelectedItem;
                    writer.WriteLine($"{panzio.Fajta};{panzio.Cim.Iranyitoszam};{panzio.Cim.Varos};{panzio.Cim.Utca};{panzio.Cim.Hazszam};{panzio.Csillagok};{panzio.Szobaar};{panzio.ReggeliE}");
                }
                else if (listBox1.SelectedItem is Camping)
                {
                    Camping camping = (Camping)listBox1.SelectedItem;
                    writer.WriteLine($"{camping.Fajta};{camping.Cim.Iranyitoszam};{camping.Cim.Varos};{camping.Cim.Utca};{camping.Cim.Hazszam};{camping.VizpartiE}");
                }

                writer.Close();
            }
        }
    }
}