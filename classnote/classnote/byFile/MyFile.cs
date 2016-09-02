using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace classnote.myFile
{
     
    class MyFile
    {
        public string filePath = @"c:\myFile\Letter.txt";
        byte[] byteDate = new byte[1024];
        char[] charDate = new char[1024];
        public MyFile()
        {
            Create();
            WriteFile();
            ReadFile();
            NewName();
            TraverseFile(@"I:\备考库", @"c:\myFile\Letter2.txt");
        }


        public void TraverseFile(string dirPath,string listpath)
        {
            if(!Directory.Exists(@"c:\myFile"))
            {
                Console.WriteLine(dirPath+"文件夹不存在");
                return;
            }
            if (!File.Exists(listpath))
            {
                Console.WriteLine(listpath + "文件不存在");
                return;
            }
            
            StreamWriter sw = new StreamWriter(listpath, true);
            DirectoryInfo myDir = new DirectoryInfo(dirPath);
            //遍历文件
            FileInfo []fileList = myDir.GetFiles();
            sw.WriteLine("Path：" + dirPath);
            sw.WriteLine("文件名".PadRight(30) + "大小".PadRight(15) + "修改时间".PadRight(15));
            foreach (FileInfo item in fileList)
            {
                sw.WriteLine(item.Name.PadRight(20) + "\t" + item.Length.ToString().PadRight(15) + item.CreationTime.ToString().PadRight(15));
            }
            sw.Close();
            DirectoryInfo[] dirList = myDir.GetDirectories();
            foreach (DirectoryInfo item in dirList)
            {
                TraverseFile(item.FullName,listpath);
            }
            //FileStream fileStream = new FileStream(listpath, FileMode.CreateNew, FileAccess.Write, FileShare.Read);
        }

        public void Create()
        {
            try
            {
                if (!Directory.Exists(@"c:\myFile"))
                {
                    Directory.CreateDirectory(@"c:\myFile");
                }
                if (File.Exists(filePath))
                {
                    Console.WriteLine("文件已创建");
                }
                else
                {
                    FileStream fs = File.Create(filePath);
                    fs.Close();
                    Console.WriteLine("Letter.txt创建成功");
                }
            }
            catch (Exception e)
            {
            }
        }

        public void WriteFile()
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            string str = "";
            try
            {
                for (int i = 'a'; i < 'z'; i++)
                {
                    str+=(char)i;
                }
                sw.WriteLine(str);
               /* charDate['z'] = '\n';
                Encoding encoding = Encoding.UTF8;
                byteDate = encoding.GetBytes(charDate);
                fileStream.Position = fileStream.Length;
                fileStream.Write(byteDate, 0, byteDate.Length);*/
                Console.WriteLine("文件写入成功");
            }
            catch (Exception e)
            {
                Console.WriteLine("文件写入失败：" + e.ToString());
            }
            finally
            {
                sw.Close();
            }
        }
       
        public void ReadFile()
        {
            FileInfo file = new FileInfo(filePath);
            Console.WriteLine("文件大小为：{0}字节", file.Length);
            try
            {
                StreamReader reader = new StreamReader(filePath);
                /*FileStream fileStream = new FileStream(filePath, FileMode.Open);
                //搜索指定位置 从0个字节开始读
                fileStream.Seek(0, SeekOrigin.Begin);
                fileStream.Read(byteDate, 0, 10);
                fileStream.Close();*/
                Console.WriteLine("文件内容："+reader.ReadLine());
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("产生IO异常：" + e.ToString());
            }
            
           /* Decoder decoder = Encoding.UTF8.GetDecoder();
            decoder.GetChars(byteDate,0,byteDate.Length,charDate,0);
            Console.WriteLine(charDate);*/

        }
        public void NewName()
        {
            File.Copy(filePath, @"c:\myFile\New-Letter.txt", true);//拷贝文件可以覆盖
            File.Delete(filePath);
            File.Copy(@"c:\myFile\New-Letter.txt", @"c:\myFile\Copy-Letter.txt", true);
            Console.WriteLine("重命名，拷贝成功 是否删除本程序产生的文件？Y/N");
            string read=Console.ReadLine();
            if (read == "Y")
            {
                File.Delete(@"c:\myFile\New-Letter.txt");
                File.Delete(@"c:\myFile\Copy-Letter.txt");
                //Directory.Delete(@"c:\myFile");
                Console.WriteLine("文件删除完成");
            }
            else
            {
                Console.WriteLine("按任意键退出");
            }
        }
        public void Note()
        {
            FileInfo file = new FileInfo(@"c:\myFile\Letter.txt");
            Directory.Exists(@"c:\myFile");//文件夹是否存在
            File.Copy(@"", @"", true);//拷贝文件可以覆盖
            file.CopyTo(@"", true);
            File.Move(@"", @"");//文件存在报异常
            File.Delete(@"");   //删除文件
            Console.WriteLine("文件名{0}大小{1}字节\t扩展名{2}创建时间{3}所在文件夹{4}",
                file.Name,file.Length,file.Extension,file.CreationTime,file.DirectoryName);
        }
    }
}
