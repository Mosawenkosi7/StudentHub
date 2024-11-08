using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHub
{
    internal class FileHandler
    {
        string txtFile = "student.txt";
        public List<string> rawData = new List<string>();
        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader(txtFile))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                   rawData.Add(line);
                }
            }
          
        }

        public void WriteFile(string studentId, string name, int age, string course)
        {
            using (FileStream fs = new FileStream(txtFile, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    string student = studentId + "," + name + "," + age + "," + course;
                    writer.WriteLine(student);
                }
            }
        }
    }
}
