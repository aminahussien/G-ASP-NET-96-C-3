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
            //StringBuilder s = new StringBuilder();
            //s.Replace("book list", "library");
            #endregion

            #region
            //question5
            //string title = "clean code";
            //int pages = 404;
            //string sent = "book:" + title + ",pages:" + pages;
            //Console.WriteLine(sent);
            #endregion

            #region
            //question6
            //string title = "clean code";
            //int pages = 404;
            //string sent = $"book:{title},,pages:{pages} ";
            //Console.WriteLine(sent);
            #endregion

            #region
            //question7
            //string title = "clean code";
            //int pages = 404;
            //string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(sentence);
            #endregion
            #region
            //question8
            int pages = 404;
            if (pages > 300)
                Console.WriteLine("long book");
            else
                Console.WriteLine("short book");

            #endregion
        }
    }
}
