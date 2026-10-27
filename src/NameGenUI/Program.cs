using NameGenCore;
INameGen nameGenerator = new OneNameGenerator();

Console.WriteLine("");
string times = Console.ReadLine();



for (int i = 0; i < int.Parse(times); i++)
{
    Console.WriteLine(nameGenerator.ToString());
}



