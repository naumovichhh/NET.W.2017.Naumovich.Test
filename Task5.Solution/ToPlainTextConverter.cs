using System.Text;

namespace Task5.Solution
{
    public class ToPlainTextConverter : IConverter
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
                    builder.Append("**");
                    builder.Append(part.Text);
                    builder.Append("**");
                }
                else if (part as Hyperlink != null)
                {
                    builder.Append(part.Text);
                    builder.Append(" [");
                    builder.Append((part as Hyperlink).Url);
                    builder.Append("]");
                }
            }

            return builder.ToString();
        }
    }
}
