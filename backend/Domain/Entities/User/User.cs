namespace backend.Doamin.Entity
{
    public class User
    {
        int id{get;set;}
        string name{get;set;}
        string cpf{get;set;}
        string email{get;set;}
        string codeVerification{get;set;}
        public int CompanyId { get; set; }
        string hashpassword{get;set;}

        public ICollection<UserAdress> Adresses = new List<UserAdress>();
        public ICollection<UserOrder> Orders = new List<UserOrder>();

    }
}