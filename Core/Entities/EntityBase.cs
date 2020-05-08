using System;

namespace Core.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public int InsertedId { get; set; } = -1;
        public int? UpdatedId { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
