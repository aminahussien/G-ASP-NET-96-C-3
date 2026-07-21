using System.Text;

namespace Assignment2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //question1
            //string title = "clean code";
            //string upperTitle=title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region
            //question2 
            //string a = "clean code";
            //string b = "clean code";
            //Console.WriteLine(ReferenceEquals(a,b));
            #endregion

            #region
            //question3
            //StringBuilder s = new StringBuilder();
            //s.Append("book list");
            //args.Append("- updated");
            //Console.WriteLine(s.ToString());
            #endregion

            #region
            //question4
            StringBuilder s = new StringBuilder();
            s.Replace("book list", "library");
            #endregion


        }
    }
}
