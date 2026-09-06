namespace G_ASP_NET_99_C_Basics_05
{
    #region Question1
    class Book
    {
        private string password= "secret";
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1
            Book book = new Book();
            Console.WriteLine(book.password); // This will cause a compilation error because 'password' is private

        }
    }
}
