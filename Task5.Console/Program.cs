using System;
using System.Collections.Generic;
using Task5.Solution;

namespace Task5.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            Document document = new Document(parts);

            System.Console.WriteLine(new ToHtmlConverter().Convert(document));

            System.Console.WriteLine(new ToLatexConverter().Convert(document));

            System.Console.WriteLine(new ToPlainTextConverter().Convert(document));
        }
    }
}
