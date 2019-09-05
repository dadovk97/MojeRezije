using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeRezije.messagebox
{
    public partial class NovoStanje : Form
    {
        public NovoStanje()
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

        private void Btn_Uredu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
