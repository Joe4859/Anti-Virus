using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace HoundAV
{
    class MyProcess
    {
        public static void Main()
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = @"C:\Program Files (x86)\WABZ\KDT Web History Tracker\";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    // This code assumes the process you are starting will terminate itself.
                    // Given that it is started without a window so you cannot terminate it
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                    System.Diagnostics.Process.Start(@"C:\Users\Joe\Documents\Whitelist.docx");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
