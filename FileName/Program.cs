using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileName
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Environment.CurrentDirectory + @"\N";

            var dirinfo = new DirectoryInfo(filePath);
            FileInfo[] fileInfos = dirinfo.GetFiles();
            string oldFileName = "";
            string newFileName = "";
            foreach (FileInfo f in fileInfos)
            {
                oldFileName = f.Name;
                if (oldFileName.Contains(".jpg"))
                {
                    newFileName = Regex.Replace(oldFileName, @"\d", string.Empty);
                    Console.WriteLine(" oldFileName:{0},newFileName={1}", oldFileName, newFileName);
                    File.Move(filePath + @"\" + oldFileName, filePath + @"\" + newFileName);
                }

            }

        }
    }

}
