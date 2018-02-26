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

namespace FileBackUpHelper
{
    public partial class Form2 : Form
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

        Properties.Settings MySetting = new Properties.Settings();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Setting";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = (Form1)this.Owner;//把Form2的父窗口指針賦給lForm1  
            form.MySettingChange(true);

            MySetting.Save();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
