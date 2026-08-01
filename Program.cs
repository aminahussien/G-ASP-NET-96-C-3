namespace Assignment2C_
{
    public class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;

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


            //Q2
            #region
            Book book2 = new Book();
            Console.WriteLine(book2.copiesInStock); //copisInStock is accessable because it declared in class book as an internal field and internal acces modifiers can be accessed in the same project
            #endregion


        }
    }
}
