﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace ActualizarFTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Cliente Web
        WebClient cliente = new WebClient();
        string ruta = "C:\\Program Files (x86)\\DBOleofinos\\DBOleofinos.exe";

        //Funtion Client

        //barra de progreso
        private void Form1_Load(object sender, EventArgs e)
        {
            //Designacion de completo y cargando
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(cargando);
            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(completo);
        }

        //Funtion
        private void cargando(object sender,DownloadProgressChangedEventArgs e)
        {
            //Calculos para el progres bar
            pbprogreso.Value = e.ProgressPercentage;
            lbprogreso.Text = pbprogreso.Value.ToString() + "%";
        }

        //Object View
        private void completo(object sender, AsyncCompletedEventArgs e)
        {
            //Cambio dinamico por la descarga en la proges bar
            pbprogreso.Value = 0;
            lbprogreso.Text = "0%";
            if (MessageBox.Show("Iniciar programa?","Sistemas Actualizado", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Ruta y cerra
                System.Diagnostics.Process.Start(ruta);
                button1.PerformClick();
            }
            else
            {
                //cerrar sin ruta ni nada
                button1.PerformClick();
            }

        }

        //Files
        private void UpdateSoft_Click(object sender, EventArgs e)
        {

            if (File.Exists(ruta))
            {
                cliente.DownloadFileAsync(new Uri(txturl.Text), ruta);
            }
            else
            {
                SaveFileDialog dialogo = new SaveFileDialog();
                dialogo.Filter = "Todos los archivos|*.*";
                dialogo.FileName = txturl.Text.Substring(txturl.Text.LastIndexOf("/") + 1);
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    ruta = dialogo.FileName;
                    cliente.DownloadFileAsync(new Uri(txturl.Text), dialogo.FileName);
                }
            }   
        }

        private void txturl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cerrar ventana
            this.Close();
        }
    }
}
