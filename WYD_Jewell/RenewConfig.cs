using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WYD_Jewell
{
    public partial class RenewConfig : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);


        Button btnEscolhido;
        ListBox listBox1;
        public RenewConfig(Button btn, ListBox lstBox1)
        {
            InitializeComponent();
            btnEscolhido = btn;
            listBox1 = lstBox1;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (possibleKeys.SelectedIndex == -1 || possibleTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o SLOT e TEMPO para renovação.", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnEscolhido.BackColor = Color.LightGreen;

            Close();
            Task.Run(() =>
            {
                var selectedRawProcess = listBox1.SelectedItem.ToString().Split('-');
                String keyToSend = possibleKeys.SelectedItem.ToString();
                String[] timeToRenew = possibleTimes.SelectedItem.ToString().Split('m');
                Process selectedProcess = Process.GetProcessById(Int32.Parse(selectedRawProcess[1]));
                if (selectedProcess != null)
                {
                    while (true)
                    {
                        IntPtr h = selectedProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait(keyToSend);
                        Thread.Sleep(Int32.Parse(timeToRenew[0]) * 1000 * 60);
                    }

                }
            });
        }

        private void btnCancelConfig_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
