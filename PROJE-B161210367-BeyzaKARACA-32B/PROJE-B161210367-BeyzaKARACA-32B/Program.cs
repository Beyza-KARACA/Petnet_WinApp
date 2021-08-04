using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_B161210367_BeyzaKARACA_32B
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new LOGIN());
            LOGIN log = new LOGIN();
            log.Show();
         Application.Run();
        }
    }
}
