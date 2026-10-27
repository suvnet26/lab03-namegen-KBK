using NameGenCore;
INameGen nameGenerator = new OneNameGenerator();
INameGen petGen = new PetersNameGenerator();

INameGen christoffersNameGen = new VIldaDjur();
INameGen JNamesGenerator = new JNamesGenerator();

JNamesGenerator.NameToString();

// int pick = int.Parse(times);

// for (int i = 0; i < pick ; i++)
// {
//     Console.WriteLine(nameGenerator.ToString());
// }

Console.WriteLine(christoffersNameGen.NameToString());
