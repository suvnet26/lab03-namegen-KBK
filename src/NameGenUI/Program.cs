using NameGenCore;
INameGen nameGenerator = new OneNameGenerator();
INameGen petGen = new PetersNameGenerator();

//Console.WriteLine("");
//string times = Console.ReadLine();

// int pick = int.Parse(times);

// for (int i = 0; i < pick ; i++)
// {
//     Console.WriteLine(nameGenerator.ToString());
// }

Console.WriteLine(petGen.NameToString());