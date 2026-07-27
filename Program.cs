namespace Assignment2C_
{
    internal class Program
    {
        //public static void printMessage()
        //{
        //    Console.WriteLine("hello from the library !");
        //}
        public static void printBookTitlle(string title)
        { 
            Console.WriteLine( "Book title: "+ title);
        }
        static void Main(string[] args)
        {
            //Q1
            //#region
            //double[] prices = { 25.5, 33.75, 40.0 };
            //Console.WriteLine(prices[1]);
            //#endregion

            //Q2
            //#region
            //int[,] shelfCopies = {
            //    {3,5},
            //    {1,4}
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            //#endregion

            //Q3
            //#region
            //printMessage();
            //#endregion

            //Q4
            #region
            printBookTitlle("clean code");
            #endregion
        }

    }
}
