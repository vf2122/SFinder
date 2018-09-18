using SFinder.Domain.Core.Interfaces.Entities;

namespace SFinder.Domain.Core.Entities
{
    public class Rating
    {
        public IUser Usuario { get; set; }
        public bool Like { get; set; }
    }
}
