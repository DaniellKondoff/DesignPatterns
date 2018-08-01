using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HtmlElement
    {
        private const int indentSize = 2;

        public string Name { get; set; }

        public string Text { get; set; }

        public List<HtmlElement> Elements { get; set; } = new List<HtmlElement>();

        public HtmlElement()
        {

        }
        public HtmlElement(string name, string text)
        {
            this.Name = name;
            this.Text = text;
        }

        private string ToStringImp(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var element in this.Elements)
            {
                sb.Append(element.ToStringImp(indent + 1));
            }

            sb.AppendLine($"{i}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.ToStringImp(0);
        }
    }
}
