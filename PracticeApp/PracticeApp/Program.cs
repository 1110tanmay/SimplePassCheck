using System;
using System.Linq;
namespace LearnString
{
    class Learnstrings 
    {
        static Boolean IsPaswordcorrect(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }
    public static void Main()
        {
            Console.WriteLine(IsPaswordcorrect("Hello123"));
        }
    }
}