using System;
using System.IO;
namespace Learn
{
    public class FileOperation
    {
        public FileOperation()
        {
        }

        public static void MyMain()
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/zhengyuh/");
            Console.WriteLine(directory.Attributes.ToString());
            FileInfo[] files = directory.GetFiles("*");
            foreach (FileInfo file in files) {
                Console.WriteLine(file.Name);
            }

            string path = Path.Combine(directory.Name, "SubFolder");
            Directory.CreateDirectory(path);
            string fileName = Path.GetRandomFileName();
            string filePath = Path.Combine(path, fileName);
            if (!File.Exists(filePath)) {
                using (System.IO.FileStream fs = System.IO.File.Create((filePath))) {
                    for (byte i = 0; i < 100; i++) {
                        fs.WriteByte(i);
                    }
                }
            }

            byte[] readBuffer = File.ReadAllBytes(filePath);
            foreach(byte i in readBuffer) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
