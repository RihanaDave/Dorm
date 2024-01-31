using System;
using System.IO;

namespace DataAccessLayer
{
    public class Logger
    {
        public Logger()
        { 
        }

        public static void DoLog(string message)
        {
            StreamWriter sw;
            if (!File.Exists("log.txt"))
            {
                sw = File.CreateText("log.txt");
                sw.WriteLine(message + " : " + DateTime.Now.ToLongTimeString());
                sw.Close();
            }
            else
            {
                sw = File.AppendText("log.txt");
                sw.WriteLine(message + " : " + DateTime.Now.ToLongTimeString());
                sw.Close();
            }
        }
    }
}

