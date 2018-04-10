using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RemoteController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sendCommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_inputCommand.Text);

            string command = tb_inputCommand.Text;

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
            Process process = new Process();

            process.StartInfo = startInfo;
            process.Start();
            process.StandardInput.Write(command + Environment.NewLine);
            process.StandardInput.Close();

            process.Close();
        }
    }
}
