using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileBackUpHelper
{
    public partial class Form1 : Form
    {

        #region AeroDefine
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }
        //DLL申明
        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern void DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS
        margins);
        //DLL申明
        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern bool DwmIsCompositionEnabled();
        //直接添加代碼
        protected override void OnLoad(EventArgs e)
        {
            if (DwmIsCompositionEnabled())
            {
                MARGINS margins = new MARGINS();
                margins.Right = margins.Left = margins.Top = margins.Bottom =
                this.Width + this.Height;
                DwmExtendFrameIntoClientArea(this.Handle, ref margins);
            }
            base.OnLoad(e);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            if (DwmIsCompositionEnabled())
            {
                e.Graphics.Clear(Color.Black);
            }
        }
        #endregion

        #region Define_Variables
        public string strSourcePath;
        public string strTargetPath;
        Properties.Settings MySetting = new Properties.Settings();//Resource Define
        public bool boolWriteOrNot;
        public string BackUpTime;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Develope_Setting
            button1.Visible = false;
            button2.Visible = false;
            #endregion
            #region Interface Setting
            bool Visible = true;
                progressBar1.Visible = false;
                label1.Visible = Visible;
                label2.Visible = Visible;
            label1.Text = MySetting.SourcePath;
            label2.Text = MySetting.TargetPath;
            //WindowState = FormWindowState.Minimized;
            #endregion
            this.Text = "FileBackUpHelper";
            #region Read Setting
            this.Location = MySetting.Start_From1_Position;
            strSourcePath = MySetting.SourcePath;
            strTargetPath = MySetting.TargetPath;
            #endregion
            /*
            WatchDog.Interval = 1000;
            WatchDog.Enabled = true;
            */
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySetting.SourcePath = strSourcePath;
            MySetting.TargetPath = strTargetPath;
            MySetting.Start_From1_Position = this.Location;
            MySetting.Save();
            if (Directory.Exists(strSourcePath) && Directory.Exists(strTargetPath))
            { button2_Click(this, null); }
            
        }

        private void sourcePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderpath = new FolderBrowserDialog();
            folderpath.ShowDialog();
            strSourcePath = folderpath.SelectedPath;
            label1.Text = strSourcePath;
        }

        private void targetPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderpath = new FolderBrowserDialog();
            folderpath.ShowDialog();
            strTargetPath = folderpath.SelectedPath;
            label2.Text = strTargetPath;
        }

        private FileInfo[] GetFileList(string path)
        {
            FileInfo[] fileList = null;
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                fileList = di.GetFiles();
            }
            return fileList;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(boolWriteOrNot)
            {
                if (Directory.Exists(strSourcePath) && Directory.Exists(strTargetPath))
                {
                    CopyFiles(strSourcePath, strTargetPath);
                }
                else
                {
                    MessageBox.Show("Path Error", "Error",MessageBoxButtons.OK);
                }
            }
            else
            {
                if (Directory.Exists(strSourcePath) && Directory.Exists(strTargetPath))
                {
                    CopyFiles(strSourcePath, strTargetPath,false);
                }
                else
                {
                    MessageBox.Show("Error", "Path Error", MessageBoxButtons.OK);
                }
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(strSourcePath))
            { System.Diagnostics.Process.Start(strSourcePath); }
            else
            {
                MessageBox.Show("Source directory does not exist", "Error", MessageBoxButtons.OK);
                sourcePathToolStripMenuItem_Click(this, null);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(strTargetPath))
            { System.Diagnostics.Process.Start(strTargetPath); }
            else
            {
                MessageBox.Show("Source directory does not exist", "Error", MessageBoxButtons.OK);
                targetPathToolStripMenuItem_Click(this, null);
            }

        }

        #region FileCopy_Function
        public void CopyFiles(string remotePath, string localPath)
        {
            FileInfo[] file = GetFileList(remotePath);
            progressBar1.Visible = true;
            progressBar1.Maximum = file.Length;
            progressBar1.Value = 0;

            for (int i = 0; i < file.Length; i++)
            {
                string fileName = remotePath + @"\" + file.GetValue(i).ToString();
                string desFileName = localPath + @"\" + file.GetValue(i).ToString();
                File.Copy(fileName, desFileName, true);
                System.Threading.Thread.Sleep(10);
                progressBar1.Value++;
            }

            progressBar1.Visible = false;
        }

        public void CopyFiles(string remotePath, string localPath, bool WriteOrNot)
        {
            FileInfo[] file = GetFileList(remotePath);
            progressBar1.Visible = true;
            progressBar1.Maximum = file.Length;
            progressBar1.Value = 0;

            for (int i = 0; i < file.Length; i++)
            {
                
                string fileName = remotePath + @"\" + file.GetValue(i).ToString();
                string desFileName = localPath + @"\" + file.GetValue(i).ToString();
                if(!File.Exists(desFileName))
                    File.Copy(fileName, desFileName, WriteOrNot);
                System.Threading.Thread.Sleep(10);
                progressBar1.Value++;
            }
            progressBar1.Visible = false;
        }

        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();

            progressBar1.Maximum = files.Length;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                if(!File.Exists(temppath))
                    file.CopyTo(temppath, false);
                progressBar1.Value++;
                System.Threading.Thread.Sleep(1);
            }

            //progressBar1.Visible = false;

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
            
        }
        #endregion

        private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
            //this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryCopy(strSourcePath, strTargetPath, true);
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        private void deleteTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result=MessageBox.Show("Delete all from TargetPath?", "Hint", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(strTargetPath, true);
                    string target = strTargetPath;
                    Directory.CreateDirectory(target);
                }
                catch
                {

                }
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                
            }
        }

        public void MySettingChange(bool Change)
        {
            if(Change)
            {
                button1.Text = Change.ToString();
            }
        }

        private void WatchDog_Tick(object sender, EventArgs e)
        {
            this.Text = "FileBackUpHelper - "+ DateTime.Now.TimeOfDay;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void nowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            button2_Click(this, null);
            notifyIcon1.BalloonTipTitle = "Hint";
            notifyIcon1.BalloonTipText = "Done";
            notifyIcon1.ShowBalloonTip(2000);
            notifyIcon1.BalloonTipText = notifyIcon1.BalloonTipTitle = "";
        }

        private void nowBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nowToolStripMenuItem_Click(this, null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
