using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanAndreasCheats
{
    class Python
    {

        public bool StorageAvailablity(char DriveLetter, long BytesSize)
        {
            DriveInfo drive = DriveInfo.GetDrives().Where(e => e.Name.Split(' ').Last()[0] == DriveLetter).ToArray()[0];

            return drive.AvailableFreeSpace > BytesSize;
        }

        public void RunPythonScript(string code, ConsoleControl.ConsoleControl control, Action finish)
        {
            string TemporaryPath = Path.GetTempPath();
            string TempFile = Path.GetRandomFileName() + ".py";
            string TempFilePath = Path.Combine(TemporaryPath, TempFile);

            byte[] Data = Encoding.UTF8.GetBytes(code);

            if (!StorageAvailablity(TemporaryPath[0], Data.Length))
            {
                MessageBox.Show("Not enough space on storage media!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.WriteAllBytes(TempFilePath, Data); 
            Task.Run(() =>
            {
                control.StartProcess("python.exe", TempFilePath);
                while (control.ProcessInterface.IsProcessRunning);
                finish();
            });

        }
    }
}
