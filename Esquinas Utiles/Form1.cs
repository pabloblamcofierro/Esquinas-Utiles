using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Diagnostics;
namespace Esquinas_Utiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Preparo variables

        internal static bool abierto = false;
        Form2 fm2 = new Form2();











        //Al iniciar el programa coloco los activadores (que son unas label en las esquinas), etc.
        private void Form1_Load(object sender, EventArgs e)
        {




            // ejecutal1e = "rundll32.exe";
            // parametrol1e = " user32.dll,LockWorkStation";

            this.Opacity = 0.10;
            int horizontal = this.Size.Width;
            int vertical = this.Size.Height;
            label1.Location = new Point(-10, -10);
            label3.Location = new Point(-10, vertical - 10);
            label2.Location = new Point(horizontal - 10, -10);
            label4.Location = new Point(horizontal - 10, vertical - 10);
        }



        // Al hacer click en el icono de la barra de notificacion suber el Form2...                   ███
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Form2 fm2 = new Form2();
            if (abierto == false)
            {
                fm2.Show();
                fm2.Enabled = true;

                Properties.Settings.Default.Reload();
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.Cancel = true;
        }

        private void cerrarEsquinasUtilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.activado1 == true)
            {
                try
                {
                    process1.StartInfo.FileName = Properties.Settings.Default.ejecuta1;
                    process1.StartInfo.Arguments = Properties.Settings.Default.parametro1;
                    process1.StartInfo.CreateNoWindow = true;
                    process1.Start();
                }
                catch
                { }
            }
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.activado2 == true)

            {
                try
                {
                    process1.StartInfo.FileName = Properties.Settings.Default.ejecuta2;
                    process1.StartInfo.Arguments = Properties.Settings.Default.parametro2;
                    process1.StartInfo.CreateNoWindow = true;
                    process1.Start();
                }
                catch { }
            }

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            {

                if (Properties.Settings.Default.activado3 == true)

                    try
                    {
                        process1.StartInfo.FileName = Properties.Settings.Default.ejecuta3;
                        process1.StartInfo.Arguments = Properties.Settings.Default.parametro3;
                        process1.StartInfo.CreateNoWindow = true;
                        process1.Start();
                    }
                    catch { }
            }

        }



        private void label4_MouseHover(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            {
                try
                {
                    if (Properties.Settings.Default.activado4 == true)
                    {
                        process1.StartInfo.FileName = Properties.Settings.Default.ejecuta4;
                        process1.StartInfo.Arguments = Properties.Settings.Default.parametro4;
                        process1.StartInfo.CreateNoWindow = true;
                        process1.Start();
                    }
                }
                catch { }
            }

        }
    }
}