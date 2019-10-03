using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace syntax_highlight
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = "F3RF5LF7";
            Highlight(code);
        }

        public static string Highlight(string code)
        {
            code = new Regex("(F+)").Replace(code, "<span style=\"color: pink\">$1</span>");
            code = new Regex("(L+)").Replace(code, "<span style=\"color: red\">$1</span>");
            code = new Regex("(R+)").Replace(code, "<span style=\"color: green\">$1</span>");
            code = new Regex(@"(\d+)").Replace(code, "<span style=\"color: orange\">$1</span>");
            WriteLine(code);
            return code;// Implement your syntax highlighter here
        }
    }
}
