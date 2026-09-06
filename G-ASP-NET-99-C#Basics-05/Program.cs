namespace G_ASP_NET_99_C_Basics_05
{
    #region Question1
    class Book
    {
        //Question2
        internal int coppiesInStock=5;
        private string password= "secret";
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

        }
    }
}
