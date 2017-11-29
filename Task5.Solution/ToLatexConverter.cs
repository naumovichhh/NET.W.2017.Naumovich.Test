using System.Text;

namespace Task5.Solution
{
    public class ToLatexConverter
    {
        public string Convert(Document document)
        {
            var builder = new StringBuilder();

            foreach (DocumentPart part in document.Parts)
            {
                if (part as PlainText != null)
                {
                    builder.Append(part.Text);
                }
                else if (part as BoldText != null)
                {
                    builder.Append("\\textbf{");
                    builder.Append(part.Text);
                    builder.Append("}");
                }
                else if (part as Hyperlink != null)
                {
                    builder.Append("\\href{");
                    builder.Append((part as Hyperlink).Url);
                    builder.Append("}{");
                    builder.Append(part.Text);
                    builder.Append("}");
                }
            }

            return builder.ToString();
        }
    }
}
