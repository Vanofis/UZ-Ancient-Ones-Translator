using System;
using System.Windows.Forms;

namespace AncientOnesTranslator;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainWindowForm());
    }
}