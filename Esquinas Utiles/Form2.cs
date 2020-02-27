using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Win32;
using System.Security.Permissions;

namespace Esquinas_Utiles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Al cargar el Form2... ████████████████████████
        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            Form1.abierto = true;
            timer1.Enabled = true;
            textBox1.Text = Properties.Settings.Default.seleccionado1;
            textBox2.Text = Properties.Settings.Default.seleccionado2;
            textBox3.Text = Properties.Settings.Default.seleccionado3;
            textBox4.Text = Properties.Settings.Default.seleccionado4;



            if (Properties.Settings.Default.autoinicio==false)
            {
                button6.Text = "Autoinicio desactivado";
            }
            else
            {
                button6.Text = "Autoinicio activado";
            }



            if (Properties.Settings.Default.activado1 == true)
            {
                button1.Text = "Desactivar";
                textBox1.BackColor = Color.White;

            }
            else
            {
                button1.Text = "Activar";
                textBox1.BackColor = Color.Red;
            }

            if (Properties.Settings.Default.activado3 == true)
            {
                button2.Text = "Desactivar";
                textBox3.BackColor = Color.White;

            }
            else
            {
                button2.Text = "Activar";
                textBox3.BackColor = Color.Red;
            }

            if (Properties.Settings.Default.activado2 == true)
               
                {
                    button4.Text = "Desactivar";
                textBox2.BackColor = Color.White;

            }
                else
                {
                    button4.Text = "Activar";
                textBox2.BackColor = Color.Red;
            }

            if (Properties.Settings.Default.activado4 == true)
            {
                button3.Text = "Desactivar";
                textBox4.BackColor = Color.White;

            }
            else
            {
                button3.Text = "Activar";
                textBox4.BackColor = Color.Red;
            }
        }

        // Timer que muestra la hora en la barra de titulo...   ████████████████████████
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Esquinas utiles" + "    " + DateTime.Now.ToString();
        }


        //Al cerrar el form paso la variable de Form1 que indica que Form2 esta abierto a false   ████████████████████████
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            Form1.abierto = false;
            
        }


        //Boton Acerca de...    ████████████████████████
        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == false)
            {
                richTextBox1.Visible = true;
            }
            else
            {
                richTextBox1.Visible = false;
            }
        }



        //Botones para Activar o Desactivar cada esquina      ████████████████████████
        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.activado1 == true)
            {
                Properties.Settings.Default.activado1 = false;
                Properties.Settings.Default.Save();
                button1.Text = "Activar";
                textBox1.BackColor = Color.Red;

            }
            else
            {
                Properties.Settings.Default.activado1 = true;
                Properties.Settings.Default.Save();
                button1.Text = "Desactivar";
                textBox1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.activado3 == true)
            {
                Properties.Settings.Default.activado3 = false;
                Properties.Settings.Default.Save();
                button2.Text = "Activar";
                textBox3.BackColor = Color.Red;

            }
            else
            {
                Properties.Settings.Default.activado3 = true;
                Properties.Settings.Default.Save();
                button2.Text = "Desactivar";
                textBox3.BackColor = Color.White;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.activado2 == true)
            {
                Properties.Settings.Default.activado2 = false;
                Properties.Settings.Default.Save();
                button4.Text = "Activar";
                textBox2.BackColor = Color.Red;

            }
            else
            {
                Properties.Settings.Default.activado2 = true;
                Properties.Settings.Default.Save();
                button4.Text = "Desactivar";
                textBox2.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.activado4 == true)
            {
                Properties.Settings.Default.activado4 = false;
                Properties.Settings.Default.Save();
                button3.Text = "Activar";
                textBox4.BackColor = Color.Red;

            }
            else
            {
                Properties.Settings.Default.activado4 = true;
                Properties.Settings.Default.Save();
                button3.Text = "Desactivar";
                textBox4.BackColor = Color.White;
            }
        }




        //Eleccion de la accion en cada esquina... ████████████████████████
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                
                Properties.Settings.Default.ejecuta1 = "calc";
                Properties.Settings.Default.parametro1 = "";
                Properties.Settings.Default.seleccionado1 = "Calculadora";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            if (listBox1.SelectedIndex == 1)
            {

                Properties.Settings.Default.ejecuta1 = "CMD";
                Properties.Settings.Default.parametro1 = "";
                Properties.Settings.Default.seleccionado1 = "CMD";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            if (listBox1.SelectedIndex == 2)
            {

                Properties.Settings.Default.ejecuta1 = "notepad";
                Properties.Settings.Default.parametro1 = "";
                Properties.Settings.Default.seleccionado1 = "Bloc de notas";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            if (listBox1.SelectedIndex == 3)
            {

                Properties.Settings.Default.ejecuta1 = "explorer";
                Properties.Settings.Default.parametro1 = "";
                Properties.Settings.Default.seleccionado1 = "Explorador de archivos";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            if (listBox1.SelectedIndex == 4)
            {

                Properties.Settings.Default.ejecuta1 = "explorer";
                Properties.Settings.Default.parametro1 = "http://";
                Properties.Settings.Default.seleccionado1 = "Navegador de internet";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            if (listBox1.SelectedIndex == 5)
            {

                Properties.Settings.Default.ejecuta1 = "taskmgr";
                Properties.Settings.Default.parametro1 = "";
                Properties.Settings.Default.seleccionado1 = "Administrador de Tareas";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            if (listBox1.SelectedIndex == 6)
            {

                Properties.Settings.Default.ejecuta1 = "rundll32.exe";
                Properties.Settings.Default.parametro1 = " user32.dll,LockWorkStation";
                Properties.Settings.Default.seleccionado1 = "Bloquear equipo";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            if (listBox1.SelectedIndex == 7)
            {

                Properties.Settings.Default.ejecuta1 = "mspaint";
                Properties.Settings.Default.parametro1 = "";
                Properties.Settings.Default.seleccionado1 = "Paint";
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
            
            if (listBox1.SelectedIndex==8)
            { 
                openFileDialog1.ShowDialog();
                Properties.Settings.Default.ejecuta1 = openFileDialog1.FileName;
                Properties.Settings.Default.parametro1 = "";
                Properties.Settings.Default.seleccionado1 = Properties.Settings.Default.ejecuta1;
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.seleccionado1;
            }
        }
        // ████████████████████████ 
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
            {

                Properties.Settings.Default.ejecuta2 = "calc";
                Properties.Settings.Default.parametro2 = "";
                Properties.Settings.Default.seleccionado2 = "Calculadora";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
            if (listBox2.SelectedIndex == 1)
            {

                Properties.Settings.Default.ejecuta2 = "CMD";
                Properties.Settings.Default.parametro2 = "";
                Properties.Settings.Default.seleccionado2 = "CMD";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
            if (listBox2.SelectedIndex == 2)
            {

                Properties.Settings.Default.ejecuta2 = "notepad";
                Properties.Settings.Default.parametro2 = "";
                Properties.Settings.Default.seleccionado2 = "Blok de notas";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
            if (listBox2.SelectedIndex == 3)
            {

                Properties.Settings.Default.ejecuta2 = "explorer";
                Properties.Settings.Default.parametro2 = "";
                Properties.Settings.Default.seleccionado2 = "Explorador de archivos";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
            if (listBox2.SelectedIndex == 4)
            {

                Properties.Settings.Default.ejecuta2 = "explorer";
                Properties.Settings.Default.parametro2 = "http://";
                Properties.Settings.Default.seleccionado2 = "Navegador de internet";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
            if (listBox2.SelectedIndex == 5)
            {

                Properties.Settings.Default.ejecuta2 = "taskmgr";
                Properties.Settings.Default.parametro2 = "";
                Properties.Settings.Default.seleccionado2 = "Gestor de tareas";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
            if (listBox2.SelectedIndex == 6)
            {

                Properties.Settings.Default.ejecuta2 = "rundll32.exe";
                Properties.Settings.Default.parametro2 = " user32.dll,LockWorkStation";
                Properties.Settings.Default.seleccionado2 = "Bloquear equipo";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
            if (listBox2.SelectedIndex == 7)
            {

                Properties.Settings.Default.ejecuta2 = "mspaint";
                Properties.Settings.Default.parametro2 = "";
                Properties.Settings.Default.seleccionado2 = "Paint";
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }

            if (listBox2.SelectedIndex == 8)
            {
                openFileDialog1.ShowDialog();
                Properties.Settings.Default.ejecuta2 = openFileDialog1.FileName;
                Properties.Settings.Default.parametro2 = "";
                Properties.Settings.Default.seleccionado2 = Properties.Settings.Default.ejecuta2;
                Properties.Settings.Default.Save();
                textBox2.Text = Properties.Settings.Default.seleccionado2;
            }
        }
        // ████████████████████████
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
            {

                Properties.Settings.Default.ejecuta3 = "calc";
                Properties.Settings.Default.parametro3 = "";
                Properties.Settings.Default.seleccionado3 = "Calculadora";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }
            if (listBox3.SelectedIndex == 1)
            {

                Properties.Settings.Default.ejecuta3 = "CMD";
                Properties.Settings.Default.parametro3 = "";
                Properties.Settings.Default.seleccionado3 = "CMD";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }
            if (listBox3.SelectedIndex == 2)
            {

                Properties.Settings.Default.ejecuta3 = "notepad";
                Properties.Settings.Default.parametro3 = "";
                Properties.Settings.Default.seleccionado3 = "Blok de notas";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }
            if (listBox3.SelectedIndex == 3)
            {

                Properties.Settings.Default.ejecuta3 = "explorer";
                Properties.Settings.Default.parametro3 = "";
                Properties.Settings.Default.seleccionado3 = "Explorador de archivos";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }
            if (listBox3.SelectedIndex == 4)
            {

                Properties.Settings.Default.ejecuta3 = "explorer";
                Properties.Settings.Default.parametro3 = "http://";
                Properties.Settings.Default.seleccionado3 = "Navegador de internet";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }
            if (listBox3.SelectedIndex == 5)
            {

                Properties.Settings.Default.ejecuta3 = "taskmgr";
                Properties.Settings.Default.parametro3 = "";
                Properties.Settings.Default.seleccionado3 = "Calculadora";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }
            if (listBox3.SelectedIndex == 6)
            {

                Properties.Settings.Default.ejecuta3 = "rundll32.exe";
                Properties.Settings.Default.parametro3 = " user32.dll,LockWorkStation";
                Properties.Settings.Default.seleccionado3 = "Bloquear equipo";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }
            if (listBox3.SelectedIndex == 7)
            {

                Properties.Settings.Default.ejecuta3 = "mspaint";
                Properties.Settings.Default.parametro3 = "";
                Properties.Settings.Default.seleccionado3 = "paint";
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }

            if (listBox3.SelectedIndex == 8)
            {
                openFileDialog1.ShowDialog();
                Properties.Settings.Default.ejecuta3 = openFileDialog1.FileName;
                Properties.Settings.Default.parametro3 = "";
                Properties.Settings.Default.seleccionado3 = Properties.Settings.Default.ejecuta3;
                Properties.Settings.Default.Save();
                textBox3.Text = Properties.Settings.Default.seleccionado3;
            }

        }
        //████████████████████████
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex == 0)
            {

                Properties.Settings.Default.ejecuta4 = "calc";
                Properties.Settings.Default.parametro4 = "";
                Properties.Settings.Default.seleccionado4 = "Calculadora";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }
            if (listBox4.SelectedIndex == 1)
            {

                Properties.Settings.Default.ejecuta4 = "CMD";
                Properties.Settings.Default.parametro4 = "";
                Properties.Settings.Default.seleccionado4 = "CMD";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }
            if (listBox4.SelectedIndex == 2)
            {

                Properties.Settings.Default.ejecuta4 = "notepad";
                Properties.Settings.Default.parametro4 = "";
                Properties.Settings.Default.seleccionado4 = "Blok de notas";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }
            if (listBox4.SelectedIndex == 3)
            {

                Properties.Settings.Default.ejecuta4 = "explorer";
                Properties.Settings.Default.parametro4 = "";
                Properties.Settings.Default.seleccionado4 = "Explorador de archivos";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }
            if (listBox4.SelectedIndex == 4)
            {

                Properties.Settings.Default.ejecuta4 = "explorer";
                Properties.Settings.Default.parametro4 = "http://";
                Properties.Settings.Default.seleccionado4 = "Navegador de internet";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }
            if (listBox4.SelectedIndex == 5)
            {

                Properties.Settings.Default.ejecuta4 = "taskmgr";
                Properties.Settings.Default.parametro4 = "";
                Properties.Settings.Default.seleccionado4 = "Gestor de tareas";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }
            if (listBox4.SelectedIndex == 6)
            {

                Properties.Settings.Default.ejecuta4 = "rundll32.exe";
                Properties.Settings.Default.parametro4 = " user32.dll,LockWorkStation";
                Properties.Settings.Default.seleccionado4 = "Bloquear equipo";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }
            if (listBox4.SelectedIndex == 7)
            {

                Properties.Settings.Default.ejecuta4 = "mspaint";
                Properties.Settings.Default.parametro4 = "";
                Properties.Settings.Default.seleccionado4 = "Paint";
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }

            if (listBox4.SelectedIndex == 8)
            {
                openFileDialog1.ShowDialog();
                Properties.Settings.Default.ejecuta4 = openFileDialog1.FileName;
                Properties.Settings.Default.parametro4 = "";
                Properties.Settings.Default.seleccionado4 = Properties.Settings.Default.ejecuta4;
                Properties.Settings.Default.Save();
                textBox4.Text = Properties.Settings.Default.seleccionado4;
            }

        }
        //████████████████████████

        //Activar o desactivar el inicio con windows.    ████████████████████████
        private void button6_Click(object sender, EventArgs e)
        {
            
            RegistryKey rk2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            if (Properties.Settings.Default.autoinicio == false)
            {
                
                    
                rk2.SetValue("EsquinasUtiles",Application.ExecutablePath.ToString());
                Properties.Settings.Default.autoinicio = true;
                Properties.Settings.Default.Save();
                button6.Text = "Autoinicio activado";
                
            }
            else
            {

                rk2.SetValue("EsquinasUtiles","");
                Properties.Settings.Default.autoinicio = false;
                Properties.Settings.Default.Save();
                button6.Text = "Autoinicio desactivado";
                
            }
            rk2.Dispose();
        }
    }
}
