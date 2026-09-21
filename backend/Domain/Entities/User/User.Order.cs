namespace backend.Doamin.Entity
{
    public class UserOrder
    {
        public int id{get;set;}
        public ICollection<Product> products = new List<Product>();
        public User user{get;set;}
        public UserAdress adress{get;set;}
        public int UserId{get;set;}
        
    }
}