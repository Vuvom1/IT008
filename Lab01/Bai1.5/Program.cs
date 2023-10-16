namespace Bai1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = args[0];
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (!di.Exists)
            {
                Console.WriteLine("Folder does not exist");
                return;
            }

            FileInfo[] fileArr = di.GetFiles();

            foreach (FileInfo file in fileArr)
                Console.WriteLine(file.Name);
        }
    }
}