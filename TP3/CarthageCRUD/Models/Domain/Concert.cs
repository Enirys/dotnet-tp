namespace CarthageCRUD.Models.Domain
{
    public class Concert
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}
