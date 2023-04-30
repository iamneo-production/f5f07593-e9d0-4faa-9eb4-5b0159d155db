namespace dotnetapp.Models
{
    public class ResponseModel
    {
        public dynamic Response { get; set; }
        public string Message { get; set; }
        public bool? Status { get; set; } //status flow f
        public string ErrorMessage { get; set; }
    }
}
