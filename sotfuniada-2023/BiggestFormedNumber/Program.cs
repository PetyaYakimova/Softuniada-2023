using System.Text;

namespace BiggestFormedNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNumbers = Console.ReadLine().Split(' ').ToList();

            inputNumbers = inputNumbers.OrderByDescending(n => n).ToList();
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                if (inputNumbers[i].Length > inputNumbers[i + 1].Length)
                {
                    if (inputNumbers[i].Contains(inputNumbers[i+1]) && (inputNumbers[i + 1][inputNumbers[i + 1].Length - 1] > inputNumbers[i][inputNumbers[i + 1].Length]))
                    {
                        string temp = inputNumbers[i];
                        inputNumbers[i] = inputNumbers[i + 1];
                        inputNumbers[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join("", inputNumbers));
        }
    }
}