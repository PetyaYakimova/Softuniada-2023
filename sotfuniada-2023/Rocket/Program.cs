namespace Rocket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int width = input + 5;
            int middleCharacterIndex = (width - 1) / 2;

            //Pointer of the rocket - row 1
            List<char> row = new List<char>();
            for (int i = 0; i < width; i++)
            {
                if (i == middleCharacterIndex)
                {
                    row.Add('^');
                }
                else
                {
                    row.Add('_');
                }
            }

            Console.WriteLine(string.Join("", row));

            //Head of the rocket
            string secondtoLastRow = "";

            for (int i = 1; i <= middleCharacterIndex; i++)
            {
                row.Clear();
                for (int j = 0; j < middleCharacterIndex - i; j++)
                {
                    row.Add('_');
                }

                row.Add('/');

                if (i > 2)
                {
                    for (int k = 0; k < i - 2; k++)
                    {
                        row.Add('.');
                    }
                }

                row.Add('|');
                if (i != 1)
                {
                    row.Add('|');
                    row.Add('|');
                }

                if (i > 2)
                {
                    for (int k = 0; k < i - 2; k++)
                    {
                        row.Add('.');
                    }
                }

                row.Add('\\');

                for (int j = 0; j < middleCharacterIndex - i; j++)
                {
                    row.Add('_');
                }

                Console.WriteLine(string.Join("", row));

                if (i == middleCharacterIndex - 1)
                {
                    secondtoLastRow = string.Join("", row);
                }
            }

            //The single row after the head of the rocket
            Console.WriteLine(secondtoLastRow);

            //Body of the rocket - input number of lines + 1 ending body row
            for (int i = 0; i <= input; i++)
            {
                row.Clear();

                for (int j = 0; j < middleCharacterIndex - 1; j++)
                {
                    row.Add('_');
                }

                char charInMiddle = '|';
                if (i == input)
                {
                    charInMiddle = '~';
                }

                for (int j = 0; j < 3; j++)
                {
                    row.Add(charInMiddle);
                }

                for (int j = 0; j < middleCharacterIndex - 1; j++)
                {
                    row.Add('_');
                }

                Console.WriteLine(string.Join("", row));
            }

            //Tail of the rocket - input/2 number of rows
            for (int i = 0; i < input / 2; i++)
            {
                row.Clear();
                for (int j = 0; j < input / 2 - i; j++)
                {
                    row.Add('_');
                }

                row.Add('/');
                row.Add('/');

                for (int k = 0; k < i; k++)
                {
                    row.Add('.');
                }

                row.Add('!');

                for (int k = 0; k < i; k++)
                {
                    row.Add('.');
                }

                row.Add('\\');
                row.Add('\\');

                for (int j = 0; j < input / 2 - i; j++)
                {
                    row.Add('_');
                }

                Console.WriteLine(string.Join("", row));
            }
        }
    }
}