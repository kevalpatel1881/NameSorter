using NameSorter.Interface;
using NameSorter.Repo;

namespace NameSorter
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        static void Main()
        {
            IFileOpertaion _fileOpertaion = new IFileOpertaionRepo();
            string inputFileName = @"unsorted-names-list.txt";
            string outputFileName = @"sorted-names-list.txt";
            if (_fileOpertaion.Exists(inputFileName))
            {
                var names = _fileOpertaion.SortNames(inputFileName);
                _fileOpertaion.WriteAllLines(outputFileName, names);
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            else
                Console.WriteLine("File does not exists");
        }
    }
}