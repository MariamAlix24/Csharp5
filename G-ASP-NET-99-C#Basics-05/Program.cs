namespace G_ASP_NET_99_C_Basics_05
{
    #region Question4
    enum Genre
    {
        Fiction,
        NonFiction,
        Science,
        History
    }
    #endregion
    #region Question1
    class Book
    {
        //Question2
        internal int coppiesInStock=5;
        private string password= "secret";
        //Question3
        public string title;
        //Question4
        public Genre genre;
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1
            Book book = new Book();
            //Question2
            Console.WriteLine(book.coppiesInStock); // This will work because 'coppiesInStock' is internal
           // Console.WriteLine(book.password); // This will cause a compilation error because 'password' is private
           //Question3
            book.title = "C# Book";
            Console.WriteLine(book.title); // This will work because 'title' is public
            //Question4
            book.genre = Genre.Science;
            Console.WriteLine(book.genre);
        }
    }
}
