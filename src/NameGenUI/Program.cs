using NameGenCore;
INameGen nameGenerator = new OneNameGenerator();

INameGen christoffersNameGen = new VIldaDjur();

Console.WriteLine(christoffersNameGen.NameToString());
