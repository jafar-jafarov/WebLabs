using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabs.Models.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? DeletedTime { get; set; }
        public int? CreatedByUserId { get; set; }
        public int? DeletedByUserId { get; set; }
    }
}
