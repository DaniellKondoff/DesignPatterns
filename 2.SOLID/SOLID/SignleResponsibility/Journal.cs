using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SignleResponsibility
{
    public class Journal
    {
        private readonly List<string> entries;
        private int count;

        public Journal()
        {
            this.entries = new List<string>();
            this.count = 0;
        }

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}
