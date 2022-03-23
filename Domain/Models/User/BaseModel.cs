using System;

namespace Domain.Models.User
{
    public class BaseModel
    {
        private Guid _id;

        private DateTime _createDate;

        private DateTime _updateDate;

        public Guid Id { 
            get {  return _id; }
            set {  _id = value; }
        }
        public DateTime CreateDate 
        {
            get {  return _createDate; }
            set {  _createDate = value; }
        }
        public DateTime UpdateDate 
        {
            get {  return _updateDate; }
            set {  _updateDate = value; }
        }
        
    }
}
