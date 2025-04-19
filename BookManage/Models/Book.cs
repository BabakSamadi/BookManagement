namespace BookManage.Models
{
    public class Book
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Autor { get; set; }

        public int publishedYear { get; set; }

        public string Description {  get; set; }

        public DateTime CreationDate { get; set; }




        public int CategoriesId { get; set; }     // Fk ID 

        public Categories categories { get; set; }  





        public int UserId { get; set; }      // Fk ID

        public Users Users { get; set; }


    }
}
