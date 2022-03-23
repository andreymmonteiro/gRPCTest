using System;

namespace Domain.Entities.User
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set;  }

        public string Name { get; set;  }

        public string Document { get; set;  }

        public int Age { get; set;  }

        public char CompanyOrPerson { get; set; }

        public string Password { get; set; }

        public Guid FinancialId { get; set; }
        
    }
}
