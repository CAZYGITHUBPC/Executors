using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyctra_Executor_PAID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://link-target.net/1249309/keysystem-roblox-executor");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string gettext = siticoneTextBox1.Text;
            int gettext_amount = gettext.Length;

            if (gettext_amount > 29)
            {
                WebClient wc = new WebClient();
                string ks = wc.DownloadString("https://raw.githubusercontent.com/CAZYGITHUBPC/Test/refs/heads/main/key");

                if (ks.Contains(siticoneTextBox1.Text))
                {
                    //true side
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("incorrect key, have you paid? or is it expired", "Nyctra Executor");
                }
            }
        }
    }
}
