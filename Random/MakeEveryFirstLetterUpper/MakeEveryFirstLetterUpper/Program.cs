string[] input = Console.ReadLine().Split();
for (int i = 0; i < input.Length; i++)
{
    char temp = input[i][0];
    temp = char.ToUpper(temp);
    string otherTemp = input[i].Substring(1);
    otherTemp = temp.ToString() + otherTemp;
    input[i] = otherTemp;
}
Console.WriteLine(string.Join(" ", input));