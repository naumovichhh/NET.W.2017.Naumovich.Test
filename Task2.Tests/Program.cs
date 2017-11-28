using Task2.Solution;

namespace Task2.Tests
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileGenerator generator1 = new RandomBytesFileGenerator();
            generator1.GenerateFiles(4, 4);
            FileGenerator generator2 = new RandomCharsFileGenerator();
            generator2.GenerateFiles(5, 3);
        }
    }
}
