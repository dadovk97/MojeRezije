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
    public partial class Recenzija : Form
    {
        public Recenzija()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Spremi_Click(object sender, EventArgs e)
        {
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            if (tb_Recenzija.Text == "")
            {
                Form PopunitePolja = new PopunitePolja();
                PopunitePolja.Show();
            }
            else
            {


                if (bunifu.Value == 1)
                {
                    if (tb_Recenzija.Text == "")
                    {
                        Form PopunitePolja = new PopunitePolja();
                        PopunitePolja.Show();
                    }
                    else
                    {


                        string query = "INSERT INTO Recenzija(Ocjena,Tekst) VALUES " +
                                         "('" + bunifu.Value + "', '" + tb_Recenzija.Text + "')";
                        SqlCommand sqlcomm = new SqlCommand(query, con);

                        sqlcomm.ExecuteNonQuery();
                        this.Hide();
                        Form Izbornik = new Izbornik();
                        Izbornik.Show();
                        Form HvalaOcjena = new HvalaOcjena();
                        HvalaOcjena.Show();
                    }

                }

                if (bunifu.Value == 2)
                {
                    if (tb_Recenzija.Text == "")
                    {
                        Form PopunitePolja = new PopunitePolja();
                        PopunitePolja.Show();
                    }
                    else
                    {


                        string query = "INSERT INTO Recenzija(Ocjena,Tekst) VALUES " +
                                         "('" + bunifu.Value + "', '" + tb_Recenzija.Text + "')";
                        SqlCommand sqlcomm = new SqlCommand(query, con);

                        sqlcomm.ExecuteNonQuery();
                        this.Hide();
                        Form Izbornik = new Izbornik();
                        Izbornik.Show();
                        Form HvalaOcjena = new HvalaOcjena();
                        HvalaOcjena.Show();
                    }
                }

                if (bunifu.Value == 3)
                {
                    if (tb_Recenzija.Text == "")
                    {
                        Form PopunitePolja = new PopunitePolja();
                        PopunitePolja.Show();
                    }
                    else
                    {


                        string query = "INSERT INTO Recenzija(Ocjena,Tekst) VALUES " +
                                         "('" + bunifu.Value + "', '" + tb_Recenzija.Text + "')";
                        SqlCommand sqlcomm = new SqlCommand(query, con);

                        sqlcomm.ExecuteNonQuery();
                        this.Hide();
                        Form Izbornik = new Izbornik();
                        Izbornik.Show();
                        Form HvalaOcjena = new HvalaOcjena();
                        HvalaOcjena.Show();
                    }

                }

                if (bunifu.Value == 4)
                {
                    if (tb_Recenzija.Text == "")
                    {
                        Form PopunitePolja = new PopunitePolja();
                        PopunitePolja.Show();
                    }
                    else
                    {


                        string query = "INSERT INTO Recenzija(Ocjena,Tekst) VALUES " +
                                         "('" + bunifu.Value + "', '" + tb_Recenzija.Text + "')";
                        SqlCommand sqlcomm = new SqlCommand(query, con);

                        sqlcomm.ExecuteNonQuery();
                        this.Hide();
                        Form Izbornik = new Izbornik();
                        Izbornik.Show();
                        Form HvalaOcjena = new HvalaOcjena();
                        HvalaOcjena.Show();
                    }
                }

                if (bunifu.Value == 5)
                {
                    if (tb_Recenzija.Text == "")
                    {
                        Form PopunitePolja = new PopunitePolja();
                        PopunitePolja.Show();
                    }
                    else
                    {


                        string query = "INSERT INTO Recenzija(Ocjena,Tekst) VALUES " +
                                         "('" + bunifu.Value + "', '" + tb_Recenzija.Text + "')";
                        SqlCommand sqlcomm = new SqlCommand(query, con);

                        sqlcomm.ExecuteNonQuery();
                        this.Hide();
                        Form Izbornik = new Izbornik();
                        Izbornik.Show();
                        Form HvalaOcjena = new HvalaOcjena();
                        HvalaOcjena.Show();
                    }

                }
                    
            }
            con.Close();
        }

        private void Btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Izbornik = new Izbornik();
            Izbornik.Show();
        }
    } 
}
