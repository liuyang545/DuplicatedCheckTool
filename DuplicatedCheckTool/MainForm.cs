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

namespace DuplicatedCheckTool
{
    public partial class MainForm : Form
    {
        #region Init
        private string[] ExcludePaths = new string[] { @"C:\", @"D:\", @"E:\", @"F:\", @"Z:\" };
        private static List<string> FileList = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbOne.SelectedIndex = cmbOne.FindString( @"Z:\");
            SetCkbListSelected();
        }
        #endregion


        #region Click
        //Compare duplicate files from one disk with other disks.
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (cmbOne.SelectedItem == null)
                MessageBox.Show("Please select a disk from the Combox One!");
            lbResult.Items.Clear();
            var path = cmbOne.SelectedItem.ToString();
            var ckItems = cklDisk.CheckedItems;

            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                foreach(var f in directory.GetFiles())
                {
                    if (FileList.Exists(l => l == f.Name))
                        lbResult.Items.Add(f.FullName);
                }
            }
            else
                MessageBox.Show("The Path is not Exist! -- " + path);
        }

        //Compare duplicate files from one disk with each other.
        private void btnAll_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
            var dicFiles = new Dictionary<string, string>();
            var path = string.Empty;
            var fName = string.Empty;

            //Path
            foreach(var ckb in cklDisk.CheckedItems)
            {
                path = cklDisk.GetItemText(ckb);
                path = path.Substring(0, path.IndexOf("--"));
                if (Directory.Exists(path))
                {
                    //Files
                    var files = Directory.GetFiles(path, "*.plot");
                    foreach(var f in files)
                    {
                        fName = f.Replace(path, string.Empty);
                        if (dicFiles.ContainsKey(fName))
                        {
                            lbResult.Items.Add(f);
                            lbResult.Items.Add(dicFiles[fName] + fName);
                        }
                        else
                        {
                            dicFiles.Add(fName, path);
                            lbResult.Items.Add(fName);
                        }
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileList.Clear();
            cklDisk.Items.Clear();

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            var text = string.Empty;
            foreach (var drive in allDrives)
            {
                if (ExcludePaths.Contains(drive.Name))
                    continue;

                if (drive.IsReady)
                    text = string.Format("{0}--{1}--{2}", drive.Name, drive.DriveType, drive.AvailableFreeSpace / 1024 / 1024 / 1024);
                else
                    text = string.Format("{0}--{1}", drive.Name, drive.DriveType); //GB

                LoadFileNames(drive.Name);
                cklDisk.Items.Add(text, true);
            }
            lkFileCount.Text = FileList.Count.ToString();
        }
        #endregion


        #region Private methods

        private void SetCkbListSelected()
        {
            var count = cklDisk.Items.Count;
            for (int i= 0; i< count - 1;i ++)
            {
                cklDisk.SetItemChecked(i, true);
            }
        }

        private void LoadFileNames(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            var files = directory.GetFiles();
            foreach(var f in files)
            {
                if (!f.Attributes.HasFlag(FileAttributes.Hidden))
                    FileList.Add(f.Name);
            }
        }

        #endregion

    }
}
