using Uwc.Ics.Ws.Client.Application.Models.Common;

namespace Uwc.Ics.Ws.Client.Application.Models
{
    public class Vacancy : BaseModel
    {
        public Guid Id { get; set; }
        public string HRPostNumber { get; set; } = string.Empty;
        public string ProjectCode { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string? PostName { get; set; } = string.Empty;
        public string PostDescription { get; set; } = string.Empty;
        public string DegreeType { get; set;} = string.Empty;
        public DateTime? CommencementDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public decimal? Budget { get; set; }
    }
}
