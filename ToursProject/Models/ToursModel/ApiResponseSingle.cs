namespace ToursProject.Models.ToursModel
{
    public class ApiResponseSingle<T>
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public T Data { get; set; }
    }
}
