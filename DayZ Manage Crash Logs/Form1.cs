using System;
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
        private string _dayZAppDataPath = string.Empty;
       // public string[] extensions = { ".log", ".MDMP", ".RPT" };
        
        private readonly string[] extensions = { ".log", ".MDMP", ".RPT" };

        public Form1()
        {
            InitializeComponent();
          
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                                                               Primary.Blue600,
                                                               Primary.Blue700,
                                                               Primary.Blue200,
                                                               Accent.LightBlue200,
                                                               TextShade.WHITE);
           
        }

        public void PopulateListbox(IEnumerable<FileInfo> files)
        {
            lstCrashLogs.Items.Clear();
            foreach(FileInfo file in files)
            {
                lstCrashLogs.Items.Add(file);
            }

        }

        private void RefreshFileList() 
        {
            var dir = new DirectoryInfo(_dayZAppDataPath);
            var files = dir.GetFiles().OrderBy(file => file.Extension);

            PopulateListbox(files);
            UpdateStatistics();
        }

        public List<FileInfo> GetCrashLogFiles(params string[] extension)
        {
            List<FileInfo> list = new List<FileInfo>();

            
            if (extension.Length > 0)
            {
                if (!string.IsNullOrEmpty(_dayZAppDataPath))
                {
                    foreach (string ext in extension)
                        list.AddRange(new DirectoryInfo(_dayZAppDataPath)
                           .GetFiles("*" + ext).Where(p => p.Extension.Equals(ext, StringComparison.CurrentCultureIgnoreCase))
                           .ToArray());
                }
                
            
            }

                return list;

        }

       

        private void btnLocateLogs_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            FileInfo[] files = new FileInfo[1];


            lstCrashLogs.Items.Clear();
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            _dayZAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"DayZ");

            txtDayZPath.Text = _dayZAppDataPath;


            try
            {
                RefreshFileList();
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
            
            List<FileInfo> list = GetCrashLogFiles(extensions);
            if (list.Count > 0)
            {

                
                foreach (var item in list)
                    File.Delete(item.FullName);


                //var dir = new DirectoryInfo(_dayZAppDataPath);
                //var files = dir.GetFiles();
                //var sortedList = files.OrderBy(f => Path.GetExtension(f.ToString()));
                //PopulateListbox(sortedList);

                RefreshFileList();
                UpdateStatistics();

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

        private void UpdateStatistics() 
        {
            var crashLogs = GetCrashLogFiles(extensions);
            long totalBytes = crashLogs.Sum(file => file.Length);

            lblFileCount.Text = $"{crashLogs.Count} crash log {(crashLogs.Count == 1 ? "file" : "files")} found";

            lblDiskSpace.Text = $"Recoverable space: {FormatFileSize(totalBytes)}";
        }

        private static string FormatFileSize(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };

            double size = bytes;
            int order = 0;

            while (size >= 1024 && order < suffixes.Length - 1)
            {
                order++;
                size /= 1024;
            }

            return $"{size:0.##} {suffixes[order]}";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
