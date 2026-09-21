namespace backend.Doamin.Entity
{
    public class Company
    {
        int id{get;set;}
        string name{get;set;}
        string cnpj{get;set;}
        string phone{get;set;}
        string email{get;set;}
        public ICollection<User> Users{get;set;} = new List<User>();
        public ICollection<Product> Products{get;set;} = new List<Product>();
        public CompanySettings CompanySettings{get;set;}
        public CompanyAdress CompanyAdress{get;set;}
        
    }
}