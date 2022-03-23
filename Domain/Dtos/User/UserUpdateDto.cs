using System;

namespace Domain.Dtos.User
{
    public class UserUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public int Age { get; set; }
        public char CompanyOrPerson { get; set; }
    }
}
