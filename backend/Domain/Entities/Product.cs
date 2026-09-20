namespace backend.Doamin.Entity {

    public class Product
    {
        int visibleId{get;set;}
        string name{get;set;}
        string description{get;set;}
        string price{get;set;}
        string pricePromotion{get;set;}
        bool isPromotion{get;set;}
        bool IsActive{get;set;}
        int amount{get;set;}
        public int CompanyId { get; set; }
        public ProductGoal goal{get;set;}
        public ICollection<ProductSettingsDescription> SettingsDescription{get;set;} = new List<ProductSettingsDescription>();

    }    

}