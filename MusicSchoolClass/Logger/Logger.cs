
using System;
using System.IO;
using System.Text;
using System.Windows;


namespace MusicSchoolClass.Logger
{
    public class Logger
    {
        public AlertMode alertMode { get; set; }
        public LogMode logMode { get; set; }

        #region Constructor
        public Logger()
        {
        }

        public Logger(LogMode logMode, AlertMode alertMode)
        {
            this.logMode = logMode;
            this.alertMode = alertMode;
        }
        #endregion

        public void log(String toLog, String msg = null, String userDirectory = null)
        {
            if (msg == null)
            {
                msg = toLog;
            }
            if (userDirectory == null)
            {
                userDirectory = Path.GetTempPath() + "\\" + AppDomain.CurrentDomain.ToString().Split('.')[0];
            }

            switch (this.logMode)
            {
                case LogMode.NONE:
                    break;
                case LogMode.CONSOLE:
                    Console.WriteLine(toLog);
                    break;
                case LogMode.EXTERNAL:
                    Directory.CreateDirectory(userDirectory);
                    TextWriter file2 = new StreamWriter(userDirectory + "\\current_logs", true, UTF8Encoding.UTF8);
                    file2.WriteLine(toLog);
                    file2.Close();
                    break;
                case LogMode.CURRENT_FOLDER:
                    TextWriter file = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\current_logs", true, UTF8Encoding.UTF8);
                    file.WriteLine(toLog);
                    file.Close();
                    break;
                case LogMode.TEMP_FOLDER:
                    String directory = Path.GetTempPath() + "\\" + AppDomain.CurrentDomain.ToString().Split('.')[0];
                    Directory.CreateDirectory(directory);
                    TextWriter file1 = new StreamWriter(directory + AppDomain.CurrentDomain + "\\current_logs", true, UTF8Encoding.UTF8);
                    file1.WriteLine(toLog);
                    file1.Close();
                    break;

            }
        }

        public void Log(Exception toLog, String msg = null, String userDirectory = null)
        {
            if (msg == null)
            {
                msg = toLog.Message;
            }
            
        }
    }
}