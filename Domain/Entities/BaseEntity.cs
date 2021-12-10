using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid id { get; set;  }
        public DateTime createDate { get; set;  }
        public DateTime updateDate {  get; set; }
    }
}
