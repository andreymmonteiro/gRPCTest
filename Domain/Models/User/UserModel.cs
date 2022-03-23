namespace Domain.Models.User
{
    public class UserModel : BaseModel
    {
        private string _name;

        private string _document;

        private int _age;

        private char _companyOrPerson;


        public string Name 
        {
            get {  return _name; }
            set {  _name = value; }
        }
        public string Document 
        {
            get { return _document; }
            set {  _document = value; }
        }
        public int Age 
        {
            get {  return _age; }
            set {  _age = value; }
        }
        public char CompanyOrPerson 
        {
            get { return _companyOrPerson; }
            set {  _companyOrPerson = value; }
        }       

    }
}
