using System.Text;

namespace Task5.Solution
{
    public class ToHtmlConverter : IConverter
    {
        public string Convert(Document document)
        {
            StringBuilder builder = new StringBuilder();
            foreach (DocumentPart part in document.Parts)
            {
                if (part as PlainText != null)
                {
                    builder.Append(part.Text);
                }
                else if (part as BoldText != null)
                {
                    builder.Append("<b>");
                    builder.Append(part.Text);
                    builder.Append("</b>");
                }
                else if (part as Hyperlink != null)
                {
                    builder.Append("<a href=\"");
                    builder.Append((part as Hyperlink).Url);
                    builder.Append("\">");
                    builder.Append(part.Text);
                    builder.Append("</a>");
                }
            }

            return builder.ToString();
        }
    }
}
