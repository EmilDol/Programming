Console.Write("Input: ");
string input = Console.ReadLine();
while (input != "end")
{

    List<char> sequence = new List<char>();
    string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "minus", "plus" };
    string[] chars = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "+" };
    //translate from words to symbols
    while (input.Length > 0)
    {
        for (int i = 1; i <= input.Length; i++)
        {
            string temp = input.Substring(0, i);

            int index = Array.IndexOf(words, temp);
            if (index == -1)
            {
                continue;
            }
            sequence.Add(char.Parse(chars[index]));
            input = input.Remove(0, temp.Length);
        }
    }
    Console.Write("Chars: ");
    Console.WriteLine(string.Join(" ", sequence));

    //translate from symbols to numbers
    List<int> nums = new List<int>();
    int numsIndex = 0;
    for (int i = 0; i < sequence.Count; i++)
    {
        if ((int)sequence[i] <= 57 && (int)sequence[i] >= 49)
        {
            string temp = sequence[i].ToString();
            while (sequence.Count > i + 1 && (int)sequence[i + 1] <= 57 && (int)sequence[i + 1] >= 49)
            {
                temp += sequence[i + 1].ToString();
                i++;
            }
            nums.Add(int.Parse(temp));
            numsIndex++;
        }

        else if (sequence[i] == '+' || sequence[i] == '-')
        {
            string temp = sequence[i].ToString();
            temp += sequence[i + 1];
            i++;
            while (sequence.Count > i + 1 && (int)sequence[i + 1] <= 57 && (int)sequence[i + 1] >= 49)
            {
                temp += sequence[i + 1].ToString();
                i++;
            }
            nums.Add(int.Parse(temp));
        }
    }
    Console.Write("Nums: ");
    Console.WriteLine(string.Join(" ", nums));

    //sum
    int sum = nums.Sum();
    Console.Write("Sum: ");
    Console.WriteLine(sum);

    //translate from numbers to symbols
    Console.Write("Output: ");
    string temp1 = sum.ToString();
    char[] finalChars = temp1.ToCharArray();
    string output = "";
    for (int i = 0; i < finalChars.Length; i++)
    {
        int wordIndex = Array.IndexOf(chars, finalChars[i].ToString());
        output += words[wordIndex];
    }
    Console.WriteLine(output);
    Console.Write("Input: ");
    input = Console.ReadLine();
}