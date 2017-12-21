using System;

namespace AccessModifiers
{
    public class Customer
    {
        private string _name;
        //private string _id;

        public string getName()
        {
            return _name; 
        }

        public void setName(string name)
        {
            // one of the advantages of setter - can check if its null/empty first
            // can have some logic when setting the field
            if (!String.IsNullOrEmpty(name))
                this._name = name; 
        }
    }
}