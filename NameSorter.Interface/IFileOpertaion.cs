namespace NameSorter.Interface
{
    public interface IFileOpertaion
    {
        /// <summary>
        /// Existses the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        bool Exists(string path);

        /// <summary>
        /// Sorts the names.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public string[] SortNames(string fileName);

        /// <summary>
        /// Writes all lines.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="names">The names.</param>
        public void WriteAllLines(string fileName, string[] names);
    }
}