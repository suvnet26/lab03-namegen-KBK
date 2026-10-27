using NameGenCore;
INameGen max = new MaxRandomNameGen();
string times = Console.ReadLine();
for (int i = 0; i < int.Parse(times); i++)
{
    Console.WriteLine(max.NameToString());
}

