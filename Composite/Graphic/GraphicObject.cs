using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Graphic
{
    public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;
        public List<GraphicObject> Children { get; } = new List<GraphicObject>();

        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
              .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color} ")
              .AppendLine($"{Name}");
            foreach (var child in Children)
                child.Print(sb, depth + 1);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }
    }
}
