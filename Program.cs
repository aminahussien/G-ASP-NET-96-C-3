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
            //#region
            //Book book = new Book();
            //Console.WriteLine(book.Genre);  
            //#endregion

            //Q5
            //#region
            //Book book = new Book();
            //Genre genre0 = Genre.Fiction;
            //Genre genre1 = Genre.NonFiction;
            //Genre genre2 = Genre.Science;

            //int value0 = (int)genre0;
            //int value1 = (int)genre1;
            //int value2 = (int)genre2;

            //Console.WriteLine(value0);
            //Console.WriteLine(value1);
            //Console.WriteLine(value2);

            //#endregion

            //Q6
            #region
            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);
            #endregion


        }
    }
}
