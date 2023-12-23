namespace Pancakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputPancakeParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLengthSum = int.MinValue;
            int maxLengthStartIndex = -1;
            int maxLengthNumberOfElements = 0;

            for (int i = 0; i < inputPancakeParts.Length; i++)
            {
                for (int j = i; j < inputPancakeParts.Length; j++)
                {
                    int currentLengthSum = 0;
                    for (int el = i; el <= j; el++)
                    {
                        currentLengthSum += inputPancakeParts[el];
                    }

                    if (currentLengthSum > maxLengthSum)
                    {
                        maxLengthNumberOfElements = j - i + 1;
                        maxLengthStartIndex = i;
                        maxLengthSum = currentLengthSum;
                    }
                    else if (currentLengthSum == maxLengthSum && maxLengthNumberOfElements < j - i + 1)
                    {
                        maxLengthNumberOfElements = j - i + 1;
                        maxLengthStartIndex = i;
                    }
                }
            }

            Console.WriteLine(maxLengthSum + " " + maxLengthStartIndex + " " + (maxLengthNumberOfElements + maxLengthStartIndex - 1));
        }
    }
}