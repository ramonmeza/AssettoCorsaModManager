﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace AssettoCorsaModManager
{
    public partial class ModManager : Form
    {
        private string SaveFileName = "settings.sav";
        private string ModCarsDirectory = "Mods\\Cars\\";
        private string ModTracksDirectory = "Mods\\Tracks\\";

        public ModManager()
        {
            InitializeComponent();
        }

        private void ModManager_Load(object sender, EventArgs e)
        {
            // If save file exists
            if (System.IO.File.Exists(SaveFileName))
            {
                // Open save file
                System.IO.StreamReader file = new System.IO.StreamReader(SaveFileName);

                // Read save file
                string[] settings = (file.ReadToEnd()).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                // Set MainDirectory text
                lbl_MainDirectory.Text = System.IO.Directory.Exists(settings[1]) ? settings[1] : "Not set";

                // Set the enabled lists
                // Get the cars index
                int index = 3;
                while (settings[index] != "[tracks]")
                {
                    // Add cars that are enabled to cars enabled list
                    list_CarsEnabled.Items.Add(settings[index]);
                    index++;
                }

                // Get the tracks index
                index++;
                for(; index < settings.Length; index++)
                {
                    // Add cars that are enabled to cars enabled list
                    list_TracksEnabled.Items.Add(settings[index]);
                }

                // Close save file
                file.Close();

                // Update disabled checkbox lists
                UpdateDisabledList(list_CarsDisabled, ModCarsDirectory, 10);
                UpdateDisabledList(list_TracksDisabled, ModTracksDirectory, 12);
            }
        }

        private void UpdateDisabledList(CheckedListBox obj, string directory, int substring)
        {
            // Get car mods directory
            string[] subdirs = System.IO.Directory.GetDirectories(directory);

            // Get list
            CheckedListBox.ObjectCollection items = obj.Items;

            // Look for subdirectories
            foreach (string dir in subdirs)
            {
                // Add car to list
                items.Add(dir.Substring(substring));
            }
        }

        private void ModManager_FormClosing(object sender, EventArgs e)
        {
            // Create data to save
            string SaveFileLines = "[ac directory]\r\n";
            SaveFileLines += lbl_MainDirectory.Text + "\r\n";

            // For each item in enabled car list
            SaveFileLines += "[cars]\r\n";
            foreach (object item in list_CarsEnabled.Items)
            {
                // Add to save data
                SaveFileLines += item.ToString() + "\r\n";
            }

            // For each item in enabled track list
            SaveFileLines += "[tracks]\r\n";
            foreach (object item in list_TracksEnabled.Items)
            {
                // Add to save data
                SaveFileLines += item.ToString() + "\r\n";
            }

            // Load save file
            System.IO.StreamWriter file = new System.IO.StreamWriter(SaveFileName);

            // Write settings to save file
            file.WriteLine(SaveFileLines);

            // Close save file
            file.Close();
        }

        private void btn_MainDirectory_Click(object sender, EventArgs e)
        {
            // Make sure you have selected the correct directory
            while (!System.IO.File.Exists(this.lbl_MainDirectory.Text + "\\AssettoCorsa.exe")) 
            {
                // Open folder dialog
                if (dialog_MainDirectory.ShowDialog() == DialogResult.OK && System.IO.File.Exists(dialog_MainDirectory.SelectedPath + "\\AssettoCorsa.exe"))
                {
                    // Change text
                    this.lbl_MainDirectory.Text = dialog_MainDirectory.SelectedPath;
                }
            }
        }

        private void btn_Enable_Click(object sender, EventArgs e)
        {
            // Check if main directory is set
            if (lbl_MainDirectory.Text != "Not Set" && System.IO.Directory.Exists(lbl_MainDirectory.Text))
            {
                // For each checked box in disabled car list
                foreach (var item in list_CarsDisabled.CheckedItems.OfType<string>().ToList())
                {
                    // Add the item to cars enabled list
                    list_CarsEnabled.Items.Add(item);

                    // Remove item from cars disabled list
                    list_CarsDisabled.Items.Remove(item);

                    // Physically move folder
                    // System.IO.Directory.Move(ModCarsDirectory + item, lbl_MainDirectory.Text + "\\content\\cars\\" + item);
                    FileSystem.MoveDirectory(ModCarsDirectory + item, lbl_MainDirectory.Text + "\\content\\cars\\" + item, UIOption.AllDialogs);
                }

                // For each checked box in disabled track list
                foreach (var item in list_TracksDisabled.CheckedItems.OfType<string>().ToList())
                {
                    // Add the item to cars enabled list
                    list_TracksEnabled.Items.Add(item);

                    // Remove item from cars disabled list
                    list_TracksDisabled.Items.Remove(item);

                    // Physically move folder
                    // System.IO.Directory.Move(ModTracksDirectory + item, lbl_MainDirectory.Text + "\\content\\tracks\\" + item);
                    FileSystem.MoveDirectory(ModTracksDirectory + item, lbl_MainDirectory.Text + "\\content\\tracks\\" + item, UIOption.AllDialogs);
                }
            } else
            {
                MessageBox.Show("Please select the Assetto Corsa main directory.", "Main Directory Not Set!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Disable_Click(object sender, EventArgs e)
        {
            // Check if main directory is set
            if (lbl_MainDirectory.Text != "Not Set" && System.IO.Directory.Exists(lbl_MainDirectory.Text))
            {
                // For each checked box in enabled car list
                foreach (var item in list_CarsEnabled.CheckedItems.OfType<string>().ToList())
                {
                    // Add the item to cars disabled list
                    list_CarsDisabled.Items.Add(item);

                    // Remove item from cars enabled list
                    list_CarsEnabled.Items.Remove(item);

                    // Physically move folder
                    // System.IO.Directory.Move(lbl_MainDirectory.Text + "\\content\\cars\\" + item, ModCarsDirectory + item);
                    FileSystem.MoveDirectory(lbl_MainDirectory.Text + "\\content\\cars\\" + item, ModCarsDirectory + item, UIOption.AllDialogs);
                }

                // For each checked box in enabled track list
                foreach (var item in list_TracksEnabled.CheckedItems.OfType<string>().ToList())
                {
                    // Add the item to cars disabled list
                    list_TracksDisabled.Items.Add(item);

                    // Remove item from cars enabled list
                    list_TracksEnabled.Items.Remove(item);

                    // Physically move folder
                    // System.IO.Directory.Move(lbl_MainDirectory.Text + "\\content\\tracks\\" + item, ModTracksDirectory + item);
                    FileSystem.MoveDirectory(lbl_MainDirectory.Text + "\\content\\tracks\\" + item, ModTracksDirectory + item, UIOption.AllDialogs);
                }
            }
            else
            {
                MessageBox.Show("Please select the Assetto Corsa main directory.", "Main Directory Not Set!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Menu options
        // About
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assetto Corsa Mod Manager v0.1\r\nMade by Ramon M.");
        }

        // How to use
        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open to Github How to Use section
            System.Diagnostics.Process.Start("https://github.com/ramonmeza/AssettoCorsaModManager#howtouse");
        }
        // View source code
        private void viewSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open to Github repo
            System.Diagnostics.Process.Start("https://github.com/ramonmeza/AssettoCorsaModManager");
        }

        // Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}