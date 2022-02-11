using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.User
{
    public class BaseModel
    {
        private Guid _id;
        private DateTime _createDate;
        private DateTime _updateDate;

        public Guid id { 
            get {  return _id; }
            set {  _id = value; }
        }
        public DateTime createDate 
        {
            get {  return _createDate; }
            set {  _createDate = value; }
        }
        public DateTime updateDate 
        {
            get {  return _updateDate; }
            set {  _updateDate = value; }
        }
        
    }
}
