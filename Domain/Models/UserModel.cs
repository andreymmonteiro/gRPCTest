using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModel : BaseModel
    {
        private string _name;
        private string _document;
        private int _age;
        private char _companyOrPerson;

        public string name 
        {
            get {  return _name; }
            set {  _name = value; }
        }
        public string document 
        {
            get { return _document; }
            set {  _document = value; }
        }
        public int age 
        {
            get {  return _age; }
            set {  _age = value; }
        }
        public char companyOrPerson 
        {
            get { return _companyOrPerson; }
            set {  _companyOrPerson = value; }
        }       

    }
}
