namespace RowInPascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 0)
            {
                //The wanted row is the next row after the input number
                int wantedRow = input + 1;

                Console.WriteLine(string.Join(" ", GetAllNumbersOnRow(wantedRow)));
            }
            else
            {
                Console.WriteLine("Input was not a valid row number.");
            }
        }

        public static List<int> GetAllNumbersOnRow(int rowNumber) 
        {
            List<int> rowNumbers = new List<int>();
            // Every row starts with 1
            rowNumbers.Add(1);

            for (int i = 1; i < rowNumber; i++)
            {
                int nextNumber = rowNumbers.Last() * (rowNumber - i) / i;
                rowNumbers.Add(nextNumber);
            }

            return rowNumbers;
        }
    }
}