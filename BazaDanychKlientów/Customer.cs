using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanychKlientów
{
    class Customer
    {
       
        private string CustomerName;
        private string CustomerLastName;
        private string CustomerNationality;
        private string CustomerAddress;
        private string CustomerPhone;
        private string CustomerAge;

        public Customer( string CustomerName, string CustomerLastName, string CustomerAge ,string CustomerNationality, string CustomerPhone, string CustomerAddress)
        {
            
            this.Name = CustomerName;
            this.LastName = CustomerLastName;
            this.Age = CustomerAge;
            this.Nationality = CustomerNationality;
            this.Phone = CustomerPhone;
            this.Address = CustomerAddress;
        }

        
        public string Name { get { return CustomerName; } set { CustomerName = value; } }
        public string LastName { get { return CustomerLastName; } set { CustomerLastName = value; } }
        public string Age { get { return CustomerAge; } set {  CustomerAge= value; } }
        public string Nationality { get { return CustomerNationality; } set { CustomerNationality = value; } }
        public string Phone { get { return CustomerPhone; } set { CustomerPhone = value; } }
        public string Address { get { return CustomerAddress; } set { CustomerAddress = value; } }
    }
}

