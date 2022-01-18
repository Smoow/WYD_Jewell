using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WYD_Jewell
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        public Form1()
        {
            InitializeComponent();
            ProcessManager.ListProcessesToListBox(listBoxProcesses);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxProcesses.Items.Clear();
            ProcessManager.ListProcessesToListBox(listBoxProcesses);
        }

        private void btnSelecProcesso1_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um processo primeiro.", "Erro ao ativar macro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RenewConfig rc = new RenewConfig(btnSelecProcesso1, listBoxProcesses);
            rc.Show();
        }

        private void btnSelecProcesso2_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex == -1)
            {
                SelectedWithoutProcess();
            }

            RenewConfig rc = new RenewConfig(btnSelecProcesso2, listBoxProcesses);
            rc.Show();
        }

        private void btnSelecProcesso3_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex == -1)
            {
                SelectedWithoutProcess();
            }

            RenewConfig rc = new RenewConfig(btnSelecProcesso3, listBoxProcesses);
            rc.Show();
        }

        private void btnSelecProcesso4_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex == -1)
            {
                SelectedWithoutProcess();
            }

            RenewConfig rc = new RenewConfig(btnSelecProcesso4, listBoxProcesses);
            rc.Show();
        }

        private void btnSelecProcesso5_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex == -1)
            {
                SelectedWithoutProcess();
            }

            RenewConfig rc = new RenewConfig(btnSelecProcesso5, listBoxProcesses);
            rc.Show();
        }

        private static void SelectedWithoutProcess()
        {
            MessageBox.Show("Selecione um processo primeiro.", "Erro ao ativar macro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
    }
}
