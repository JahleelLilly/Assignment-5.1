namespace Assignment_5._1
{
    class Program
    {
        static bool IsPalindrome(int x)
        {
            
            if (x >= 0 && x < 10)
                return true;

            
            int firstDigit = x;
            int lastDigit = x % 10;

            x /= 10;

            
            bool isInnerPalindrome = IsPalindrome(x);

            return isInnerPalindrome && (firstDigit % 10 == lastDigit);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            bool isPalin = IsPalindrome(num);
            Console.WriteLine($"Is {num} a palindrome? {isPalin}");
        }
    }
}
