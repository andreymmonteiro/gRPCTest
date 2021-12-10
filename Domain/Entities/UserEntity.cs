using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {

        public string name { get; set;  }
        public string document { get; set;  }
        public int age { get; set;  }
        public char companyOrPerson { get; set; }
        public string password { get; set; }
        
    }
}
