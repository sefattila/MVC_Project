using MVC_Project.Models.Entities.Enums;

namespace MVC_Project.Models.Entities.Abstracts
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
