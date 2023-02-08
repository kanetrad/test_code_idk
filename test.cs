Random random = new Random();

int random_number = random.Next(1,100);

if (random_number>60)
{
	int random_five = random.Next(1,5);
	if (bot_random == 1)
	{
		int bot1 = 1;
		Console.WriteLine(bot1);
	}
	if (bot_random == 2)
	{
		int bot2 = 2;
		Console.WriteLine(bot2);
	}
	if (bot_random == 3)
	{
		int bot3 = 3;
		Console.WriteLine(bot3);
	}
	if (bot_random == 4)
	{
		int bot4 = 4;
		Console.WriteLine(bot4);
	}
	if (bot_random == 5)
	{
		int bot5 = 5;
		Console.WriteLine(bot5);
	}
}