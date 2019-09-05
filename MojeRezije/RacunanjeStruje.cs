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
    public partial class RacunanjeStruje : Form
    {
        DataTable DT = new DataTable();
        public RacunanjeStruje()
        {
            InitializeComponent();
        }
        
        double Podatak;
        private void Btn_Izracunaj_Click(object sender, EventArgs e)
        {
            try
            {



                if (tb_NovoStanjeVT.Text == "" || tb_StaroStanjeVT.Text == "" || tb_NovoStanjeNT.Text == "" || tb_StaroStanjeNT.Text == "")
                {
                    Form PopunitePolja = new PopunitePolja();
                    PopunitePolja.Show();
                }
                else
                {
                    if (Convert.ToInt32(tb_NovoStanjeVT.Text) < Convert.ToInt32(tb_StaroStanjeVT.Text) || Convert.ToInt32(tb_NovoStanjeNT.Text) < Convert.ToInt32(tb_StaroStanjeNT.Text))
                    {
                        Form NovoStanje = new NovoStanje();
                        NovoStanje.Show();
                    }
                    else
                    {
                        tb_RazlikaVT.Text = (Convert.ToInt32(tb_NovoStanjeVT.Text) - Convert.ToInt32(tb_StaroStanjeVT.Text)).ToString();
                        tb_RazlikaNT.Text = (Convert.ToInt32(tb_NovoStanjeNT.Text) - Convert.ToInt32(tb_StaroStanjeNT.Text)).ToString();
                        tb_Naknada1.Text = Math.Round((Convert.ToDouble(tb_RazlikaVT.Text) * 0.11 + Convert.ToDouble(tb_RazlikaNT.Text) * 0.05), 2).ToString();
                        tb_Naknada2.Text = Math.Round((Convert.ToDouble(tb_RazlikaVT.Text) * 0.24 + Convert.ToDouble(tb_RazlikaNT.Text) * 0.12 + 10), 2).ToString();
                        tb_Naknada3.Text = Math.Round(((Convert.ToDouble(tb_RazlikaVT.Text) + Convert.ToDouble(tb_RazlikaNT.Text)) * 0.1050), 2).ToString();
                        double x1, x2;
                        x1 = Convert.ToDouble(tb_RazlikaVT.Text) * 0.49;
                        x2 = Convert.ToDouble(tb_RazlikaNT.Text) * 0.24;

                        tb_PDV.Text = Math.Round(((x1 + x2 + 7.40 + Convert.ToDouble(tb_Naknada1.Text) + Convert.ToDouble(tb_Naknada2.Text) + Convert.ToDouble(tb_Naknada3.Text)) * 0.13), 2).ToString();
                        lbl_Izracun.Text = "Ukupan Izracun  " + Math.Round((x1 + x2 + 7.40 + Convert.ToDouble(tb_Naknada1.Text) + Convert.ToDouble(tb_Naknada2.Text) + Convert.ToDouble(tb_Naknada3.Text) + Convert.ToDouble(tb_PDV.Text)), 2).ToString() + "kn";
                        Podatak = Math.Round((x1 + x2 + 7.40 + Convert.ToDouble(tb_Naknada1.Text) + Convert.ToDouble(tb_Naknada2.Text) + Convert.ToDouble(tb_Naknada3.Text) + Convert.ToDouble(tb_PDV.Text)), 2);
                        lbl_Izracun.Visible = Enabled;
                    }


                }
            }
            catch
            {
                MessageBox.Show("Unesite znamenke!");
            }




        

    

           
              

        }

        private void Btn_Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Izbornik = new Izbornik();
            Izbornik.Show();
        }

        private void Btn_ExportStruja_Click(object sender, EventArgs e)
        {
            try
            {



                WorkBook ExcelPodatak = WorkBook.Create(ExcelFileFormat.XLS);
                ExcelPodatak.Metadata.Author = "IronXL";
                WorkSheet SpremiPodatak = ExcelPodatak.CreateWorkSheet("new_sheet");
                SpremiPodatak["A1"].Value = "Mjesec";
                SpremiPodatak["B1"].Value = cb_SMjesec.SelectedItem.ToString();
                SpremiPodatak["A2"].Value = "Godina";
                SpremiPodatak["B2"].Value = cb_Godina.SelectedItem.ToString();
                SpremiPodatak["A3"].Value = "Dnevno Staro Stanje";
                SpremiPodatak["B3"].Value = tb_StaroStanjeVT.Text;
                SpremiPodatak["A4"].Value = "Dnevno Novo Stanje";
                SpremiPodatak["B4"].Value = tb_NovoStanjeVT.Text;
                SpremiPodatak["A5"].Value = "Dnevna Razlika";
                SpremiPodatak["B5"].Value = tb_RazlikaVT.Text;
                SpremiPodatak["A6"].Value = "Nocno Staro Stanje";
                SpremiPodatak["B6"].Value = tb_StaroStanjeNT.Text;
                SpremiPodatak["A7"].Value = "Nocno Novo Stanje";
                SpremiPodatak["B7"].Value = tb_NovoStanjeNT.Text;
                SpremiPodatak["A8"].Value = "Nocna Razlika";
                SpremiPodatak["B8"].Value = tb_RazlikaNT.Text;
                SpremiPodatak["A9"].Value = lbl_Izracun.Text;
                ExcelPodatak.SaveAs(@"C:\Users\Dado\Desktop\Struja.xls");
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


        private void Btn_sVoda_Click(object sender, EventArgs e)
        {
            Form RacunanjeVoda = new RacunanjeVoda();
            RacunanjeVoda.Show();
            this.Hide();
        }

        private void Btn_sPlin_Click(object sender, EventArgs e)
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

                if (PrijavaKorisnika.ImePrijavljenog == DT.Rows[i][0].ToString() && cb_SMjesec.SelectedItem.ToString() == DT.Rows[i][1].ToString() && cb_Godina.SelectedItem.ToString() == DT.Rows[i][2].ToString())
                {
                    Form IstiIzracun = new IstiIzracun();
                    IstiIzracun.Show();
                    flag = false;
                }





            }
            if (tb_RazlikaNT.Text == "" || tb_RazlikaVT.Text == "")
            {
                MessageBox.Show("Prvo izracunajte");
            }
             else if (flag == true)
            {
                string Unos = "INSERT INTO Struja(Email, Izracun, Mjesec, Godina) VALUES " +
                              "('" + PrijavaKorisnika.ImePrijavljenog + "', '" + Podatak + "', '" + cb_SMjesec.Text + "','" +
                                 cb_Godina.Text + "')";

                SqlCommand Spremi = new SqlCommand(Unos, con);
                Spremi.ExecuteNonQuery();
                Form UspjesnoSpremljeno = new UspjesnoSpremljeno();
                UspjesnoSpremljeno.Show();
                RefreshDataTable();
                Spremi.Dispose();

            }

        }

        private void RacunanjeStruje_Load(object sender, EventArgs e)
        {
            cb_Godina.SelectedIndex = 11;
            cb_SMjesec.SelectedIndex = 0;
            RefreshDataTable();
        }
        public void RefreshDataTable()
        {
            DT.Rows.Clear();
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            string sql = "SELECT Email,Mjesec,Godina From Struja";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, con);
            Adapter.Fill(DT);
            con.Close();

        }

       
    }

       
    }

