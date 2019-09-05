using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace MojeRezije
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            PopuniGrid();
            BrojacOcjena();
            DrawPieChart(Ocjena1, Ocjena2, Ocjena3, Ocjena4, Ocjena5);
        }

        int Ocjena1 = 0;
        int Ocjena2 = 0;
        int Ocjena3 = 0;
        int Ocjena4 = 0;
        int Ocjena5 = 0;
        DataTable DB;

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void PopuniGrid()
        {
            var con = DataBase.GetSqlkonekcija();
            con.Open();

            SqlCommand Uzmi = new SqlCommand("SELECT Ocjena,Tekst FROM Recenzija", con);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = Uzmi;
            DB = new DataTable();
            Adapter.Fill(DB);
            BindingSource Izvor = new BindingSource();
            GridRecenzija.RowTemplate.Height = 40;
            GridRecenzija.AllowUserToAddRows = false;

            GridRecenzija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridRecenzija.ForeColor = Color.Black;
            Izvor.DataSource = DB;
            GridRecenzija.DataSource = Izvor;
            Adapter.Update(DB);

            con.Close();

            int A = 0, B = 0;
            for (A = 0; A < GridRecenzija.Rows.Count; ++A)
            {
                B += Convert.ToInt32(GridRecenzija.Rows[A].Cells[0].Value);
            }
            lbl_Pros.Text = B.ToString();
            double BrojRedaka = GridRecenzija.Rows.Count;
            double Prosjek = B / BrojRedaka;
            lbl_Pros.Text = "Prosjecna ocjena :" + (Prosjek.ToString());
            lbl_Pros.Visible = true;
        }
        private void BrojacOcjena()
        {
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            SqlCommand Uzmi = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 5", con);
            SqlDataReader Citac = Uzmi.ExecuteReader();
            while (Citac.Read())
            {
                Ocjena5++;

            }

            Citac.Close();

            SqlCommand Uzmi1 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 4", con);
            SqlDataReader Citac1 = Uzmi1.ExecuteReader();
            while (Citac1.Read())
            {
                Ocjena4++;

            }
            Citac1.Close();

            SqlCommand Uzmi2 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 3", con);
            SqlDataReader Citac2 = Uzmi2.ExecuteReader();
            while (Citac2.Read())
            {
                Ocjena3++;

            }
            Citac2.Close();

            SqlCommand Uzmi3 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 2", con);
            SqlDataReader Citac3 = Uzmi3.ExecuteReader();
            while (Citac3.Read())
            {
                Ocjena2++;

            }
            Citac3.Close();

            SqlCommand Uzmi4 = new SqlCommand("SELECT Ocjena FROM Recenzija WHERE Ocjena = 1", con);
            SqlDataReader Citac4 = Uzmi4.ExecuteReader();
            while (Citac4.Read())
            {
                Ocjena1++;

            }
            Citac4.Close();

            con.Close();
        }
        private void DrawPieChart(int Ocjena1, int Ocjena2, int Ocjena3, int Ocjena4, int Ocjena5)
        {
            Graf.Series.Clear();
            Graf.Legends.Clear();

            Graf.Legends.Add("Legenda");
            Graf.Legends[0].LegendStyle = LegendStyle.Table;
            Graf.Legends[0].Docking = Docking.Bottom;
            Graf.Legends[0].Alignment = StringAlignment.Center;
            Graf.Legends[0].Title = "Ocjenjene Recenzije";
            Graf.Legends[0].BorderColor = Color.Black;

            string seriesname = "Ocjene";
            Graf.Series.Add(seriesname);

            Graf.Series[seriesname].ChartType = SeriesChartType.Pie;

            Graf.Series[seriesname].Points.AddXY("1", Ocjena1);
            Graf.Series[seriesname].Points.AddXY("2", Ocjena2);
            Graf.Series[seriesname].Points.AddXY("3", Ocjena3);
            Graf.Series[seriesname].Points.AddXY("4", Ocjena4);
            Graf.Series[seriesname].Points.AddXY("5", Ocjena5);
        }

        private void Btn_Odjava_Click(object sender, EventArgs e)
        {
            Form Prijava = new Prijava();
            Prijava.Show();
            this.Hide();
        }
    }
}
