namespace BibliothequeDeClasse
{
    public class MonException : Exception
    {
        public MonException(string message) : base(message)
        {
        }

        public MonException(string message, Exception autreexception) : base(message, autreexception)
        {
        }

        public int ErrorCode { get; set; }
    }
}
