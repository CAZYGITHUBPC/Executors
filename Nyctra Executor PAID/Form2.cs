using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cxapi;

namespace Nyctra_Executor_PAID
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CoreFunctions.setconfig("Nyctra Executor PAID", "1.0V", "nyctra successfully Injected 94 UNC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            // OpenFileDialog to select a Lua file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Lua Script Files (*.lua)|*.lua|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a Lua Script File";

            // Show the dialog and get the file path
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string luaScriptPath = openFileDialog.FileName;  // Get the selected Lua file path
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            CoreFunctions.Inject(false);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(Editor.Text);
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            // OpenFileDialog to select a Lua file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Lua Script Files (*.lua)|*.lua|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a Lua Script File";

            // Show the dialog and get the file path
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string luaScriptPath = openFileDialog.FileName;  // Get the selected Lua file path
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            CoreFunctions.KillRoblox();
        }
    }
}
