namespace Day_1_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int first = 0;
			int last = 0;
			int answer = 0;
			while (Console.ReadLine() is { } line)
			{
				for (int i = 0; i < line.Length; i++) 
				{
					if (char.IsDigit(line[i])) 
					{
						first = (Convert.ToInt32(line[i]) - '0');
						break;
					}
				}

				for (int i = line.Length-1; i >= 0; i--)
				{
					if (char.IsDigit(line[i]))
					{
						last = (Convert.ToInt32(line[i]) - '0');
				break;
					}
				}
				answer = first * 10 + last;
				Console.WriteLine(answer);
			}
		}
	}
}
