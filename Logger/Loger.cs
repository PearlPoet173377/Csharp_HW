using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Loger
{
    class Loger
    {
        private string log;

        private string config;

        private string mode;
        public Loger() { }
        public Loger(string log, string config)
        {
            this.log = log;
            this.config = config;
            FileInfo finfo = new FileInfo(log);
            using (FileStream fs = finfo.Open(FileMode.OpenOrCreate))
            {

            };

            using (StreamWriter writer = File.AppendText(log))
            {
                writer.WriteLine($"Log file create at {DateTime.Now}");
            }


            using (StreamReader reader = File.OpenText(this.config))
            {
                mode = reader.ReadLine();
            }
        }

        public void CreateLog(string mesType, string uName, string message) //write method
        {
            if (mode == "Base")
            {

                using (StreamWriter writer = File.AppendText(log))
                {
                    writer.WriteLine($"|Время записи: {DateTime.Now}||Тип: {mesType}|");
                }

            }
            else if (mode == "Mid")
            {
                using (StreamWriter writer = File.AppendText(log))
                {
                    writer.WriteLine($"|Время записи: {DateTime.Now}||Тип: {mesType}||Пользователь: {uName}|");
                }
            }
            else if (mode == "Full")
            {
                using (StreamWriter writer = File.AppendText(log))
                {
                    writer.WriteLine($"|Время записи: {DateTime.Now}||Тип: {mesType}||Пользователь: {uName}|| Текст: {message}|");
                }
            }
            else
            {
                WriteLine("Ошибка конфигурационного файла");
            }
        }
        public void GetLogs() //read method
        {

            foreach (string i in File.ReadAllLines(log))
            {
                WriteLine(i);
            }
        }

    }
}