﻿using Strategy.Dynamic;
using static System.Console;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicSwitchStrategy();
        }

        private static void DynamicSwitchStrategy()
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            WriteLine(tp);

            tp.Clear();
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            WriteLine(tp);
        }
    }
}
