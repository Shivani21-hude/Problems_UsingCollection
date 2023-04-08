using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CountOfRemaingChapters
{
    internal class RemainingChapters
    {
        public static void Remaining()
        {
            Console.WriteLine("Enter the number of chapters prent in book");
            int chapters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter page of starting and ending of chapter as like 1 4 in next line 5 7");
            List<Tuple<int, int>> numberOfPages = new List<Tuple<int, int>>();
            for(int i=0;i<chapters; i++)
            {
                int[] pageNumber = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);
                numberOfPages.Add(new Tuple<int, int>(pageNumber[0], pageNumber[1]));
            }

            Console.WriteLine("Enter the current page of book");
            int currentPage = Convert.ToInt32(Console.ReadLine());
            int countChapters = 0;
            for(int i = 0; i < chapters; i++)
            {
                if (currentPage >= numberOfPages[i].Item1 && currentPage <= numberOfPages[i].Item2)
                {
                    break;
                }
                countChapters++;
            }
            int remainingChapter=chapters-countChapters;
            Console.WriteLine("Remaing Chapters yet to read : " + remainingChapter);
        }
    }
}
