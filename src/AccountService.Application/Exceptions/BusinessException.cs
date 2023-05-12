namespace AccountService.Application.Exceptions
{
    public abstract class BusinessException : Exception
    {
        protected BusinessException(string message) : base(message) {}

        public abstract dynamic Data { get; }
        public abstract ushort Code { get; }
    }
}
