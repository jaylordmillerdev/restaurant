namespace Restaurant.Business
{
    public class RequestResult
    {
        public string message { get; }
        public bool isSuccess { get; }
        public RequestResult(string message, bool isSuccess)
        {
            this.message = message;
            this.isSuccess = isSuccess;
        }
    }
}
