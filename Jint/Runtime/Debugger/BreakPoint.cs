namespace Jint.Runtime.Debugger
{
    public class BreakPoint
    {
        public int Line { get; set; }
        public int Char { get; set; }
        public string Condition { get; set; }
        public string Source { get; set; }

        public BreakPoint(int line, int character, string source)
        {
            Line = line;
            Char = character;
            Source = source;
        }

        public BreakPoint(int line, int character, string source, string condition)
            : this(line, character, source)
        {
            Condition = condition;
        }
    }
}
