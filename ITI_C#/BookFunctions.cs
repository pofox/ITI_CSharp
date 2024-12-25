using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public class BookFunctions
    {
        public static string GetTitle(Book B) => B.Title;
        public static string GetAuthors(Book B)
        {
            string authors = string.Empty;
            foreach (string author in B.Authors)
            {
                authors += $"{author}, ";
            }
            return authors;
        }
        public static string GetPrice(Book B) => $"{B.Price}";
    }
}
