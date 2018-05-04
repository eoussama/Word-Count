namespace Word_Count.classes
{
    public enum Lang { pawn }

    public static class Config
    {
        public static readonly string author = "Eoussama";
        public static readonly string title = "Word Count";
        public static readonly string version = "1.0.0";

        private static bool syntax;
        private static Lang lang;

        public static bool Syntax { get => syntax; set => syntax = value; }
        public static Lang Lang { get => lang; set => lang = value; }
    }
}
