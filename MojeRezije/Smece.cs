using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IronXL;
using MojeRezije.Model;
using MojeRezije.messagebox;

namespace MojeRezije
{
    public partial class Smece : Form
    {
        public DataTable DT = new DataTable();
        public Smece()
        {
            InitializeComponent();
        }

        private void Btn_Internet_Click(object sender, EventArgs e)
        {
            Form Internet = new Internet();
            Internet.Show();
            this.Hide();
        }

        private void Btn_Mobitel_Click(object sender, EventArgs e)
        {
            Form Mobitel = new Mobitel();
            Mobitel.Show();
            this.Hide();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Podustani_Click(object sender, EventArgs e)
        {
            Form Izbornik = new Izbornik();
            Izbornik.Show();
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
            if (tb_Cijena.Text == "")
            {
                MessageBox.Show("Prvo izracunajte");
            }
            else if (flag == true)
            {
                string Unos = "INSERT INTO Smece(Email, Izracun, Mjesec, Godina) VALUES " +
                              "('" + PrijavaKorisnika.ImePrijavljenog + "', '" + tb_Cijena.Text + "', '" + cb_SMjesec.Text + "','" +
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

        private void Smece_Load(object sender, EventArgs e)
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
            string sql = "SELECT Email,Mjesec,Godina From Smece";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, con);
            Adapter.Fill(DT);
            con.Close();

        }

        private void Btn_ExportPlin_Click(object sender, EventArgs e)
        {
            try
            {


                if (tb_Cijena.Text == "" || tb_Tvrtka.Text == "")
                {
                    Form PopunitePolja = new PopunitePolja();
                    PopunitePolja.Show();
                }
                else
                {

                    WorkBook ExcelPodatak = WorkBook.Create(ExcelFileFormat.XLS);
                    ExcelPodatak.Metadata.Author = "IronXL";
                    WorkSheet SpremiPodatak = ExcelPodatak.CreateWorkSheet("new_sheet");
                    SpremiPodatak["A1"].Value = "Mjesec";
                    SpremiPodatak["B1"].Value = cb_SMjesec.SelectedItem.ToString();
                    SpremiPodatak["A2"].Value = "Godina";
                    SpremiPodatak["B2"].Value = cb_Godina.SelectedItem.ToString();
                    SpremiPodatak["A3"].Value = "Tvrtka";
                    SpremiPodatak["B3"].Value = tb_Tvrtka.Text;
                    SpremiPodatak["A4"].Value = "Cijena Računa";
                    SpremiPodatak["B4"].Value = tb_Cijena.Text;
                    ExcelPodatak.SaveAs(@"C:\Users\Dado\Desktop\Smece.xls");
                    Form DatotekaSpremljena = new DatotekaSpremljena();
                    DatotekaSpremljena.Show();
                }
            }
            catch
            {
                MessageBox.Show("Zatvorite postojeću datoteku prvo");
            }

        }

        private void Tb_Cijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            char prov = e.KeyChar;

            if (prov == 46 && tb_Cijena.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(prov) && prov != 8 && prov != 46)
            {
                e.Handled = true;
            }
        }
    }
}
