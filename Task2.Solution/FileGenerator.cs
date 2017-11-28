using System;

namespace Task2.Solution
{
    public abstract class FileGenerator
    {
        public abstract string FileExtension
        {
            get;
        }

        public abstract string WorkingDirectory
        {
            get;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        protected abstract byte[] GenerateFileContent(int contentLength);
        protected abstract void WriteBytesToFile(string fileName, byte[] content);
    }
}
