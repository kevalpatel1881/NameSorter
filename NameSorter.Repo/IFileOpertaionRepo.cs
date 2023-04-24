using NameSorter.Interface;

namespace NameSorter.Repo
{
    public class IFileOpertaionRepo : IFileOpertaion
    {
        /// <summary>
        /// Existses the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        /// Sorts the names.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public string[] SortNames(string fileName)
        {
            string[] names = System.IO.File.ReadAllLines(fileName);
            var sortKey = names.Select(SwapLastName).ToArray();
            System.Array.Sort(sortKey, names);
            return names;
        }

        /// <summary>
        /// Swaps the last name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string SwapLastName(string name)
        {
            var names = name.Split(' ', System.StringSplitOptions.None);
            var length = names.Length;
            return names[length - 1] + ' ' + string.Join(' ', names, 0, length - 1);
        }

        /// <summary>
        /// Writes all lines.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="names">The names.</param>
        public void WriteAllLines(string fileName, string[] names)
        {
            System.IO.File.WriteAllLines(fileName, names);
        }
    }
}