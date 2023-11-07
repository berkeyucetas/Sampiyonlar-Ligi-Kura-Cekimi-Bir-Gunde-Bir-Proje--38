using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şampiyonlar_Ligi_Kura_Çekimi
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar =new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yeniTakim = null;
            takimlar = new List<Takim>();
            yeniTakim = new Takim("Bayern Münih", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Kopenhag", "Danimarka");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yeniTakim);

            yeniTakim = new Takim("Sevilla", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Arsenal", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("PSV Eindhoven", "Hollanda");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Lens", "Fransa");
            takimlar.Add(yeniTakim);

            yeniTakim = new Takim("Napoli", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Braga", "Portekiz");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Union Berlin", "Almanya");
            takimlar.Add(yeniTakim);

            yeniTakim = new Takim("Benfica", "Portekiz");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Inter Milan", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("RB Salzburg", "Avusturya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Real Sociedad", "İspanya");
            takimlar.Add(yeniTakim);

            yeniTakim = new Takim("Feyenoord", "Hollanda");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Lazio", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Celtic", "İskoçya");
            takimlar.Add(yeniTakim);

            yeniTakim = new Takim("Paris Saint-Germain", "Fransa");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("AC Milan", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Newcastle United", "İngiltere");
            takimlar.Add(yeniTakim);

            yeniTakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("RB Leipzig", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Red Star Belgrade", "Sırbistan");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Young Boys", "İsviçre");
            takimlar.Add(yeniTakim);

            yeniTakim = new Takim("Barcelona", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Shakhtar Donetsk", "Ukrayna");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Royal Antwerp", "Belçika");
            takimlar.Add(yeniTakim);
        }

        private void buttonGrup_Click(object sender, EventArgs e)
        {
            Random rastgele= new Random();
            List<int> seçilentakımlar= new List<int>();
            for (int t = 0; t < 4; t++)
            {
                seçilentakımlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int seçilenTakım = rastgele.Next(0,takimlar.Count/4);
                    if (seçilentakımlar.Contains(seçilenTakım))
                    {
                        i--;
                    }
                    else
                    {
                        seçilentakımlar.Add(seçilenTakım);
                    }
                }
                bool aynıulkedentakımvar = false;
                for (int k = 0; k < 8; k++)
                {
                    aynıulkedentakımvar = Aynıulkedentakımvarmı(gruplar[k], torbalar[t].Items[seçilentakımlar[k]] as Takim);
                    if (aynıulkedentakımvar)
                    {
                        break;
                    }
                }
                if (!aynıulkedentakımvar)
                {
                    listBox1.Items.Add(torbalar[t].Items[seçilentakımlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[t].Items[seçilentakımlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[t].Items[seçilentakımlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[t].Items[seçilentakımlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[t].Items[seçilentakımlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[t].Items[seçilentakımlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[t].Items[seçilentakımlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[t].Items[seçilentakımlar[7]] as Takim);
                }
                else
                {
                    t--;
                }
            }
        }
        private bool Aynıulkedentakımvarmı(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim= grup.Items[i] as Takim;
                if(gruptakim.TeamCountry==takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void buttonTorba_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> seçilentakımlar = new List<int>();
            for(int i = 0;i<takimlar.Count;i++)
            {
                int seçilentakim=rastgele.Next(0,takimlar.Count);
                if(seçilentakımlar.Contains(seçilentakim))
                {
                    i--;
                }
                else
                {
                    seçilentakımlar.Add(seçilentakim);
                }
            }
            for (int i = 0; i < seçilentakımlar.Count; i++)
            {
                if (i < 8)
                {
                    listTorba1.Items.Add(takimlar[seçilentakımlar[i]]);
                }
                else if (i < 16)
                {
                    listTorba2.Items.Add(takimlar[seçilentakımlar[i]]);
                }
                else if (i < 24)
                {
                    listTorba3.Items.Add(takimlar[seçilentakımlar[i]]);
                }
                else
                {
                    listTorba4.Items.Add(takimlar[seçilentakımlar[i]]);
                }
            }
            torbalar.Add(listTorba1);
            torbalar.Add(listTorba2);
            torbalar.Add(listTorba3);
            torbalar.Add(listTorba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }
    }
}
