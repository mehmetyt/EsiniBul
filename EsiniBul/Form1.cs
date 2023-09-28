namespace EsiniBul
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int boyut = 4;// satýr ve sütun sayýsý
        List<string> resimler = new List<string>();
        List<string> kartlar = new List<string>();
        List<PictureBox> aciklar = new List<PictureBox>();
        int yokedilenAdet = 0;
        public Form1()
        {
            InitializeComponent();


            ResimleriYukle();


        }//----------------------------------------------------------------------------------------------------------------------------

        private void KartlariDiz()
        {
            int bosluk = 10;
            int gen = (pnlKartlar.Width - (boyut - 1) * bosluk) / boyut;
            int yuk = (pnlKartlar.Height - (boyut - 1) * bosluk) / boyut;
            int i = 0;
            for (int y = 0; y < boyut; y++)
            {
                for (int x = 0; x < boyut; x++)
                {
                    PictureBox resimKutusu = new PictureBox();
                    resimKutusu.Tag = i;
                    resimKutusu.BackColor = Color.Bisque;
                    resimKutusu.Size = new Size(gen, yuk);
                    resimKutusu.Left = x * (resimKutusu.Width + bosluk);
                    resimKutusu.Top = y * (resimKutusu.Height + bosluk);
                    resimKutusu.ImageLocation = @"back.jpg";
                    resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
                    resimKutusu.Click += ResimKutusu_Click;
                    pnlKartlar.Controls.Add(resimKutusu);
                    i++;
                }
            }

        }

        // sender: týklanan resim kutusunu taþýr
        private void ResimKutusu_Click(object? sender, EventArgs e)
        {
            PictureBox tikanan = (PictureBox)sender;

            // eðer ayný karta 2. kez týklandýysa bir þey yapma
            if (aciklar.Count == 1 && aciklar[0] == tikanan)
                return;

            if (aciklar.Count == 2)
            {
                AciklariKapat();

            }
            aciklar.Add(tikanan);
            int kartIndex = (int)tikanan.Tag;
            string resim = kartlar[kartIndex];
            tikanan.ImageLocation = @"img\" + resim;

            // 2. kartý actýðýnda yapýlacak eþleþme kontrolü
            if (aciklar.Count == 2 && aciklar[0].ImageLocation == aciklar[1].ImageLocation)
            {
                Application.DoEvents();
                AciklariGecikmeliYoket();
                AciklariKapat();

                //oyun bitti mi
                if (yokedilenAdet == kartlar.Count)
                {
                    MessageBox.Show("Oyun bitti.");
                    OyunuSifirla();
                }
            }
        }

        private void OyunuSifirla()
        {
            pnlKartlar.Controls.Clear();
            yokedilenAdet = 0;
            kartlar.Clear();
            aciklar.Clear();
            gboYeniOyun.Show();
            pnlKartlar.BackColor = Color.Transparent;
        }

        private void AciklariGecikmeliYoket()
        {
            Thread.Sleep(500);
            foreach (var kutu in aciklar)
            {
                pnlKartlar.Controls.Remove(kutu);
                yokedilenAdet++;
            }
        }

        private void AciklariKapat()
        {
            foreach (var kutu in aciklar)
            {
                kutu.ImageLocation = @"back.jpg";
            }
            aciklar.Clear();
        }

        private void KartlariKaristir()
        {
            string yedek;
            for (int i = 0; i < kartlar.Count; i++)
            {
                int talihliIndex = rnd.Next(kartlar.Count);
                yedek = kartlar[i];
                kartlar[i] = kartlar[talihliIndex];
                kartlar[talihliIndex] = yedek;

            }
        }

        private void KartlariSec()
        {
            int ciftAdet = boyut * boyut / 2;
            while (kartlar.Count < ciftAdet)
            {
                string resim = resimler[rnd.Next(resimler.Count)];
                if (!kartlar.Contains(resim))
                    kartlar.Add(resim);
            }

            kartlar.AddRange(kartlar);
            KartlariKaristir();
        }

        private void ResimleriYukle()
        {
            DirectoryInfo klasor = new DirectoryInfo("img");
            FileInfo[] dosyalar = klasor.GetFiles();

            foreach (FileInfo dosya in dosyalar)
                resimler.Add(dosya.Name);
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            pnlKartlar.BackColor = Color.WhiteSmoke;
            SeviyeyeKararVer();
            gboYeniOyun.Hide();
            KartlariSec();
            KartlariDiz();
        }

        private void SeviyeyeKararVer()
        {
            if (rb1.Checked)
                boyut = 2;
            else if (rb2.Checked)
                boyut = 4;
            else if (rb3.Checked)
                boyut = 6;
            else if (rb4.Checked)
                boyut = 8;
            else
                boyut = 10;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            OyunuSifirla();
        }
    }//--------------------------------------------------------------------------------------------------------------------------------
}