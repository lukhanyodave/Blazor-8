using Uwc.Ics.Ws.Client.Application.Models.Common;

namespace Uwc.Ics.Ws.Client.Application.Models
{
    public class PostCategory : BaseModel
    {
       
        public int Year { get; set; }
        public string ProjectCode { get; set; } = string.Empty;
        public Guid FacultyId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid PostTypeId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string PostName { get; set; } = string.Empty;
        public string PostDescription { get; set; } = string.Empty;
        //public string DegreeType { get; set; }
        public string EntityCode { get; set; } = string.Empty;
        public string Account { get; set; } = string.Empty;
        //public string Module { get; set; }        // One of criteria?
        public DateTime DateApplicationsOpen { get; set; }
        public DateTime DateApplicationsClose { get; set; }
    }
}
