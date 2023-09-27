namespace EsiniBul
{
    public partial class Form1 : Form
    {
        int boyut = 4;// satýr ve sütun sayýsý
        List<string> resimler = new List<string>();
        List<string> kartlar = new List<string>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            //PictureBox resimKutusu=new PictureBox();
            //resimKutusu.Size = new Size(200, 200);
            //resimKutusu.ImageLocation = @"img\" + resimler[33];
            //resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
            //Controls.Add(resimKutusu);

            //int i = 0;
            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 10; x++)
            //    {
            //        PictureBox resimKutusu = new PictureBox();
            //        resimKutusu.Size = new Size(50, 50);
            //        resimKutusu.Left = x * resimKutusu.Width;
            //        resimKutusu.Top = y * resimKutusu.Height;
            //        resimKutusu.ImageLocation = @"img\" + resimler[i];
            //        resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
            //        Controls.Add(resimKutusu);
            //        i++;
            //    }
            //}

            ResimleriYukle();

            KartlariSec();

            KartlariDiz();












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
                    resimKutusu.ImageLocation = @"img\" + kartlar[i];
                    resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
                    pnlKartlar.Controls.Add(resimKutusu);
                    i++;
                }
            }

        }

        private void KartlariKaristir()
        {
            string yedek;
            int talihliIndex = rnd.Next(kartlar.Count);
            for (int i = 0; i < kartlar.Count; i++)
            {
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







    }//--------------------------------------------------------------------------------------------------------------------------------
}