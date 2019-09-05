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
using System.Text.RegularExpressions;
using MojeRezije.messagebox;

namespace MojeRezije
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registriraj_Click(object sender, EventArgs e)
        {
            var con = DataBase.GetSqlkonekcija();
            con.Open();

            SqlCommand Uzmi = new SqlCommand("SELECT COUNT(*) FROM [Registracija] WHERE Email=@email", con);
            Uzmi.Parameters.AddWithValue("@email", tb_EmailReg.Text);
            object R = Uzmi.ExecuteScalar();
            int Registracija = Convert.ToInt32(R);

            if (tb_ImeReg.Text == "" || tb_PrezimeReg.Text == "" || tb_EmailReg.Text == "" || tb_LozinkaReg.Text == "" || tb_PotvrdaLoz.Text == "")
            {
                 Form PopunitePolja = new PopunitePolja();
                 PopunitePolja.Show();
               
            }
            
          
            else if(tb_LozinkaReg.Text != tb_PotvrdaLoz.Text)
             {

                    Form LozinkePodudarati = new LozinkePodudarati();
                    LozinkePodudarati.ShowDialog();
                    

             }

            else if (Registracija > 0)
           {
               Form EmailPostoji = new EmailPostoji();
               EmailPostoji.Show();
           }
           else
                  {
                        string query = "INSERT INTO Registracija(Ime, Prezime, Email, Lozinka) VALUES " +
                                      "('" + tb_ImeReg.Text + "', '" + tb_PrezimeReg.Text + "', '" + tb_EmailReg.Text + "', '" +
                                      tb_LozinkaReg.Text + "')";
                        SqlCommand sqlcomm = new SqlCommand(query, con);
                        sqlcomm.ExecuteNonQuery();
                        this.Hide();
                Form Prijava = new Prijava();
                Prijava.Show();
                Form UspjesnoRegistriran = new UspjesnoRegistriran();
                UspjesnoRegistriran.Show();

                        
                        


            }
             con.Close();
        }
            
           
        

        private void Btn_Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Prijava = new Prijava();
            Prijava.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Tb_EmailReg_Leave(object sender, EventArgs e)
        {



            if (!string.IsNullOrWhiteSpace(tb_EmailReg.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (reg.IsMatch(tb_EmailReg.Text))
                {

                }
                else
                {
                    Form IspravanEmail = new IspravanEmail();
                    IspravanEmail.ShowDialog();
                    tb_EmailReg.Focus();
                }
            }
        }

        private void Tb_EmailReg_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
