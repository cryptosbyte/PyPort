using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ScintillaNET;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanAndreasCheats
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        Python python = new Python();
        public Form1()
        {
            InitializeComponent();

            pythonInput.BorderStyle = BorderStyle.None;
            pythonInput.Styles[Style.Default].BackColor = Color.FromArgb(44, 47, 51);
            pythonInput.Styles[Style.Default].ForeColor = Color.White;
            pythonInput.Styles[Style.Default].Font = "Consolas";
            pythonInput.Styles[Style.Default].Size = 10;
            pythonInput.StyleClearAll();

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e) {}

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            console1.ResetText();

            string code = pythonInput.Text;
            RunScriptImgBtn.Enabled = false;
            python.RunPythonScript(code, console1, () =>
            {
                console1.InternalRichTextBox.AppendText("\n[Process exited]");
                RunScriptImgBtn.Enabled = true;
            });
        }
    }
}
