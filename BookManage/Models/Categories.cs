namespace BookManage.Models
{
    public class Categories
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection <Book> books { get; set; }
    }
}
