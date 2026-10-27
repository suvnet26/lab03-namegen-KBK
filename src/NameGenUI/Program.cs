using NameGenCore;
INameGen nameGenerator = new OneNameGenerator();

INameGen christoffersNameGen = new VIldaDjur();
INameGen JNamesGenerator = new JNamesGenerator();

JNamesGenerator.NameToString();



Console.WriteLine(christoffersNameGen.NameToString());
