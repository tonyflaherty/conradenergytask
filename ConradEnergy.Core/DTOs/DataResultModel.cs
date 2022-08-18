namespace ConradEnergy.Core.DTOs
{

    public class DataResultModel<T>
    {        
        public T Results { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
