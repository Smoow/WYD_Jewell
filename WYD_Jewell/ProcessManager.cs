using System.Diagnostics;
using System.Windows.Forms;

namespace WYD_Jewell
{
    internal static class ProcessManager
    {
        public static void ListProcessesToListBox(ListBox lb)
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                if ((p.ProcessName.Contains("WYD") || p.ProcessName.Contains("DK") || p.ProcessName.Contains("KOD") || p.ProcessName.Contains("Over")) && !p.ProcessName.Equals("WYD_Jewell")) lb.Items.Add(p.ProcessName + " - " + p.Id);
            }

            if (lb.Items.Count == 0) lb.Items.Add("Abra uma instância de WYD e recarregue os processos.");
        }
    }
}
