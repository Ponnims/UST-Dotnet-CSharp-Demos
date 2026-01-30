using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public static class ErrorLogging
    {
        public static void LogError(string errordetails)
        {
            using (FileStream fs = new FileStream("ErrorLogging.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(errordetails);
                }
            }
               
        }
    }
}
