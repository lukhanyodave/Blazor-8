using Uwc.Ics.Ws.Client.Application.Models.Common;

namespace Uwc.Ics.Ws.Client.Application.Models
{
    public class PostType : BaseModel
    {
        public Guid Id { get; set; }
        public string PostTypeCode { get; set; } = string.Empty;
        public string PostName { get; set; } = string.Empty;
    }
}
