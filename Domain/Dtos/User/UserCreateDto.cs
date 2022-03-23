namespace Domain.Dtos.User
{
    public class UserCreateDto
    {
        public string Name { get; set; }

        public string Document { get; set; }

        public int Age { get; set; }

        public char CompanyOrPerson { get; set; }
    }
}
