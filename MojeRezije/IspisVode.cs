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
using MojeRezije.Model;
using MojeRezije.messagebox;

namespace MojeRezije
{
    public partial class IspisVode : Form
    {
        DataTable DT = new DataTable();
        public IspisVode()
        {
            InitializeComponent();
        }
        

        private void Btn_Nazad_Click(object sender, EventArgs e)
        {
            Form Izbornik = new Izbornik();
            Izbornik.Show();
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

        private void IspisVode_Load(object sender, EventArgs e)
        {
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            RefreshDataTable();
            GridIspis.RowTemplate.Height = 40;
            GridIspis.AllowUserToAddRows = false;
            GridIspis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridIspis.ForeColor = Color.Black;
            GridIspis.DataSource = DT;
            GridIspis.Columns[0].Visible = false;
            RefreshDataTable();

            con.Close();
        }

        private void Btn_Obrisi_Click(object sender, EventArgs e)
        {
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            GridIspis.DataSource = DT;
            string str = GridIspis.Rows[GridIspis.SelectedRows[0].Index].Cells[0].Value.ToString();

            SqlCommand Brisi;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            string Obrisi = "Delete from Voda where ID='" + str + "'";
            Brisi = new SqlCommand(Obrisi, con);
            Adapter.DeleteCommand = new SqlCommand(Obrisi, con);
            Adapter.DeleteCommand.ExecuteNonQuery();
            Brisi.Dispose();
            Form UspjesnoObrisano = new UspjesnoObrisano();
            UspjesnoObrisano.Show();
            RefreshDataTable();
            con.Close();
           
        }

        private void Btn_vStruja_Click(object sender, EventArgs e)
        {
            Form IspisStruje = new IspisStruje();
            IspisStruje.Show();
            this.Hide();
        }

        private void Btn_sPlin_Click(object sender, EventArgs e)
        {
            Form IspisPlina = new IspisPlina();
            IspisPlina.Show();
            this.Hide();
        }

        private void Cb_GodinaVoda_SelectedIndexChanged(object sender, EventArgs e)
        {

            double ukupno = 0;
            var con = DataBase.GetSqlkonekcija();
            con.Open();
           
                SqlCommand Uzmi = new SqlCommand("SELECT Izracun, Godina FROM Voda Where Email = '" + PrijavaKorisnika.ImePrijavljenog + "'AND Godina = '" + cb_GodinaVoda.Text + "'", con);
                SqlDataReader Citac;
                Citac = Uzmi.ExecuteReader();
                while (Citac.Read())
                {
                    ukupno = ukupno + Convert.ToDouble(Citac.GetValue(0));
                }
                lbl_Ispis.Text = "Vasa Ukupna cijena za godinu " + cb_GodinaVoda.Text + " iznosi " + ukupno + "kn";
                lbl_Ispis.Visible = true;
                Citac.Close();
                Uzmi.Dispose();
                lbl_Ispis.Refresh();
                con.Close();

            }
        public void RefreshDataTable()
        {
            DT.Rows.Clear();
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            string sql = "SELECT ID, Email, Izracun,Mjesec,Godina From Voda  WHERE Email='" + PrijavaKorisnika.ImePrijavljenog + "'";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, con);
            Adapter.Fill(DT);
            con.Close();

        }

        private void Btn_Internet_Click(object sender, EventArgs e)
        {
            Form IspisInterneta = new IspisInterneta();
            IspisInterneta.Show();
            this.Hide();
        }

        private void Btn_Mobitel_Click(object sender, EventArgs e)
        {
            Form IspisMobitela = new IspisMobitela();
            IspisMobitela.Show();
            this.Hide();
        }

        private void Btn_Smece_Click(object sender, EventArgs e)
        {
            Form IspisSmeca = new IspisSmeca();
            IspisSmeca.Show();
            this.Hide();
        }
    }
}
