using System;
using System.Windows.Forms;

internal static class ProgramHelpers
{
    [STAThread]
    private static void Main(string[] args)
    {

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new İş_yeri_kullanıcı_girişleri.Form1());
    }
}