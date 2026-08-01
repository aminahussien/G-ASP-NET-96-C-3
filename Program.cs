namespace Assignment2C_
{
    public enum Genre
    { 
        Fiction,
        NonFiction,
        Science
    }
    public class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string title = "clean code";
         internal Genre Genre = Genre.Science;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ////Q1
            //#region
            //Book book = new Book();
            //Console.WriteLine(book.password); //password is inaccessable 
            //#endregion


            ////Q2
            //#region
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock); //copisInStock is accessable because it declared in class book as an internal field and internal acces modifiers can be accessed in the same project
            //#endregion


            //Q3
            //#region
            //Book book = new Book();
            //Console.WriteLine(book.title);
            //#endregion

            //Q4
            #region
            Book book = new Book();
            Console.WriteLine(book.Genre);  
            #endregion


        }
    }
}
