using NameSorter.Repo;
using Xunit;

namespace NameSorter.Test
{
    public class NameSorterTest
    {
        private readonly IFileOpertaionRepo _repo;

        public NameSorterTest()
        {
            _repo = new IFileOpertaionRepo();
        }
        [Fact]
        public void CheckFileExist()
        {
            //Arrange
            string filePath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string fileName = filePath + "/Files/unsorted-names-list.txt";

            //Act
            bool isExists = _repo.Exists(fileName);

            //Assert
            Assert.True(isExists);
        }
        [Fact]
        public void CheckGivenNameInRange()
        {
            //Arrange
            string filePath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string fileName = filePath + "/Files/unsorted-names-list-givennameinrange.txt";
            string[] names = System.IO.File.ReadAllLines(fileName);

            //Act
            foreach (var name in names)
            {
                var splitName = name.Split(' ', System.StringSplitOptions.None);
                int length = splitName.Length;
                //Assert
                Assert.InRange(length,2,4);
            }
        }

        [Fact]
        public void CheckMustHaveOneGivenName()
        {
            //Arrange
            string filePath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string fileName = filePath + "/Files/unsorted-names-list-onegivenname.txt";
            string[] names = System.IO.File.ReadAllLines(fileName);

            //Act
            foreach (var name in names)
            {
                var splitName = name.Split(' ', System.StringSplitOptions.None);
                int length = splitName.Length;
                //Assert
                Assert.False(length > 1,"Must have one given name.");
            }
        }
    }
}