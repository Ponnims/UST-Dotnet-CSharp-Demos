using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{
    internal class CollectionExpressions
    {
        static void Main(string[] args)
        {
            // old way of initializing collections
            //int[] nums= new int[] {1,2,3,4,5,6,7,8,9,10};
            //int[] scoreslist= new int[] {90,85,78,92,88};
            //List<string> namelist= new List<string> {"Alice","Bob","Charlie","Diana"};

            // new way of initializing collections using collection expressions
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int[] scoreslist = [90, 85, 78, 92, 88];
            List<string> namelist = ["Alice", "Bob", "Charlie", "Diana"];

        }
    }
}
