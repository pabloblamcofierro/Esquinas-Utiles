using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Esquinas_Utiles
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            bool ejecutando=false ;
            // Comprobar que el programa no este abierto ya y si lo esta cerrar la nueva instancia.
            Process actual = Process.GetCurrentProcess();
            Process[] todos = Process.GetProcesses();
               foreach (Process comprobador in todos)
            { 
            if (comprobador.ProcessName==actual.ProcessName && comprobador.Id != actual.Id)
                { ejecutando = true; }
                  
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ejecutando == false)
            {
                Application.Run(new Form1());
            }
            else
            { Application.Exit(); }
        }
    }
}
