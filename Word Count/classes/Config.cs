namespace Word_Count.classes
{
    public enum Lang { pawn }

    public static class Config
    {
        private static bool syntax;
        private static Lang lang;

        public static bool Syntax { get => syntax; set => syntax = value; }
        public static Lang Lang { get => lang; set => lang = value; }
    }
}
