using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MojeRezije.Model;
using MojeRezije.messagebox;
using IronXL;

namespace MojeRezije
{
    public partial class RacunanjeVoda : Form
    {
        DataTable DT = new DataTable();
        public RacunanjeVoda()
        {
            InitializeComponent();
        }
        double Podatak;
        

        private void Btn_VodaOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Izbornik = new Izbornik();
            Izbornik.Show();
        }

        private void Btn_IzracunajVoda_Click(object sender, EventArgs e)
        {
            if (tb_novo.Text == "" || tb_Staro.Text == "")
            {
                Form PopunitePolja = new PopunitePolja();
                PopunitePolja.Show();
            }
            else
            {
                if (Convert.ToInt32(tb_novo.Text) < Convert.ToInt32(tb_Staro.Text))
                {
                    Form NovoStanje = new NovoStanje();
                    NovoStanje.Show();
                }
                else
                {
                    switch (cb_Voda.SelectedItem.ToString())
                    {
                        case "Vodovod - Osijek d.o.o":
                            tb_RazlikaVoda.Text = (Convert.ToInt32(tb_novo.Text) - Convert.ToInt32(tb_Staro.Text)).ToString();
                            lbl_VodaIzracun.Text = "Ukupan izracun : " + Math.Round((Convert.ToDouble(tb_RazlikaVoda.Text) * 12.68 + 28.25), 2).ToString() + "kn";
                            Podatak = Math.Round((Convert.ToDouble(tb_RazlikaVoda.Text) * 12.68 + 28.25), 2);
                            lbl_VodaIzracun.Visible = Enabled;
                            lbl_CijenaPDV.Text = "Ukupni dio cijene sa PDV-om : 12.68 kn/m3";
                            lbl_CijenaPDV.Visible = Enabled;
                            lbl_FiksniDio.Text = "Fiknsi dio cijene : 28.25 kn";
                            lbl_FiksniDio.Visible = Enabled;
                            break;

                        case "Vodovod i Kanalizacija d.o.o Rijeka":
                            tb_RazlikaVoda.Text = (Convert.ToInt32(tb_novo.Text) - Convert.ToInt32(tb_Staro.Text)).ToString();
                            lbl_VodaIzracun.Text = "Ukupan izracun : " + Math.Round((Convert.ToDouble(tb_RazlikaVoda.Text) * 12.7157 + 19.20), 2).ToString() + "kn";
                            Podatak = Math.Round((Convert.ToDouble(tb_RazlikaVoda.Text) * 12.7157 + 19.20), 2);
                            lbl_VodaIzracun.Visible = Enabled;
                            lbl_CijenaPDV.Text = "Ukupni dio cijene sa PDV-om : 12.7157 kn/m3";
                            lbl_CijenaPDV.Visible = Enabled;
                            lbl_FiksniDio.Text = "Fiknsi dio cijene : 19.20 kn";
                            lbl_FiksniDio.Visible = Enabled;
                            break;

                        case "Vodoopskrba i odvodnja d.o.o Zagreb":
                            tb_RazlikaVoda.Text = (Convert.ToInt32(tb_novo.Text) - Convert.ToInt32(tb_Staro.Text)).ToString();
                            lbl_VodaIzracun.Text = "Ukupan izracun : " + Math.Round((Convert.ToDouble(tb_RazlikaVoda.Text) * 15.2887 + 18.92), 2).ToString() + "kn";
                            Podatak = Math.Round((Convert.ToDouble(tb_RazlikaVoda.Text) * 15.2887 + 18.92), 2);
                            lbl_VodaIzracun.Visible = Enabled;
                            lbl_CijenaPDV.Text = "Ukupni dio cijene sa PDV-om : 15.2887 kn/m3";
                            lbl_CijenaPDV.Visible = Enabled;
                            lbl_FiksniDio.Text = "Fiknsi dio cijene : 18.92 kn";
                            lbl_FiksniDio.Visible = Enabled;
                            break;

                    }


                }

            }



        }

        private void RacunanjeVoda_Load(object sender, EventArgs e)
        {
            cb_Voda.SelectedIndex = 0;
            cb_Godina.SelectedIndex = 11;
            cb_VMjesec.SelectedIndex = 0;
            RefreshDataTable();
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            try
            {


                WorkBook ExcelPodatak = WorkBook.Create(ExcelFileFormat.XLS);
                ExcelPodatak.Metadata.Author = "IronXL";
                WorkSheet SpremiPodatak = ExcelPodatak.CreateWorkSheet("new_sheet");
                SpremiPodatak["A1"].Value = "Mjesec";
                SpremiPodatak["B1"].Value = cb_VMjesec.SelectedItem.ToString();
                SpremiPodatak["A2"].Value = "Godina";
                SpremiPodatak["B2"].Value = cb_Godina.SelectedItem.ToString();
                SpremiPodatak["A3"].Value = "Dnevno Staro Stanje";
                SpremiPodatak["B3"].Value = tb_Staro.Text;
                SpremiPodatak["A4"].Value = "Dnevno Novo Stanje";
                SpremiPodatak["B4"].Value = tb_novo.Text;
                SpremiPodatak["A5"].Value = "Dnevna Razlika";
                SpremiPodatak["B5"].Value = tb_RazlikaVoda.Text;
                SpremiPodatak["B6"].Value = lbl_VodaIzracun.Text;
                ExcelPodatak.SaveAs(@"C:\Users\Dado\Desktop\Voda.xls");
                Form DatotekaSpremljena = new DatotekaSpremljena();
                DatotekaSpremljena.Show();
            }
            catch
            {
                MessageBox.Show("Zatvorite postojecu datoteku prvo");
            }

        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_vStruja_Click(object sender, EventArgs e)
        {
            Form RacunanjeStruje = new RacunanjeStruje();
            RacunanjeStruje.Show();
            this.Hide();
        }

        private void Btn_vPlin_Click(object sender, EventArgs e)
        {
            Form RacunanjePlin = new RacunanjePlin();
            RacunanjePlin.Show();
            this.Hide();
        }

        private void Btn_Spremi_Click(object sender, EventArgs e)
        {

            bool flag = true;
            var con = DataBase.GetSqlkonekcija();
            con.Open();


            for (int i = 0; i < DT.Rows.Count; i++)
            {

                if (PrijavaKorisnika.ImePrijavljenog == DT.Rows[i][0].ToString() && cb_VMjesec.SelectedItem.ToString() == DT.Rows[i][1].ToString() && cb_Godina.SelectedItem.ToString() == DT.Rows[i][2].ToString())
                {
                    Form IstiIzracun = new IstiIzracun();
                    IstiIzracun.Show();
                    flag = false;
                }
            }
                if (tb_RazlikaVoda.Text == "")
                {
                MessageBox.Show("Prvo izracunajte");

                }
                else if (flag == true)
            {
                string Unos = "INSERT INTO Voda(Email, Izracun, Mjesec, Godina) VALUES " +
                                 "('" + PrijavaKorisnika.ImePrijavljenog + "', '" + Podatak + "', '" + cb_VMjesec.Text + "','" +
                                    cb_Godina.Text + "')";

                SqlCommand Spremi = new SqlCommand(Unos, con);
                Spremi.ExecuteNonQuery();
                Form UspjesnoSpremljeno = new UspjesnoSpremljeno();
                UspjesnoSpremljeno.Show();
                RefreshDataTable();
                Spremi.Dispose();
            }
            
            
          

        }
        public void RefreshDataTable()
        {
            DT.Rows.Clear();
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            string sql = "SELECT Email,Mjesec,Godina From Voda";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, con);
            Adapter.Fill(DT);
            con.Close();

        }
    }
}

    

