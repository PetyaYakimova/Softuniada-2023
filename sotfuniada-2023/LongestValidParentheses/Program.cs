namespace LongestValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] inputCharacters = Console.ReadLine().ToCharArray();
            int longestValidLength = 0;

            //Get the longest valid length of elements starting from each of the elements
            for (int i = 0; i < inputCharacters.Length; i++)
            {
                int currentValidLength = 0;

                bool lastCharIsOpeningBracket = false;
                for (int j = i; j < inputCharacters.Length; j++)
                {
                    if ((inputCharacters[j] == '(' && !lastCharIsOpeningBracket) || (inputCharacters[j] == ')' && lastCharIsOpeningBracket))
                    {
                        currentValidLength++;
                        lastCharIsOpeningBracket = !lastCharIsOpeningBracket;
                    }
                    else
                    {
                        break;
                    }
                }

                if (lastCharIsOpeningBracket)
                {
                    currentValidLength--;
                }

                if (currentValidLength > longestValidLength)
                {
                    longestValidLength = currentValidLength;
                }
            }

            Console.WriteLine(longestValidLength);
        }
    }
}