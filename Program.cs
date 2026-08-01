namespace Assignment2C_
{
    public class Book
    {
        private string password = "secret";

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Q1
            #region
            Book book = new Book();
            Console.WriteLine(book.password); //password is inaccessable 
            #endregion

           
        }
    }
}
