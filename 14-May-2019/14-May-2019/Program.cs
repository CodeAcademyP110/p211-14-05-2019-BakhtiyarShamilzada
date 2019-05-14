using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_May_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine("Sentence:");
            //string sentence = Console.ReadLine();
            //Console.WriteLine(SpaceCounter(sentence));
            #endregion

            #region Task 2
            //int[] numbers = { 1, 2, 3, 4, 5, 9 };
            //Console.WriteLine(NumberAverage(numbers));
            #endregion

            #region Task 3
            //int[] numbers = { 1, 2, 3, 4, 5, 9 };
            //Console.WriteLine(EvenNumbers(numbers));
            #endregion

            #region Task 4
            //int[] numbers = { 1, 2, 3, 4, 5, 9 };
            //Console.WriteLine(NumberAverageGreather(numbers));
            #endregion

            #region Task 5
            //Console.WriteLine(Pow(5, 3));
            #endregion

            #region Task 6
            //string[] words = { "Alma", "Armud", "Portagal", "Uzum", "Banan" };
            //Console.WriteLine(WordMaxLength(words));
            #endregion

            #region Task 7
            //string[] words = { "Alma", "Armud", "Portagal", "Uzum", "Banan" };
            //Console.WriteLine(WordsJoin(words));
            #endregion
        }

        #region Task 1
        //static int SpaceCounter(string sentence)
        //{
        //    string[] words = sentence.Split(' ');
        //    int spaceCount = words.Length - 1;
        //    return spaceCount;
        //}
        #endregion

        #region Task 2
        //static string NumberAverage(int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        sum += number;
        //    }
        //    int numberAverage = sum / numbers.Length;
        //    return numberAverage.ToString();
        //}
        #endregion

        #region Task 3
        //static string EvenNumbers(int[] numbers)
        //{
        //    StringBuilder evenNumbers = new StringBuilder();
        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 == 0)
        //        {
        //            evenNumbers.Append(number).Append(' ');
        //        }
        //    }
        //    return evenNumbers.ToString();
        //}
        #endregion

        #region Task 4
        //static string NumberAverageGreather(int[] numbers)
        //{
        //    StringBuilder NumberAverageGreat = new StringBuilder();
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        sum += number;
        //    }
        //    int numberAverage = sum / numbers.Length;
        //    foreach (int number in numbers)
        //    {
        //        if (number > numberAverage)
        //        {
        //            NumberAverageGreat.Append(number).Append(' ');
        //        }
        //    }
        //    return NumberAverageGreat.ToString();
        //}
        #endregion

        #region Task 5
        //static int Pow(int a, int b)
        //{
        //    int pow = 1;
        //    for (int i = 0; i < b; i++)
        //    {
        //        pow *= a;
        //    }
        //    return pow;
        //}
        #endregion

        #region Task 6
        //static string WordMaxLength(string[] words)
        //{
        //    string wordMaxLength = "";
        //    int wordLength = words[0].Length;
        //    foreach (string word in words)
        //    {
        //        if (wordLength < word.Length)
        //        {
        //            wordLength = word.Length;
        //            wordMaxLength = word;
        //        }
        //    }
        //    return wordMaxLength;
        //}
        #endregion

        #region Task 7
        //static string WordsJoin(string[] words)
        //{
        //    StringBuilder newWord = new StringBuilder();
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        newWord.Append(words[i]);
        //        if (i != words.Length - 1)
        //        {
        //            newWord.Append(", ");
        //        }
        //    }
        //    return newWord.ToString();
        //}
        #endregion
    }
}
