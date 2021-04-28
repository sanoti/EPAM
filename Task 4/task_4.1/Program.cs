using System;
using System.Xml;
using System.IO;

namespace task_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HandmadeGit git = new();
            string message, time;
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("1. all files in directory");
                Console.WriteLine("2. observation mode");
                Console.WriteLine("3. rollback mode");
                Console.WriteLine("4. Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();
                        for (int i = 0; i < git.Length(); i++)
                        {
                            Console.WriteLine(i + ". " + git[i].Name);
                        }
                        break;

                    case "2":
                        Console.WriteLine();
                        for (int i = 0; i < git.Length(); i++)
                        {
                            Console.WriteLine(i + ". " + git[i].Name);
                        }
                        Console.WriteLine();

                        Console.WriteLine("Enter file number");
                        if (!int.TryParse(Console.ReadLine(), out int fileNumber) || fileNumber < 0 || fileNumber > git.Length())
                        {
                            throw new ArgumentOutOfRangeException();
                        }

                        Console.WriteLine("1. view content");
                        Console.WriteLine("2. add sentence");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine(git.Read(fileNumber));
                                continue;
                            case "2":
                                Console.Write("sentense: ");
                                message = Console.ReadLine();
                                git.Write(fileNumber, message, true);
                                git.AddChangeXML(fileNumber);
                                continue;
                        }
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Enter the rollback time(MM/DD/YYYY HH/MM/SS AM or PM)");
                        time = Console.ReadLine();
                        git.GetRollbackFiles(time);
                        break;

                    case "4":
                        isWork = false;
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
            }
        }
    }

    public class HandmadeGit
    {
        private FileInfo[] MasFile;
        private readonly string path = @"/Users/daniil/Documents/GitHub/EPAM/Task 4";
        private readonly string pathXML = @"/Users/daniil/Documents/GitHub/EPAM/Task 4/task_4.1/write.xml";

        public HandmadeGit()
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            MasFile = directory.GetFiles();
            CreateXML();
        }

        public string Read(int i)
        {
            FileStream fileStream = MasFile[i].Open(FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);

            var str = reader.ReadToEnd();
            reader.Dispose();
            return str;
        }

        public void Write(int i, string str, bool AppendOrCreate)
        {
            FileStream fileStream;
            if (AppendOrCreate)
            {
                fileStream = MasFile[i].Open(FileMode.Append);
            }
            else
            {
                fileStream = MasFile[i].Open(FileMode.Create);
            }

            StreamWriter writer = new StreamWriter(fileStream);
            using (writer)
            {
                writer.Write(str);
            }
        }

        private void CreateXML()
        {
            FileInfo info = new FileInfo(pathXML);
            if (info.Exists)
                return;
            var doc = new XmlDocument();
            var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            doc.AppendChild(xmlDeclaration);
            var root = doc.CreateElement("Files");
            doc.AppendChild(root);
            for (int i = 0; i < Length(); i++)
            {
                var element = doc.CreateElement("File");

                var name = doc.CreateAttribute("name");
                name.InnerText = MasFile[i].Name;
                element.SetAttributeNode(name);

                var change = doc.CreateElement("Change");
                var changeText = doc.CreateTextNode(MasFile[i].CreationTime.ToString());

                var text = doc.CreateElement("Text");
                var textText = doc.CreateTextNode(Read(i));

                change.AppendChild(changeText);
                text.AppendChild(textText);
                element.AppendChild(change);
                element.AppendChild(text);
                root.AppendChild(element);
            }
            doc.AppendChild(root);

            doc.Save(pathXML);
        }

        public void AddChangeXML(int i)
        {
            var doc = new XmlDocument();
            doc.Load(pathXML);
            var root = doc.DocumentElement;

            foreach (XmlElement element in root)
            {
                if (element.Attributes.GetNamedItem("name").Value == MasFile[i].Name)
                {
                    var change = doc.CreateElement("Change");
                    var changeText = doc.CreateTextNode(DateTime.Now.ToString());

                    var text = doc.CreateElement("Text");
                    var textText = doc.CreateTextNode(Read(i));

                    change.AppendChild(changeText);
                    text.AppendChild(textText);
                    element.AppendChild(change);
                    element.AppendChild(text);
                }
            }
            doc.AppendChild(root);

            doc.Save(pathXML);
        }

        public void GetRollbackFiles(string time)
        {
            var doc = new XmlDocument();
            doc.Load(pathXML);
            var root = doc.DocumentElement;

            int fileNumber = 0;
            bool flag = false;

            foreach (XmlNode node in root)
            {
                foreach (XmlNode childNode in node)
                {
                    if (childNode.Name == "Change" && childNode.InnerText == time)
                    {
                        flag = true;
                    }
                    else if (childNode.Name == "Text" && flag)
                    {
                        Write(fileNumber, childNode.InnerText, false);
                        flag = false;
                    }
                }
                fileNumber++;
            }
        }

        public int Length()
        {
            return MasFile.Length;
        }

        public FileInfo this[int index]
        {
            get
            {
                return MasFile[index];
            }
            set
            {

            }
        }
    }
}