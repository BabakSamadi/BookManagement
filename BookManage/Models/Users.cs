namespace BookManage.Models
{
    public class Users
    {

        public int Id { get; set; }


        public string Name { get; set; }


        public string Email { get; set; }

        public string password { get; set; }


        public string Role { get; set; }    // نقش کاربر یا ادمین 

        public DateTime CreateDate { get; set; }


        public ICollection <Book> Books { get; set; }   

    }
}
