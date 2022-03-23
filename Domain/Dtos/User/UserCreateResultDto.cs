using System;

namespace Domain.Dtos.User
{
    public class UserCreateResultDto
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public int Age { get; set; }
        public char CompanyOrPerson { get; set; }
    }
}
