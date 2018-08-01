namespace Builder
{
    public class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();
        public string RootName { get; set; }

        public HtmlBuilder(string rootName)
        {
            this.RootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);

            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement { Name = RootName };
        }
    }
}
