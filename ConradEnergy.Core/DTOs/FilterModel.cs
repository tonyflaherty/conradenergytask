using System.ComponentModel.DataAnnotations;

namespace ConradEnergy.Core.DTOs
{
    public class FilterModel
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateFrom { get; set; } = DateTime.Now.Date.AddDays(-1);
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateTo { get; set; } = DateTime.Now.Date.AddDays(1);
        [Required]
        public int PageSize { get; set; } = 20;
        public int CurrentPage { get; set; } = 1;

        public string RequestQuery
        {
            get
            {
                return $"{DateFrom.ToString("yyyy-MM-dd")}/{DateTo.ToString("yyyy-MM-dd")}/{PageSize}/{CurrentPage}";
            }
        }
    }
}
