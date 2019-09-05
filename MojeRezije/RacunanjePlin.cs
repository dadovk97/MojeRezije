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
using MojeRezije.Model;
using System.Data.SqlClient;
using MojeRezije.messagebox;
using IdentityModel.Client;
using IronXL;

namespace MojeRezije
{
    public partial class RacunanjePlin : Form
    {
        public DataTable DT = new DataTable();


        public RacunanjePlin()
        {
            InitializeComponent();
        }
        double Podatak;




        private void Btn_Podustani_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Izbornik = new Izbornik();
            Izbornik.Show();
        }

        private void Btn_Pizracunaj_Click(object sender, EventArgs e)
        {


            if (tb_Plin1.Text == "" || tb_Plin2.Text == "")
            {
                Form PopunitePolja = new PopunitePolja();
                PopunitePolja.Show();
            }
            else
            {




                if (cb_Tarifa.SelectedItem.ToString() == "PPD")
                {

                    double energija;
                    double TM1 = 0.3298; double TM2 = 0.3298; double TM3 = 0.3279; double TM4 = 0.3234; double TM5 = 0.3179; double TM6 = 0.3143;
                    double TM7 = 0.3096; double TM8 = 0.3050; double TM9 = 0.2995; double TM10 = 0.2914; double TM11 = 0.2821; double TM12 = 0.2730;





                    try
                    {




                        if (Convert.ToInt32(tb_Plin2.Text) < Convert.ToInt32(tb_Plin1.Text))
                        {
                            Form NovoStanje = new NovoStanje();
                            NovoStanje.Show();
                        }
                        else
                        {






                            switch (cb_TM.SelectedItem.ToString())
                            {
                                case "TM1":


                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM1)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM1)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM2":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM2)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM2)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM3":


                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM3)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM3)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM4":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM4)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM4)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;
                                case "TM5":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM5)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM5)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM6":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM6)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM6)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;
                                case "TM7":


                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM7)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM7)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM8":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM8)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM8)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;
                                case "TM9":


                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM9)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM9)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM10":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM10)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM10)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM11":


                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM11)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM11)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM12":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.2607, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM12)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM12)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;
                            }


                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unesite znamenke ");
                    }
                }
            }
                    
        
                
            
        












                if (cb_Tarifa.SelectedItem.ToString() == "PIS")
                {

                    double energija;
                    double TM1 = 0.3953; double TM2 = 0.3830; double TM3 = 0.3830; double TM4 = 0.3769; double TM5 = 0.3708; double TM6 = 0.3646;
                    double TM7 = 0.3585; double TM8 = 0.3524; double TM9 = 0.3461; double TM10 = 0.3339; double TM11 = 0.3216; double TM12 = 0.3094;

                    try
                    {


                        if (Convert.ToInt32(tb_Plin2.Text) < Convert.ToInt32(tb_Plin1.Text))
                        {
                            Form NovoStanje = new NovoStanje();
                            NovoStanje.Show();
                        }
                        else
                        {




                            switch (cb_TM.SelectedItem.ToString())
                            {

                                case "TM1":

                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM1)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM1)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM2":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM2)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM2)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM3":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM3)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM3)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM4":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM4)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM4)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM5":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM5)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM5)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM6":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM6)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM6)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM7":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM7)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM7)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM8":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM8)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM8)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM9":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM9)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM9)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM10":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM10)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM10)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM11":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM11)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM11)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;

                                case "TM12":
                                    tb_Prazlika.Text = (Convert.ToInt32(tb_Plin2.Text) - Convert.ToInt32(tb_Plin1.Text)).ToString();
                                    energija = Math.Round(Convert.ToDouble(tb_Prazlika.Text) * 9.638183, 2);
                                    lbl_Pizracunaj.Text = "Ukupan Izracun " + Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM12)), 2).ToString() + "kn";
                                    Podatak = Math.Round((Convert.ToDouble(energija) * Convert.ToDouble(TM12)), 2);
                                    lbl_Pizracunaj.Visible = Enabled;
                                    break;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unesite znamenke");
                    }


                }
                


            }


        
    

    




        private void RacunanjePlin_Load(object sender, EventArgs e)
        {
            
            cb_TM.SelectedIndex = 0;
            cb_Tarifa.SelectedIndex = 0;
            cb_PMjesec.SelectedIndex = 0;
            cb_Godina.SelectedIndex = 11;
            RefreshDataTable();

            
            


        }

        private void Btn_ExportPlin_Click(object sender, EventArgs e)
        {
            try
            {



                WorkBook ExcelPodatak = WorkBook.Create(ExcelFileFormat.XLS);
                ExcelPodatak.Metadata.Author = "IronXL";
                WorkSheet SpremiPodatak = ExcelPodatak.CreateWorkSheet("new_sheet");
                SpremiPodatak["A1"].Value = "Mjesec";
                SpremiPodatak["B1"].Value = cb_PMjesec.SelectedItem.ToString();
                SpremiPodatak["A2"].Value = "Godina";
                SpremiPodatak["B2"].Value = cb_Godina.SelectedItem.ToString();
                SpremiPodatak["A3"].Value = "Staro Stanje";
                SpremiPodatak["B3"].Value = tb_Plin1.Text;
                SpremiPodatak["A4"].Value = "Novo Stanje";
                SpremiPodatak["B4"].Value = tb_Plin2.Text;
                SpremiPodatak["A5"].Value = "Razlika";
                SpremiPodatak["B5"].Value = tb_Prazlika.Text;
                SpremiPodatak["A6"].Value = lbl_Pizracunaj.Text;
                ExcelPodatak.SaveAs(@"C:\Users\Dado\Desktop\Plin.xlsx");
                Form DatotekaSpremljena = new DatotekaSpremljena();
                DatotekaSpremljena.Show();
            }
            catch
            {
                MessageBox.Show("Zatvorite Postojecu datoteku prvo");
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

        private void Btn_pVoda_Click(object sender, EventArgs e)
        {
            Form RacunanjeVoda = new RacunanjeVoda();
            RacunanjeVoda.Show();
            this.Hide();
        }

        private void Btn_pStruja_Click(object sender, EventArgs e)
        {
            Form RacunanjeStruje = new RacunanjeStruje();
            RacunanjeStruje.Show();
            this.Hide();
        }

        private void Btn_Spremi_Click(object sender, EventArgs e)
        {
            bool flag = true;
            var con = DataBase.GetSqlkonekcija();
            con.Open();


            for (int i = 0; i < DT.Rows.Count; i++)
            {
                
                if (PrijavaKorisnika.ImePrijavljenog == DT.Rows[i][0].ToString() && cb_PMjesec.SelectedItem.ToString() == DT.Rows[i][1].ToString() && cb_Godina.SelectedItem.ToString() == DT.Rows[i][2].ToString())
                {
                    Form IstiIzracun = new IstiIzracun();
                    IstiIzracun.Show();
                    flag = false;
                }





            }
            if(tb_Prazlika.Text == "")
            {
                MessageBox.Show("Prvo izracunajte");
            }
            else if (flag == true)
            {
                string Unos = "INSERT INTO Plin(Email, Izracun, Mjesec, Godina) VALUES " +
                              "('" + PrijavaKorisnika.ImePrijavljenog + "', '" + Podatak + "', '" + cb_PMjesec.Text + "','" +
                                 cb_Godina.Text + "')";

                SqlCommand Spremi = new SqlCommand(Unos, con);
                Spremi.ExecuteNonQuery();
                Form UspjesnoSpremljeno = new UspjesnoSpremljeno();
                UspjesnoSpremljeno.Show();
                RefreshDataTable();
                Spremi.Dispose();

            }






            con.Close();



        }
        public void RefreshDataTable()
        {
            DT.Rows.Clear();
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            string sql = "SELECT Email,Mjesec,Godina From Plin";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, con);
            Adapter.Fill(DT);
            con.Close();

        }
            



        }





        }















    
    







        


        


    

