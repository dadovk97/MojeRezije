using MojeRezije.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeRezije
{
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Voda_Click(object sender, EventArgs e)
        {
            Form RacunanjeVoda = new RacunanjeVoda();
            RacunanjeVoda.Show();
            this.Hide();
        }

        private void Btn_Plin_Click(object sender, EventArgs e)
        {
            Form RacunanjePlin = new RacunanjePlin();
            RacunanjePlin.Show();
            this.Hide();
        }

        private void Btn_Struja_Click(object sender, EventArgs e)
        {
            Form RacunanjeStruje = new RacunanjeStruje();
            RacunanjeStruje.Show();
            this.Hide();
        }

        private void Btn_Odjava_Click(object sender, EventArgs e)
        {
            PrijavaKorisnika.ImePrijavljenog = null;
            Form Prijava = new Prijava();
            Prijava.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            lbl_prijavljen.Text ="Prijavljeni ste kao : " +  PrijavaKorisnika.ImePrijavljenog;
        }

        private void Btn_Ocjena_Click(object sender, EventArgs e)
        {
            Form Recenzija = new Recenzija();
            Recenzija.Show();
            this.Hide();
        }

        private void Btn_Ispis_Click(object sender, EventArgs e)
        {
            Form IspisVode =  new IspisVode();
            IspisVode.Show();
            this.Hide();
        }

        private void btn_Ostalo_Click(object sender, EventArgs e)
        {
            Form Internet = new Internet();
            Internet.Show();
            this.Hide();
        }
    }
    }
