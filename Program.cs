namespace Assignment2C_
{
    internal class Program
    {
        //public static void printMessage()
        //{
        //    Console.WriteLine("hello from the library !");
        //}
        //public static void printBookTitlle(string title)
        //{ 
        //    Console.WriteLine( "Book title: "+ title);
        //}

        //public static void addBounusPage(int pages)
        //{
        //    pages += 50;
        //}


        //public static void applyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}

        //public static void addBounusPage(ref int pages)
        //{
        //    pages += 50;
        //}

        public static void replaceArray(ref double[] prices)
        {
            prices[0] =10.0;
            prices[1] =12.5;
            prices[2] =15.0;
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
            //#region
            //printBookTitlle("clean code");
            //#endregion

            //Q5
            //#region
            //int pages = 400;
            //Console.WriteLine(pages);
            //addBounusPage(pages);
            //Console.WriteLine(pages);
            ////nothing changes cause it just calling by value , the mthod just recieve a copy of the value that the variable has and the variable pages remains with the same value 

            //#endregion

            //Q6
            //#region
            //double[] prices = { 25.5, 40.0};
            //applyDiscount(prices);
            //Console.WriteLine(prices[0]);
            ////cause it a reference type 
            //#endregion

            //Q7
            //#region
            //int pages = 400;
            //Console.WriteLine(pages);
            //addBounusPage(ref pages);
            //Console.WriteLine(pages);
            //#endregion

            //Q8
            #region
            double[] prices = { 25.0, 40.0,33.75};
            replaceArray(ref prices);
            Console.WriteLine(prices.Length);

            #endregion
        }

    }
}
