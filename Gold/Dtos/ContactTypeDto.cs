using Gold.Common.Mappings;
using Gold.Models;

namespace Gold.Dtos
{
    public class ContactTypeDto : IMapFrom<ContactType> 
    {
        public int ContactTypeID { get; set; }
        public string Name { get; set; } = string.Empty;
    }

}
