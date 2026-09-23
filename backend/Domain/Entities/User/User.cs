namespace backend.Doamin.Entity
{
    public class User
    {
        public int id{get;set;}
        public string name{get;set;}
        public string cpf{get;set;}
        public string email{get;set;}
        public string codeVerification{get;set;}
        public int CompanyId { get; set; }
        string hashpassword{get;set;}

        EUserRole role{get;set;}

        public ICollection<UserAdress> Adresses = new List<UserAdress>();
        public ICollection<UserOrder> Orders = new List<UserOrder>();

    }
}