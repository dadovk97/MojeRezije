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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
           
            var con = DataBase.GetSqlkonekcija();
            con.Open();
            if (tb_Email.Text == "0000" && tb_Lozinka.Text == "5555")
            {
                Form AdmingPage = new AdminPage();
                AdmingPage.Show();
                this.Hide();
            }
            else
            {
                if (tb_Email.Text == "" || tb_Lozinka.Text == "")
                {
                    Form PopunitePolja = new PopunitePolja();
                    PopunitePolja.Show();
                }
                else
                {
                    string provjera = "SELECT Email , Lozinka FROM Registracija  WHERE Email = '" + tb_Email.Text + "' AND Lozinka = '" + tb_Lozinka.Text + "';";

                    SqlCommand nadji = new SqlCommand(provjera, con);
                    SqlDataReader pronadji = nadji.ExecuteReader();
                    if (pronadji.Read())
                    {

                        PrijavaKorisnika.ImePrijavljenog = (string)pronadji["Email"];
                        this.Hide();
                        Form Izbornik = new Izbornik();
                        Izbornik.Show();
                        Form UspjesnoPrijavljen = new UspjesnoPrijavljen();
                        UspjesnoPrijavljen.Show();
                        

                    }
                    else
                    {
                        Form LozEmailNetocni = new LozEmailNetocni();
                        LozEmailNetocni.Show();
                    }
                }
                con.Close();
            }

        }

 

        private void Lbl_Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form Registracija = new Registracija();
            Registracija.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
