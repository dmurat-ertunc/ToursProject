using ToursProject.Models.ToursModel;

namespace ToursProject.Models
{
    public class ApiResponse<T>
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public List<T> Data { get; set; }
    }
}
