namespace EXtensionMethods
{
    public static class MyExtension
    {
        public static string IsOddOrEven(this int mynum)
        {
            return mynum % 2 != 0 ? "odd" : "even";
        }

        public static string TrimAndConvertToUpper(this string str)
        {
            return str.Trim().ToUpper();
        }

        public static double GetAverage(this int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        public static bool IsValidEmail(this string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
