﻿/*
  ChangeLog Generator File
  This file is published under Strayker Free Software License v1.0
  Copyright 2019 Daniel Strayker Nowak
  All rights reserved by Copyright and this license
*/

using System;
// using System.Diagnostics;
using System.Windows.Forms;

namespace ChangeLog_Generator
{
    public partial class main : Form
    {
        string lang;

        public main()
        {
            InitializeComponent();
            var a = new Language();
            lang = a.Lang_get();
            
            if(lang == "en")
            {
                button1.Text = "Generate file";
                button3.Text = "Documentation";
                button4.Text = "Informations about app";
            }
            else if(lang == "pl")
            {
                button1.Text = "Generuj plik";
                button3.Text = "Dokomentacja";
                button4.Text = "Informacje o programie";
            }
        }

        public void button3_Click(object sender, EventArgs e) // Documentation button:
        {
            // Process.Start("http://www.strayker.cba.pl/docs/docs.html"); Webpage under mainteinance!
        }

        public void button4_Click(object sender, EventArgs e) // Informations about app button:
        {
            // Opens app's info screen:
            Form info = new info();
            info.Show();
        }

        public void button1_Click(object sender, EventArgs e) // New file button:
        {
            // Configures and shows dialog box for choosing directory, text in dialog,
            if (lang == "en")
            {
                folderBrowserDialog1.Description = "Choose directory to create file in:";
            }
            else if(lang == "pl")
            {
                folderBrowserDialog1.Description = "Wybierz ścieżkę, gdzie ma być wygenerowany plik";
            }

            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) // Checks, what was pressed,
            {
                if(folderBrowserDialog1.SelectedPath != null)
                { //If dialog box returned directory:
                    //Open creator window,
                    Form edit = new edit(folderBrowserDialog1.SelectedPath);
                    edit.Show();
                    Hide();
                }
            }
        }
    }
}
