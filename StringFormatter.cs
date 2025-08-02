using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public static class StringFormatter
    {
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            if (quote == null)
                throw new ArgumentNullException(nameof(quote));

            var qry = new StringBuilder(items[0].Length + quote.Length * 2);
            qry.Append(quote).Append(items[0]).Append(quote);

            for (int i = 1; i < items.Length; i++)
            {
                qry.Append(", ")
                   .Append(quote).Append(items[i]).Append(quote);
            }

            return qry.ToString();
        }
    }
}
