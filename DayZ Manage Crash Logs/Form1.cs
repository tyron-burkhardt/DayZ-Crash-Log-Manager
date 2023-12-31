﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DayZ_Manage_Crash_Logs
{
    public partial class Form1 : MaterialForm
    {
        public string DayZAppDataPath = string.Empty;
        public string[] extensions = { ".log", ".MDMP", ".RPT" };
        public Form1()
        {
            InitializeComponent();
          
            var materialSKinManager = MaterialSkinManager.Instance;
            materialSKinManager.AddFormToManage(this);
            materialSKinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSKinManager.ColorScheme = new ColorScheme(Primary.Red700, 
                                                             Primary.Red400, 
                                                             Primary.Amber100, 
                                                             Accent.Blue200,
                                                             TextShade.WHITE) ;
                                                             





        }


        public DirectoryInfo GetInfo()
        {
            DirectoryInfo place = new DirectoryInfo(DayZAppDataPath);
            return place;
        }

        public void PopulateListbox(IOrderedEnumerable<FileInfo> files)
        {
            listbox_targetfiles.Items.Clear();
            foreach(FileInfo file in files)
            {
                listbox_targetfiles.Items.Add(file);
            }

        }

        public List<FileInfo> GetFilesWithExtension(params string[] extension)
        {
            List<FileInfo> list = new List<FileInfo>();

            
            if (extension.Length > 0)
            {
                if (!string.IsNullOrEmpty(DayZAppDataPath))
                {
                    foreach (string ext in extension)
                        list.AddRange(new DirectoryInfo(DayZAppDataPath)
                           .GetFiles("*" + ext).Where(p => p.Extension.Equals(ext, StringComparison.CurrentCultureIgnoreCase))
                           .ToArray());
                }
                
            
            }

                return list;

        }

       

        private void btn_browse_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            FileInfo[] files = new FileInfo[1];


            listbox_targetfiles.Items.Clear();
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

               
            
                DayZAppDataPath = localAppDataPath + "\\DayZ";

                txtbox_browsetarget.Text = DayZAppDataPath;

                DirectoryInfo dir = GetInfo();

            try
            {
               files = dir.GetFiles();

                var sortedList = files.OrderBy(f => Path.GetExtension(f.ToString()));

                PopulateListbox(sortedList);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! No DayZ folder could be found in " + localAppDataPath.ToString() + " folder. Please ensure that the game is installed.", "DayZ Folder Not Found",
                MessageBoxButtons.OK,
               MessageBoxIcon.Warning);

                
            }
               

            
        }

        private void btn_deletelogfiles_Click_1(object sender, EventArgs e)
        {
            
            List<FileInfo> list = GetFilesWithExtension(extensions);
            if (list.Count > 0)
            {

                // string[] dir_files = Directory.GetFiles(DayZAppDataPath,".log");
                foreach (var item in list)
                    File.Delete(item.FullName);

                DirectoryInfo place = GetInfo();
                FileInfo[] files = place.GetFiles();
                var sortedList = files.OrderBy(f => Path.GetExtension(f.ToString()));
                PopulateListbox(sortedList);

                MessageBox.Show("Successfully deleted all log files.", "Success!",
                   MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There are no log files to be deleted.", "No action needed.",
                   MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
