namespace dotnetapp
{
    public class ResponseModel
    {
        public string Message { get; internal set; }
        public bool Status { get; internal set; }
        public object ErrorMessage { get; internal set; }
    }
}